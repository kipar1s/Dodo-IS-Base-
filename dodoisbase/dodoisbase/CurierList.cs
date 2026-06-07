using dodoisbase.Nhibernate.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace dodoisbase
{
    public partial class CurierList : Form
    {
        ISession nhibernate_session;
        IList<Curier> curiers;
        public CurierList()
        {
            InitializeComponent();
        }

        private void CurierList_Load(object sender, EventArgs e)
        {
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            nhibernate_session = c.BuildSessionFactory().OpenSession();

            //Выполним загрузки данных 
            UdateCurierGrid();
        }

        void UdateCurierGrid()
        {
            //Загрузка данных из таблицы курьеры в массив объекотов 
            curiers = nhibernate_session.QueryOver<Curier>()
                .JoinQueryOver(c => c.Сотрудник)
                .List<Curier>();
            this.curierBindingSource.DataSource = curiers;
        }

        private void tsb_Create_Click(object sender, EventArgs e)
        {
            CurierForm form = new CurierForm(nhibernate_session);
            form.CreateItem(); // Без параметров — выбор сотрудника внутри

            if (form.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Clear();
                UdateCurierGrid();
            }
        }

        private void tsb_Edit_Click(object sender, EventArgs e)
        {
            if (this.curierBindingSource.Current == null) return;

            var curier = (Curier)this.curierBindingSource.Current;

            CurierForm form = new CurierForm(nhibernate_session);
            form.LoadItem(curier.ID_Курьера);

            if (form.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Clear();
                UdateCurierGrid();
            }
        }

        private void tsb_Delite_Click(object sender, EventArgs e)
        {
            if (this.curierBindingSource.Current == null) return;

            var curier = (Curier)this.curierBindingSource.Current;

            var result = MessageBox.Show(
                $"Удалить курьера {curier.ФИО ?? "без имени"}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var toDelete = nhibernate_session.Get<Curier>(curier.ID_Курьера);
                nhibernate_session.Delete(toDelete);
                nhibernate_session.Flush();
                nhibernate_session.Clear();
                UdateCurierGrid();
            }
        }

        private void CurierList_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрываем сессию при закрытии формы
            nhibernate_session?.Close();
        }
    }
}

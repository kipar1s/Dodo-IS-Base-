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
            Curier curier = new Curier();

            // При создании курьера нужно выбрать сотрудника
            // Открываем форму курьера — там есть ComboBox для выбора сотрудника
            CurierFormUnit curier_form_unit = new CurierFormUnit();
            curier_form_unit.SetDataSourse(curier);

            if (curier_form_unit.ShowDialog() == DialogResult.OK)
            {
                // Проверяем, что сотрудник выбран
                if (curier.Сотрудник == null || curier.Сотрудник.ID_Сотрудника == 0)
                {
                    MessageBox.Show("Не выбран сотрудник!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                nhibernate_session.Save(curier);
                nhibernate_session.Flush();

                // Обновление данных
                UdateCurierGrid();
            }
        }

        private void tsb_Edit_Click(object sender, EventArgs e)
        {
            var curier = (Curier)this.curierBindingSource.Current;

            // Инициализируем ленивые загрузки перед клонированием            
            if (curier == null)
            {
                MessageBox.Show("Выберите курьера для редактирования!");
                return;
            }

            // Инициализируем ленивые загрузки перед клонированием
            // Теперь обращаемся через Сотрудник, а не через ID_Сотрудника
            if (curier.Сотрудник != null)
            {
                NHibernateUtil.Initialize(curier.Сотрудник);
            }

            Curier curierClone = MyUtiletes.Clone<Curier>(curier);
            CurierFormUnit curier_form_unit = new CurierFormUnit();
            curier_form_unit.SetDataSourse(curier);
            if (curier_form_unit.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Merge(curierClone);
                nhibernate_session.Flush();

                //Обнов данных
                UdateCurierGrid();
            }
        }       
        private void tsb_Delite_Click(object sender, EventArgs e)
        {
            var curier = (Curier)this.curierBindingSource.Current;
            if (curier == null)
            {
                MessageBox.Show("Выберите курьера для удаления!");
                return;
            }

            var result = MessageBox.Show(
                $"Удалить курьера {curier.ФИО ?? "без имени"}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                nhibernate_session.Delete(curier);
                nhibernate_session.Flush();
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

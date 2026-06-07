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
using dodoisbase.Nhibernate.Entites;

namespace dodoisbase.nhibPersonal
{
    public partial class nhibPersonalListForm : Form
    {
        ISession nhibernate_session;
        IList<Personal> personals;

        public nhibPersonalListForm()
        {
            InitializeComponent();
        }

        private void nhibPersonalListForm_Load(object sender, EventArgs e)
        {
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            nhibernate_session = c.BuildSessionFactory().OpenSession();
            UpdateGrid();
        }

        void UpdateGrid()
        {
            personals = nhibernate_session.QueryOver < Personal > ().List < Personal > ();
            this.personalBindingSource.DataSource = personals;
        }

        private void tsb_Create_Click(object sender, EventArgs e)
        {
            // Передаём сессию в форму
            nhibPersonalUnitForm form = new nhibPersonalUnitForm(nhibernate_session);
            form.CreateItem();

            if (form.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Clear();
                UpdateGrid();
            }
        }

        private void tsb_Edit_Click(object sender, EventArgs e)
        {
            if (this.personalBindingSource.Current == null) return;

            int id = ((Personal)this.personalBindingSource.Current).ID_Сотрудника;

            nhibPersonalUnitForm form = new nhibPersonalUnitForm(nhibernate_session);
            form.LoadItem(id);

            if (form.ShowDialog() == DialogResult.OK)
            {
                nhibernate_session.Clear();
                UpdateGrid();
            }
        }

        private void tsb_Delite_Click(object sender, EventArgs e)
        {
            if (this.personalBindingSource.Current == null) return;

            var personal = (Personal)this.personalBindingSource.Current;

            if (MessageBox.Show($"Удалить сотрудника {personal.ФИО}?",
                "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var toDelete = nhibernate_session.Get < Personal > (personal.ID_Сотрудника);
                nhibernate_session.Delete(toDelete);
                nhibernate_session.Flush();
                nhibernate_session.Clear();
                UpdateGrid();
            }
        }

        private void nhibPersonalListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //nhibernate_session?.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            // Колонка "Тип_сотрудника"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Тип_сотрудника" && e.Value == null)
            {
                var personal = dataGridView1.Rows[e.RowIndex].DataBoundItem as Personal;
                if (personal != null)
                {
                    e.Value = "P"; // Персонал всегда 'P'
                    e.FormattingApplied = true;
                }
            }

            // Колонка "Категория" — показываем название вместо типа класса
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Категория" && e.Value != null)
            {
                var categori = e.Value as Categori;
                if (categori != null)
                {
                    e.Value = categori.Категория;
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
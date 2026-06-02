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
    public partial class nhibPersonalUnitForm : Form
    {
        ISession nhibernate_session;
        Personal personal;
        IList<Categori> categories;

        // Конструктор с сессией (из nhibPersonalListForm)
        public nhibPersonalUnitForm(ISession session)
        {
            InitializeComponent();
            nhibernate_session = session;
        }

        // Старый конструктор (если где-то вызывается без сессии)
        public nhibPersonalUnitForm()
        {
            InitializeComponent();
        }

        private void nhibPersonalUnitForm_Load(object sender, EventArgs e)
        {
            // Если сессия не передана — создаём свою
            if (nhibernate_session == null || !nhibernate_session.IsOpen)
            {
                var c = new Configuration();
                c.Configure();
                c.AddAssembly("dodoisbase");
                nhibernate_session = c.BuildSessionFactory().OpenSession();
            }

            LoadCategories();
        }

        private void LoadCategories()
        {
            categories = nhibernate_session.QueryOver<Categori>().List<Categori>();

            if (comboBoxCategory != null)
            {
                comboBoxCategory.DataSource = categories;
                comboBoxCategory.DisplayMember = "Категория";
                comboBoxCategory.ValueMember = "Код";
            }
        }

        public void CreateItem()
        {
            personal = new Personal
            {
                Тип_сотрудника = "P"
            };

            this.personalBindingSource.DataSource = personal;

            if (comboBoxCategory != null && categories != null && categories.Count > 0)
            {
                comboBoxCategory.SelectedIndex = 0;
            }
        }

        public void LoadItem(int idСотрудника)
        {
            // Загружаем из той же сессии, что и в ListForm
            personal = nhibernate_session.Get < Personal > (idСотрудника);

            if (personal == null)
            {
                MessageBox.Show("Сотрудник не найден!");
                return;
            }

            this.personalBindingSource.DataSource = personal;

            // Устанавливаем категорию в ComboBox
            if (comboBoxCategory != null && personal.Категория != null)
            {
                comboBoxCategory.SelectedValue = personal.Категория.Код;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Завершаем редактирование BindingSource
                this.personalBindingSource.EndEdit();

                // 2. Устанавливаем категорию из ComboBox ВРУЧНУЮ
                // (т.к. ComboBox не привязан к personalBindingSource)
                if (comboBoxCategory != null && comboBoxCategory.SelectedValue != null)
                {
                    int catId = (int)comboBoxCategory.SelectedValue;
                    personal.Категория = nhibernate_session.Get<Categori>(catId);
                }

                // 3. Убеждаемся, что дискриминатор установлен
                personal.Тип_сотрудника = "P";

                // 4. Сохраняем или обновляем
                if (personal.ID_Сотрудника == 0)
                {
                    nhibernate_session.Save(personal);
                }
                else
                {
                    nhibernate_session.Update(personal);  // ← Update вместо Merge
                }

                nhibernate_session.Flush();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        // НЕ закрываем сессию здесь — она принадлежит ListForm!
        private void nhibPersonalUnitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // nhibernate_session?.Close(); ← УБРАТЬ!
        }
    }
}
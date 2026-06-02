using dodoisbase.Nhibernate.Entites;
using System;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;

namespace dodoisbase
{
    public partial class TovarFormU : Form
    {
        ISession nhibernate_session;

        private readonly string[] categories = new string[]
        {
            "Пицца", "Закуска", "Напитки", "Десерты", "Соусы"
        };

        // Конструктор с сессией (из TovarListF)
        public TovarFormU(ISession session)
        {
            InitializeComponent();
            nhibernate_session = session;
        }

        // Старый конструктор
        public TovarFormU()
        {
            InitializeComponent();
        }

        private void TovarFormU_Load(object sender, EventArgs e)
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
            if (comboBoxCatTov != null)
            {
                comboBoxCatTov.DataSource = categories;
                comboBoxCatTov.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        public void SetDataSourse(Tovar tovar)
        {
            this.tovarBindingSource.DataSource = tovar;

            if (comboBoxCatTov != null && !string.IsNullOrEmpty(tovar.Категория))
            {
                comboBoxCatTov.SelectedItem = tovar.Категория;
            }
            else
            {
                comboBoxCatTov.SelectedIndex = 0;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.tovarBindingSource.EndEdit();
                Tovar currentTovar = (Tovar)this.tovarBindingSource.Current;

                if (comboBoxCatTov != null && comboBoxCatTov.SelectedItem != null)
                {
                    currentTovar.Категория = comboBoxCatTov.SelectedItem.ToString();
                }

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

        // НЕ закрываем сессию здесь!
        private void TovarFormU_FormClosing(object sender, FormClosingEventArgs e)
        {
            // nhibernate_session?.Close(); ← УБРАТЬ!
        }
    }
}
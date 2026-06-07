using dodoisbase.Nhibernate.Entites;
using dodoisbase.Nhibernate.Maping;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dodoisbase
{
    public partial class TovarListF : Form
    {
        ISession nhibernate_session;
        IList<Tovar> tovars;

        public TovarListF()
        {
            InitializeComponent();
        }

        private void TovarListF_Load(object sender, EventArgs e)
        {
            try
            {
                var c = new Configuration();
                c.Configure();
                c.AddAssembly("dodoisbase");
                nhibernate_session = c.BuildSessionFactory().OpenSession();
                UpdateTovarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка инициализации: " + ex.Message);
            }
        }

        void UpdateTovarGrid()
        {
            try
            {
                tovars = nhibernate_session.QueryOver<Tovar>().List<Tovar>();
                this.tovarBindingSource.DataSource = tovars;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        // === СОЗДАНИЕ ===
        private void tsb_Create_Click(object sender, EventArgs e)
        {
            Tovar new_tovar = new Tovar();
            new_tovar.Ingrs = new List<Ingr>();

            // Шаг 1: Форма с ингредиентами — передаём сессию!
            TovarFormUIngr formIngr = new TovarFormUIngr(nhibernate_session);
            formIngr.SetDataSourse(new_tovar, GetAllIngredients());

            if (formIngr.ShowDialog() == DialogResult.OK)
            {
                // Шаг 2: Простая форма — передаём сессию!
                TovarFormU formSimple = new TovarFormU(nhibernate_session);
                formSimple.SetDataSourse(new_tovar);

                if (formSimple.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем в той же сессии
                    nhibernate_session.Save(new_tovar);
                    nhibernate_session.Flush();
                    UpdateTovarGrid();
                }
            }
        }

        // === РЕДАКТИРОВАНИЕ ===
        private void tsb_Edit_Click(object sender, EventArgs e)
        {
            if (this.tovarBindingSource.Current == null) return;

            int tovarId = ((Tovar)this.tovarBindingSource.Current).ID_Товара;

            // Загружаем из БД в ТЕКУЩЕЙ сессии
            Tovar tovar = nhibernate_session.Get<Tovar>(tovarId);

            if (tovar.Ingrs != null)
            {
                NHibernateUtil.Initialize(tovar.Ingrs);
            }

            // Шаг 1: Форма с ингредиентами — передаём сессию!
            TovarFormUIngr formIngr = new TovarFormUIngr(nhibernate_session);
            formIngr.SetDataSourse(tovar, GetAllIngredients());

            if (formIngr.ShowDialog() == DialogResult.OK)
            {
                // Шаг 2: Простая форма — передаём сессию!
                TovarFormU formSimple = new TovarFormU(nhibernate_session);
                formSimple.SetDataSourse(tovar);

                if (formSimple.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем в той же сессии
                    nhibernate_session.Merge(tovar);
                    nhibernate_session.Flush();
                    UpdateTovarGrid();
                }
            }
        }

        // === УДАЛЕНИЕ ===
        private void tsb_Delete_Click(object sender, EventArgs e)
        {
            if (this.tovarBindingSource.Current == null) return;

            if (MessageBox.Show("Удалить товар?", "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Tovar current = (Tovar)this.tovarBindingSource.Current;
                nhibernate_session.Delete(current);
                nhibernate_session.Flush();
                UpdateTovarGrid();
            }
        }

        private List<Ingr> GetAllIngredients()
        {
            return nhibernate_session.QueryOver<Ingr>().List<Ingr>().ToList();
        }

        private void TovarListF_FormClosing(object sender, FormClosingEventArgs e)
        {
            nhibernate_session?.Close();
        }
    }
}
using dodoisbase.Nhibernate.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;

namespace dodoisbase.Nhibernate.Maping
{
    public partial class TovarFormUIngr : Form
    {
        ISession nhibernate_session;
        IList<Ingr> ingrs;
        List<Ingr> ingrCH;
        Tovar currentTovar;

        // Конструктор с сессией (из TovarListF)
        public TovarFormUIngr(ISession session)
        {
            InitializeComponent();
            nhibernate_session = session;
        }

        // Старый конструктор (если где-то вызывается без сессии)
        public TovarFormUIngr()
        {
            InitializeComponent();
        }

        private void TovarFormUIngr_Load(object sender, EventArgs e)
        {
            // Если сессия не передана — создаём свою (для совместимости)
            if (nhibernate_session == null || !nhibernate_session.IsOpen)
            {
                var c = new Configuration();
                c.Configure();
                c.AddAssembly("dodoisbase");
                nhibernate_session = c.BuildSessionFactory().OpenSession();
            }

            // Загружаем все ингредиенты
            ingrs = nhibernate_session.QueryOver<Ingr>().List<Ingr>();
            this.ingrbS.DataSource = ingrs;
        }
        public void SetDataSourse(Tovar tovar, List<Ingr> allIngredients)
        {
            this.currentTovar = tovar;
            this.tovarbS.DataSource = tovar;

            // Инициализируем коллекцию
            if (tovar.Ingrs == null)
            {
                tovar.Ingrs = new List<Ingr>();
            }

            // Копируем список (просто ссылки)
            this.ingrCH = allIngredients != null ? new List<Ingr>(allIngredients) : new List<Ingr>();

            FillIngr();
        }

        public void FillIngr()
        {
            listView1.Items.Clear();
            if (currentTovar == null) return;

            var tovarIngrs = currentTovar.Ingrs;
            if (tovarIngrs == null)
            {
                currentTovar.Ingrs = new List<Ingr>();
                tovarIngrs = currentTovar.Ingrs;
            }

            foreach (var ingr in ingrCH)
            {
                ListViewItem item = new ListViewItem(ingr.Название);
                item.Tag = ingr;
                item.Checked = tovarIngrs.Any(i => i.ID_Ингредиента == ingr.ID_Ингредиента);
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (currentTovar == null) return;
            if (currentTovar.Ingrs == null)
            {
                currentTovar.Ingrs = new List<Ingr>();
            }

            var tovarIngrs = currentTovar.Ingrs;
            var selectedIngr = (Ingr)listView1.Items[e.Index].Tag;

            if (e.NewValue == CheckState.Checked)
            {
                if (!tovarIngrs.Any(i => i.ID_Ингредиента == selectedIngr.ID_Ингредиента))
                {
                    tovarIngrs.Add(selectedIngr);
                }
            }
            else
            {
                var existing = tovarIngrs.FirstOrDefault(
                    i => i.ID_Ингредиента == selectedIngr.ID_Ингредиента);
                if (existing != null)
                {
                    tovarIngrs.Remove(existing);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tovarbS.EndEdit();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
        private void TovarFormUIngr_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Edit_Tovat_Click(object sender, EventArgs e)
        {

        }
    }
}
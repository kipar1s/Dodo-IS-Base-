using dodoisbase.Nhibernate.Entites;
using NHibernate;

using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodoisbase
{
    public partial class CurierForm : Form
    {
        ISession nhibernate_session;
        Curier curier;

        public CurierForm()
        {
            InitializeComponent();
        }

        private void CurierForm_Load(object sender, EventArgs e)
        {
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            nhibernate_session = c.BuildSessionFactory().OpenSession();
        }

        public void CreateItem(int IDСотрудника, int ID_Курьера)
        {
            // Создаём нового курьера с привязкой к сотруднику
            var personal = nhibernate_session.Get < Personal > (IDСотрудника);

            curier = new Curier
            {
                ID_Курьера = ID_Курьера,
                Сотрудник = personal
            };

            this.curierBindingSource.DataSource = curier;
        }

        public void LoadItem(int ID_Курьера)
        {
            curier = nhibernate_session.Get < Curier > (ID_Курьера);
            if (curier != null && curier.Сотрудник != null)
            {
                NHibernateUtil.Initialize(curier.Сотрудник);
            }
            this.curierBindingSource.DataSource = curier;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.curierBindingSource.EndEdit();

            if (curier.ID_Курьера == 0)
            {
                nhibernate_session.Save(curier);
            }
            else
            {
                nhibernate_session.Merge(curier);
            }
            nhibernate_session.Flush();
        }

        private void CurierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            nhibernate_session?.Close();
        }
    }
}


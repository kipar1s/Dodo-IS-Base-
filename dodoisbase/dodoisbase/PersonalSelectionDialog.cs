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
    public partial class PersonalSelectionDialog : Form
    {
        ISession nhibernate_session;
        IList<Personal> personals;

        public PersonalSelectionDialog(ISession session)
        {
            InitializeComponent();
            nhibernate_session = session;
        }

        public PersonalSelectionDialog()
        {
            InitializeComponent();
        }

        private void PersonalSelectionDialog_Load(object sender, EventArgs e)
        {
            // Если сессия не передана — создаём свою
            if (nhibernate_session == null || !nhibernate_session.IsOpen)
            {
                var c = new Configuration();
                c.Configure();
                c.AddAssembly("dodoisbase");
                nhibernate_session = c.BuildSessionFactory().OpenSession();
            }

            // Загружаем всех сотрудников
            personals = nhibernate_session.QueryOver<Personal>().List<Personal>();
            this.personalBindingSource.DataSource = personals;
        }

        // Выбранный сотрудник (для передачи в вызывающую форму)
        public Personal SelectedPersonal
        {
            get
            {
                return (Personal)this.comboBoxPersonal.SelectedItem;
            }
        }

        // Кнопка "Выбрать"
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (comboBoxPersonal.SelectedItem == null)
            {
                MessageBox.Show("Выберите сотрудника!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Кнопка "Отмена"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PersonalSelectionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Не закрываем сессию — она извне!
        }

        // Публичный метод для установки выбранного сотрудника
        public void SetSelectedPersonal(int personalId)
        {
            if (comboBoxPersonal != null && comboBoxPersonal.Items.Count > 0)
            {
                comboBoxPersonal.SelectedValue = personalId;
            }
        }
    }
}


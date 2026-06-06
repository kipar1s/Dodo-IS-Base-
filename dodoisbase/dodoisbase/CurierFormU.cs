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
        Personal selectedPersonal;
        public CurierForm()
        {
            InitializeComponent();
        }
        public CurierForm(ISession session)
        {
            InitializeComponent();
            nhibernate_session = session;
        }

        private void CurierForm_Load(object sender, EventArgs e)
        {
            // Если сессия не передана — создаём свою
            if (nhibernate_session == null || !nhibernate_session.IsOpen)
            {
                var c = new Configuration();
                c.Configure();
                c.AddAssembly("dodoisbase");
                nhibernate_session = c.BuildSessionFactory().OpenSession();
            }
            this.curierBindingSource.DataSource= nhibernate_session;



        }
        // === СОЗДАНИЕ ===
        public void CreateItem()
        {
            curier = new Curier();
            this.curierBindingSource.DataSource = curier;

            // Сразу открываем выбор сотрудника
            SelectPersonal();
        }

        // === РЕДАКТИРОВАНИЕ ===
        public void LoadItem(int ID_Курьера)
        {
            curier = nhibernate_session.Get<Curier>(ID_Курьера);

            if (curier != null && curier.Сотрудник != null)
            {
                NHibernateUtil.Initialize(curier.Сотрудник);
                selectedPersonal = curier.Сотрудник;
            }

            this.curierBindingSource.DataSource = curier;
        }

        // Кнопка "Выбрать сотрудника" (если нужно поменять)
        private void btnSelectPersonal_Click(object sender, EventArgs e)
        {
            SelectPersonal();
        }

        // Метод выбора сотрудника через диалог
        private void SelectPersonal()
        {
            PersonalSelectionDialog dialog = new PersonalSelectionDialog(nhibernate_session);

            // Если сотрудник уже выбран — подставляем
            if (selectedPersonal != null)
            {
                dialog.SetSelectedPersonal(selectedPersonal.ID_Сотрудника);
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedPersonal = dialog.SelectedPersonal;
                curier.Сотрудник = selectedPersonal;

                // Обновляем отображение (ФИО, Стаж подтянутся из Сотрудник)
                this.curierBindingSource.ResetBindings(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.curierBindingSource.EndEdit();

                // Проверяем, что сотрудник выбран
                if (curier.Сотрудник == null || curier.Сотрудник.ID_Сотрудника == 0)
                {
                    MessageBox.Show("Выберите сотрудника!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (curier.ID_Курьера == 0)
                {
                    nhibernate_session.Save(curier);
                }
                else
                {
                    nhibernate_session.Merge(curier);
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

        private void CurierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Не закрываем сессию!
        }
    }
}


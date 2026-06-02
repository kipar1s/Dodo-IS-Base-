using dodoisbase.Nhibernate.Entites;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping;
using NHibernate.Tool.hbm2ddl;
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

    enum State_CurierFormUnit
    {
        Create = 1,//Создание нового курьера
        Update = 2,//Обновление сущ курьера
    }

    public partial class CurierFormUnit : Form
    {
        ISession nhibernate_session;
        Curier curier;
        IList<Personal> personals;
        IList<Curier> curiers;

        static State_CurierFormUnit state;
        public CurierFormUnit()
        {
            InitializeComponent();
        }

        private void CurierFormUnit_Load(object sender, EventArgs e)
        {
            // Загрузка списка сотрудников для ComboBox
            var c = new Configuration();
            c.Configure();
            c.AddAssembly("dodoisbase");
            nhibernate_session = c.BuildSessionFactory().OpenSession();

            personals = nhibernate_session.QueryOver<Personal>().List<Personal>();
            this.personalBindingSource.DataSource = personals;

            // Определяем состояние: создание или редактирование
            if (curier != null && curier.ID_Курьера > 0)
            {//Редактирование
                state = State_CurierFormUnit.Update;
                ShowCurierDetails();
                // Убедимся, что сотрудник загружен (для отображения ФИО)
                if (curier.Сотрудник != null)
                {
                    NHibernateUtil.Initialize(curier.Сотрудник);
                }
                ShowCurierDetails();
                LoadCuriersForCurrentPersonal();
            }
            else
            {//Создание
                state = State_CurierFormUnit.Create;
                HideCurierDetails();
            }
        }
        public void SetDataSourse(Curier curier)
        {
            this.curier = curier;
            this.curierBindingSource.DataSource = curier;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.curierBindingSource.EndEdit();

            // Привязываем выбранного сотрудника из ComboBox к курьеру
            if (this.personalBindingSource.Current != null)
            {
                var selectedPersonal = (Personal)this.personalBindingSource.Current;
                curier.Сотрудник = selectedPersonal;
            }

            if (state == State_CurierFormUnit.Create)
            {

                // Сохраняем нового курьера
                nhibernate_session.Save(curier);
                nhibernate_session.Flush();

                // При создании ID еще нет, он будет присвоен при сохранении в БД
                ShowCurierDetails();
                state = State_CurierFormUnit.Update;
            }
            else
            {
                // Обновляем существующего
                nhibernate_session.Merge(curier);
                nhibernate_session.Flush();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void personalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (state == State_CurierFormUnit.Create) return;

            if (this.personalBindingSource.Current == null) return;

            LoadCuriersForCurrentPersonal();
        }

     

        int GetCurrentСотрудникID()
        {
            if (this.personalBindingSource.Current == null) return 0;
            var personal = (Personal)this.personalBindingSource.Current;
            return personal.ID_Сотрудника;
        }
        void ShowCurierDetails()
        {
            lb_Warning.Visible = false;
            gb_Curier.Visible = true;
        }

        void HideCurierDetails()
        {
            lb_Warning.Visible = true;
            gb_Curier.Visible = false;
        }
                
        private void curierbindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Добавление нового курьера для текущего сотрудника
            if (this.personalBindingSource.Current == null)
            {
                MessageBox.Show("Выберите сотрудника!");
                return;
            }

            var personal = (Personal)this.personalBindingSource.Current;
            Curier newCurier = new Curier();
            newCurier.Сотрудник = personal;

            // Устанавливаем источник данных для формы курьера
            CurierFormUnit cf = new CurierFormUnit();
            cf.SetDataSourse(newCurier);

            if (cf.ShowDialog() == DialogResult.OK)
            {
                // Сохранение нового курьера
                nhibernate_session.Save(newCurier);
                nhibernate_session.Flush();

                // Обновляем список
                LoadCuriersForCurrentPersonal();
            }
        }

        private void personalbindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Создание нового курьера - сначала нужно создать сотрудника
            MessageBox.Show("Сначала создайте сотрудника в списке сотрудников!");
            state = State_CurierFormUnit.Create;
            HideCurierDetails();
        }

        private void curierBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            // Автоподстановка значения ID_Сотрудника при добавлении
            if (this.personalBindingSource.Current == null) return;

            var personal = (Personal)this.personalBindingSource.Current;
            // Новый объект создается в событии AddNewItem
        }

        private void curierBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (state == State_CurierFormUnit.Create) return;
            if (this.curierBindingSource.Current == null) return;

            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Кнопка удаления курьера
            if (this.curierBindingSource.Current == null) return;

            var curierToDelete = (Curier)this.curierBindingSource.Current;
            var fio = curierToDelete.ФИО ?? "без имени";

            var result = MessageBox.Show(
                $"Удалить курьера {fio}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                nhibernate_session.Delete(curierToDelete);
                nhibernate_session.Flush();
                LoadCuriersForCurrentPersonal();
            }
        }

        void LoadCuriersForCurrentPersonal()
        {
            if (this.personalBindingSource.Current != null)
            {
                var personal = (Personal)this.personalBindingSource.Current;
                int personalId = personal.ID_Сотрудника;

                // Загружаем курьеров, у которых Сотрудник.ID_Сотрудника = personalId
                curiers = nhibernate_session.QueryOver <Curier > ()
                    .JoinQueryOver(c => c.Сотрудник)
                    .Where(s => s.ID_Сотрудника == personalId)
                    .List < Curier > ();
            }
            else
            {
                curiers = new List< Curier > ();
            }
            this.curierBindingSource.DataSource = curiers;
        }
        void UdateCurierGrid()
        {
            LoadCuriersForCurrentPersonal();
        }
        private void CurierFormUnit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрываем сессию при закрытии формы
            nhibernate_session?.Close();
        }

    }
}

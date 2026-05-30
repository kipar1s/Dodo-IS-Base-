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
using dodoisbase.Nhibernate.Entites;

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
                ShowOderList();
            }
            else
            {//Создание
                state = State_CurierFormUnit.Create;
                HideOderList();
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

            if (state == State_CurierFormUnit.Create)
            {
                // При создании ID еще нет, он будет присвоен при сохранении в БД
                ShowOderList();
                state = State_CurierFormUnit.Update;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void personalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (state == State_CurierFormUnit.Create) return;

            if (this.personalBindingSource.Current == null) return;

            //Выполнение загрузки заказов данного клиента
            this.curierTableAdapter.FillByIDСотрудника(
                this.dodoDS.Курьер,
                GetCurrentСотрудникID()
                );
        }

     

        int GetCurrentСотрудникID()
        {
            if (this.personalBindingSource.Current == null) return 0;
            var personal = (Personal)this.personalBindingSource.Current;
            return personal.ID_Сотрудника;
        }
        void ShowOderList()
        {
            lb_Warning.Visible = false;
            gb_Curier.Visible = true;
        }

        void HideOderList()
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
                UdateCurierGrid();
            }
        }

        private void personalbindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Создание нового курьера - сначала нужно создать сотрудника
            MessageBox.Show("Сначала создайте сотрудника в списке сотрудников!");
            state = State_CurierFormUnit.Create;
            HideOderList();
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
            // Кнопка удаления
            if (this.curierBindingSource.Current == null) return;

            var result = MessageBox.Show("Удалить курьера?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var curierToDelete = (Curier)this.curierBindingSource.Current;
                nhibernate_session.Delete(curierToDelete);
                nhibernate_session.Flush();
                UdateCurierGrid();
            }
        }

        void UdateCurierGrid()
        {
            // Обновление списка курьеров
            if (this.personalBindingSource.Current != null)
            {
                var personal = (Personal)this.personalBindingSource.Current;
                curiers = nhibernate_session.QueryOver<Curier>()
                    .Where(c => c.Сотрудник.ID_Сотрудника == personal.ID_Сотрудника)
                    .List<Curier>();
            }
            else
            {
                curiers = new List<Curier>();
            }
            this.curierBindingSource.DataSource = curiers;
        }
    
    }
}

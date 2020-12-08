using Dem2._2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dem2._2
{
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
            
            
               
            if (Properties.Settings.Default.Polsovatel == "Администратор")
            { 
            
            }
            else if (Properties.Settings.Default.Polsovatel == "Пользователь") 
            {

                redaktirovanieIDobavlenieKlienta.Visible = false;
            }
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    this.Validate();
                    this.clientBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void Klient_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Gender". При необходимости она может быть перемещена или удалена.
                this.genderTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Gender);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Client". При необходимости она может быть перемещена или удалена.
                this.clientTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Client);
                string ds = dataGridViewTextBoxColumn10.Name.ToString();
                Column1.Image = Image.FromFile(ds.Replace(@" ", @""));
                initialPage = 0; pageSize = 25;



                db.Client.OrderBy(c => c.ID)//.Skip((initialPage * pageSize))
                                                            .Take(25)
                                                           .Load();
                var Clients = db.Client.Local.ToBindingList()//.Skip((initialPage * pageSize))
                                                             //.Take(pageSize)
                                                             ;
                //ClientList - измененное имя DataGridView
                clientDataGridView.DataSource = Clients;
            }
            catch (Exception )
            {

               
            }
   

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void redaktirovanieIDobavlenieKlienta_Click(object sender, EventArgs e)
        {
            this.Hide();
            RedaktirovanieIDobavlenieKlienta redaktirovanieIDobavlenieKlienta_Click = new RedaktirovanieIDobavlenieKlienta();
            redaktirovanieIDobavlenieKlienta_Click.Show();
        }

        private void genderCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (genderCode.Text == "Мужской")
                {                  
                    clientBindingSource.Filter = "GenderCode like'*" + "м" + "'";
                }
                else if (genderCode.Text == "Женский")
                {
                    clientBindingSource.Filter = "GenderCode like'*" + "ж" + "'";
                }
                else if (genderCode.Text == "Все")
                {
                    clientBindingSource.Filter = "GenderCode like'*" + "" + "'";
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            try
            {

                 
                clientBindingSource.Filter = "FirstName like'*" + filter.Text + "*' or LastName like'*" + filter.Text + "*' or Patronymic like'*" + filter.Text + "*' or Email like'*" + filter.Text + "*' or Phone like'*" + filter.Text + "'";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void IToA_CheckedChanged(object sender, EventArgs e)
        {
            
            try
            {

                clientDataGridView.Sort(dataGridViewTextBoxColumn4, ListSortDirection.Descending);
                AToI.Checked = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AToI_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                clientDataGridView.Sort(dataGridViewTextBoxColumn4, ListSortDirection.Ascending);
                IToA.Checked = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        int initialPage, pageSize;
        Entities db = new Entities();
        private void VivodL_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.Client.Local.Clear();

           
                if (VivodL.SelectedIndex == 0)
                {
                    initialPage = 0; pageSize = 25;
                }
                else if (VivodL.SelectedIndex == 1)
                {
                    initialPage = 0; pageSize = 50;
                }
                else if (VivodL.SelectedIndex == 2)
                {
                    initialPage = 0; pageSize = 200;
                }

                if (VivodL.SelectedIndex != 3)
                {
                    db.Client.OrderBy(c => c.ID).Skip((initialPage * pageSize))
                                                          .Take(pageSize)
                                                          .Load();
                }
                else
                {
                    db.Client.OrderBy(c => c.ID).Skip((initialPage * pageSize))
                                                        // .Take(25)
                                                        .Load();
                }



                var Clients = db.Client.Local.ToBindingList();
                clientDataGridView.DataSource = Clients;
          
           
            
        }
    }
}

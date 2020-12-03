using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    string tr = "GenderCode like'*" + "м" + "'";
                    clientBindingSource.Filter = tr;
                   
                }
                else if (genderCode.Text == "Женский")
                {
                    
                    string tr = "GenderCode like'*" + "ж" + "'";
                    clientBindingSource.Filter = tr;
                }
                else if (genderCode.Text == "Все")
                {
                    
                    string tr = "GenderCode like'*" + "" + "'";
                    clientBindingSource.Filter = tr;
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

                string tr = "FirstName like'*" + filter.Text + "*' or LastName like'*" + filter.Text + "*' or Patronymic like'*" + filter.Text + "*' or Email like'*" + filter.Text + "*' or Phone like'*" + filter.Text + "'";
                clientBindingSource.Filter = tr;
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
    }
}

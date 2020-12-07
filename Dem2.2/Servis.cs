using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dem2._2
{
    public partial class Servis : Form
    {
        public Servis()
        {
            InitializeComponent();
            KolvoStrok();





            if (Properties.Settings.Default.Polsovatel == "Администратор")
            {

            }
            else if (Properties.Settings.Default.Polsovatel == "Пользователь")
            {

                redaktirovanieIDobavlenieServis.Visible = false;
            }
        }

        public void Videlenie()
        {
            //bool lol = 0;
            //if (serviceDataGridView[6,2].Value.ToString().IndexOf(0)) 
            //{ serviceDataGridView[6, 2].Style.BackColor = Color.Red; }
           

        }
        public void KolvoStrok()
        {
            int GotKol = Convert.ToInt32(serviceDataGridView.RowCount.ToString()) - 1;
            string GK = Convert.ToString(GotKol);
            Kolvo.Text = GK;
            if (Kolvo.Text == "-1")
            {

                TekstL.Visible = false;

                Kolvo.Visible = false;

            }
            else {
                TekstL.Visible = true;

                Kolvo.Visible = true;
            }
        }



        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.Validate();
                this.serviceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Servis_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Service". При необходимости она может быть перемещена или удалена.
                this.serviceTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Service);  // мяTODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Service". При необходимости она может быть перемещена или удалена.
                this.serviceTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Service);
                //string ds = dataGridViewTextBoxColumn7.Name.ToString();
                //Column1.Image = Image.FromFile(ds.Replace(@" ", @""));

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void redaktirovanieIDobavlenieServis_Click(object sender, EventArgs e)
        {
            this.Hide();
            RedaktirovanieIDobavlenieServis redaktirovanieIDobavlenieServis = new RedaktirovanieIDobavlenieServis();
            redaktirovanieIDobavlenieServis.Show();
        }

        private void Poisk_TextChanged(object sender, EventArgs e)
        {
           

            serviceBindingSource.Filter = "[Title] LIKE'" + Poisk.Text + "%'";
            KolvoStrok();
        }

        private void serviceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        
    }
}

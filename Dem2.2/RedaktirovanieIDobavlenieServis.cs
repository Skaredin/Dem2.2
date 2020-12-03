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
    public partial class RedaktirovanieIDobavlenieServis : Form
    {
        public RedaktirovanieIDobavlenieServis()
        {
            InitializeComponent();
            Timerr();
        }
        private void Timerr()
        {
            
            try
            {

                TimeSpan result = TimeSpan.FromSeconds(Convert.ToInt32(durationInSecondsTextBox.Text));
                time.Text = result.ToString("hh':'mm':'ss");

            }
            catch (Exception )
            {

                
            }
        }
            private void Photo()
        {
            try
            {
                PhotoPB.Image = Image.FromFile(mainImagePathComboBox.Text.Replace(@" ", @""));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          

        } 
        
        private void lol()
        {
            //просто потестить
            Random rand = new Random(); int c = rand.Next(1, 5);
            if (Save.BackColor != SystemColors.Control) c = 0;
            switch (c)
            {
                case 0: Save.BackColor = SystemColors.Control; Save.UseVisualStyleBackColor = true; break;
                case 1: Save.BackColor = Color.Cyan; break;
                case 2: Save.BackColor = Color.Magenta; break;
                case 3: Save.BackColor = Color.Yellow; break;
                case 4: Save.BackColor = Color.Black; break;

            }

        }
        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);

        }

        private void serviceBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);

        }

        private void RedaktirovanieIDobavlenieServis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Service);

        }

        private void mainImagePathComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainImagePathComboBox.Text != "") { Photo(); }

        }

        private void Left_Click(object sender, EventArgs e)
        {
            serviceBindingSource.MovePrevious();
            if (mainImagePathComboBox.Text != "") { Photo(); }
            Timerr();
        }

        private void Rigiht_Click(object sender, EventArgs e)
        {
            serviceBindingSource.MoveNext();
            if (mainImagePathComboBox.Text != "") { Photo(); }
            Timerr();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            serviceBindingSource.AddNew();
            MessageBox.Show("После добавления данных нужно сохранить");

            lol();


        }

        private void Deleted_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                serviceBindingSource.RemoveCurrent();
                this.Validate();
                this.serviceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);
            lol();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Servis servis = new Servis();
            servis.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void durationInSecondsTextBox_TextChanged(object sender, EventArgs e)
        {
            



                Timerr();


            
        }
    }
}

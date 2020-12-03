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

        private void redaktirovanieIDobavlenieKlienta_Click(object sender, EventArgs e)
        {
            this.Hide();
            RedaktirovanieIDobavlenieKlienta redaktirovanieIDobavlenieKlienta_Click = new RedaktirovanieIDobavlenieKlienta();
            redaktirovanieIDobavlenieKlienta_Click.Show();
        }
    }
}

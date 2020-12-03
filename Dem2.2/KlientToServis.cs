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
    public partial class KlientToServis : Form
    {
        public KlientToServis()
        {
            InitializeComponent();
        }

        private void clientServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    this.Validate();
                    this.clientServiceBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void KlientToServis_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Service". При необходимости она может быть перемещена или удалена.
                    this.serviceTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Service);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Client". При необходимости она может быть перемещена или удалена.
                    this.clientTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Client);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.ClientService". При необходимости она может быть перемещена или удалена.
                    this.clientServiceTableAdapter.Fill(this.___Dem2Skarredin2DataSet.ClientService);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
 

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }
    }
}

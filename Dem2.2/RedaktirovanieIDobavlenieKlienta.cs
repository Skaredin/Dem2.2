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
    public partial class RedaktirovanieIDobavlenieKlienta : Form
    {
        public RedaktirovanieIDobavlenieKlienta()
        {
            InitializeComponent();
        }
        public void Photo()
        {
            try
            {

                PhotoPB.Image = Image.FromFile(photoPathComboBox.Text.Replace(@" ", @""));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        private void RedaktirovanieIDobavlenieKlienta_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Client);
            Photo();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);

        }

        private void Left_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
            if (photoPathComboBox.Text != "") { Photo(); }


        }

        private void Rigiht_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
            if (photoPathComboBox.Text != "") { Photo(); }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
            MessageBox.Show("После добавления данных нужно сохранить");
        }

        private void Deleted_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) { 
            clientBindingSource.RemoveCurrent();
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___Dem2Skarredin2DataSet);
        }

        private void photoPathComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (photoPathComboBox.Text != "") { Photo(); }
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klient klient = new Klient();
            klient.Show();
        }

        private void PhotoPB_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klient klient = new Klient();
            klient.Show();

        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Servis servis = new Servis();
            servis.Show();
        }

        private void клиентИСервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlientToServis klientToServis = new KlientToServis();
            klientToServis.Show();
        }
    }
}

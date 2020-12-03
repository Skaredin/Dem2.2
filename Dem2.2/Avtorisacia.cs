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
    public partial class Avtorizacia : Form
    {
        public Avtorizacia()
        {
            InitializeComponent();
      
        }

        private void Avtorisacia_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.Text == "0000" || Passvord.Text == "0000")
                {
                    this.Hide();
                    Menu mainMenu = new Menu();
                    mainMenu.Show();
                    Properties.Settings.Default.Polsovatel = "Администратор";
                    MessageBox.Show(Properties.Settings.Default.Polsovatel);
                }
                else if (Login.Text == "1111" || Passvord.Text == "1111") 
                {

                    this.Hide();
                    Menu mainMenu = new Menu();
                    mainMenu.Show();
                    Properties.Settings.Default.Polsovatel = "Пользователь";
                    MessageBox.Show(Properties.Settings.Default.Polsovatel);
                }
                else
                {

                    MessageBox.Show("Такого пользователя не существует!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void Avtorizacia_Load(object sender, EventArgs e)
        {

        }
    }
}

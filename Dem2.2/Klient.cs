using Dem2._2.__Dem2Skarredin2DataSetTableAdapters;
using Dem2._2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Количество". При необходимости она может быть перемещена или удалена.
            this.количествоTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Количество);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Tag". При необходимости она может быть перемещена или удалена.
            this.tagTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Tag);
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Gender". При необходимости она может быть перемещена или удалена.
                this.genderTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Gender);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "___Dem2Skarredin2DataSet.Client". При необходимости она может быть перемещена или удалена.
                this.clientTableAdapter.Fill(this.___Dem2Skarredin2DataSet.Client);
                //string ds = dataGridViewTextBoxColumn10.Name.ToString();
                //Column1.Image = Image.FromFile(ds.Replace(@" ", @""));
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



















        //int pageSize1 = 10; // размер страницы
        //int pageNumber = 0; // текущая страница
        //int countRows = 0;
        //int countRowsPage = 0;

        //bool flag = false;

        //string connectionString = @"Data Source=SBD\MSSQL;Initial Catalog=DemOrSkaredin1DataSet;Integrated Security=True";
        //SqlDataAdapter adapter;
        //DataSet ds;
        //StringBuilder sb = new StringBuilder();

        //private string GetSql()
        //{
        //    return $"SELECT  ID, FirstName, LastName, Patronymic, Birthday, RegistrationDate, Phone, Email, GenderCode, '' as Count FROM Client {sb.ToString()} ORDER BY Id OFFSET ((" + pageNumber + ") * " + pageSize1 + ") " +
        //        "ROWS FETCH NEXT " + pageSize1 + "ROWS ONLY";
        //}
        //public class combo
        //{
        //    public string page { get; set; }
        //    public string name { get; set; }
        //}
        //private void LoadCD()
        //{
        //    int i = 0;
        //    for (i = 0; i < clientDataGridView.RowCount; i++)
        //    {
        //        int id2 = Convert.ToInt32(clientDataGridView.Rows[i].Cells[0].Value);
        //        Количество count = Entities.GetContext().Количество.Where(p => p.ID == id2).FirstOrDefault();
        //        clientDataGridView.Rows[i].Cells[9].Value = count.Expr1.ToString();
        //        clientDataGridView.Rows[i].Cells[10].Value = count.Expr2.ToString();
        //    }
        //}
        //private void Clear()
        //{
        //    pageNumber = 0;

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        adapter = new SqlDataAdapter(GetSql(), connection);

        //        ds.Tables["Client"].Rows.Clear();

        //        adapter.Fill(ds, "Client");
        //    }

        //    countRowsPage = 0;
        //    countRows = clientDataGridView.Rows.Count;

        //    numRows = GetSqlCount();
        //    Vivod.Text = countRows + " из " + numRows;
        //    LoadCD();
        //}
        //private void FormLoad()
        //{
        //    clientDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        adapter = new SqlDataAdapter(GetSql(), connection);
        //        ds = new DataSet();
        //        adapter.Fill(ds, "Client");
        //        ds.Tables["Client"].Columns.Add("LastDate", typeof(DateTime));
        //        clientDataGridView.DataSource = ds.Tables[0];
        //    }



        //    //// TODO: данная строка кода позволяет загрузить данные в таблицу "eyyafyadlayokyudlDataSet.Gender". При необходимости она может быть перемещена или удалена.
        //    //this.genderTableAdapter.Fill(this.eyyafyadlayokyudlDataSet.Gender);
        //    //// TODO: данная строка кода позволяет загрузить данные в таблицу "eyyafyadlayokyudlDataSet.Tag". При необходимости она может быть перемещена или удалена.
        //    //this.tagTableAdapter.Fill(this.eyyafyadlayokyudlDataSet.Tag);
        //    //// TODO: данная строка кода позволяет загрузить данные в таблицу "eyyafyadlayokyudlDataSet.TagOfClient". При необходимости она может быть перемещена или удалена.
        //    //this.tagOfClientTableAdapter.Fill(this.eyyafyadlayokyudlDataSet.TagOfClient);
        //    //// TODO: данная строка кода позволяет загрузить данные в таблицу "eyyafyadlayokyudlDataSet.Количество". При необходимости она может быть перемещена или удалена.
        //    //this.количествоTableAdapter.Fill(this.eyyafyadlayokyudlDataSet.Количество);

        //    var Combo = new List<combo>();
        //    Combo.Add(new combo() { page = "10", name = "10" });
        //    Combo.Add(new combo() { page = "50", name = "50" });
        //    Combo.Add(new combo() { page = "200", name = "200" });
        //    Combo.Add(new combo() { page = GetSqlCount().ToString(), name = "Все" });
        //    VivodCombo.DataSource = Combo;
        //    VivodCombo.DisplayMember = "name";
        //    VivodCombo.ValueMember = "page";
        //    VivodCombo.SelectedValue = "10";

        //    countRows = clientDataGridView.Rows.Count;
        //    numRows = GetSqlCount();
        //    Vivod.Text = countRows + " из " + numRows;

        //    foreach (DataGridViewColumn item in clientDataGridView.Columns)
        //    {
        //        item.SortMode = DataGridViewColumnSortMode.NotSortable;
        //    }

        //    tagBindingSource.Filter = $"ClientID=-5";
        //    flag = true;

        //    //sb = new StringBuilder("");
        //    //textBox1.Text = "";
        //    //textBox2.Text = "";
        //    //textBox3.Text = "";
        //    //textBox4.Text = "";
        //    //textBox5.Text = "";
        //    //comboBox2.Text = "";
        //    //radioButton1.Checked = false;
        //    //radioButton2.Checked = false;
        //    //radioButton3.Checked = false;
        //    //checkBox1.Checked = false;

        //    LoadCD();
        //}
        //private int GetSqlCount()
        //{
        //    int numRows;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = $"SELECT count(*) FROM Client {sb.ToString()}";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        connection.Open();
        //        numRows = Convert.ToInt32(command.ExecuteScalar());
        //    }
        //    return numRows;
        //}

        //int numRows = 0;



        //private void VivodCombo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (VivodCombo.SelectedValue.ToString() != "" && flag)
        //    {
        //        pageSize1 = Convert.ToInt32(VivodCombo.SelectedValue.ToString());
        //    }

        //    pageNumber = 0;

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        adapter = new SqlDataAdapter(GetSql(), connection);

        //        ds.Tables["Client"].Rows.Clear();

        //        adapter.Fill(ds, "Client");
        //    }
        //    countRowsPage = 0;
        //    countRows = clientDataGridView.Rows.Count;

        //    numRows = GetSqlCount();
        //    Vivod.Text = countRows + " из " + numRows;

        //    Clear();
        //    LoadCD();
        //}
    }
}

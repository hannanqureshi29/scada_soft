using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdvancedHMICS
{
    public partial class data_select_1 : Form
    {
        DataTable dta;
        private MySqlConnection con;
        public data_select_1()
        {
            con = new MySqlConnection("Server =localhost; Port =3306; Database =tech; user id =root; password =; Connection Reset=false;convert zero datetime = True;SslMode=None;");
            InitializeComponent();
        }

        private void data_select_1_Load(object sender, EventArgs e)
        {
            load_data();

            date_1.Format = DateTimePickerFormat.Custom;
            date_1.CustomFormat = "yyyy/MM/dd HH:mm:ss ";
            date_2.Format = DateTimePickerFormat.Custom;
            date_2.CustomFormat = "yyyy/MM/dd HH:mm:ss";
        }
        private void sign()
        { // °
          //string a ="";

            //try
            //{
            //    foreach (DataGridViewRow datarow in table1.Rows)
            //    {
            //        foreach (DataGridViewCell datacol in table1.)
            //        {
            //            datarow[datacol] = System.Text.RegularExpressions.Regex.Replace(comma.ToString(), slash.ToString());
            //            datarow[datacol] = System.Text.RegularExpressions.Regex.Replace(colon.ToString(), Blank.ToString());
            //        }
            //    }
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
        public void load_data()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT time,door_1,door_2 FROM data_1 ", con);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dta = new DataTable();
                sda.Fill(dta);
                //  BindingSource bsource = new BindingSource();

                // bsource.DataSource = dta;
                // table1.DataSource = bsource;
                // sda.Update(dta);
            }
            catch (Exception ex)
            {
                //con.Close();
                MessageBox.Show(ex.Message);
            }

            table1.DataSource = dta;

            table1.Columns[0].HeaderText = "Time";
            table1.Columns[1].HeaderText = "Door 1";
            table1.Columns[2].HeaderText = "Door 2";
           


            table1.Columns[0].Width = 400;
            table1.Columns[1].Width = 400;
            table1.Columns[2].Width = 400;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

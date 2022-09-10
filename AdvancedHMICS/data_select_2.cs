using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
namespace AdvancedHMICS
{
    public partial class data_select_2 : Form
    {
        DataTable data;
        private IEnumerable<string> headerLabels;

        public data_select_2()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void data_select_2_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = table;


            // data();
        }
        //private void data(string filepath)
        //{
        //    //// string[] str = File.ReadAllLines(Server.("demo.csv"));

        //    //DataTable dt = new DataTable();
        //    //string[] str = System.IO.File.ReadAllLines(filepath);
        //    //// ReadCSV csv = new ReadCSV(fileName);
        //    //// create new datatable

        //    ////DataTable dt = new DataTable();
        //    //if(str.Length>0)
        //    //{
        //    //    string firstline = str[0];
        //    //    string[] headerLabels = firstline.Split(',');

        //    //    foreach (string headerWord in headerLabels)
        //    //    {
        //    //        dt.Columns.Add(new DataColumn(headerWord));
        //    //    }
        //    //    for (int i = 1; i < str.Length; i++)
        //    //    {
        //    //        string[] dataword = str[i].Split(',');
        //    //        DataRow dr = dt.NewRow();
        //    //        int columnIndex = 0;
        //    //        foreach (string headerWord in headerLabels)
        //    //        {
        //    //            dr[headerWord] = dataword[columnIndex++];
        //    //        }
        //    //        dt.Rows.Add(dr);
        //    //    }
               
        //    //}
        //    //if (dt.Rows.Count>0)
        //    //{
        //    //    table1.DataSource = dt;
        //    //}
        //    //    // get the column header means first line

        //    //   // string[] temp = str[0].Split(',');

        //    //// creates columns of gridview as per the header name

        //    ////foreach (string t in temp)

        //    ////{

        //    ////    string tempstr = t;

        //    ////    tempstr = tempstr.Trim('\"');

        //    ////    dt.Columns.Add(tempstr, typeof(string));

        //    ////}



        //    //// now retrive the record from second line and add it to datatable

        //    ////for (int i = 1; i < str.Length; i++)

        //    ////{

        //    ////    string[] t = str[i].Split(',');

        //    ////    for (int j = 0; j < t.Length; j++)

        //    ////    {

        //    ////        t[j] = t[j].Trim('\"');

        //    ////    }

        //    ////    dt.Rows.Add(t);



        //    ////}

        //    //// assign gridview datasource property by datatable

        //    ////table1.DataSource = dt;
        //    //// bind the gridview
        //    ////table1.DataBind();
        //}
       
       
        private void button1_Click(object sender, EventArgs e)
        {
            string pathcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties=\"Excel 12.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathcon);

            OleDbDataAdapter mydb = new OleDbDataAdapter("Select * from[" + textBox2.Text + "$]", conn);
           // string mySelectQuery = "Select * from " + textBox2 + " WHERE [Date] Between #" + dateTimePicker1 + "# and #" + dateTimePicker1 + "#";
            DataTable dt = new DataTable();

            mydb.Fill(dt);
            table1.DataSource = dt;
           // table1.DataSource = loadCSV(textBox1.Text);
        }
        //public List<product> loadCSV(string csvFile)
        //{
        //    var query = from l in File.ReadAllLines(csvFile)
        //                let data = l.Split(',')
                        
        //                select new product
        //                {
        //                    Date = DateTime.Parse(data[0]),
        //                    Time = data[1],
        //                    Millisecond = data[2],
        //                    TEMPDATA = data[3]

        //                };
            
        //    return query.ToList();
            
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            // dlg.ShowDialog();

            // textBox1.Text = dlg.FileName;
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = dlg.FileName;

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var appointmentNoShow = from a in dat
            //                        from p in Time
            //                        from c in clients
            //                        where a.Id == p.OID &&
            //                       (a.Start.Date >= dateTimePicker1.Text && a.Start.Date <= endDate)
            // String constring = "datasource=;port=;username;password=";
            // using (var conn = new MySqlConnection(constring))
            // {

           //  BindingSource bs = new BindingSource();
           //// DataView dv = new DataView(data);
           // bs.DataSource = table1.DataSource;
           //   bs.Filter = string.Format("Date >= '" + dateTimePicker1.Value + "' And Date <=  '" + dateTimePicker2.Value + "' ");
           //// bs.Filter = "Date Between  '%" + dateTimePicker1.Text + "%' AND '%" + dateTimePicker2.Text + "%'  ";
           //     table1.DataSource = bs;

            //}
        }

        private void dateTimePicker2_KeyUp(object sender, KeyEventArgs e)
        {
            //DataView dv = new DataView(data);
            ////  bs.DataSource = table1.DataSource;
            //dv.RowFilter = string.Format("Date >= '" + dateTimePicker1.Value + "' And Date <=  '" + dateTimePicker2.Value + "' ");
            //// bs.Filter = "Date Between  '%" + dateTimePicker1.Text + "%' AND '%" + dateTimePicker2.Text + "%'  ";
            //table1.DataSource = dv;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pathcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + ";Extended Properties=\"Excel 12.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(pathcon);
            //for (int i=0; i < dataGridView1.Rows.Count; ++i)
          //  {
                OleDbDataAdapter mydb = new OleDbDataAdapter("Select * from "+ dataGridView1 +" WHERE Date Between '" + dateTimePicker1 + "' AND '" + dateTimePicker2 + "'", conn);
                //   OleDbDataAdapter mydb = new OleDbDataAdapter("Select * from[" + textBox2.Text + "$]", conn);
                DataTable dt = new DataTable();
                mydb.Fill(dt);
                dataGridView1.DataSource = dt;
           // }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date) > 0)
            {
                MessageBox.Show("The start date cannot be greater than the end date.");
        
                dateTimePicker1.Focus();
                return;
            }

            DataTable dt = (DataTable)table1.DataSource;
            DataView dv = new DataView();
            dv = dt.DefaultView;
            dv.RowFilter = "Date >= '" + dateTimePicker1.Value.Date + "' and  Date <= '" +
            dateTimePicker2.Value.Date + "'";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HannanQureshi\Downloads\table");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('|');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridView1.Rows.Add(row);
            }
        }

       

        private void Load(string filepath)
        {
            
        }
    }
    //public class product
    //{
    //    public DateTime Date { get; set; }
    //    public string Time { get; set; }
    //    public string Millisecond { get; set; }
    //    public string TEMPDATA { get; set; }
    //}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MfgControl.AdvancedHMI.Drivers;
using AdvancedHMIControls;
using AdvancedHMIDrivers;
using AdvancedHMICS;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Wpf;
using LiveCharts;
using LiveCharts.Defaults;

namespace AdvancedHMICS
{
    public partial class MainForm : Form
    {

        private MySqlConnection con;
      //  SeriesCollection series = new SeriesCollection();
        public MainForm()
        {
            con = new MySqlConnection("Server =localhost; Port =3306; Database =tech; user id =root; password =; Connection Reset=false;convert zero datetime = True;SslMode=None;");
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Title title = chart1.Titles.Add("Chart Title");
            chart1.Series.Add("Temp 1");
            //  chart1.Series.Add("Resistence");
            chart1.Series.Add("Temp 2");
            chart1.Series.Add("Temp 3");

           // chart1.Series.Add("Time");

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;

            ChartArea CA = chart1.ChartAreas[0];
            CA.CursorX.IsUserSelectionEnabled = true;
            CA.AxisX.ScaleView.Zoom(firstDataPoint, lastDataPointInView);

             
            CA.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            CA.AxisX.ScaleView.Zoomable = false;


            //chart1.ChartArea.AxisX.ScrollBar.Min = cd.MinY
            //chart1.ChartArea.AxisX.ScrollBar.Max = cd.MaxY
            //chart1.ChartArea.AxisX.ScrollBar.Appearance = ScrollBarAppearanceEnum.Normal
            //  chart1.ChartArea.AxisX.ScrollBar.Visible = True
            //chart1.ChartArea.AxisX.ScrollBar.Alignment = StringAlignment.Center

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PLC1_ConnectionEstablished(object sender, EventArgs e)
        {
            //basicIndicator2.Se
            
            //basicIndicator3.SelectColor2 = true;
           // MessageBox.Show("PLC Connected ");
        }

        private void analogValueDisplay1_Click(object sender, EventArgs e)
        {

        }

        private void dataSubscriber1_DataChanged(object sender, MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs e)
        {

        }

        private void analogValueDisplay1_Click_1(object sender, EventArgs e)
        {

        }

        private void basicButton1_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay6_Click(object sender, EventArgs e)
        {

        }

        private void basicIndicator6_Click(object sender, EventArgs e)
        {

        }

        private void basicIndicator3_Click(object sender, EventArgs e)
        {

        }

        private void basicButton2_Click(object sender, EventArgs e)
        {

        }

        private void basicButton3_Click(object sender, EventArgs e)
        {

        }

        private void basicButton4_Click(object sender, EventArgs e)
        {

        }

        private void basicButton5_Click(object sender, EventArgs e)
        {

        }

        private void basicIndicator8_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay5_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay13_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay21_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay8_ValueChanged(object sender, EventArgs e)
        {
            //float A = Convert.ToSingle(analogValueDisplay8.Value);
            //double A = Convert.ToDouble(analogValueDisplay8.Value);
            //double R = Convert.ToDouble(A);
            //int B = 1;
            //int C = (Convert.ToInt32(R)) / B;
            //analogValueDisplay8.Text = A.ToString();
        }

        private void analogValueDisplay7_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay8_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay14_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay23_ValueChanged(object sender, EventArgs e)
        {
           // Double A = Convert.ToDouble(analogValueDisplay23.Value);
            //analogValueDisplay23.Text = A.ToString();
        }

        private void modbusTCPCom1_DataReceived(object sender, MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs e)
        {

        }

        private void analogValueDisplay26_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay54_ValueChanged(object sender, EventArgs e)
        {
          //  Double A = Convert.ToDouble(analogValueDisplay54.Value);
            //analogValueDisplay54.Text = A.ToString();
        }

        private void analogValueDisplay73_ValueChanged(object sender, EventArgs e)
        {
            //Double A = Convert.ToDouble(analogValueDisplay73.Value);
          //  analogValueDisplay73.Text = A.ToString();
        }

        private void analogValueDisplay72_ValueChanged(object sender, EventArgs e)
        {
            //Double A = Convert.ToDouble(analogValueDisplay72.Value);
            //analogValueDisplay72.Text = A.ToString();
        }

        private void analogValueDisplay71_ValueChanged(object sender, EventArgs e)
        {
            //Double A = Convert.ToDouble(analogValueDisplay71.Value);
           // analogValueDisplay71.Text = A.ToString();
        }

        private void analogValueDisplay70_ValueChanged(object sender, EventArgs e)
        {
            //Double A = Convert.ToDouble(analogValueDisplay70.Value);
           // analogValueDisplay70.Text = A.ToString();
        }

        private void analogValueDisplay29_ValueChanged(object sender, EventArgs e)
        {
            //Double A = Convert.ToDouble(analogValueDisplay29.Value);
            //analogValueDisplay29.Text = A.ToString();
        }

        private void analogValueDisplay28_ValueChanged(object sender, EventArgs e)
        {
           // Double A = Convert.ToDouble(analogValueDisplay28.Value);
           // analogValueDisplay28.Text = A.ToString();
        }

        private void analogValueDisplay27_ValueChanged(object sender, EventArgs e)
        {
          //  Double A = Convert.ToDouble(analogValueDisplay27.Value);
           // analogValueDisplay27.Text = A.ToString();
        }

        private void analogValueDisplay26_ValueChanged(object sender, EventArgs e)
        {
           //Double A = Convert.ToDouble(analogValueDisplay26.Value);
           // analogValueDisplay26.Text = A.ToString();
        }

        private void USR_2_DataReceived(object sender, MfgControl.AdvancedHMI.Drivers.Common.PlcComEventArgs e)
        {

        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay12_Click(object sender, EventArgs e)
        {
           
        }
        public void graph_load()
        {
            try
            {


                //For 1st Value
                //  chart1.Series.Add("Temperature");
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Series[0].Color = Color.Black;
                //chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
                //chart1.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
                // chart1.ChartAreas[0].AxisY.Maximum = 100;
                //chart1.ChartAreas[0].AxisY.Interval = 5;
                //chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.Series[0].BorderWidth = 2;
                //For 2nd Value
                //  chart1.Series.Add("Resistence");
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                chart1.Series[1].Color = Color.Green;
                chart1.Series[1].BorderWidth = 2;


                // chart1.Series[0].Points.AddX() = temp_k3.Text;
                //while (temp_k3.Text == temp_k3.Text)
                //{
                //    cartesianChart1.Series[0].Points.AddXY(temp_k3.Text);
                chart1.Series[0].Points.AddY(temp_k3.Text);
                chart1.Series[1].Points.AddY(resis_3.Text);
                //}
                // temp_k3.Text
                //chart1.Series[0].Points.AddXY(temp_k3.Text);

                //chart1.Series[1].Points.AddXY(resis_3.Text);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
        }
        private void rtd_1_ValueChanged(object sender, EventArgs e)
        {
            double K = 273.15;
            int A = 10;
            decimal B = Convert.ToDecimal(rtd_1.Value);
            decimal D = (B / A)-20;
            rtd_1.Text = D.ToString("0.0");
            average();

            decimal E = D + Convert.ToDecimal(K);
            temp_k1.Text = E.ToString("0.00");

            decimal result = (D / 50) + 8;
            resis_1.Text = result.ToString("0.00");

            
           // chart1.Series[0].Points.AddY(rtd_1.Text);
           // chart1.Series[0].Points.AddXY(System.DateTime.Now.ToString());
          //  this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "mm:ss";

            chart1.Series[0].Points.AddXY((System.DateTime.Now.ToString()), (rtd_1.Text));
            // chart1.Series[1].Points.AddY(resis_3.Text);
            // chart1.Series[0].Points.AddY(rtd_1.Text);

        }

        private void rtd_2_Click(object sender, EventArgs e)
        {
           
        }

        private void rtd_3_Click(object sender, EventArgs e)
        {
            
        }

        private void rtd_2_ValueChanged(object sender, EventArgs e)
        {
            double K = 273.15;
            int A = 100;
            decimal B = Convert.ToDecimal(rtd_2.Value);
            decimal D = B / A;
            rtd_2.Text = D.ToString("0.0");
            average();

            decimal E = D + Convert.ToDecimal(K);
            temp_k2.Text = E.ToString("0.00");

            decimal result = (D / 50) + 8;
            resis_2.Text = result.ToString("0.00");
           // chart1.Series[1].Points.AddY(rtd_2.Text);

            chart1.Series[1].Points.AddXY((System.DateTime.Now.ToString()), (rtd_2.Text));
        }

        private void rtd_3_ValueChanged(object sender, EventArgs e)
        {
            double K = 273.15;
            int A = 10;
            decimal B = Convert.ToDecimal(rtd_3.Value);
            decimal D = B / A;
            rtd_3.Text = D.ToString("0.0");
            average();
            decimal E =D + Convert.ToDecimal(K);
            temp_k3.Text = E.ToString("0.00");

            decimal result = (D / 50) + 8;
            resis_3.Text = result.ToString("0.00");
            //   graph_load();

            //chart1.Series[2].Points.AddY(rtd_3.Text);
            chart1.Series[2].Points.AddXY((System.DateTime.Now.ToString()), (rtd_3.Text));

        }
        private void average()
        {
            decimal a = Convert.ToDecimal(rtd_1.Text);
            decimal b = Convert.ToDecimal(rtd_2.Text);
            decimal c = Convert.ToDecimal(rtd_3.Text);

            decimal e = (a + b + c) / 3;

            lbl_result.Text = e.ToString("0.0");
        }

        private void analogValueDisplay17_ValueChanged(object sender, EventArgs e)
        {
            int A = 577;
            int C = 224;
            
            Double B = Convert.ToDouble(analogValueDisplay17.Value);
            Double D = ((B / A)*C) -13.4;

            lbl_1.Text = D.ToString("0.0");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();



            //    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO temp_data(time,temp_1,temp_2,temp_3) VALUES (NOW(),@temp1,@temp2,@temp3) ", con);


            //    cmd2.Parameters.AddWithValue("@temp1", Convert.ToDecimal(rtd_1.Text));
            //    cmd2.Parameters.AddWithValue("@temp2", Convert.ToDecimal(rtd_2.Text));
            //    cmd2.Parameters.AddWithValue("@temp3", Convert.ToDecimal(rtd_3.Text));


            //    cmd2.ExecuteNonQuery();

            //    con.Close();
            //    //  MessageBox.Show("Success");

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    con.Close();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dash = new data_select();
            dash.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        int i = 0;
        List<DateTime> TimeList = new List<DateTime>();
        private double firstDataPoint;
        private double lastDataPointInView;

        private void timer2_Tick(object sender, EventArgs e)
        {
            //DateTime now = DateTime.Now;
            //TimeList.Add(now);

            //chart1.Series[3].Points.AddXY(now, Math.Sin(i / 60.0));
            //i += 2;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();



            //    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO data_1(time,door_1,door_2) VALUES (NOW(),@door1,@door2) ", con);


            //    cmd2.Parameters.AddWithValue("@door1", Convert.ToDecimal(door_1.Text));
            //    cmd2.Parameters.AddWithValue("@door2", Convert.ToDecimal(door_2.Text));
            //   // cmd2.Parameters.AddWithValue("@temp3", Convert.ToDecimal(rtd_3.Text));


            //    cmd2.ExecuteNonQuery();

            //    con.Close();
            //    //  MessageBox.Show("Success");

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    con.Close();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dash = new data_select_1();
            dash.Show();
        }

        private void door_1_ValueChanged(object sender, EventArgs e)
        {
            if(door_1.Text ==0.ToString())
            {
                label5.Text = "Off";
            }
          //  if (door_1.Text == 1.ToString())
            else
            {
                label5.Text = "On";
            }
        }

        private void door_2_ValueChanged(object sender, EventArgs e)
        {
            if (door_2.Text == 0.ToString())
            {
                label4.Text = "Off";
            }
            //  if (door_1.Text == 1.ToString())
            else
            {
                label4.Text = "On";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dash = new data_select_2();
            dash.Show();
        }
    }
}
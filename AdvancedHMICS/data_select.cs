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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace AdvancedHMICS
{
    public partial class data_select : Form
    {
        double result;
        string istvalue, istvalue1, istvalue2, istvalue3, istvalue4, istvalue5, istvalue6, istvalue7, istvalue8;
        string last_row_r, last_row_r1, last_row_r2, last_row_r3, last_row_r4, last_row_r5, last_row_r6, last_row_r7, last_row_r8;
        SaveFileDialog savefiledialog1 = new SaveFileDialog();
        public string filename;
        DataTable dta;

        private void table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable dta1;
        private MySqlConnection con;
        public data_select()
        {
            con = new MySqlConnection("Server =localhost; Port =3306; Database =tech; user id =root; password =; Connection Reset=false;convert zero datetime = True;SslMode=None;");
            InitializeComponent();
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT time,temp_1,'','',temp_2,'','',temp_3,'','' FROM temp_data WHERE time BETWEEN '" + date_1.Text + "' AND '" + date_2.Text + "' ", con);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                dta1 = new DataTable();
                sda.Fill(dta1);
                //BindingSource bsource = new BindingSource();

                // bsource.DataSource = dta1;
                // table1.DataSource = bsource;
                //  sda.Update(dta1);
                table1.DataSource = dta1;
                //table1.DataMember = "temp_1";
                table1.Columns[0].HeaderText = "Time";
                table1.Columns[1].HeaderText = "Temp1 in °C";
                table1.Columns[2].HeaderText = "Temp1 in K";
                table1.Columns[3].HeaderText = "Resistence";

                table1.Columns[4].HeaderText = "Temp2 in °C";
                table1.Columns[5].HeaderText = "Temp2 in K";
                table1.Columns[6].HeaderText = "Resistence";

                table1.Columns[7].HeaderText = "Temp3 in °C";
                table1.Columns[8].HeaderText = "Temp3 in K";
                table1.Columns[9].HeaderText = "Resistence";


                table1.Columns[0].Width = 100;
                table1.Columns[1].Width = 100;
                table1.Columns[2].Width = 100;
                table1.Columns[3].Width = 100;
                table1.Columns[4].Width = 100;
                table1.Columns[5].Width = 100;
                table1.Columns[6].Width = 100;
                table1.Columns[7].Width = 100;
                table1.Columns[8].Width = 100;
                table1.Columns[9].Width = 150;

                datagrid_cal();
                amp_cal();
                average();
              //  sign();

                istvalue = Convert.ToString(table1.CurrentRow.Cells[1].Value);
                istvalue1 = Convert.ToString(table1.CurrentRow.Cells[2].Value);
                istvalue2 = Convert.ToString(table1.CurrentRow.Cells[3].Value);
                istvalue3 = Convert.ToString(table1.CurrentRow.Cells[4].Value);
                istvalue4 = Convert.ToString(table1.CurrentRow.Cells[5].Value);
                istvalue5 = Convert.ToString(table1.CurrentRow.Cells[6].Value);
                istvalue6 = Convert.ToString(table1.CurrentRow.Cells[7].Value);
                istvalue7 = Convert.ToString(table1.CurrentRow.Cells[8].Value);
                istvalue8 = Convert.ToString(table1.CurrentRow.Cells[9].Value);

                // textBox1.Text = istvalue.Trim();
                textBox1.Text = istvalue.ToString();
                textBox4.Text = istvalue1.ToString();
                textBox5.Text = istvalue2.ToString();
                textBox6.Text = istvalue3.ToString();
                textBox7.Text = istvalue4.ToString();
                textBox8.Text = istvalue5.ToString();
                textBox9.Text = istvalue6.ToString();
                textBox10.Text = istvalue7.ToString();
                textBox11.Text = istvalue8.ToString();


                int lastvalue = table1.Rows.Count - 1;

                object lastrow = table1.Rows[lastvalue].Cells[1].Value;
                object lastrow1 = table1.Rows[lastvalue].Cells[2].Value;
                object lastrow2 = table1.Rows[lastvalue].Cells[3].Value;
                object lastrow3 = table1.Rows[lastvalue].Cells[4].Value;
                object lastrow4 = table1.Rows[lastvalue].Cells[5].Value;
                object lastrow5 = table1.Rows[lastvalue].Cells[6].Value;
                object lastrow6 = table1.Rows[lastvalue].Cells[7].Value;
                object lastrow7 = table1.Rows[lastvalue].Cells[8].Value;
                object lastrow8 = table1.Rows[lastvalue].Cells[9].Value;
              
                last_row_r = Convert.ToString(lastrow);
                last_row_r1 = Convert.ToString(lastrow1);
                last_row_r2 = Convert.ToString(lastrow2);
                last_row_r3 = Convert.ToString(lastrow3);
                last_row_r4 = Convert.ToString(lastrow4);
                last_row_r5 = Convert.ToString(lastrow5);
                last_row_r6 = Convert.ToString(lastrow6);
                last_row_r7 = Convert.ToString(lastrow7);
                last_row_r8 = Convert.ToString(lastrow8);


                textBox2.Text = last_row_r.ToString();
                textBox19.Text = last_row_r1.ToString();
                textBox18.Text = last_row_r2.ToString();
                textBox17.Text = last_row_r3.ToString();
                textBox16.Text = last_row_r4.ToString();
                textBox15.Text = last_row_r5.ToString();
                textBox14.Text = last_row_r6.ToString();
                textBox13.Text = last_row_r7.ToString();
                textBox12.Text = last_row_r8.ToString();


                sign();
                cal();
                //ist_ltemp();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

          

            // con.Close();

        }
        private void cal()
        {
            Double A = Convert.ToDouble(textBox1.Text);
            Double B = Convert.ToDouble(textBox2.Text);

            Double A1 = Convert.ToDouble(textBox4.Text);
            Double B1 = Convert.ToDouble(textBox19.Text);

            Double A2 = Convert.ToDouble(textBox5.Text);
            Double B2 = Convert.ToDouble(textBox18.Text);

            Double A3 = Convert.ToDouble(textBox6.Text);
            Double B3 = Convert.ToDouble(textBox17.Text);

            Double A4 = Convert.ToDouble(textBox7.Text);
            Double B4 = Convert.ToDouble(textBox16.Text);

            Double A5 = Convert.ToDouble(textBox8.Text);
            Double B5 = Convert.ToDouble(textBox15.Text);

            Double A6 = Convert.ToDouble(textBox9.Text);
            Double B6 = Convert.ToDouble(textBox14.Text);

            Double A7 = Convert.ToDouble(textBox10.Text);
            Double B7 = Convert.ToDouble(textBox13.Text);

            Double A8 = Convert.ToDouble(textBox11.Text);
            Double B8 = Convert.ToDouble(textBox12.Text);

            Double C = A-B;
            Double C1 = A1 - B1;
            Double C2 = A2 - B2;
            Double C3 = A3 - B3;
            Double C4 = A4 - B4;
            Double C5 = A5 - B5;
            Double C6 = A6 - B6;
            Double C7 = A7 - B7;
            Double C8 = A8 - B8;

            textBox3.Text = C.ToString("0.0");
            textBox27.Text = C1.ToString("0.0");
            textBox26.Text = C2.ToString("0.0");
            textBox25.Text = C3.ToString("0.0");
            textBox24.Text = C4.ToString("0.0");
            textBox23.Text = C5.ToString("0.0");
            textBox22.Text = C6.ToString("0.0");
            textBox21.Text = C7.ToString("0.0");
            textBox20.Text = C8.ToString("0.0");

        }
        private void datagrid_cal()
        {
            foreach (DataGridViewRow row in table1.Rows)
            {
                double a;
                double b;
                double c;

                a = Convert.ToDouble(row.Cells[table1.Columns[1].Index].Value) + Convert.ToDouble(273.15);
                row.Cells[table1.Columns[2].Index].Value = a.ToString("N2");

                b = Convert.ToDouble(row.Cells[table1.Columns[4].Index].Value) + Convert.ToDouble(273.15);
                row.Cells[table1.Columns[5].Index].Value = b.ToString("N2");

                c = Convert.ToDouble(row.Cells[table1.Columns[7].Index].Value) + Convert.ToDouble(273.15);
                row.Cells[table1.Columns[8].Index].Value = c.ToString("N2");
            }
        }
        private void amp_cal()   
        {
            foreach (DataGridViewRow row in table1.Rows)
            {
                double a;
                double b;
                double c;

                a = (Convert.ToDouble(row.Cells[table1.Columns[1].Index].Value) / Convert.ToDouble(50)) + Convert.ToDouble(8);
                row.Cells[table1.Columns[3].Index].Value = a.ToString("N2");

                b = (Convert.ToDouble(row.Cells[table1.Columns[4].Index].Value) / Convert.ToDouble(50)) + Convert.ToDouble(8);
                row.Cells[table1.Columns[6].Index].Value = b.ToString("N2");

                c = (Convert.ToDouble(row.Cells[table1.Columns[7].Index].Value) / Convert.ToDouble(50)) + Convert.ToDouble(8);
                row.Cells[table1.Columns[9].Index].Value = c.ToString("N2");
            }
        }
        private void average()
        {
            decimal sum = 0;
            decimal sum1 = 0;
            decimal sum2 = 0;

            decimal sum3 = 0;
            decimal sum4 = 0;
            decimal sum5 = 0;

            decimal sum6 = 0;
            decimal sum7 = 0;
            decimal sum8 = 0;
            //double avg =0 ;
            int i = 0;
            for (i = 0; i < table1.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(table1.Rows[i].Cells[1].Value);
                sum1 += Convert.ToDecimal(table1.Rows[i].Cells[2].Value);
                sum2 += Convert.ToDecimal(table1.Rows[i].Cells[3].Value);

                sum3 += Convert.ToDecimal(table1.Rows[i].Cells[4].Value);
                sum4 += Convert.ToDecimal(table1.Rows[i].Cells[5].Value);
                sum5 += Convert.ToDecimal(table1.Rows[i].Cells[6].Value);

                sum6 += Convert.ToDecimal(table1.Rows[i].Cells[7].Value);
                sum7 += Convert.ToDecimal(table1.Rows[i].Cells[8].Value);
                sum8 += Convert.ToDecimal(table1.Rows[i].Cells[9].Value);
            }
            int dataCount = table1.Rows.Count;
            double avg = Convert.ToDouble(sum) / dataCount;
            double avg1 = Convert.ToDouble(sum1) / dataCount;
            double avg2= Convert.ToDouble(sum2) / dataCount;

            double avg3 = Convert.ToDouble(sum3) / dataCount;
            double avg4 = Convert.ToDouble(sum4) / dataCount;
            double avg5 = Convert.ToDouble(sum5) / dataCount;

            double avg6 = Convert.ToDouble(sum6) / dataCount;
            double avg7 = Convert.ToDouble(sum7) / dataCount;
            double avg8 = Convert.ToDouble(sum8) / dataCount;
            lbl_1.Text = avg.ToString("0.00");
            lbl_4.Text = avg1.ToString("0.00");
            lbl_5.Text = avg2.ToString("0.00");

            lbl_2.Text = avg3.ToString("0.00");
            lbl_6.Text = avg4.ToString("0.00");
            lbl_7.Text = avg5.ToString("0.00");

            lbl_3.Text = avg6.ToString("0.00");
            lbl_8.Text = avg7.ToString("0.00");
            lbl_9.Text = avg8.ToString("0.00");
        }
        //private void ist_ltemp()
        //{
           
        //    if(table1.Rows.Count>0)
        //    {
        //        table1.MultiSelect = false;
        //        table1.MultiSelect = true;
        //        table1.Rows[0].Selected = true;

        //        istvalue = Convert.ToDouble(table1.CurrentRow.Cells[1].Value);
               
        //        int lastvalue = table1.Rows.Count - 1;
               

        //        object lastrow =table1.Rows[lastvalue].Cells[1].Value;
        //        double last_row_r = Convert.ToDouble(lastrow);
        //    }
           
            
            

            //decimal a;
            //decimal d=0;
            //for (int i = 0; i < table1.Rows.Count; ++i)
            //{
            //    a = Convert.ToDecimal(table1.Rows[i].Cells[1].Value);
            //    table1.Rows[i].Cells[1].Value = d;
            //}
            //textBox1.Text = d.ToString("0.00");

            // Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1




        //}
        private void sign()
        { // °
            //string a ="";
            foreach (DataGridViewRow row in table1.Rows)
            {
                //a += "°C"+ Convert.ToDouble(row.Cells[table1.Columns[1].Index].Value) ;
                row.Cells[1].Value = row.Cells[1].Value.ToString() + " °C";
                row.Cells[2].Value = row.Cells[2].Value.ToString() + " K";
                row.Cells[3].Value = row.Cells[3].Value.ToString() + " Ω";

                row.Cells[4].Value = row.Cells[4].Value.ToString() + " °C";
                row.Cells[5].Value = row.Cells[5].Value.ToString() + " K";
                row.Cells[6].Value = row.Cells[6].Value.ToString() + " Ω";

                row.Cells[7].Value = row.Cells[7].Value.ToString() + " °C";
                row.Cells[8].Value = row.Cells[8].Value.ToString() + " K";
                row.Cells[9].Value = row.Cells[9].Value.ToString() + " Ω";

            }
            
        }
        private void data_select_Load(object sender, EventArgs e)
        {
            savefiledialog1.FileName = "";
            savefiledialog1.Filter = "PDF (*.pdf)|*.pdf";
            //load_data();
            //dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            // dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            date_1.Format = DateTimePickerFormat.Custom;
            date_1.CustomFormat = "yyyy/MM/dd HH:mm:ss ";
            date_2.Format = DateTimePickerFormat.Custom;
            date_2.CustomFormat = "yyyy/MM/dd HH:mm:ss";

         //   table1.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
        }
        public void load_data()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT time,temp_1,'',temp_2,'',temp_3,'' FROM temp_data ", con);

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
            table1.Columns[1].HeaderText = "Temp 1";
            table1.Columns[2].HeaderText = "C1 ";
            table1.Columns[3].HeaderText = "Temp 2";
            table1.Columns[4].HeaderText = "C2 ";
            table1.Columns[5].HeaderText = "Temp 3";
            table1.Columns[6].HeaderText = "C3 ";


            table1.Columns[0].Width = 150;
            table1.Columns[1].Width = 150;
            table1.Columns[2].Width = 150;
            table1.Columns[3].Width = 150;
            table1.Columns[4].Width = 150;
            table1.Columns[5].Width = 150;
            table1.Columns[6].Width = 100;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void table1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Byte[] bytes;
            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                using (var ms = new MemoryStream())
                {
                    // Declaring File Name via Textbox
                    filename = savefiledialog1.FileName;
                    // Code Start for Font Styles
                    iTextSharp.text.Font ptitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font pstitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font pdata = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font p_s_data = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font pbold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font pb = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font pb_u = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.UNDERLINE, BaseColor.BLACK);
                    iTextSharp.text.Font pfoot = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK);
                    iTextSharp.text.Font punder = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.UNDERLINE, BaseColor.BLACK);
                    iTextSharp.text.Font pdata1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font pdata2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    // Code Ends for Font Styling

                    //Code Starts for Method of Saving File As PDF
                    Paragraph paragraph = new Paragraph();
                    Document pdffile = new Document(PageSize.A4, 8f, 8f, 80f, 150f);
                    //new FileStream(textBox1.Text, FileMode.Create)
                    PdfWriter write = PdfWriter.GetInstance(pdffile, ms);
                    pdffile.Open();
                    //For Adding Logo on Top
                    //System.Drawing.Bitmap kitz = Quotation_management_system.Properties.Resources.kitz;
                    //iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(kitz, System.Drawing.Imaging.ImageFormat.Png);
                    //System.Drawing.Bitmap star_corp = Quotation_management_system.Properties.Resources.star_corp;
                    //iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance(star_corp, System.Drawing.Imaging.ImageFormat.Png);
                    //image2.ScaleToFit(140.0F, 100.0F);
                    //image2.SetAbsolutePosition(pdffile.Left, pdffile.Top - 40);
                    //pdffile.Add(image2);
                    //image1.ScaleToFit(150.0F, 150.0F);
                    //image1.SetAbsolutePosition(pdffile.Right - 150, pdffile.Top - 46);
                    //pdffile.Add(image1);
                    ////Adding Header Text
                    //pdffile.Add(new Paragraph("    "));
                    //pdffile.Add(new Paragraph("    "));
                    //pdffile.Add(new Paragraph("102-McLeod Rd,Australia Chowk,Lahore", pdata1));
                    //pdffile.Add(new Paragraph("Tel: +92-42-37659317,7667735    ", pdata1));
                    //pdffile.Add(new Paragraph("Fax: +92-42-37631666", pdata1));
                    //pdffile.Add(new Paragraph("Email: starlhr@starcorporation.org", pdata1));
                    //pdffile.Add(new Paragraph("----------------------------------------------------------------------------------------------------------------------------------------------"));
                    //// pdffile.Add(new Paragraph("                                                                                                                                             Issue Date: " + txt_issued.Text, pdata));
                    // pdffile.Add(new Paragraph("                                                                                                                                             REF No: " + txt_Quot_Num.Text + "- REV:" + txt_Rev_Sta.Text, pdata));
                    //pdffile.Add(new Paragraph(txt_Comp_N.Text, pbold));
                    //pdffile.Add(new Paragraph(txt_address.Text, pb));
                    //pdffile.Add(new Paragraph("PH #: " + txt_Tele.Text, pb));
                    //pdffile.Add(new Paragraph("Cell #: " + txt_Cell.Text, pb));
                    //pdffile.Add(new Paragraph("Email: " + txt_Email.Text, pb_u));
                    //pdffile.Add(new Paragraph("Attn: " + txt_Cont_Per.Text, pbold));
                    // pdffile.Add(new Paragraph("                                                                Subject: " + txt_Subject.Text, pbold));
                    //pdffile.Add(new Paragraph("Dear Sir, ", pdata));
                    //pdffile.Add(new Paragraph("Thank you very much for your good response & Cooperation to sent us your valuable enquiry Ref #." + txt_Ref.Text, pdata));
                    //pdffile.Add(new Paragraph("We are sending you quotation for the same, ", pdata));
                    pdffile.Add(new Paragraph("  "));
                    //Code Ends for Header and Upper Textboxes

                    //Code For Data Grid View Data (pdf export)
                    pdffile.Add(paragraph);
                    PdfPTable pdftable = new PdfPTable(table1.Columns.Count);
                    //pdftable.WidthPercentage = 97f;
                    pdftable.TotalWidth = 580f;
                    pdftable.LockedWidth = true;
                    int[] intTblWidth = new[] { 58,58,58,58,58,58,58,58,58,58 };


                    pdftable.SetWidths(intTblWidth);

                    for (int i = 0; i <= table1.Columns.Count - 1; i++)
                    {
                        //pdftable.SetWidths(intTblWidth);
                        pdftable.HorizontalAlignment = 0;
                        pdftable.SpacingBefore = 5.0F;
                    }
                    PdfPCell pdfcell = new PdfPCell();

                    for (int i = 0; i <= table1.Columns.Count - 1; i++)
                    {
                        pdfcell = new PdfPCell(new Phrase(new Chunk(table1.Columns[i].HeaderText, pb)));
                        pdfcell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        pdfcell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                        pdfcell.FixedHeight = (20f);
                        pdfcell.BackgroundColor = new iTextSharp.text.BaseColor(Color.Gray);
                        pdftable.AddCell(pdfcell);
                    }

                    // pdfcell.BackgroundColor = new iTextSharp.text.BaseColor(128, 128, 128);

                    for (int i = 0; i <= table1.Rows.Count - 2; i++)
                    {
                        for (int j = 0; j <= table1.Columns.Count - 1; j++)
                        {
                            pdfcell = new PdfPCell(new Phrase(table1[j, i].Value.ToString(), pdata));
                            pdftable.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                            pdfcell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                            pdfcell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                            pdfcell.FixedHeight = (25f);
                            pdftable.AddCell(pdfcell);
                        }
                    }
                    //string dateTime = String.Format("{0:MM/dd/yyyy}", q.Rows[i]["PAYDATE"]);

                    //PdfPCell cellT1 = new PdfPCell(new Phrase(dateTime, f));
                    //cellT1.HorizontalAlignment = Element.ALIGN_CENTER;
                    //cellT1.VerticalAlignment = Element.ALIGN_CENTER;
                    //table.AddCell(cellT1);
                    pdffile.Add(pdftable);

                    PdfPTable table5 = new PdfPTable(10);
                    table5.WidthPercentage = 100;

                    //set column widths
                    int[] firstTablellwi = { 58, 58, 58, 58, 58, 58, 58, 58, 58, 58 };
                    table5.SetWidths(firstTablellwi);

                    PdfPCell h1e3 = new PdfPCell(new Phrase("Average", pdata2));
                    h1e3.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e3.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e3.FixedHeight = 15f;
                    h1e3.BorderWidthBottom = 1f;
                    h1e3.BorderWidthLeft = 1f;
                    h1e3.BorderWidthTop = 1f;
                    h1e3.BorderWidthRight = 1f;

                    table5.AddCell(h1e3);

                    PdfPCell h1e4 = new PdfPCell(new Phrase(lbl_1.Text, pb));
                    h1e4.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e4.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e4.FixedHeight = 15f;
                    h1e4.BorderWidthBottom = 1f;
                    h1e4.BorderWidthLeft = 1f;
                    h1e4.BorderWidthTop = 1f;
                    h1e4.BorderWidthRight = 1f;

                    table5.AddCell(h1e4);

                    PdfPCell h1e5 = new PdfPCell(new Phrase(lbl_4.Text, pb));
                    h1e5.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e5.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e5.FixedHeight = 15f;
                    h1e5.BorderWidthBottom = 1f;
                    h1e5.BorderWidthLeft = 1f;
                    h1e5.BorderWidthTop = 1f;
                    h1e5.BorderWidthRight = 1f;
                  
                    table5.AddCell(h1e5);

                    PdfPCell h1e6 = new PdfPCell(new Phrase(lbl_5.Text, pb));
                    h1e6.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e6.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e6.FixedHeight = 15f;
                    h1e6.BorderWidthBottom = 1f;
                    h1e6.BorderWidthLeft = 1f;
                    h1e6.BorderWidthTop = 1f;
                    h1e6.BorderWidthRight =1f;

                    table5.AddCell(h1e6);

                    PdfPCell h1e7 = new PdfPCell(new Phrase(lbl_2.Text, pb));
                    h1e7.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e7.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e7.FixedHeight = 15f;
                    h1e7.BorderWidthBottom = 1f;
                    h1e7.BorderWidthLeft = 1f;
                    h1e7.BorderWidthTop = 1f;
                    h1e7.BorderWidthRight = 1f;

                    table5.AddCell(h1e7);

                    PdfPCell h1e8 = new PdfPCell(new Phrase(lbl_6.Text, pb));
                    h1e8.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e8.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e8.FixedHeight = 15f;
                    h1e8.BorderWidthBottom = 1f;
                    h1e8.BorderWidthLeft = 1f;
                    h1e8.BorderWidthTop = 1f;
                    h1e8.BorderWidthRight = 1f;

                    table5.AddCell(h1e8);

                    PdfPCell h1e9 = new PdfPCell(new Phrase(lbl_7.Text, pb));
                    h1e9.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e9.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e9.FixedHeight = 15f;
                    h1e9.BorderWidthBottom = 1f;
                    h1e9.BorderWidthLeft = 1f;
                    h1e9.BorderWidthTop = 1f;
                    h1e9.BorderWidthRight = 1f;

                    table5.AddCell(h1e9);

                    PdfPCell h1e10 = new PdfPCell(new Phrase(lbl_3.Text, pb));
                    h1e10.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e10.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e10.FixedHeight = 15f;
                    h1e10.BorderWidthBottom = 1f;
                    h1e10.BorderWidthLeft = 1f;
                    h1e10.BorderWidthTop = 1f;
                    h1e10.BorderWidthRight = 1f;

                    table5.AddCell(h1e10);

                    PdfPCell h1e11 = new PdfPCell(new Phrase(lbl_8.Text, pb));
                    h1e11.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e11.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e11.FixedHeight = 15f;
                    h1e11.BorderWidthBottom = 1f;
                    h1e11.BorderWidthLeft = 1f;
                    h1e11.BorderWidthTop = 1f;
                    h1e11.BorderWidthRight = 1f;

                    table5.AddCell(h1e11);

                    PdfPCell h1e12 = new PdfPCell(new Phrase(lbl_9.Text, pb));
                    h1e12.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e12.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e12.FixedHeight = 15f;
                    h1e12.BorderWidthBottom = 1f;
                    h1e12.BorderWidthLeft = 1f;
                    h1e12.BorderWidthTop = 1f;
                    h1e12.BorderWidthRight = 1f;

                    table5.AddCell(h1e12);



                    pdffile.Add(table5);

                    //if (table1.Rows.Count > 0)
                    //{
                    //    table1.MultiSelect = false;
                    //    table1.MultiSelect = true;
                    //    table1.Rows[0].Selected = true;

                    //    istvalue = Convert.ToString(table1.CurrentRow.Cells[1].Value);
                    //  //  istvalue.Trim();
                        
                    //   // Double A = Convert.ToDouble(istvalue);

                    //    int lastvalue = table1.Rows.Count - 1;

                    //    object lastrow = table1.Rows[lastvalue].Cells[1].Value;
                    //    last_row_r = Convert.ToString(lastrow);

                    //   // last_row_r.Trim();
                    //   // Double B = Convert.ToDouble(last_row_r);

                    //   // Double C = A - B;
                    //   // result= Convert.ToDouble(C.ToString("0.0"));
                    //}
                   //  string result = Convert.ToDouble(istvalue -last_row_r);

                    // 1st table
                    PdfPTable table6 = new PdfPTable(10);
                    table6.WidthPercentage = 100;

                    //set column widths
                    int[] firstTablellwi_1 = { 58, 58, 58, 58, 58, 58, 58, 58, 58, 58 };
                    table6.SetWidths(firstTablellwi_1);

                    PdfPCell h1e16 = new PdfPCell(new Phrase("First Value", pdata2));
                    h1e16.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e16.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e16.FixedHeight = 15f;
                    h1e16.BorderWidthBottom = 1f;
                    h1e16.BorderWidthLeft = 1f;
                    h1e16.BorderWidthTop = 1f;
                    h1e16.BorderWidthRight = 1f;

                    table6.AddCell(h1e16);

                    PdfPCell h1e13 = new PdfPCell(new Phrase(textBox1.Text, pb));
                    h1e13.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e13.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e13.FixedHeight = 15f;
                    h1e13.BorderWidthBottom = 1f;
                    h1e13.BorderWidthLeft = 1f;
                    h1e13.BorderWidthTop = 1f;
                    h1e13.BorderWidthRight = 1f;

                    table6.AddCell(h1e13);

                    PdfPCell h1e25 = new PdfPCell(new Phrase(textBox4.Text, pb));
                    h1e25.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e25.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e25.FixedHeight = 15f;
                    h1e25.BorderWidthBottom = 1f;
                    h1e25.BorderWidthLeft = 1f;
                    h1e25.BorderWidthTop = 1f;
                    h1e25.BorderWidthRight = 1f;

                    table6.AddCell(h1e25);

                    PdfPCell h1e26 = new PdfPCell(new Phrase(textBox5.Text, pb));
                    h1e26.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e26.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e26.FixedHeight = 15f;
                    h1e26.BorderWidthBottom = 1f;
                    h1e26.BorderWidthLeft = 1f;
                    h1e26.BorderWidthTop = 1f;
                    h1e26.BorderWidthRight = 1f;

                    table6.AddCell(h1e26);

                    PdfPCell h1e27 = new PdfPCell(new Phrase(textBox6.Text, pb));
                    h1e27.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e27.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e27.FixedHeight = 15f;
                    h1e27.BorderWidthBottom = 1f;
                    h1e27.BorderWidthLeft = 1f;
                    h1e27.BorderWidthTop = 1f;
                    h1e27.BorderWidthRight = 1f;

                    table6.AddCell(h1e27);

                    PdfPCell h1e28 = new PdfPCell(new Phrase(textBox7.Text, pb));
                    h1e28.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e28.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e28.FixedHeight = 15f;
                    h1e28.BorderWidthBottom = 1f;
                    h1e28.BorderWidthLeft = 1f;
                    h1e28.BorderWidthTop = 1f;
                    h1e28.BorderWidthRight = 1f;

                    table6.AddCell(h1e28);

                    PdfPCell h1e29 = new PdfPCell(new Phrase(textBox8.Text, pb));
                    h1e29.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e29.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e29.FixedHeight = 15f;
                    h1e29.BorderWidthBottom = 1f;
                    h1e29.BorderWidthLeft = 1f;
                    h1e29.BorderWidthTop = 1f;
                    h1e29.BorderWidthRight = 1f;

                    table6.AddCell(h1e29);

                    PdfPCell h1e30 = new PdfPCell(new Phrase(textBox9.Text, pb));
                    h1e30.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e30.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e30.FixedHeight = 15f;
                    h1e30.BorderWidthBottom = 1f;
                    h1e30.BorderWidthLeft = 1f;
                    h1e30.BorderWidthTop = 1f;
                    h1e30.BorderWidthRight = 1f;

                    table6.AddCell(h1e30);

                    PdfPCell h1e31 = new PdfPCell(new Phrase(textBox10.Text, pb));
                    h1e31.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e31.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e31.FixedHeight = 15f;
                    h1e31.BorderWidthBottom = 1f;
                    h1e31.BorderWidthLeft = 1f;
                    h1e31.BorderWidthTop = 1f;
                    h1e31.BorderWidthRight = 1f;

                    table6.AddCell(h1e31);

                    PdfPCell h1e32 = new PdfPCell(new Phrase(textBox11.Text, pb));
                    h1e32.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e32.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e32.FixedHeight = 15f;
                    h1e32.BorderWidthBottom = 1f;
                    h1e32.BorderWidthLeft = 1f;
                    h1e32.BorderWidthTop = 1f;
                    h1e32.BorderWidthRight = 1f;

                    table6.AddCell(h1e32);

                    pdffile.Add(table6);


                    //2nd table
                    PdfPTable table7 = new PdfPTable(10);
                    table7.WidthPercentage = 100;

                    //set column widths
                    int[] firstTablellwi_2 = { 58, 58, 58, 58, 58, 58, 58, 58, 58, 58 };
                    table7.SetWidths(firstTablellwi_2);

                    PdfPCell h1e17 = new PdfPCell(new Phrase("last Value", pdata2));
                    h1e17.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e17.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e17.FixedHeight = 15f;
                    h1e17.BorderWidthBottom = 1f;
                    h1e17.BorderWidthLeft = 1f;
                    h1e17.BorderWidthTop = 1f;
                    h1e17.BorderWidthRight = 1f;

                    table7.AddCell(h1e17);

                    PdfPCell h1e14 = new PdfPCell(new Phrase(textBox2.Text, pb));
                    h1e14.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e14.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e14.FixedHeight = 15f;
                    h1e14.BorderWidthBottom = 1f;
                    h1e14.BorderWidthLeft = 1f;
                    h1e14.BorderWidthTop = 1f;
                    h1e14.BorderWidthRight = 1f;

                    table7.AddCell(h1e14);


                    PdfPCell h1e15 = new PdfPCell(new Phrase(textBox19.Text, pb));
                    h1e15.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e15.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e15.FixedHeight = 15f;
                    h1e15.BorderWidthBottom = 1f;
                    h1e15.BorderWidthLeft = 1f;
                    h1e15.BorderWidthTop = 1f;
                    h1e15.BorderWidthRight = 1f;

                    table7.AddCell(h1e15);


                    PdfPCell h1e18 = new PdfPCell(new Phrase(textBox18.Text, pb));
                    h1e18.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e18.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e18.FixedHeight = 15f;
                    h1e18.BorderWidthBottom = 1f;
                    h1e18.BorderWidthLeft = 1f;
                    h1e18.BorderWidthTop = 1f;
                    h1e18.BorderWidthRight = 1f;

                    table7.AddCell(h1e18);


                    PdfPCell h1e19 = new PdfPCell(new Phrase(textBox17.Text, pb));
                    h1e19.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e19.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e19.FixedHeight = 15f;
                    h1e19.BorderWidthBottom = 1f;
                    h1e19.BorderWidthLeft = 1f;
                    h1e19.BorderWidthTop = 1f;
                    h1e19.BorderWidthRight = 1f;

                    table7.AddCell(h1e19);


                    PdfPCell h1e20 = new PdfPCell(new Phrase(textBox16.Text, pb));
                    h1e20.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e20.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e20.FixedHeight = 15f;
                    h1e20.BorderWidthBottom = 1f;
                    h1e20.BorderWidthLeft = 1f;
                    h1e20.BorderWidthTop = 1f;
                    h1e20.BorderWidthRight = 1f;

                    table7.AddCell(h1e20);


                    PdfPCell h1e21 = new PdfPCell(new Phrase(textBox15.Text, pb));
                    h1e21.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e21.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e21.FixedHeight = 15f;
                    h1e21.BorderWidthBottom = 1f;
                    h1e21.BorderWidthLeft = 1f;
                    h1e21.BorderWidthTop = 1f;
                    h1e21.BorderWidthRight = 1f;

                    table7.AddCell(h1e21);


                    PdfPCell h1e22 = new PdfPCell(new Phrase(textBox14.Text, pb));
                    h1e22.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e22.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e22.FixedHeight = 15f;
                    h1e22.BorderWidthBottom = 1f;
                    h1e22.BorderWidthLeft = 1f;
                    h1e22.BorderWidthTop = 1f;
                    h1e22.BorderWidthRight = 1f;

                    table7.AddCell(h1e22);


                    PdfPCell h1e23 = new PdfPCell(new Phrase(textBox13.Text, pb));
                    h1e23.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e23.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e23.FixedHeight = 15f;
                    h1e23.BorderWidthBottom = 1f;
                    h1e23.BorderWidthLeft = 1f;
                    h1e23.BorderWidthTop = 1f;
                    h1e23.BorderWidthRight = 1f;

                    table7.AddCell(h1e23);



                    PdfPCell h1e24 = new PdfPCell(new Phrase(textBox12.Text, pb));
                    h1e24.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e24.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e24.FixedHeight = 15f;
                    h1e24.BorderWidthBottom = 1f;
                    h1e24.BorderWidthLeft = 1f;
                    h1e24.BorderWidthTop = 1f;
                    h1e24.BorderWidthRight = 1f;

                    table7.AddCell(h1e24);



                    pdffile.Add(table7);

                    //3rd table
                    PdfPTable table8 = new PdfPTable(10);
                    table8.WidthPercentage = 100;

                    //set column widths
                    int[] firstTablellwi_3 = { 58, 58, 58, 58, 58, 58, 58, 58, 58, 58 };
                    table8.SetWidths(firstTablellwi_3);

                    PdfPCell h1e40 = new PdfPCell(new Phrase("Difference", pdata2));
                    h1e40.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e40.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e40.FixedHeight = 15f;
                    h1e40.BorderWidthBottom = 1f;
                    h1e40.BorderWidthLeft = 1f;
                    h1e40.BorderWidthTop = 1f;
                    h1e40.BorderWidthRight = 1f;

                    table8.AddCell(h1e40);

                    PdfPCell h1e41 = new PdfPCell(new Phrase(textBox3.Text, pb));
                    h1e41.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e41.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e41.FixedHeight = 15f;
                    h1e41.BorderWidthBottom = 1f;
                    h1e41.BorderWidthLeft = 1f;
                    h1e41.BorderWidthTop = 1f;
                    h1e41.BorderWidthRight = 1f;

                    table8.AddCell(h1e41);

                    PdfPCell h1e42 = new PdfPCell(new Phrase(textBox27.Text, pb));
                    h1e42.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e42.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e42.FixedHeight = 15f;
                    h1e42.BorderWidthBottom = 1f;
                    h1e42.BorderWidthLeft = 1f;
                    h1e42.BorderWidthTop = 1f;
                    h1e42.BorderWidthRight = 1f;

                    table8.AddCell(h1e42);

                    PdfPCell h1e43 = new PdfPCell(new Phrase(textBox26.Text, pb));
                    h1e43.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e43.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e43.FixedHeight = 15f;
                    h1e43.BorderWidthBottom = 1f;
                    h1e43.BorderWidthLeft = 1f;
                    h1e43.BorderWidthTop = 1f;
                    h1e43.BorderWidthRight = 1f;

                    table8.AddCell(h1e43);

                    PdfPCell h1e44 = new PdfPCell(new Phrase(textBox25.Text, pb));
                    h1e44.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e44.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e44.FixedHeight = 15f;
                    h1e44.BorderWidthBottom = 1f;
                    h1e44.BorderWidthLeft = 1f;
                    h1e44.BorderWidthTop = 1f;
                    h1e44.BorderWidthRight = 1f;

                    table8.AddCell(h1e44);

                    PdfPCell h1e45 = new PdfPCell(new Phrase(textBox24.Text, pb));
                    h1e45.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e45.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e45.FixedHeight = 15f;
                    h1e45.BorderWidthBottom = 1f;
                    h1e45.BorderWidthLeft = 1f;
                    h1e45.BorderWidthTop = 1f;
                    h1e45.BorderWidthRight = 1f;

                    table8.AddCell(h1e45);

                    PdfPCell h1e46 = new PdfPCell(new Phrase(textBox23.Text, pb));
                    h1e46.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e46.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e46.FixedHeight = 15f;
                    h1e46.BorderWidthBottom = 1f;
                    h1e46.BorderWidthLeft = 1f;
                    h1e46.BorderWidthTop = 1f;
                    h1e46.BorderWidthRight = 1f;

                    table8.AddCell(h1e46);

                    PdfPCell h1e47 = new PdfPCell(new Phrase(textBox22.Text, pb));
                    h1e47.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e47.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e47.FixedHeight = 15f;
                    h1e47.BorderWidthBottom = 1f;
                    h1e47.BorderWidthLeft = 1f;
                    h1e47.BorderWidthTop = 1f;
                    h1e47.BorderWidthRight = 1f;

                    table8.AddCell(h1e47);

                    PdfPCell h1e48 = new PdfPCell(new Phrase(textBox21.Text, pb));
                    h1e48.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e48.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e48.FixedHeight = 15f;
                    h1e48.BorderWidthBottom = 1f;
                    h1e48.BorderWidthLeft = 1f;
                    h1e48.BorderWidthTop = 1f;
                    h1e48.BorderWidthRight = 1f;

                    table8.AddCell(h1e48);

                    PdfPCell h1e49 = new PdfPCell(new Phrase(textBox20.Text, pb));
                    h1e49.HorizontalAlignment = Element.ALIGN_LEFT;
                    h1e49.VerticalAlignment = Element.ALIGN_LEFT;
                    h1e49.FixedHeight = 15f;
                    h1e49.BorderWidthBottom = 1f;
                    h1e49.BorderWidthLeft = 1f;
                    h1e49.BorderWidthTop = 1f;
                    h1e49.BorderWidthRight = 1f;

                    table8.AddCell(h1e49);

                    pdffile.Add(table8);

                    //pdffile.Add(new Paragraph("    "));
                    // pdffile.Add(new Paragraph("Total Quotation=  " + lbl_quotation_count.Text, pdata));
                    //pdffile.Add(new Paragraph("                                                                                                                                          Total Discount %:  " + txt_disc.Text, pdata));
                    //pdffile.Add(new Paragraph("                                                                                                                                          Total Discount Price:  " + txt_discount_price.Text, pdata));
                    //pdffile.Add(new Paragraph("                                                                                                                                          Sales Tax @ 17%:  " + txtGSTAmount.Text, pdata));
                    //pdffile.Add(new Paragraph("                                                                                                                                          Total Price Incl. GST:  " + txtTotalPriceGST.Text, pb));

                    //pdffile.Add(new Paragraph("Terms and Conditions:", punder));
                    //pdffile.Add(new Paragraph(txt_T_Condition.Text, pdata));
                    //pdffile.Add(new Paragraph("Lead Time: " + txt_Lead_Time.Text, pdata));
                    //pdffile.Add(new Paragraph("Payment Terms: " + txt_Pay_Term.Text, pdata));
                    //pdffile.Add(new Paragraph("Valid Till: " + txt_validity.Text, pdata));
                    //pdffile.Add(new Paragraph("Price: Ex-Godown Lahore", pdata));
                    pdffile.Add(new Paragraph("    "));
                    //  pdffile.Add(new Paragraph("We hope above offer is acceptable to you and look forward to your esteem order.", p_s_data));

                    //pdffile.Add(new Paragraph("Prepared By:  " + user_logged.Text + "                                                                                                       Approved By: ________________ ", pb));     
                    //  pdffile.Add(new Paragraph());
                    pdffile.Close();
                    bytes = ms.ToArray();
                }

                //Read our PDF and apply page numbers
                //using (var reader = new PdfReader(bytes))
                //{
                //    using (var ms = new MemoryStream())
                //    {
                //        using (var stamper = new PdfStamper(reader, ms))
                //        {
                //            int PageCount = reader.NumberOfPages;
                //            iTextSharp.text.Font pdata = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                //            iTextSharp.text.Font pdata1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                //            iTextSharp.text.Font pb = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                //            // For Adding Logo on Top
                //            System.Drawing.Bitmap kitz = Quotation_management_system.Properties.Resources.kitz;
                //            iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(kitz, System.Drawing.Imaging.ImageFormat.Png);

                //            System.Drawing.Bitmap star_corp = Quotation_management_system.Properties.Resources.star_corp;
                //            iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance(star_corp, System.Drawing.Imaging.ImageFormat.Png);

                //            for (int i = 1; i <= PageCount; i++)
                //            {
                //                PdfContentByte content = stamper.GetUnderContent(i);
                //                image2.ScaleToFit(180.0F, 150.0F);
                //                image2.SetAbsolutePosition(10, 780);

                //                content.AddImage(image2);
                //                ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase(String.Format("   Importor & Stockist: Valves,Pipes & Fittings.", i, PageCount), pb), 5, 771, 0);



                //                ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase(String.Format("                                                                                                                                                        Authorized Agent & Distributor:", i, PageCount), pb), 5, 825, 0);
                //                PdfContentByte content1 = stamper.GetUnderContent(i);
                //                image1.ScaleToFit(155.0F, 150.0F);
                //                image1.SetAbsolutePosition(426, 770);

                //                content1.AddImage(image1);

                //                ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase(String.Format("Lahore Office:                                                                                                                                Faisalabad Office:", i, PageCount), pdata), 5, 55, 0);
                //                ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase(String.Format("102-McLeod Rd,Australia Chowk,                                                                                                 Shop # 135,Ground Floor Railway Road,", i, PageCount), pdata), 5, 45, 0);
                //                ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase(String.Format("Lahore-Pakistan. Tel: +92-42-37659317,37667735,                                                                     Faisalabad-Pakistan.Tel: +92-41-2629532-2642259", i, PageCount), pdata), 5, 35, 0);
                //                ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase(String.Format("Fax: +92-42-37631666                                                                                                                  Fax: 92-41-2629531", i, PageCount), pdata), 5, 25, 0);
                //                ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase(String.Format("Email: starlhr@starcorporation.org                     http://www.starcorporation.org                           Email: starcorp@starcorporation.org", i, PageCount), pdata), 5, 15, 0);



                //                ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_CENTER, new Phrase(String.Format("                                                                                                                                                                                                                                                                                                                                                                                                                                    Page {0} of {1}", i, PageCount), pdata1), 100, 3, 0);
                //                //ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_CENTER, new Phrase(String.Format("                                                                                                                       Page {0} of {1}", i, PageCount)), 100, 10, 0);
                //                // ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_LEFT, new Phrase(String.Format("Prepared By: " + user_logged.Text + "                                                  Approved By: ________________ ", i, PageCount)), 100, 10, 0);
                //            }
                //        }
                //        bytes = ms.ToArray();
                //    }
                //}
                var outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filename);
                System.IO.File.WriteAllBytes(outputFile, bytes);
                MessageBox.Show("Data Exported to PDF Successfuly");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

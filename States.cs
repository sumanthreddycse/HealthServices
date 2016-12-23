using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace DataIntegration
{
    public partial class States : Form
    {
        public OleDbConnection dbcon;
        public void fileopen(string s)
        {
            dbcon = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; " + "data source='" + s + " '; " + "Extended Properties=Excel 8.0;");

        }
        public OleDbCommand dbcom;
        public DataSet dbds;
        public OleDbDataAdapter oledbdad;
        public DataTable dbdt;
        public string str;

        string fileLoc = @"C:\Users\ACER\Documents\Healthdata.xls";

        public States()
        {
            InitializeComponent();
            Blink();
        }
        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                label1.BackColor = label1.BackColor == Color.DarkRed ? Color.Navy : Color.DarkRed;
            }
        }

        private void Set1_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='AR'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void Set2_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='CA'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

        }

        private void Set3_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='FL'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Set4_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='GA'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Set5_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='IL'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Set6_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='IN'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Set7_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='MI'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Set8_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='OH'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Set9_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='PA'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Set10_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='TX'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void Set11_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox1.Text = String.Empty;
                comboBox1.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='DC'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox1.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox2.Items.Clear();
                dbcon.Open();

                str = "SELECT DISTINCT HospitalName FROM [Excel_Destination$] WHERE HospitalCity='" + comboBox1.Text + "'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox2.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                
                dbcon.Open();
                str = "SELECT Diagnosis, AvgTotalPayments, AvgCoveredCharges, AvgMedicarePayments FROM [Excel_Destination$] WHERE HospitalName='" + comboBox2.Text + "' AND HospitalCity ='" + comboBox1.Text + "'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds, "[Excel_Destination$]");
                dbcon.Close();
                dataGridView1.DataSource = dbds;
                dataGridView1.DataMember = "[Excel_Destination$]";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

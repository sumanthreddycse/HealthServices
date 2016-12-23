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
    public partial class Patient : Form
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

        public Patient()
        {
            InitializeComponent();
            InitializeComboBox();
            Blink();
        }
        string fileLoc = @"C:\Users\ACER\Documents\Healthdata.xls";

        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                label2.BackColor = label2.BackColor == Color.SkyBlue ? Color.SteelBlue : Color.SkyBlue;
            }
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Add("AR");
            comboBox1.Items.Add("CA");
            comboBox1.Items.Add("FL");
            comboBox1.Items.Add("GA");
            comboBox1.Items.Add("IL");
            comboBox1.Items.Add("IN");
            comboBox1.Items.Add("MI");
            comboBox1.Items.Add("OH");
            comboBox1.Items.Add("PA");
            comboBox1.Items.Add("TX");
            comboBox1.Items.Add("DC");



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
                comboBox2.Text = String.Empty;
                comboBox2.Items.Clear();
                comboBox3.Text = String.Empty;
                dbcon.Open();

                str = "SELECT DISTINCT HospitalCity FROM [Excel_Destination$] WHERE HospitalState='" + comboBox1.Text + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            fileopen(fileLoc);
            try
            {
                comboBox3.Items.Clear();


                dbcon.Open();
                str = "SELECT DISTINCT Diagnosis FROM [Excel_Destination$] WHERE HospitalState='" + comboBox1.Text + "'AND HospitalCity ='" + comboBox2.Text + "'";
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds);

                for (int i = 0; i < dbds.Tables[0].Rows.Count; i++)
                    comboBox3.Items.Add(dbds.Tables[0].Rows[i][0].ToString());


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
                str = "SELECT Diagnosis, HospitalName, HospitalAddress, Region, AvgCoveredCharges FROM [Excel_Destination$] WHERE HospitalState='" + comboBox1.Text + "'AND HospitalCity ='" + comboBox2.Text + "'AND Diagnosis='" + comboBox3.Text + "'";
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

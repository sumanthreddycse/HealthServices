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
    public partial class HealthServices : Form
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


        public HealthServices()
        {
            InitializeComponent();
            Blink();
        }
        
        string fileLoc=@"C:\Users\ACER\Documents\Healthdata.xls";
        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(500);
                label1.BackColor = label1.BackColor == Color.PowderBlue ? Color.Cornsilk : Color.PowderBlue;
            }
        }

        
        private void ShowAll_Click(object sender, EventArgs e)
        {
           
            fileopen(fileLoc);
            try
            {
                dbcon.Open();
                str = "select * from [Excel_Destination$]";
                           
                dbcom = new OleDbCommand(str, dbcon);
                dbds = new DataSet();
                oledbdad = new OleDbDataAdapter(dbcom);
                oledbdad.Fill(dbds, "[Excel_Destination$]");
                dbcon.Close();
                DataGridView1.DataSource = dbds;
                DataGridView1.DataMember = "[Excel_Destination$]";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            var form2 = new Doctor();
            form2.Show();
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            var form3 = new Patient();
            form3.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void States_Click(object sender, EventArgs e)
        {
            var form5 = new States();
            form5.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form6 = new Reports();
            form6.Show();
        }

         
       
    }
}

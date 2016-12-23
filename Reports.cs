using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataIntegration
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void InitializeComboBox()
        {
            comboBox1.Items.Add("DRG_Definition Vs TotalDischarges");
            comboBox1.Items.Add("HospitalReferralRegion Vs AvgCoveredCharges");
            comboBox1.Items.Add("ProviderName Vs AvgMedicarePayments");
            comboBox1.Items.Add("ProviderCity Vs AvgCoveredCharges");
            comboBox2.Items.Add("Arkansas");
            comboBox2.Items.Add("California");
            comboBox2.Items.Add("Florida");
            comboBox2.Items.Add("Georgia");
            comboBox2.Items.Add("Illinois");
            comboBox2.Items.Add("Indiana");
            comboBox2.Items.Add("Michigan");
            comboBox2.Items.Add("Ohio");
            comboBox2.Items.Add("Pennsylvania");
            comboBox2.Items.Add("Texas");
            comboBox2.Items.Add("DC");
            comboBox3.Items.Add("AvgMedicarePayments Vs ProviderState");
            comboBox3.Items.Add("TotalDischarges Vs ProviderState");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox3.Text = String.Empty;
            switch (comboBox1.Text)
            {
                case "DRG_Definition Vs TotalDischarges":
                    switch(comboBox2.Text)
                    {
                        case "Arkansas":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.AR.PNG";
                            break;
                        case "California":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.CA.PNG";
                            break;
                        case "Florida":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.FL.PNG";
                            break;
                        case "Georgia":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.GA.PNG";
                            break;
                        case "Illinois":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.IL.PNG";
                            break;
                        case "Indiana":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.IN.PNG";
                            break;
                        case "Michigan":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.MI.PNG";
                            break;
                        case "Ohio":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.OH.PNG";
                            break;
                        case "Pennsylvania":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.PA.PNG";
                            break;
                        case "Texas":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.TX.PNG";
                            break;
                        case "DC":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\1.DC.PNG";
                            break;
                    }
                    break;
                case "HospitalReferralRegion Vs AvgCoveredCharges":
                    switch (comboBox2.Text)
                    {
                        case "Arkansas":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.AR.PNG";
                            break;
                        case "California":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.CA.PNG";
                            break;
                        case "Florida":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.FL.PNG";
                            break;
                        case "Georgia":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.GA.PNG";
                            break;
                        case "Illinois":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.IL.PNG";
                            break;
                        case "Indiana":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.IN.PNG";
                            break;
                        case "Michigan":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.MI.PNG";
                            break;
                        case "Ohio":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.OH.PNG";
                            break;
                        case "Pennsylvania":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.PA.PNG";
                            break;
                        case "Texas":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.TX.PNG";
                            break;
                        case "DC":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\2.DC.PNG";
                            break;
                    }
                    break;
                case "ProviderName Vs AvgMedicarePayments":
                    switch (comboBox2.Text)
                    {
                        case "Arkansas":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.AR.PNG";
                            break;
                        case "California":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.CA.PNG";
                            break;
                        case "Florida":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.FL.PNG";
                            break;
                        case "Georgia":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.GA.PNG";
                            break;
                        case "Illinois":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.IL.PNG";
                            break;
                        case "Indiana":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.IN.PNG";
                            break;
                        case "Michigan":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.MI.PNG";
                            break;
                        case "Ohio":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.OH.PNG";
                            break;
                        case "Pennsylvania":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.PA.PNG";
                            break;
                        case "Texas":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.TX.PNG";
                            break;
                        case "DC":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\3.DC.PNG";
                            break;
                    }
                    break;
                case "ProviderCity Vs AvgCoveredCharges":
                    switch (comboBox2.Text)
                    {
                        case "Arkansas":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.AR.PNG";
                            break;
                        case "California":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.CA.PNG";
                            break;
                        case "Florida":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.FL.PNG";
                            break;
                        case "Georgia":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.GA.PNG";
                            break;
                        case "Illinois":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.IL.PNG";
                            break;
                        case "Indiana":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.IN.PNG";
                            break;
                        case "Michigan":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.MI.PNG";
                            break;
                        case "Ohio":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.OH.PNG";
                            break;
                        case "Pennsylvania":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.PA.PNG";
                            break;
                        case "Texas":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.TX.PNG";
                            break;
                        case "DC":
                            pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\4.DC.PNG";
                            break;
                    }
                    break;

            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            switch (comboBox3.Text)
            {
                case "AvgMedicarePayments Vs ProviderState":
                    pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\AvgMedicarePayments Vs ProviderState.PNG";
                    break;
                case "TotalDischarges Vs ProviderState":
                    pictureBox1.ImageLocation = @"C:\Users\ACER\Pictures\Di\TotalDischarges Vs ProviderState.PNG";
                    break;

            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}

namespace DataIntegration
{
    partial class HealthServices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthServices));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Doctor = new System.Windows.Forms.Button();
            this.Patient = new System.Windows.Forms.Button();
            this.States = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridView1.Location = new System.Drawing.Point(46, 71);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(940, 550);
            this.DataGridView1.TabIndex = 0;
            // 
            // ShowAll
            // 
            this.ShowAll.Image = global::DataIntegration.Properties.Resources.blue1;
            this.ShowAll.Location = new System.Drawing.Point(1053, 71);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(178, 46);
            this.ShowAll.TabIndex = 2;
            this.ShowAll.Text = "Show All";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // Doctor
            // 
            this.Doctor.Image = global::DataIntegration.Properties.Resources.blue1;
            this.Doctor.Location = new System.Drawing.Point(1053, 170);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(178, 46);
            this.Doctor.TabIndex = 4;
            this.Doctor.Text = "Doctor";
            this.Doctor.UseVisualStyleBackColor = true;
            this.Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // Patient
            // 
            this.Patient.Image = global::DataIntegration.Properties.Resources.blue1;
            this.Patient.Location = new System.Drawing.Point(1053, 269);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(178, 46);
            this.Patient.TabIndex = 5;
            this.Patient.Text = "     Patient";
            this.Patient.UseVisualStyleBackColor = true;
            this.Patient.Click += new System.EventHandler(this.Patient_Click);
            // 
            // States
            // 
            this.States.Image = global::DataIntegration.Properties.Resources.blue1;
            this.States.Location = new System.Drawing.Point(1053, 370);
            this.States.Name = "States";
            this.States.Size = new System.Drawing.Size(178, 46);
            this.States.TabIndex = 7;
            this.States.Text = "States";
            this.States.UseVisualStyleBackColor = true;
            this.States.Click += new System.EventHandler(this.States_Click);
            // 
            // Close
            // 
            this.Close.Image = global::DataIntegration.Properties.Resources.blue1;
            this.Close.Location = new System.Drawing.Point(1053, 575);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(178, 46);
            this.Close.TabIndex = 8;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "HEALTH SERVICES";
            // 
            // button1
            // 
            this.button1.Image = global::DataIntegration.Properties.Resources.blue1;
            this.button1.Location = new System.Drawing.Point(1053, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HealthServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::DataIntegration.Properties.Resources.health3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 674);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.States);
            this.Controls.Add(this.Patient);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.DataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HealthServices";
            this.Text = "HealthServices";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.Button Doctor;
        private System.Windows.Forms.Button Patient;
        private System.Windows.Forms.Button States;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}


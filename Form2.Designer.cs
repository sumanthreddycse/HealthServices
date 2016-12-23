namespace DataIntegration
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 510);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Close
            // 
            this.Close.Image = global::DataIntegration.Properties.Resources.health;
            this.Close.Location = new System.Drawing.Point(1022, 490);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(238, 46);
            this.Close.TabIndex = 6;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // button1
            // 
            this.button1.Image = global::DataIntegration.Properties.Resources.health;
            this.button1.Location = new System.Drawing.Point(1022, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "FetchCities";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "DOCTOR";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1022, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1022, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Image = global::DataIntegration.Properties.Resources.health;
            this.button3.Location = new System.Drawing.Point(1022, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 33);
            this.button3.TabIndex = 15;
            this.button3.Text = "FetchDiagnosis";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1022, 336);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(238, 21);
            this.comboBox3.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Image = global::DataIntegration.Properties.Resources.health;
            this.button2.Location = new System.Drawing.Point(1022, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "FetchDetails";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataIntegration.Properties.Resources.Health_doc;
            this.ClientSize = new System.Drawing.Size(1284, 674);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctor";
            this.Text = "HealthServices_Doctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
    }
}
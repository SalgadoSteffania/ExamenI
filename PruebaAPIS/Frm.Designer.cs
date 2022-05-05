namespace PruebaAPIS
{
    partial class Frm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDay.ForeColor = System.Drawing.Color.Black;
            this.lblDay.Location = new System.Drawing.Point(12, 137);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(28, 15);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Day";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeather.ForeColor = System.Drawing.Color.Black;
            this.lblWeather.Location = new System.Drawing.Point(12, 165);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(52, 15);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "Weather";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(12, 196);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 15);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(126, 220);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Frm";
            this.Text = "FrmForecast";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblDay;
        public System.Windows.Forms.Label lblWeather;
        public System.Windows.Forms.Label lblDescription;
    }
}
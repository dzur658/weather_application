namespace WeatherFinalProject
{
    partial class Form1
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
            this.converter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // converter
            // 
            this.converter.Location = new System.Drawing.Point(709, 398);
            this.converter.Name = "converter";
            this.converter.Size = new System.Drawing.Size(101, 33);
            this.converter.TabIndex = 0;
            this.converter.Text = "Convert to Celcius";
            this.converter.UseVisualStyleBackColor = true;
            this.converter.Click += new System.EventHandler(this.converter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 431);
            this.Controls.Add(this.converter);
            this.Name = "Form1";
            this.Text = "WeatherForecastApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button converter;
    }
}


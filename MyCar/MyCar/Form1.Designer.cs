namespace MyCar
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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(112, 114);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(16, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "...";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(112, 55);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(16, 13);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "...";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(112, 166);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(16, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblYear;
    }
}


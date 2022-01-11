namespace Trackbar
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
            this.TrackGlasnoca = new System.Windows.Forms.TrackBar();
            this.ispis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackGlasnoca)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackGlasnoca
            // 
            this.TrackGlasnoca.LargeChange = 20;
            this.TrackGlasnoca.Location = new System.Drawing.Point(12, 12);
            this.TrackGlasnoca.Maximum = 100;
            this.TrackGlasnoca.Name = "TrackGlasnoca";
            this.TrackGlasnoca.Size = new System.Drawing.Size(227, 45);
            this.TrackGlasnoca.TabIndex = 0;
            this.TrackGlasnoca.Scroll += new System.EventHandler(this.TrackGlasnoca_Scroll);
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(139, 64);
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(100, 20);
            this.ispis.TabIndex = 1;
            this.ispis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Postavljena vrijednost je";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 145);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.TrackGlasnoca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrackGlasnoca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrackGlasnoca;
        private System.Windows.Forms.TextBox ispis;
        private System.Windows.Forms.Label label1;
    }
}


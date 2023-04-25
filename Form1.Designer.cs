namespace AtestatBreakoutio
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
            this.components = new System.ComponentModel.Container();
            this.txtScor = new System.Windows.Forms.Label();
            this.jucator = new System.Windows.Forms.PictureBox();
            this.bila = new System.Windows.Forms.PictureBox();
            this.timerjoc = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jucator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bila)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScor
            // 
            this.txtScor.AutoSize = true;
            this.txtScor.BackColor = System.Drawing.Color.Transparent;
            this.txtScor.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScor.ForeColor = System.Drawing.Color.White;
            this.txtScor.Location = new System.Drawing.Point(12, 9);
            this.txtScor.Name = "txtScor";
            this.txtScor.Size = new System.Drawing.Size(367, 48);
            this.txtScor.TabIndex = 0;
            this.txtScor.Text = "Scor :   Enter - Incepe";
            this.txtScor.Click += new System.EventHandler(this.txtScor_Click);
            // 
            // jucator
            // 
            this.jucator.BackColor = System.Drawing.Color.White;
            this.jucator.Location = new System.Drawing.Point(527, 656);
            this.jucator.Name = "jucator";
            this.jucator.Size = new System.Drawing.Size(133, 36);
            this.jucator.TabIndex = 1;
            this.jucator.TabStop = false;
            // 
            // bila
            // 
            this.bila.BackColor = System.Drawing.Color.LawnGreen;
            this.bila.Location = new System.Drawing.Point(568, 348);
            this.bila.Name = "bila";
            this.bila.Size = new System.Drawing.Size(32, 31);
            this.bila.TabIndex = 2;
            this.bila.TabStop = false;
            // 
            // timerjoc
            // 
            this.timerjoc.Interval = 20;
            this.timerjoc.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1207, 704);
            this.Controls.Add(this.bila);
            this.Controls.Add(this.jucator);
            this.Controls.Add(this.txtScor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TastaJos);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TastaSus);
            ((System.ComponentModel.ISupportInitialize)(this.jucator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScor;
        private System.Windows.Forms.PictureBox jucator;
        private System.Windows.Forms.PictureBox bila;
        private System.Windows.Forms.Timer timerjoc;
    }
}
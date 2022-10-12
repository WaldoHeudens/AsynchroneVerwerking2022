namespace Les_5_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btStart = new System.Windows.Forms.Button();
            this.tbSynchroonResultaat = new System.Windows.Forms.TextBox();
            this.tbAsynchroonResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSynchroonTijd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAsynchroonTijd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(27, 12);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(155, 37);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start de klok";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbSynchroonResultaat
            // 
            this.tbSynchroonResultaat.Location = new System.Drawing.Point(27, 123);
            this.tbSynchroonResultaat.Multiline = true;
            this.tbSynchroonResultaat.Name = "tbSynchroonResultaat";
            this.tbSynchroonResultaat.ReadOnly = true;
            this.tbSynchroonResultaat.Size = new System.Drawing.Size(365, 156);
            this.tbSynchroonResultaat.TabIndex = 1;
            // 
            // tbAsynchroonResult
            // 
            this.tbAsynchroonResult.Location = new System.Drawing.Point(418, 123);
            this.tbAsynchroonResult.Multiline = true;
            this.tbAsynchroonResult.Name = "tbAsynchroonResult";
            this.tbAsynchroonResult.ReadOnly = true;
            this.tbAsynchroonResult.Size = new System.Drawing.Size(358, 156);
            this.tbAsynchroonResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Synchroon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asynchroon";
            // 
            // tbSynchroonTijd
            // 
            this.tbSynchroonTijd.Location = new System.Drawing.Point(120, 330);
            this.tbSynchroonTijd.Name = "tbSynchroonTijd";
            this.tbSynchroonTijd.Size = new System.Drawing.Size(150, 23);
            this.tbSynchroonTijd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tijd Verwerking";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tijd Verwerking";
            // 
            // tbAsynchroonTijd
            // 
            this.tbAsynchroonTijd.Location = new System.Drawing.Point(512, 330);
            this.tbAsynchroonTijd.Name = "tbAsynchroonTijd";
            this.tbAsynchroonTijd.Size = new System.Drawing.Size(150, 23);
            this.tbAsynchroonTijd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAsynchroonTijd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSynchroonTijd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAsynchroonResult);
            this.Controls.Add(this.tbSynchroonResultaat);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Demonstratie Asynchrone verwerking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btStart;
        private TextBox tbSynchroonResultaat;
        private TextBox tbAsynchroonResult;
        private Label label1;
        private Label label2;
        private TextBox tbSynchroonTijd;
        private Label label3;
        private Label label4;
        private TextBox tbAsynchroonTijd;
    }
}
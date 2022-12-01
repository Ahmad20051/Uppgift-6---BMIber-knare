namespace Uppgift_6___BMIberäknare
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtVikt = new System.Windows.Forms.TextBox();
            this.txtLängd = new System.Windows.Forms.TextBox();
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnStäng = new System.Windows.Forms.Button();
            this.btnStartaOm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI beräknare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vikt (kg)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Längd (m)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(91, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Namn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(91, 166);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(232, 27);
            this.txtNamn.TabIndex = 4;
            // 
            // txtVikt
            // 
            this.txtVikt.Location = new System.Drawing.Point(91, 245);
            this.txtVikt.Name = "txtVikt";
            this.txtVikt.Size = new System.Drawing.Size(232, 27);
            this.txtVikt.TabIndex = 5;
            this.txtVikt.ReadOnlyChanged += new System.EventHandler(this.textBox2_ReadOnlyChanged);
            // 
            // txtLängd
            // 
            this.txtLängd.Location = new System.Drawing.Point(91, 326);
            this.txtLängd.Name = "txtLängd";
            this.txtLängd.Size = new System.Drawing.Size(232, 27);
            this.txtLängd.TabIndex = 6;
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBeräkna.Location = new System.Drawing.Point(91, 534);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(326, 29);
            this.btnBeräkna.TabIndex = 7;
            this.btnBeräkna.Text = "Beräkna";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.btn_bmi);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(91, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtResultat.Location = new System.Drawing.Point(91, 421);
            this.txtResultat.Multiline = true;
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(326, 92);
            this.txtResultat.TabIndex = 9;
            this.txtResultat.TextChanged += new System.EventHandler(this.txtResultat_TextChanged);
            // 
            // btnStäng
            // 
            this.btnStäng.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStäng.Location = new System.Drawing.Point(272, 588);
            this.btnStäng.Name = "btnStäng";
            this.btnStäng.Size = new System.Drawing.Size(145, 29);
            this.btnStäng.TabIndex = 10;
            this.btnStäng.Text = "Stäng";
            this.btnStäng.UseVisualStyleBackColor = true;
            this.btnStäng.Click += new System.EventHandler(this.btnStäng_Click);
            // 
            // btnStartaOm
            // 
            this.btnStartaOm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartaOm.Location = new System.Drawing.Point(91, 588);
            this.btnStartaOm.Name = "btnStartaOm";
            this.btnStartaOm.Size = new System.Drawing.Size(145, 29);
            this.btnStartaOm.TabIndex = 11;
            this.btnStartaOm.Text = "Starta om";
            this.btnStartaOm.UseVisualStyleBackColor = true;
            this.btnStartaOm.Click += new System.EventHandler(this.btnStartaOm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 683);
            this.Controls.Add(this.btnStartaOm);
            this.Controls.Add(this.btnStäng);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBeräkna);
            this.Controls.Add(this.txtLängd);
            this.Controls.Add(this.txtVikt);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNamn;
        private TextBox txtVikt;
        private TextBox txtLängd;
        private Button btnBeräkna;
        private Label label5;
        private TextBox txtResultat;
        private Button btnStäng;
        private Button btnStartaOm;
    }
}
namespace Filmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.vnosLeto = new System.Windows.Forms.TextBox();
            this.vnosOcena = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prikazRezultati = new System.Windows.Forms.TextBox();
            this.gumbPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregledovanje baze Filmi";
            // 
            // vnosLeto
            // 
            this.vnosLeto.BackColor = System.Drawing.Color.Black;
            this.vnosLeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vnosLeto.ForeColor = System.Drawing.Color.White;
            this.vnosLeto.Location = new System.Drawing.Point(55, 167);
            this.vnosLeto.Name = "vnosLeto";
            this.vnosLeto.Size = new System.Drawing.Size(100, 35);
            this.vnosLeto.TabIndex = 1;
            // 
            // vnosOcena
            // 
            this.vnosOcena.BackColor = System.Drawing.Color.Black;
            this.vnosOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vnosOcena.ForeColor = System.Drawing.Color.White;
            this.vnosOcena.Location = new System.Drawing.Point(55, 280);
            this.vnosOcena.Name = "vnosOcena";
            this.vnosOcena.Size = new System.Drawing.Size(100, 35);
            this.vnosOcena.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-38, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 508);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vnesite leto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(49, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ocena večja od:";
            // 
            // prikazRezultati
            // 
            this.prikazRezultati.BackColor = System.Drawing.Color.Black;
            this.prikazRezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prikazRezultati.ForeColor = System.Drawing.Color.White;
            this.prikazRezultati.Location = new System.Drawing.Point(308, 99);
            this.prikazRezultati.Multiline = true;
            this.prikazRezultati.Name = "prikazRezultati";
            this.prikazRezultati.Size = new System.Drawing.Size(470, 319);
            this.prikazRezultati.TabIndex = 6;
            // 
            // gumbPrikazi
            // 
            this.gumbPrikazi.BackColor = System.Drawing.Color.HotPink;
            this.gumbPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbPrikazi.Location = new System.Drawing.Point(48, 375);
            this.gumbPrikazi.Name = "gumbPrikazi";
            this.gumbPrikazi.Size = new System.Drawing.Size(107, 43);
            this.gumbPrikazi.TabIndex = 7;
            this.gumbPrikazi.Text = "Prikaži";
            this.gumbPrikazi.UseVisualStyleBackColor = false;
            this.gumbPrikazi.Click += new System.EventHandler(this.prikaziKlik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gumbPrikazi);
            this.Controls.Add(this.prikazRezultati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vnosOcena);
            this.Controls.Add(this.vnosLeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Filmi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vnosLeto;
        private System.Windows.Forms.TextBox vnosOcena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prikazRezultati;
        private System.Windows.Forms.Button gumbPrikazi;
    }
}


namespace Card
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
            this.deckA = new System.Windows.Forms.PictureBox();
            this.pileB = new System.Windows.Forms.PictureBox();
            this.pileA = new System.Windows.Forms.PictureBox();
            this.numpileA = new System.Windows.Forms.Label();
            this.numpileB = new System.Windows.Forms.Label();
            this.showB = new System.Windows.Forms.PictureBox();
            this.showA = new System.Windows.Forms.PictureBox();
            this.hit = new System.Windows.Forms.Button();
            this.deckB = new System.Windows.Forms.PictureBox();
            this.com = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastA1 = new System.Windows.Forms.PictureBox();
            this.lastA2 = new System.Windows.Forms.PictureBox();
            this.lastA3 = new System.Windows.Forms.PictureBox();
            this.lastB1 = new System.Windows.Forms.PictureBox();
            this.lastB2 = new System.Windows.Forms.PictureBox();
            this.lastB3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deckA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastA3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastB3)).BeginInit();
            this.SuspendLayout();
            // 
            // deckA
            // 
            this.deckA.Location = new System.Drawing.Point(565, 227);
            this.deckA.Name = "deckA";
            this.deckA.Size = new System.Drawing.Size(100, 125);
            this.deckA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deckA.TabIndex = 1;
            this.deckA.TabStop = false;
            // 
            // pileB
            // 
            this.pileB.Location = new System.Drawing.Point(565, 82);
            this.pileB.Name = "pileB";
            this.pileB.Size = new System.Drawing.Size(100, 125);
            this.pileB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pileB.TabIndex = 2;
            this.pileB.TabStop = false;
            // 
            // pileA
            // 
            this.pileA.Location = new System.Drawing.Point(290, 227);
            this.pileA.Name = "pileA";
            this.pileA.Size = new System.Drawing.Size(100, 125);
            this.pileA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pileA.TabIndex = 3;
            this.pileA.TabStop = false;
            // 
            // numpileA
            // 
            this.numpileA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpileA.Location = new System.Drawing.Point(169, 253);
            this.numpileA.Name = "numpileA";
            this.numpileA.Size = new System.Drawing.Size(75, 75);
            this.numpileA.TabIndex = 4;
            this.numpileA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numpileB
            // 
            this.numpileB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpileB.Location = new System.Drawing.Point(711, 107);
            this.numpileB.Name = "numpileB";
            this.numpileB.Size = new System.Drawing.Size(75, 75);
            this.numpileB.TabIndex = 5;
            this.numpileB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showB
            // 
            this.showB.Location = new System.Drawing.Point(428, 82);
            this.showB.Name = "showB";
            this.showB.Size = new System.Drawing.Size(100, 125);
            this.showB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showB.TabIndex = 10;
            this.showB.TabStop = false;
            // 
            // showA
            // 
            this.showA.Location = new System.Drawing.Point(428, 228);
            this.showA.Name = "showA";
            this.showA.Size = new System.Drawing.Size(100, 125);
            this.showA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showA.TabIndex = 11;
            this.showA.TabStop = false;
            // 
            // hit
            // 
            this.hit.Location = new System.Drawing.Point(426, 394);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(103, 23);
            this.hit.TabIndex = 20;
            this.hit.Text = "DRAW";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // deckB
            // 
            this.deckB.Location = new System.Drawing.Point(290, 82);
            this.deckB.Name = "deckB";
            this.deckB.Size = new System.Drawing.Size(100, 125);
            this.deckB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deckB.TabIndex = 21;
            this.deckB.TabStop = false;
            // 
            // com
            // 
            this.com.Location = new System.Drawing.Point(426, 423);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(103, 23);
            this.com.TabIndex = 22;
            this.com.Text = "TURN CARD";
            this.com.UseVisualStyleBackColor = true;
            this.com.Click += new System.EventHandler(this.com_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "PLAYER B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "PLAYER A";
            // 
            // lastA1
            // 
            this.lastA1.Location = new System.Drawing.Point(276, 227);
            this.lastA1.Name = "lastA1";
            this.lastA1.Size = new System.Drawing.Size(100, 125);
            this.lastA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastA1.TabIndex = 27;
            this.lastA1.TabStop = false;
            // 
            // lastA2
            // 
            this.lastA2.Location = new System.Drawing.Point(263, 227);
            this.lastA2.Name = "lastA2";
            this.lastA2.Size = new System.Drawing.Size(100, 125);
            this.lastA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastA2.TabIndex = 28;
            this.lastA2.TabStop = false;
            // 
            // lastA3
            // 
            this.lastA3.Location = new System.Drawing.Point(250, 227);
            this.lastA3.Name = "lastA3";
            this.lastA3.Size = new System.Drawing.Size(100, 125);
            this.lastA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastA3.TabIndex = 29;
            this.lastA3.TabStop = false;
            // 
            // lastB1
            // 
            this.lastB1.Location = new System.Drawing.Point(578, 82);
            this.lastB1.Name = "lastB1";
            this.lastB1.Size = new System.Drawing.Size(100, 125);
            this.lastB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastB1.TabIndex = 30;
            this.lastB1.TabStop = false;
            // 
            // lastB2
            // 
            this.lastB2.Location = new System.Drawing.Point(592, 82);
            this.lastB2.Name = "lastB2";
            this.lastB2.Size = new System.Drawing.Size(100, 125);
            this.lastB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastB2.TabIndex = 31;
            this.lastB2.TabStop = false;
            // 
            // lastB3
            // 
            this.lastB3.Location = new System.Drawing.Point(605, 82);
            this.lastB3.Name = "lastB3";
            this.lastB3.Size = new System.Drawing.Size(100, 125);
            this.lastB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lastB3.TabIndex = 32;
            this.lastB3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(953, 502);
            this.Controls.Add(this.pileB);
            this.Controls.Add(this.lastB1);
            this.Controls.Add(this.lastB2);
            this.Controls.Add(this.pileA);
            this.Controls.Add(this.lastA1);
            this.Controls.Add(this.lastA2);
            this.Controls.Add(this.lastB3);
            this.Controls.Add(this.lastA3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com);
            this.Controls.Add(this.deckB);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.showA);
            this.Controls.Add(this.showB);
            this.Controls.Add(this.numpileB);
            this.Controls.Add(this.numpileA);
            this.Controls.Add(this.deckA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deckA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastA3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastB3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox deckA;
        private System.Windows.Forms.PictureBox pileB;
        private System.Windows.Forms.PictureBox pileA;
        private System.Windows.Forms.Label numpileA;
        private System.Windows.Forms.Label numpileB;
        private System.Windows.Forms.PictureBox showB;
        private System.Windows.Forms.PictureBox showA;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.PictureBox deckB;
        private System.Windows.Forms.Button com;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox lastA1;
        private System.Windows.Forms.PictureBox lastA2;
        private System.Windows.Forms.PictureBox lastA3;
        private System.Windows.Forms.PictureBox lastB1;
        private System.Windows.Forms.PictureBox lastB2;
        private System.Windows.Forms.PictureBox lastB3;
    }
}


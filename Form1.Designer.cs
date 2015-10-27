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
            this.namepileA = new System.Windows.Forms.Label();
            this.namepileB = new System.Windows.Forms.Label();
            this.showB = new System.Windows.Forms.PictureBox();
            this.showA = new System.Windows.Forms.PictureBox();
            this.hit = new System.Windows.Forms.Button();
            this.deckB = new System.Windows.Forms.PictureBox();
            this.com = new System.Windows.Forms.Button();
            this.listA = new System.Windows.Forms.ListBox();
            this.listB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deckA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pileA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deckB)).BeginInit();
            this.SuspendLayout();
            // 
            // deckA
            // 
            this.deckA.Location = new System.Drawing.Point(789, 322);
            this.deckA.Name = "deckA";
            this.deckA.Size = new System.Drawing.Size(200, 250);
            this.deckA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deckA.TabIndex = 1;
            this.deckA.TabStop = false;
            // 
            // pileB
            // 
            this.pileB.Location = new System.Drawing.Point(789, 57);
            this.pileB.Name = "pileB";
            this.pileB.Size = new System.Drawing.Size(200, 250);
            this.pileB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pileB.TabIndex = 2;
            this.pileB.TabStop = false;
            // 
            // pileA
            // 
            this.pileA.Location = new System.Drawing.Point(268, 322);
            this.pileA.Name = "pileA";
            this.pileA.Size = new System.Drawing.Size(200, 250);
            this.pileA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pileA.TabIndex = 3;
            this.pileA.TabStop = false;
            // 
            // numpileA
            // 
            this.numpileA.AutoSize = true;
            this.numpileA.Location = new System.Drawing.Point(65, 103);
            this.numpileA.Name = "numpileA";
            this.numpileA.Size = new System.Drawing.Size(13, 13);
            this.numpileA.TabIndex = 4;
            this.numpileA.Text = "0";
            // 
            // numpileB
            // 
            this.numpileB.AutoSize = true;
            this.numpileB.Location = new System.Drawing.Point(1169, 103);
            this.numpileB.Name = "numpileB";
            this.numpileB.Size = new System.Drawing.Size(13, 13);
            this.numpileB.TabIndex = 5;
            this.numpileB.Text = "0";
            // 
            // namepileA
            // 
            this.namepileA.AutoSize = true;
            this.namepileA.Location = new System.Drawing.Point(52, 82);
            this.namepileA.Name = "namepileA";
            this.namepileA.Size = new System.Drawing.Size(40, 13);
            this.namepileA.TabIndex = 6;
            this.namepileA.Text = "PILE A";
            // 
            // namepileB
            // 
            this.namepileB.AutoSize = true;
            this.namepileB.Location = new System.Drawing.Point(1155, 82);
            this.namepileB.Name = "namepileB";
            this.namepileB.Size = new System.Drawing.Size(40, 13);
            this.namepileB.TabIndex = 7;
            this.namepileB.Text = "PILE B";
            // 
            // showB
            // 
            this.showB.Location = new System.Drawing.Point(529, 57);
            this.showB.Name = "showB";
            this.showB.Size = new System.Drawing.Size(200, 250);
            this.showB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showB.TabIndex = 10;
            this.showB.TabStop = false;
            // 
            // showA
            // 
            this.showA.Location = new System.Drawing.Point(529, 322);
            this.showA.Name = "showA";
            this.showA.Size = new System.Drawing.Size(200, 250);
            this.showA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showA.TabIndex = 11;
            this.showA.TabStop = false;
            // 
            // hit
            // 
            this.hit.Location = new System.Drawing.Point(29, 449);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(103, 23);
            this.hit.TabIndex = 20;
            this.hit.Text = "DRAW";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // deckB
            // 
            this.deckB.Location = new System.Drawing.Point(268, 57);
            this.deckB.Name = "deckB";
            this.deckB.Size = new System.Drawing.Size(200, 250);
            this.deckB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deckB.TabIndex = 21;
            this.deckB.TabStop = false;
            // 
            // com
            // 
            this.com.Location = new System.Drawing.Point(29, 478);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(103, 23);
            this.com.TabIndex = 22;
            this.com.Text = "TURN CARD";
            this.com.UseVisualStyleBackColor = true;
            this.com.Click += new System.EventHandler(this.com_Click);
            // 
            // listA
            // 
            this.listA.FormattingEnabled = true;
            this.listA.Location = new System.Drawing.Point(29, 131);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(103, 290);
            this.listA.TabIndex = 23;
            // 
            // listB
            // 
            this.listB.FormattingEnabled = true;
            this.listB.Location = new System.Drawing.Point(1125, 131);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(103, 290);
            this.listB.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "PLAYER B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "PLAYER A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1254, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listB);
            this.Controls.Add(this.listA);
            this.Controls.Add(this.com);
            this.Controls.Add(this.deckB);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.showA);
            this.Controls.Add(this.showB);
            this.Controls.Add(this.namepileB);
            this.Controls.Add(this.namepileA);
            this.Controls.Add(this.numpileB);
            this.Controls.Add(this.numpileA);
            this.Controls.Add(this.pileA);
            this.Controls.Add(this.pileB);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox deckA;
        private System.Windows.Forms.PictureBox pileB;
        private System.Windows.Forms.PictureBox pileA;
        private System.Windows.Forms.Label numpileA;
        private System.Windows.Forms.Label numpileB;
        private System.Windows.Forms.Label namepileA;
        private System.Windows.Forms.Label namepileB;
        private System.Windows.Forms.PictureBox showB;
        private System.Windows.Forms.PictureBox showA;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.PictureBox deckB;
        private System.Windows.Forms.Button com;
        private System.Windows.Forms.ListBox listA;
        private System.Windows.Forms.ListBox listB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


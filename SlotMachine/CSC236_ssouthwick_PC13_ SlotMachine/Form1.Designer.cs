namespace CSC236_ssouthwick_PC13__SlotMachine
{
    partial class SlotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMachine));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbxDeposit = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imlSlots = new System.Windows.Forms.ImageList(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.tbxTotalDeposits = new System.Windows.Forms.TextBox();
            this.tbxTotalWon = new System.Windows.Forms.TextBox();
            this.buttonCashOut = new System.Windows.Forms.Button();
            this.labelCashOut = new System.Windows.Forms.Label();
            this.lblSlots = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LawnGreen;
            this.btnExit.Location = new System.Drawing.Point(655, 400);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Lime;
            this.btnSpin.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(215, 342);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(345, 46);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "SPIN   SPIN   SPIN";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(137, 299);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(242, 27);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Enter Amount: $";
            // 
            // tbxDeposit
            // 
            this.tbxDeposit.Location = new System.Drawing.Point(379, 299);
            this.tbxDeposit.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxDeposit.Name = "tbxDeposit";
            this.tbxDeposit.Size = new System.Drawing.Size(95, 31);
            this.tbxDeposit.TabIndex = 4;
            this.tbxDeposit.Text = "100.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(268, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(513, 74);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(218, 196);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "by Sheryl Southwick";
            // 
            // imlSlots
            // 
            this.imlSlots.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSlots.ImageStream")));
            this.imlSlots.TransparentColor = System.Drawing.Color.Transparent;
            this.imlSlots.Images.SetKeyName(0, "banana.jpg");
            this.imlSlots.Images.SetKeyName(1, "bar.jpg");
            this.imlSlots.Images.SetKeyName(2, "bell.jpg");
            this.imlSlots.Images.SetKeyName(3, "cherries.jpg");
            this.imlSlots.Images.SetKeyName(4, "lemon.jpg");
            this.imlSlots.Images.SetKeyName(5, "orange.jpg");
            this.imlSlots.Images.SetKeyName(6, "plum.jpg");
            this.imlSlots.Images.SetKeyName(7, "seven.jpg");
            this.imlSlots.Images.SetKeyName(8, "strawberry.jpg");
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Yellow;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(26, 323);
            this.btnOK.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(705, 46);
            this.btnOK.TabIndex = 10;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbxTotalDeposits
            // 
            this.tbxTotalDeposits.Location = new System.Drawing.Point(26, 372);
            this.tbxTotalDeposits.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxTotalDeposits.Name = "tbxTotalDeposits";
            this.tbxTotalDeposits.Size = new System.Drawing.Size(75, 31);
            this.tbxTotalDeposits.TabIndex = 12;
            this.tbxTotalDeposits.Text = "0.00";
            this.tbxTotalDeposits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxTotalDeposits.Visible = false;
            // 
            // tbxTotalWon
            // 
            this.tbxTotalWon.Location = new System.Drawing.Point(117, 372);
            this.tbxTotalWon.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbxTotalWon.Name = "tbxTotalWon";
            this.tbxTotalWon.Size = new System.Drawing.Size(82, 31);
            this.tbxTotalWon.TabIndex = 13;
            this.tbxTotalWon.Text = "0.00";
            this.tbxTotalWon.Visible = false;
            // 
            // buttonCashOut
            // 
            this.buttonCashOut.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonCashOut.ForeColor = System.Drawing.Color.Black;
            this.buttonCashOut.Location = new System.Drawing.Point(476, 400);
            this.buttonCashOut.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.buttonCashOut.Name = "buttonCashOut";
            this.buttonCashOut.Size = new System.Drawing.Size(255, 46);
            this.buttonCashOut.TabIndex = 14;
            this.buttonCashOut.Text = "CASH OUT && EXIT";
            this.buttonCashOut.UseVisualStyleBackColor = false;
            this.buttonCashOut.Click += new System.EventHandler(this.buttonCashOut_Click);
            // 
            // labelCashOut
            // 
            this.labelCashOut.BackColor = System.Drawing.Color.Yellow;
            this.labelCashOut.Font = new System.Drawing.Font("Broadway", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashOut.Location = new System.Drawing.Point(136, 120);
            this.labelCashOut.Name = "labelCashOut";
            this.labelCashOut.Size = new System.Drawing.Size(475, 233);
            this.labelCashOut.TabIndex = 15;
            this.labelCashOut.Text = "label1";
            this.labelCashOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCashOut.Visible = false;
            // 
            // lblSlots
            // 
            this.lblSlots.BackColor = System.Drawing.Color.Fuchsia;
            this.lblSlots.Font = new System.Drawing.Font("Broadway", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlots.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSlots.Location = new System.Drawing.Point(170, 9);
            this.lblSlots.Name = "lblSlots";
            this.lblSlots.Size = new System.Drawing.Size(426, 36);
            this.lblSlots.TabIndex = 16;
            this.lblSlots.Text = "Sheryl\'s Winning Slots";
            this.lblSlots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.buttonPlayAgain.Location = new System.Drawing.Point(242, 400);
            this.buttonPlayAgain.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(255, 46);
            this.buttonPlayAgain.TabIndex = 17;
            this.buttonPlayAgain.Text = "PLAY AGAIN";
            this.buttonPlayAgain.UseVisualStyleBackColor = false;
            this.buttonPlayAgain.Visible = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // SlotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(771, 468);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.lblSlots);
            this.Controls.Add(this.labelCashOut);
            this.Controls.Add(this.buttonCashOut);
            this.Controls.Add(this.tbxTotalWon);
            this.Controls.Add(this.tbxTotalDeposits);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbxDeposit);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(500, 150);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "SlotMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Let\'s Play!";
            this.Load += new System.EventHandler(this.SlotMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbxDeposit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imlSlots;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbxTotalDeposits;
        private System.Windows.Forms.TextBox tbxTotalWon;
        private System.Windows.Forms.Button buttonCashOut;
        private System.Windows.Forms.Label labelCashOut;
        private System.Windows.Forms.Label lblSlots;
        private System.Windows.Forms.Button buttonPlayAgain;
    }
}


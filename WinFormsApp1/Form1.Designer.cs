namespace WinFormsApp1
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
            Twater = new TextBox();
            BBCoffee = new Button();
            LWater = new Label();
            BMocca = new Button();
            BLatte = new Button();
            LCoffee = new Label();
            LMike = new Label();
            TCoffee = new TextBox();
            TMilk = new TextBox();
            TChocolate = new TextBox();
            LChocolate = new Label();
            BChocolate = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            BStockUp = new Button();
            SChoco = new TextBox();
            label1 = new Label();
            Smilk = new TextBox();
            Scoffee = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Swater = new TextBox();
            Pic = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic).BeginInit();
            SuspendLayout();
            // 
            // Twater
            // 
            Twater.BackColor = Color.FromArgb(192, 192, 255);
            Twater.Location = new Point(97, 29);
            Twater.Name = "Twater";
            Twater.ReadOnly = true;
            Twater.Size = new Size(100, 23);
            Twater.TabIndex = 0;
            Twater.Text = "300";
            Twater.TextChanged += Twater_TextChanged;
            // 
            // BBCoffee
            // 
            BBCoffee.Location = new Point(90, 233);
            BBCoffee.Name = "BBCoffee";
            BBCoffee.Size = new Size(166, 56);
            BBCoffee.TabIndex = 1;
            BBCoffee.Text = "BlackCoffee";
            BBCoffee.UseVisualStyleBackColor = true;
            BBCoffee.Click += button1_Click;
            // 
            // LWater
            // 
            LWater.AutoSize = true;
            LWater.Location = new Point(39, 29);
            LWater.Name = "LWater";
            LWater.Size = new Size(38, 15);
            LWater.TabIndex = 2;
            LWater.Text = "Water";
            // 
            // BMocca
            // 
            BMocca.Location = new Point(262, 233);
            BMocca.Name = "BMocca";
            BMocca.Size = new Size(166, 56);
            BMocca.TabIndex = 3;
            BMocca.Text = "Mocca";
            BMocca.UseVisualStyleBackColor = true;
            BMocca.Click += button2_Click;
            // 
            // BLatte
            // 
            BLatte.Location = new Point(90, 304);
            BLatte.Name = "BLatte";
            BLatte.Size = new Size(166, 56);
            BLatte.TabIndex = 4;
            BLatte.Text = "Latte";
            BLatte.UseVisualStyleBackColor = true;
            BLatte.Click += button3_Click;
            // 
            // LCoffee
            // 
            LCoffee.AutoSize = true;
            LCoffee.Location = new Point(39, 58);
            LCoffee.Name = "LCoffee";
            LCoffee.Size = new Size(42, 15);
            LCoffee.TabIndex = 5;
            LCoffee.Text = "Coffee";
            // 
            // LMike
            // 
            LMike.AutoSize = true;
            LMike.Location = new Point(39, 90);
            LMike.Name = "LMike";
            LMike.Size = new Size(30, 15);
            LMike.TabIndex = 6;
            LMike.Text = "Milk";
            // 
            // TCoffee
            // 
            TCoffee.BackColor = Color.FromArgb(192, 192, 255);
            TCoffee.Location = new Point(97, 58);
            TCoffee.Name = "TCoffee";
            TCoffee.ReadOnly = true;
            TCoffee.Size = new Size(100, 23);
            TCoffee.TabIndex = 7;
            TCoffee.Text = "300";
            TCoffee.TextChanged += textBox2_TextChanged;
            // 
            // TMilk
            // 
            TMilk.BackColor = Color.FromArgb(192, 192, 255);
            TMilk.Location = new Point(97, 87);
            TMilk.Name = "TMilk";
            TMilk.ReadOnly = true;
            TMilk.Size = new Size(100, 23);
            TMilk.TabIndex = 8;
            TMilk.Text = "300";
            // 
            // TChocolate
            // 
            TChocolate.BackColor = Color.FromArgb(192, 192, 255);
            TChocolate.Location = new Point(97, 116);
            TChocolate.Name = "TChocolate";
            TChocolate.ReadOnly = true;
            TChocolate.Size = new Size(100, 23);
            TChocolate.TabIndex = 10;
            TChocolate.Text = "300";
            // 
            // LChocolate
            // 
            LChocolate.AutoSize = true;
            LChocolate.Location = new Point(39, 119);
            LChocolate.Name = "LChocolate";
            LChocolate.Size = new Size(61, 15);
            LChocolate.TabIndex = 9;
            LChocolate.Text = "Chocolate";
            // 
            // BChocolate
            // 
            BChocolate.Location = new Point(262, 304);
            BChocolate.Name = "BChocolate";
            BChocolate.Size = new Size(166, 56);
            BChocolate.TabIndex = 11;
            BChocolate.Text = "Chocolate";
            BChocolate.UseVisualStyleBackColor = true;
            BChocolate.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(TChocolate);
            groupBox1.Controls.Add(LChocolate);
            groupBox1.Controls.Add(TMilk);
            groupBox1.Controls.Add(TCoffee);
            groupBox1.Controls.Add(LMike);
            groupBox1.Controls.Add(LCoffee);
            groupBox1.Controls.Add(LWater);
            groupBox1.Controls.Add(Twater);
            groupBox1.Location = new Point(558, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 156);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Incraingredient";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 122);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 14;
            label5.Text = "G";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 93);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 13;
            label6.Text = "G";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 61);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 12;
            label7.Text = "G";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(196, 32);
            label8.Name = "label8";
            label8.Size = new Size(15, 15);
            label8.TabIndex = 11;
            label8.Text = "G";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(BStockUp);
            groupBox2.Controls.Add(SChoco);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(Smilk);
            groupBox2.Controls.Add(Scoffee);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Swater);
            groupBox2.Location = new Point(558, 180);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 217);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Stock Up";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(198, 123);
            label9.Name = "label9";
            label9.Size = new Size(15, 15);
            label9.TabIndex = 18;
            label9.Text = "G";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(198, 94);
            label10.Name = "label10";
            label10.Size = new Size(15, 15);
            label10.TabIndex = 17;
            label10.Text = "G";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(198, 62);
            label11.Name = "label11";
            label11.Size = new Size(15, 15);
            label11.TabIndex = 16;
            label11.Text = "G";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(198, 33);
            label12.Name = "label12";
            label12.Size = new Size(15, 15);
            label12.TabIndex = 15;
            label12.Text = "G";
            // 
            // BStockUp
            // 
            BStockUp.Location = new Point(31, 155);
            BStockUp.Name = "BStockUp";
            BStockUp.Size = new Size(166, 56);
            BStockUp.TabIndex = 14;
            BStockUp.Text = "Stock Up";
            BStockUp.UseVisualStyleBackColor = true;
            BStockUp.Click += BStockUp_Click;
            // 
            // SChoco
            // 
            SChoco.Location = new Point(97, 116);
            SChoco.Name = "SChoco";
            SChoco.Size = new Size(100, 23);
            SChoco.TabIndex = 10;
            SChoco.Text = "100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 119);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 9;
            label1.Text = "Chocolate";
            // 
            // Smilk
            // 
            Smilk.Location = new Point(97, 87);
            Smilk.Name = "Smilk";
            Smilk.Size = new Size(100, 23);
            Smilk.TabIndex = 8;
            Smilk.Text = "100";
            // 
            // Scoffee
            // 
            Scoffee.Location = new Point(97, 58);
            Scoffee.Name = "Scoffee";
            Scoffee.Size = new Size(100, 23);
            Scoffee.TabIndex = 7;
            Scoffee.Text = "100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 90);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Mike";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 58);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Coffee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 29);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "Water";
            // 
            // Swater
            // 
            Swater.Location = new Point(97, 29);
            Swater.Name = "Swater";
            Swater.Size = new Size(100, 23);
            Swater.TabIndex = 0;
            Swater.Text = "100";
            Swater.TextChanged += Swater_TextChanged;
            // 
            // Pic
            // 
            Pic.BackColor = SystemColors.ActiveBorder;
            Pic.BackgroundImageLayout = ImageLayout.Center;
            Pic.BorderStyle = BorderStyle.Fixed3D;
            Pic.ErrorImage = null;
            Pic.Image = Properties.Resources.giphy;
            Pic.Location = new Point(177, 12);
            Pic.Name = "Pic";
            Pic.Size = new Size(165, 216);
            Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic.TabIndex = 14;
            Pic.TabStop = false;
            Pic.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pic);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BChocolate);
            Controls.Add(BLatte);
            Controls.Add(BMocca);
            Controls.Add(BBCoffee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Twater;
        private Button BBCoffee;
        private Label LWater;
        private Button BMocca;
        private Button BLatte;
        private Label LCoffee;
        private Label LMike;
        private TextBox TCoffee;
        private TextBox TMilk;
        private TextBox TChocolate;
        private Label LChocolate;
        private Button BChocolate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button BStockUp;
        private TextBox SChoco;
        private Label label1;
        private TextBox Smilk;
        private TextBox Scoffee;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Swater;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private PictureBox Pic;
    }
}

namespace ReliefCenterFinals
{
    partial class Form2
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
            this.rcLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goodNameBox = new System.Windows.Forms.TextBox();
            this.goodRateBox = new System.Windows.Forms.TextBox();
            this.outputWindow = new System.Windows.Forms.RichTextBox();
            this.addGoodButton = new System.Windows.Forms.Button();
            this.goodUnitBox = new System.Windows.Forms.ComboBox();
            this.inventoryWindow = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goodQuantityBox = new System.Windows.Forms.TextBox();
            this.printInventoryButton = new System.Windows.Forms.Button();
            this.clearOutputButton = new System.Windows.Forms.Button();
            this.goodDonateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.goodDropBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.goodPackBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.packReleaseButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcLabel
            // 
            this.rcLabel.AutoSize = true;
            this.rcLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcLabel.ForeColor = System.Drawing.Color.Black;
            this.rcLabel.Location = new System.Drawing.Point(305, 7);
            this.rcLabel.Name = "rcLabel";
            this.rcLabel.Size = new System.Drawing.Size(564, 55);
            this.rcLabel.TabIndex = 0;
            this.rcLabel.Text = "RELIEF CENTER NAME";
            this.rcLabel.Click += new System.EventHandler(this.rcLabelN);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(30, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unit";
            // 
            // goodNameBox
            // 
            this.goodNameBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodNameBox.Location = new System.Drawing.Point(127, 65);
            this.goodNameBox.Name = "goodNameBox";
            this.goodNameBox.Size = new System.Drawing.Size(121, 28);
            this.goodNameBox.TabIndex = 4;
            this.goodNameBox.TextChanged += new System.EventHandler(this.goodNameBox_TextChanged);
            // 
            // goodRateBox
            // 
            this.goodRateBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodRateBox.Location = new System.Drawing.Point(127, 124);
            this.goodRateBox.Name = "goodRateBox";
            this.goodRateBox.Size = new System.Drawing.Size(121, 28);
            this.goodRateBox.TabIndex = 5;
            // 
            // outputWindow
            // 
            this.outputWindow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputWindow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputWindow.ForeColor = System.Drawing.Color.DimGray;
            this.outputWindow.Location = new System.Drawing.Point(16, 321);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.ReadOnly = true;
            this.outputWindow.Size = new System.Drawing.Size(791, 362);
            this.outputWindow.TabIndex = 7;
            this.outputWindow.Text = "";
            this.outputWindow.TextChanged += new System.EventHandler(this.outputWindow_TextChanged);
            // 
            // addGoodButton
            // 
            this.addGoodButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addGoodButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGoodButton.ForeColor = System.Drawing.Color.White;
            this.addGoodButton.Location = new System.Drawing.Point(16, 218);
            this.addGoodButton.Name = "addGoodButton";
            this.addGoodButton.Size = new System.Drawing.Size(234, 46);
            this.addGoodButton.TabIndex = 8;
            this.addGoodButton.Text = "Add new Good";
            this.addGoodButton.UseVisualStyleBackColor = false;
            this.addGoodButton.Click += new System.EventHandler(this.addGoodClick);
            // 
            // goodUnitBox
            // 
            this.goodUnitBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodUnitBox.FormattingEnabled = true;
            this.goodUnitBox.Items.AddRange(new object[] {
            "liters",
            "kg",
            "cans"});
            this.goodUnitBox.Location = new System.Drawing.Point(127, 181);
            this.goodUnitBox.Name = "goodUnitBox";
            this.goodUnitBox.Size = new System.Drawing.Size(121, 29);
            this.goodUnitBox.TabIndex = 9;
            // 
            // inventoryWindow
            // 
            this.inventoryWindow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventoryWindow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryWindow.ForeColor = System.Drawing.Color.DimGray;
            this.inventoryWindow.Location = new System.Drawing.Point(10, 21);
            this.inventoryWindow.Name = "inventoryWindow";
            this.inventoryWindow.ReadOnly = true;
            this.inventoryWindow.Size = new System.Drawing.Size(413, 544);
            this.inventoryWindow.TabIndex = 10;
            this.inventoryWindow.Text = "";
            this.inventoryWindow.TextChanged += new System.EventHandler(this.inventoryWindow_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(283, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Relief Good";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(298, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // goodQuantityBox
            // 
            this.goodQuantityBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodQuantityBox.Location = new System.Drawing.Point(117, 94);
            this.goodQuantityBox.Name = "goodQuantityBox";
            this.goodQuantityBox.Size = new System.Drawing.Size(130, 28);
            this.goodQuantityBox.TabIndex = 14;
            this.goodQuantityBox.TextChanged += new System.EventHandler(this.goodQuantityBox_TextChanged);
            // 
            // printInventoryButton
            // 
            this.printInventoryButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.printInventoryButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInventoryButton.ForeColor = System.Drawing.Color.White;
            this.printInventoryButton.Location = new System.Drawing.Point(935, 581);
            this.printInventoryButton.Name = "printInventoryButton";
            this.printInventoryButton.Size = new System.Drawing.Size(250, 46);
            this.printInventoryButton.TabIndex = 15;
            this.printInventoryButton.Text = "Print Inventory";
            this.printInventoryButton.UseVisualStyleBackColor = false;
            this.printInventoryButton.Click += new System.EventHandler(this.printInventoryClick);
            // 
            // clearOutputButton
            // 
            this.clearOutputButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearOutputButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearOutputButton.ForeColor = System.Drawing.Color.White;
            this.clearOutputButton.Location = new System.Drawing.Point(935, 640);
            this.clearOutputButton.Name = "clearOutputButton";
            this.clearOutputButton.Size = new System.Drawing.Size(250, 46);
            this.clearOutputButton.TabIndex = 16;
            this.clearOutputButton.Text = "Clear Output Window";
            this.clearOutputButton.UseVisualStyleBackColor = false;
            this.clearOutputButton.Click += new System.EventHandler(this.clearOutputClick);
            // 
            // goodDonateButton
            // 
            this.goodDonateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.goodDonateButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodDonateButton.ForeColor = System.Drawing.Color.White;
            this.goodDonateButton.Location = new System.Drawing.Point(291, 197);
            this.goodDonateButton.Name = "goodDonateButton";
            this.goodDonateButton.Size = new System.Drawing.Size(234, 46);
            this.goodDonateButton.TabIndex = 17;
            this.goodDonateButton.Text = "Donate Goods";
            this.goodDonateButton.UseVisualStyleBackColor = false;
            this.goodDonateButton.Click += new System.EventHandler(this.goodDonateClick);
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(5, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 240);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adding New Goods";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.goodDropBox);
            this.groupBox2.Controls.Add(this.goodQuantityBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(276, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 194);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donating Goods";
            // 
            // goodDropBox
            // 
            this.goodDropBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodDropBox.FormattingEnabled = true;
            this.goodDropBox.Location = new System.Drawing.Point(117, 34);
            this.goodDropBox.Name = "goodDropBox";
            this.goodDropBox.Size = new System.Drawing.Size(130, 29);
            this.goodDropBox.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(12, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(807, 390);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output Window";
            // 
            // goodPackBox
            // 
            this.goodPackBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodPackBox.Location = new System.Drawing.Point(125, 29);
            this.goodPackBox.Name = "goodPackBox";
            this.goodPackBox.Size = new System.Drawing.Size(130, 28);
            this.goodPackBox.TabIndex = 23;
            this.goodPackBox.TextChanged += new System.EventHandler(this.goodPackBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(568, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "# of Packs";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.goodPackBox);
            this.groupBox4.Controls.Add(this.packReleaseButton);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(557, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 138);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Releasing Goods (in Packs)";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // packReleaseButton
            // 
            this.packReleaseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.packReleaseButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packReleaseButton.ForeColor = System.Drawing.Color.White;
            this.packReleaseButton.Location = new System.Drawing.Point(13, 76);
            this.packReleaseButton.Name = "packReleaseButton";
            this.packReleaseButton.Size = new System.Drawing.Size(237, 46);
            this.packReleaseButton.TabIndex = 24;
            this.packReleaseButton.Text = "Release Packs";
            this.packReleaseButton.UseVisualStyleBackColor = false;
            this.packReleaseButton.Click += new System.EventHandler(this.packReleaseButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.inventoryWindow);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Location = new System.Drawing.Point(843, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 570);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inventory Report";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1300, 705);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goodDonateButton);
            this.Controls.Add(this.clearOutputButton);
            this.Controls.Add(this.printInventoryButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goodUnitBox);
            this.Controls.Add(this.addGoodButton);
            this.Controls.Add(this.outputWindow);
            this.Controls.Add(this.goodRateBox);
            this.Controls.Add(this.goodNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rcLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rcLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox goodNameBox;
        private System.Windows.Forms.TextBox goodRateBox;
        private System.Windows.Forms.RichTextBox outputWindow;
        private System.Windows.Forms.Button addGoodButton;
        private System.Windows.Forms.ComboBox goodUnitBox;
        private System.Windows.Forms.RichTextBox inventoryWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox goodQuantityBox;
        private System.Windows.Forms.Button printInventoryButton;
        private System.Windows.Forms.Button clearOutputButton;
        private System.Windows.Forms.Button goodDonateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox goodPackBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button packReleaseButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox goodDropBox;
    }
}
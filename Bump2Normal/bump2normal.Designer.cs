namespace Bump2Normal
{
    partial class Bump2Normal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bump2Normal));
            label1 = new Label();
            Bump1Path = new TextBox();
            BrowseBump1BTN = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Bump2Path = new TextBox();
            label2 = new Label();
            BrowseBump2BTN = new Button();
            CreateSMDIBTN = new Button();
            CreateASBTN = new Button();
            CreateNormalBTN = new Button();
            PreviewTexturesBTN = new Button();
            label3 = new Label();
            label4 = new Label();
            heightBox = new TextBox();
            widthBox = new TextBox();
            heightLabel = new Label();
            widthLabel = new Label();
            CreatePrefixCheckBox = new CheckBox();
            FileNameTextbox = new TextBox();
            label5 = new Label();
            CreateAllTexturesBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Select your bump file";
            // 
            // Bump1Path
            // 
            Bump1Path.Location = new Point(8, 45);
            Bump1Path.Name = "Bump1Path";
            Bump1Path.Size = new Size(253, 23);
            Bump1Path.TabIndex = 2;
            Bump1Path.TextChanged += Bump1Path_TextChanged;
            // 
            // BrowseBump1BTN
            // 
            BrowseBump1BTN.ForeColor = Color.Black;
            BrowseBump1BTN.Location = new Point(267, 45);
            BrowseBump1BTN.Name = "BrowseBump1BTN";
            BrowseBump1BTN.Size = new Size(75, 23);
            BrowseBump1BTN.TabIndex = 3;
            BrowseBump1BTN.Text = "Browse";
            BrowseBump1BTN.UseVisualStyleBackColor = true;
            BrowseBump1BTN.Click += BrowseBump1BTN_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(620, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(360, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Bump2Path
            // 
            Bump2Path.Location = new Point(8, 93);
            Bump2Path.Name = "Bump2Path";
            Bump2Path.Size = new Size(253, 23);
            Bump2Path.TabIndex = 6;
            Bump2Path.TextChanged += Bump2Path_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 74);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 7;
            label2.Text = "Select your #bump file";
            // 
            // BrowseBump2BTN
            // 
            BrowseBump2BTN.ForeColor = Color.Black;
            BrowseBump2BTN.Location = new Point(267, 93);
            BrowseBump2BTN.Name = "BrowseBump2BTN";
            BrowseBump2BTN.Size = new Size(75, 23);
            BrowseBump2BTN.TabIndex = 8;
            BrowseBump2BTN.Text = "Browse";
            BrowseBump2BTN.UseVisualStyleBackColor = true;
            BrowseBump2BTN.Click += BrowseBump2BTN_Click;
            // 
            // CreateSMDIBTN
            // 
            CreateSMDIBTN.Enabled = false;
            CreateSMDIBTN.Location = new Point(8, 160);
            CreateSMDIBTN.Name = "CreateSMDIBTN";
            CreateSMDIBTN.Size = new Size(125, 24);
            CreateSMDIBTN.TabIndex = 9;
            CreateSMDIBTN.Text = "Create SMDI map";
            CreateSMDIBTN.UseVisualStyleBackColor = true;
            CreateSMDIBTN.Click += CreateSMDIBTN_Click;
            // 
            // CreateASBTN
            // 
            CreateASBTN.Enabled = false;
            CreateASBTN.Location = new Point(8, 130);
            CreateASBTN.Name = "CreateASBTN";
            CreateASBTN.Size = new Size(125, 24);
            CreateASBTN.TabIndex = 10;
            CreateASBTN.Text = "Create AS map";
            CreateASBTN.UseVisualStyleBackColor = true;
            CreateASBTN.Click += CreateAsBTN_Click_1;
            // 
            // CreateNormalBTN
            // 
            CreateNormalBTN.Enabled = false;
            CreateNormalBTN.Location = new Point(8, 190);
            CreateNormalBTN.Name = "CreateNormalBTN";
            CreateNormalBTN.Size = new Size(125, 24);
            CreateNormalBTN.TabIndex = 11;
            CreateNormalBTN.Text = "Create Normal map";
            CreateNormalBTN.UseVisualStyleBackColor = true;
            CreateNormalBTN.Click += CreateNormalBTN_Click;
            // 
            // PreviewTexturesBTN
            // 
            PreviewTexturesBTN.Enabled = false;
            PreviewTexturesBTN.Location = new Point(8, 249);
            PreviewTexturesBTN.Name = "PreviewTexturesBTN";
            PreviewTexturesBTN.Size = new Size(125, 24);
            PreviewTexturesBTN.TabIndex = 12;
            PreviewTexturesBTN.Text = "Preview Textures";
            PreviewTexturesBTN.UseVisualStyleBackColor = true;
            PreviewTexturesBTN.Click += PreviewTexturesBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 16);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "bump";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(717, 16);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 14;
            label4.Text = "bump#";
            // 
            // heightBox
            // 
            heightBox.Location = new Point(236, 144);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(71, 23);
            heightBox.TabIndex = 15;
            heightBox.KeyPress += textBox1_KeyPress;
            // 
            // widthBox
            // 
            widthBox.Location = new Point(160, 144);
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(70, 23);
            widthBox.TabIndex = 16;
            widthBox.KeyPress += textBox2_KeyPress;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(248, 126);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(41, 15);
            heightLabel.TabIndex = 17;
            heightLabel.Text = "height";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(174, 126);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(37, 15);
            widthLabel.TabIndex = 18;
            widthLabel.Text = "width";
            // 
            // CreatePrefixCheckBox
            // 
            CreatePrefixCheckBox.AutoSize = true;
            CreatePrefixCheckBox.Checked = true;
            CreatePrefixCheckBox.CheckState = CheckState.Checked;
            CreatePrefixCheckBox.Location = new Point(160, 173);
            CreatePrefixCheckBox.Name = "CreatePrefixCheckBox";
            CreatePrefixCheckBox.Size = new Size(93, 19);
            CreatePrefixCheckBox.TabIndex = 19;
            CreatePrefixCheckBox.Text = "Create Prefix";
            CreatePrefixCheckBox.UseVisualStyleBackColor = true;
            CreatePrefixCheckBox.CheckedChanged += CreatePrefixCheckBox_CheckedChanged;
            // 
            // FileNameTextbox
            // 
            FileNameTextbox.Location = new Point(160, 220);
            FileNameTextbox.Name = "FileNameTextbox";
            FileNameTextbox.Size = new Size(182, 23);
            FileNameTextbox.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 202);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 21;
            label5.Text = "File name";
            // 
            // CreateAllTexturesBTN
            // 
            CreateAllTexturesBTN.Enabled = false;
            CreateAllTexturesBTN.Location = new Point(8, 220);
            CreateAllTexturesBTN.Name = "CreateAllTexturesBTN";
            CreateAllTexturesBTN.Size = new Size(125, 23);
            CreateAllTexturesBTN.TabIndex = 22;
            CreateAllTexturesBTN.Text = "Create all textures";
            CreateAllTexturesBTN.UseVisualStyleBackColor = true;
            CreateAllTexturesBTN.Click += CreateAllTexturesBTN_Click;
            // 
            // Bump2Normal
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 287);
            Controls.Add(CreateAllTexturesBTN);
            Controls.Add(label5);
            Controls.Add(FileNameTextbox);
            Controls.Add(CreatePrefixCheckBox);
            Controls.Add(widthLabel);
            Controls.Add(heightLabel);
            Controls.Add(widthBox);
            Controls.Add(heightBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PreviewTexturesBTN);
            Controls.Add(CreateNormalBTN);
            Controls.Add(CreateASBTN);
            Controls.Add(CreateSMDIBTN);
            Controls.Add(BrowseBump2BTN);
            Controls.Add(label2);
            Controls.Add(Bump2Path);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(BrowseBump1BTN);
            Controls.Add(Bump1Path);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Bump2Normal";
            Text = "Bump2Normal";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public FolderBrowserDialog FolderBrowser;
        private TextBox Bump1Path;
        private Button BrowseBump1BTN;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox Bump2Path;
        private Label label2;
        private Button BrowseBump2BTN;
        private Button CreateSMDIBTN;
        private Button CreateASBTN;
        private Button CreateNormalBTN;
        private Button PreviewTexturesBTN;
        private Label label3;
        private Label label4;
        private TextBox heightBox;
        private TextBox widthBox;
        private Label heightLabel;
        private Label widthLabel;
        private CheckBox CreatePrefixCheckBox;
        private TextBox FileNameTextbox;
        private Label label5;
        private Button CreateAllTexturesBTN;
    }
}
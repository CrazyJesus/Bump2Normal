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
            CreateAsBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Select your bump file";
            // 
            // Bump1Path
            // 
            Bump1Path.Location = new Point(12, 23);
            Bump1Path.Name = "Bump1Path";
            Bump1Path.Size = new Size(253, 23);
            Bump1Path.TabIndex = 2;
            Bump1Path.TextChanged += Bump1Path_TextChanged;
            // 
            // BrowseBump1BTN
            // 
            BrowseBump1BTN.ForeColor = Color.Black;
            BrowseBump1BTN.Location = new Point(271, 23);
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
            pictureBox2.Location = new Point(638, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(352, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Bump2Path
            // 
            Bump2Path.Location = new Point(12, 71);
            Bump2Path.Name = "Bump2Path";
            Bump2Path.Size = new Size(253, 23);
            Bump2Path.TabIndex = 6;
            Bump2Path.TextChanged += Bump2Path_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 7;
            label2.Text = "Select your #bump file";
            // 
            // BrowseBump2BTN
            // 
            BrowseBump2BTN.ForeColor = Color.Black;
            BrowseBump2BTN.Location = new Point(271, 71);
            BrowseBump2BTN.Name = "BrowseBump2BTN";
            BrowseBump2BTN.Size = new Size(75, 23);
            BrowseBump2BTN.TabIndex = 8;
            BrowseBump2BTN.Text = "Browse";
            BrowseBump2BTN.UseVisualStyleBackColor = true;
            BrowseBump2BTN.Click += BrowseBump2BTN_Click;
            // 
            // CreateAsBTN
            // 
            CreateAsBTN.Enabled = false;
            CreateAsBTN.Location = new Point(15, 181);
            CreateAsBTN.Name = "CreateAsBTN";
            CreateAsBTN.Size = new Size(115, 24);
            CreateAsBTN.TabIndex = 9;
            CreateAsBTN.Text = "Create AS map";
            CreateAsBTN.UseVisualStyleBackColor = true;
            CreateAsBTN.Click += CreateAsBTN_Click;
            // 
            // Bump2Normal
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 267);
            Controls.Add(CreateAsBTN);
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
        private Button CreateAsBTN;
    }
}
using Bump2Normal.Properties;
using System.Windows.Forms;

namespace Bump2Normal
{
    partial class PreviewMaps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewMaps));
            PreviewTextureBoxAS = new PictureBox();
            PreviewTextureBoxSMDI = new PictureBox();
            PreviewTextureBoxNormal = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)PreviewTextureBoxAS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PreviewTextureBoxSMDI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PreviewTextureBoxNormal).BeginInit();
            SuspendLayout();
            // 
            // PreviewTextureBoxAS
            // 
            PreviewTextureBoxAS.Location = new Point(11, 43);
            PreviewTextureBoxAS.Name = "PreviewTextureBoxAS";
            PreviewTextureBoxAS.Size = new Size(230, 243);
            PreviewTextureBoxAS.TabIndex = 0;
            PreviewTextureBoxAS.TabStop = false;
            // 
            // PreviewTextureBoxSMDI
            // 
            PreviewTextureBoxSMDI.Location = new Point(247, 43);
            PreviewTextureBoxSMDI.Name = "PreviewTextureBoxSMDI";
            PreviewTextureBoxSMDI.Size = new Size(230, 243);
            PreviewTextureBoxSMDI.TabIndex = 1;
            PreviewTextureBoxSMDI.TabStop = false;
            // 
            // PreviewTextureBoxNormal
            // 
            PreviewTextureBoxNormal.Location = new Point(483, 43);
            PreviewTextureBoxNormal.Name = "PreviewTextureBoxNormal";
            PreviewTextureBoxNormal.Size = new Size(230, 243);
            PreviewTextureBoxNormal.TabIndex = 2;
            PreviewTextureBoxNormal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "As map";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 25);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "SMDI map";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 25);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "Normal map";
            // 
            // PreviewMaps
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(725, 307);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PreviewTextureBoxNormal);
            Controls.Add(PreviewTextureBoxSMDI);
            Controls.Add(PreviewTextureBoxAS);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PreviewMaps";
            Text = "PreviewTextures";
            ((System.ComponentModel.ISupportInitialize)PreviewTextureBoxAS).EndInit();
            ((System.ComponentModel.ISupportInitialize)PreviewTextureBoxSMDI).EndInit();
            ((System.ComponentModel.ISupportInitialize)PreviewTextureBoxNormal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PreviewTextureBoxAS;
        private PictureBox PreviewTextureBoxSMDI;
        private PictureBox PreviewTextureBoxNormal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
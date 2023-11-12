using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bump2Normal
{
    public partial class PreviewMaps : Form
    {
        public PreviewMaps()
        {
            InitializeComponent();
        }

        public PictureBox GetPictureAs()
        {
            return PreviewTextureBoxAS;
        }

        public void SetImageAS(Bitmap image)
        {
            PreviewTextureBoxAS.Image = image;
        }
        public void SetImageSMDI(Bitmap image)
        {
            PreviewTextureBoxSMDI.Image = image;
        }
        public void SetImageNormal(Bitmap image)
        {
            PreviewTextureBoxNormal.Image = image;
        }

        public void SetLabelSize(int width, int height)
        {
            widthLabel.Text = widthLabel.Text.Replace("%width%", width.ToString());
            heightLabel.Text = heightLabel.Text.Replace("%height%", height.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

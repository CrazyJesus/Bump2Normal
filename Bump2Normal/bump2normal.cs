using System.IO;
using System.IO.Packaging;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using static System.Net.WebRequestMethods;
using S16.Drawing;

namespace Bump2Normal
{

    public partial class Bump2Normal : Form
    {
        public Bump2Normal()
        {
            InitializeComponent();
        }

        private void BrowseBump1BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "tga files (*.dds)|*.dds|All files (*.*)|*.*";
            ofd.Title = "Please select bump.dds file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bump1Path.Text = ofd.FileName;
            }
        }

        private void Bump1Path_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Bump1Path.Text) && System.IO.File.Exists(Bump2Path.Text))
            {
                CreateSMDIBTN.Enabled = true;
                CreateASBTN.Enabled = true;
                CreateNormalBTN.Enabled = true;
                PreviewTexturesBTN.Enabled = true;
                CreateAllTexturesBTN.Enabled = true;
            }
            else
            {
                CreateAllTexturesBTN.Enabled = false;
                CreateSMDIBTN.Enabled = false;
                CreateASBTN.Enabled = false;
                CreateNormalBTN.Enabled = false;
                PreviewTexturesBTN.Enabled = false;
            }
            if (System.IO.File.Exists(Bump1Path.Text))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(Bump1Path.Text);
                DDSImage dds = new DDSImage(bytes);
                pictureBox1.Image = dds.BitmapImage;
                widthBox.Text = pictureBox1.Image.Width.ToString();
                heightBox.Text = pictureBox1.Image.Height.ToString();
                FileNameTextbox.Text = Path.GetFileName(Bump1Path.Text).Replace(".dds", "");
            }
        }

        private void BrowseBump2BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "dds files (*.dds)|*.dds|All files (*.*)|*.*";
            ofd.Title = "Please select bump.dds file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bump2Path.Text = ofd.FileName;
            }
        }

        private void Bump2Path_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Bump1Path.Text) && System.IO.File.Exists(Bump2Path.Text))
            {
                CreateSMDIBTN.Enabled = true;
                CreateASBTN.Enabled = true;
                CreateNormalBTN.Enabled = true;
                PreviewTexturesBTN.Enabled = true;
                CreateAllTexturesBTN.Enabled = true;
            }
            else
            {
                CreateAllTexturesBTN.Enabled = false;
                CreateSMDIBTN.Enabled = false;
                CreateASBTN.Enabled = false;
                CreateNormalBTN.Enabled = false;
                PreviewTexturesBTN.Enabled = false;
            }
            if (System.IO.File.Exists(Bump2Path.Text))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(Bump2Path.Text);
                DDSImage dds = new DDSImage(bytes);
                pictureBox2.Image = dds.BitmapImage;
            }
        }

        private void CreateAsaBTN_Click(object sender, EventArgs e)
        {
        }
        private Bitmap CreateAsMap()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(Bump1Path.Text);
            DDSImage dds = new DDSImage(bytes);
            Bitmap bump = dds.BitmapImage;
            bump = new Bitmap(bump, new Size(Convert.ToInt32(widthBox.Text), Convert.ToInt32(heightBox.Text)));
            Bitmap result = new Bitmap(Convert.ToInt32(widthBox.Text), Convert.ToInt32(heightBox.Text));
            for (int i = 0; i < bump.Width; i++)
            {
                for (int j = 0; j < bump.Height; j++)
                {
                    Color color = bump.GetPixel(i, j);

                    result.SetPixel(i, j, Color.FromArgb(255, 255, color.G, 255));
                }
            }
            return result;
        }
        private Bitmap CreateNormalMap()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(Bump1Path.Text);
            DDSImage dds = new DDSImage(bytes);
            Bitmap bump = dds.BitmapImage;
            bump = new Bitmap(bump, new Size(Convert.ToInt32(widthBox.Text), Convert.ToInt32(heightBox.Text)));
            Bitmap result = new Bitmap(Convert.ToInt32(widthBox.Text), Convert.ToInt32(heightBox.Text));
            for (int i = 0; i < bump.Width; i++)
            {
                for (int j = 0; j < bump.Height; j++)
                {
                    Color color = bump.GetPixel(i, j);

                    result.SetPixel(i, j, Color.FromArgb(255, color.A, color.B, color.G));
                }
            }
            return result;
        }

        private Bitmap CreateSmdiMap()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(Bump1Path.Text);
            DDSImage dds = new DDSImage(bytes);
            Bitmap bump = dds.BitmapImage;
            bump = new Bitmap(bump, new Size(Convert.ToInt32(widthBox.Text), Convert.ToInt32(heightBox.Text)));

            byte[] bytes2 = System.IO.File.ReadAllBytes(Bump2Path.Text);
            DDSImage dds2 = new DDSImage(bytes2);
            Bitmap bump2 = dds2.BitmapImage;
            bump2 = new Bitmap(bump2, new Size(Convert.ToInt32(widthBox.Text), Convert.ToInt32(heightBox.Text)));

            Bitmap result = new Bitmap(Convert.ToInt32(widthBox.Text), Convert.ToInt32(heightBox.Text));
            Color clr = bump.GetPixel(pictureBox1.Width, pictureBox1.Height);
            Color clr2 = bump2.GetPixel(pictureBox2.Width, pictureBox2.Height);
            for (int i = 0; i < bump.Width; i++)
            {
                for (int j = 0; j < bump.Height; j++)
                {
                    clr = bump.GetPixel(i, j);
                    clr2 = bump2.GetPixel(i, j);
                    result.SetPixel(i, j, Color.FromArgb(255, 255, clr.R, clr2.A));
                }
            }
            return result;
        }

        private void PreviewTexturesBTN_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Bump1Path.Text))
            {
                if (System.IO.File.Exists(Bump2Path.Text))
                {
                    PreviewMaps previewmap = new PreviewMaps();
                    previewmap.SetImageAS(CreateAsMap());
                    previewmap.SetImageNormal(CreateNormalMap());
                    previewmap.SetImageSMDI(CreateSmdiMap());
                    previewmap.SetLabelSize(Convert.ToInt32(widthBox.Text), Convert.ToInt32(heightBox.Text));
                    previewmap.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bump# is missing");
                }
            }
            else
            {
                MessageBox.Show("Bump is missing");
            }
        }

        private void CreateNormalBTN_Click(object sender, EventArgs e)
        {
            Bitmap normalmap = CreateNormalMap();

            if (CreatePrefixCheckBox.Checked)
            {
                MessageBox.Show("File was crated in path \"" + Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + "_nohq.png \"");
                normalmap.Save(Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + "_nohq.png");
            }
            else
            {
                MessageBox.Show("File was crated in path \"" + Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + ".png \"");
                normalmap.Save(Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + ".png");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void CreateAsBTN_Click_1(object sender, EventArgs e)
        {
            Bitmap normalmap = CreateAsMap();

            if (CreatePrefixCheckBox.Checked)
            {
                MessageBox.Show("File was crated in path \"" + Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + "_nohq.png \"");
                normalmap.Save(Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + "_as.png");
            }
            else
            {
                MessageBox.Show("File was crated in path \"" + Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + ".png \"");
                normalmap.Save(Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + ".png");
            }
        }

        private void CreateSMDIBTN_Click(object sender, EventArgs e)
        {
            Bitmap normalmap = CreateAsMap();

            if (CreatePrefixCheckBox.Checked)
            {
                MessageBox.Show("File was crated in path \"" + Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + "_nohq.png \"");
                normalmap.Save(Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + "_smdi.png");
            }
            else
            {
                MessageBox.Show("File was crated in path \"" + Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + ".png \"");
                normalmap.Save(Path.GetDirectoryName(Bump1Path.Text) + "\\" + FileNameTextbox.Text + ".png");
            }
        }

        private void CreatePrefixCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreateAllTexturesBTN_Click(object sender, EventArgs e)
        {
            CreateSMDIBTN_Click(sender, e);
            CreateAsBTN_Click_1(sender, e);
            CreateNormalBTN_Click(sender, e);
        }
    }
}
using System.IO;
using System.IO.Packaging;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


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
            ofd.Filter = "Select png file (*.png)|*.png|All files (*.*)|*.*";
            ofd.Title = "Please select bump.png file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bump1Path.Text = ofd.FileName;
            }
        }

        private void Bump1Path_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(Bump1Path.Text) && File.Exists(Bump2Path.Text))
            {
                CreateAsBTN.Enabled = true;
            }
            else
            {
                CreateAsBTN.Enabled = false;
            }
            if (File.Exists(Bump1Path.Text))
            {
                pictureBox1.Image = new Bitmap(Bump1Path.Text);
            }
        }
        private void BrowseBump2BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select png file (*.png)|*.png|All files (*.*)|*.*";
            ofd.Title = "Please select bump.png file";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bump2Path.Text = ofd.FileName;
            }
        }

        private void Bump2Path_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(Bump1Path.Text) && File.Exists(Bump2Path.Text))
            {
                CreateAsBTN.Enabled = true;
            }
            else
            {
                CreateAsBTN.Enabled = false;
            }
            if (File.Exists(Bump2Path.Text))
            {
                pictureBox2.Image = new Bitmap(Bump2Path.Text);
            }
        }

        private void CreateAsBTN_Click(object sender, EventArgs e)
        {
            if (File.Exists(Bump1Path.Text))
            {
                if (File.Exists(Bump2Path.Text))
                {
                    pictureBox2.Image = CreateAsMap();
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

        Bitmap CreateAsMap()
        {
            Bitmap bump = (Bitmap)pictureBox1.Image;
            Bitmap result = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
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
    }
}
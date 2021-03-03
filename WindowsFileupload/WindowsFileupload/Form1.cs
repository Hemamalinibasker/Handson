using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFileupload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Image Files (*.BMP;*.JPG;*.JPEG;.*.GIF;)|*.BMP;*.JPG;*.JPEG;.*.GIF";
            if (opn.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opn.FileName);
            }

        }
    }
}

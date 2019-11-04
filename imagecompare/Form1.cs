using System;
using System.Drawing;
using System.Windows.Forms;
using AbuEhabHelper;

namespace imagecompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        OpenFileDialog op1 = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            op1.ShowDialog();
            pictureBox1.Image = Image.FromFile(op1.FileName);

        }
        OpenFileDialog op2 = new OpenFileDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            op2.ShowDialog();
            pictureBox2.Image = Image.FromFile(op2.FileName);

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            bool resdul = ImagesArea.CompareIamges(pictureBox1, pictureBox2);
            MessageBox.Show(resdul.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

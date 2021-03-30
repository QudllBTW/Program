using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        private Form2 newForm = new Form2();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int v = random.Next(100, 9876);
            labelKeyGen.Text =Convert.ToString(v);
            MessageBox.Show(labelKeyGen.Text);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == labelKeyGen.Text)
            {
                newForm.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }


        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

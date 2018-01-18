using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20171108Win_BizimDialogBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            BizimDialoqBox bizimDialoq = new BizimDialoqBox();
            DialogResult netice = bizimDialoq.ShowDialog();

            if (netice == DialogResult.Yes)
            {
                label1.Text = "Gonder Buttonu klik oldu";
                label1.Text += "\n" + bizimDialoq.textBox1.Text;
            }
            else if (netice == DialogResult.No)
            {
                label1.Text = "Legv et buttonu klik oldu";
            }
            else
            {
                label1.Text = "Basqa button klik oldu";
            }

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }
    }
}

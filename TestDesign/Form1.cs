using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace TestDesign
{
    public partial class Form1 : Form
    {
        FirstUser u1 = new FirstUser();
        UserControl1 u2 = new UserControl1();
        
        public Form1()
        {
            InitializeComponent();
            pnlMiniRed.Top = button1.Top;
            u1.BringToFront();         
            pnlMiniRed.Height = button1.Height;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            pnlMiniRed.Top = button1.Top;
            u1.BringToFront();
            pnlMiniRed.Height = button1.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlMiniRed.Top = button3.Top;
            u2.BringToFront();
            pnlMiniRed.Height = button3.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMiniRed.Top = button1.Top;
            u1.BringToFront();
            pnlMiniRed.Height = button1.Height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickclick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clicar n = new clicar();

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = n.timeS();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button3.Visible = true;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label4.Text = n.treset();
            label5.Text = n.treset();
            button3.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            n.move(sender);
            label5.Text = n.points();
        }
    }
}

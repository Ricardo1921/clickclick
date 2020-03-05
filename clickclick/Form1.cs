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
            mao.Visible = false;
            timer1.Interval = 1000;
        }

        clicar n = new clicar();

        private void Form1_Load(object sender, EventArgs e)
        {
            mao.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int _tempo = Convert.ToInt32(timer.Text);
            if (_tempo < 1) Stop();
            else
            {
                _tempo--;
            }
            timer.Text = _tempo.ToString();
        }

        private void Stop()
        {
            button2.Text = "GO!";
            mao.Visible = false;
            timer1.Stop();
            n.Record(pontos, record);
        }

        private void Start()
        {
            button2.Text = "STOP";
            timer.Text = "10";
            mao.Visible = true;
            timer1.Start();
            pontos.Text = "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            mao.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer.Text = n.treset();
            pontos.Text = n.treset();
            mao.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            n.move(sender);
            pontos.Text = n.points();
        }

    }
}

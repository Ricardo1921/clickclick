using System;
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
            record.Text = n.Abrir;
        }

        clicar n = new clicar();

        public object Classe { get; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (n.Tempo(tempo)) Stop();
        }

        private void Stop()
        {
            button1.Text = "GO!";
            mao.Visible = false;
            timer1.Stop();
            n.Record(pontos, record);
        }

        private void Start()
        {
            button1.Text = "STOP";
            tempo.Text = "10";
            mao.Visible = true;
            timer1.Start();
            pontos.Text = "0";
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "GO!") Start(); else Stop();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void clicar(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            n.Pontos(pontos);
            n.Move(sender);

        }

    }
}

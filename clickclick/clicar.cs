using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickclick
{
    class clicar
    {
        private int pontos;
        private int tempo = 20;

        public string timeS()
        {
           if (tempo > 0)
           {
                tempo -= 1;
           }
            return tempo.ToString();
        }


        public string points()
        {
            if (tempo > 0)
            {
                pontos += 1;
            }
            return pontos.ToString();
        }
        public string  treset()
        {

            tempo = 10;
            return tempo.ToString();
        }

        public string preset()
        {

            pontos = 0;
            return pontos.ToString();
        }

        public void move(object sender)
        {
            if (tempo > 0)
            {
                Random r = new Random();
                int _x = int.Parse(r.Next(500).ToString());
                int _y = int.Parse(r.Next(250).ToString()) + 100;
                Point pt = new Point(_x, _y);
                Button b = (Button)sender;
                b.Location = pt;
            }
        }
    }
}

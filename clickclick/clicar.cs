using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickclick
{
    class clicar
    {
        private bool _start = true;
        private bool Start => _start;

        public string _path = Application.StartupPath + "\\Resources\\Recorde.txt";

        public string Abrir => File.ReadAllText(_path);

        public void Gravar(string valor) => File.WriteAllText(_path, valor);
        private int pontos;
        private string _texto;

        public void Salvar(string valor)
        {
            File.WriteAllText(_path,valor);
        }

        public void Pontos(object sender)
        {
            TextBox _t = (TextBox)sender;
            int _pts = Convert.ToInt32(_t.Text) + 1;
            _t.Text = _pts.ToString();
        }

        public string Tempo(string tempo)
        {
            int _tempo = Convert.ToInt32(tempo);
            if (_tempo > 0) _tempo--; else _start = false;
            return _tempo.ToString();
        }

        /*public string points()
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
        }*/

        public void move(object sender)
        {
            Random r = new Random();
            int _x = int.Parse(r.Next(500).ToString());
            int _y = int.Parse(r.Next(250).ToString()) + 100;
            Point pt = new Point(_x, _y);

            Button btn = (Button)sender;
            btn.Location = pt;
        }

        public void Record(Object pontos, object record)
        {
            TextBox _pontos = (TextBox)pontos;
            TextBox _record = (TextBox)record;
            int _max = Convert.ToInt32(_record.Text);
            int _pts = Convert.ToInt32(_pontos.Text);
            if (_max < _pts) _record.Text = _pontos.Text;

        }
    }
}

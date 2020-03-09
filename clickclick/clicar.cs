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
        public string _path = Application.StartupPath + "\\Resources\\Recorde.txt";

        public string Abrir => File.ReadAllText(_path);

        public void Gravar(string valor) => File.WriteAllText(_path, valor);
        
        public void Move(object sender)
        {
            Random _r = new Random();
            int _x = int.Parse(_r.Next(500).ToString());
            int _y = int.Parse(_r.Next(250).ToString()) + 100;
            Point _pt = new Point(_x, _y);
            Button _b = (Button)sender;
            _b.Location = _pt;
        }

        public bool Tempo(object sender)
        {
            Label _t = (Label)sender;
            int _tempo = Convert.ToInt32(_t.Text);
            if (_tempo > 0)
            {
                _tempo--;
                _t.Text = _tempo.ToString();
                return false;
            }
            else return true;
        }

        public void Pontos(object sender)
        {
            Label _t = (Label)sender;
            int _pts = Convert.ToInt32(_t.Text) + 1;
            _t.Text = _pts.ToString();
        }

        public void Record(object pontos, object record)
        {
            Label _pontos = (Label)pontos;
            Label _record = (Label)record;
            int _max = Convert.ToInt32(_record.Text);
            int _pts = Convert.ToInt32(_pontos.Text);
            if (_max < _pts)
            {
                _record.Text = _pontos.Text;
                this.Gravar(_record.Text);
            }
        }

        public void Salvar(string valor)
        {
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
    }
}

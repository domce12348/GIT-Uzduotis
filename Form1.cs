using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa
{
    public partial class Form1 : Form
    {
        private decimal[] _masyvas = new decimal[10];
        private int _kiekMas = 0;
        public Form1()
        {
            InitializeComponent();
            LabelSkaiciai.Text = $"Įvesta {_kiekMas} iš {_masyvas.Length} skaičių";
        }

        private void Button_Vykdyti_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TextBoxMasyvas.Text, out decimal skaicius))
            {
                _masyvas[_kiekMas++] = skaicius;
                TextBoxMasyvas.Clear();
                if (_masyvas.Length == _kiekMas)
                {
                    LabelSkaiciai.Text = $"Suma={_masyvas.Sum()}";
                    _masyvas = new decimal[_masyvas.Length];
                    _kiekMas = 0;
                }
                else
                {
                    LabelSkaiciai.Text = $"Įvesta {_kiekMas} iš {_masyvas.Length} skaičių";
                }
            }
        }

        private void ButtonPiesti_Click(object sender, EventArgs e)
        {
            int Tarpas, Skaicius;
            if (int.TryParse(Ivestis.Text, out int EglutesSkaicius))
            {
                eglute.Clear();
                for (int i = 1; i <= EglutesSkaicius; i++)
                {
                    for (Tarpas = 1; Tarpas <= (EglutesSkaicius - i); Tarpas++)
                        eglute.Text += " ";
                    for (Skaicius = 1; Skaicius <= i; Skaicius++)
                        eglute.Text += "* ";
                    eglute.Text += Environment.NewLine;
                }
            }
        }
    }
}

using Savas_Ucagi_Oyunu.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas_Ucagi_Oyunu
{
    public partial class Anasayfa : Form
    {
        private readonly Oyun _oyun ; //readonly= Başka yerden değer Atılmasını Engeller

        public Anasayfa()
        {
            InitializeComponent();
            _oyun = new Oyun(AltUcakPaneli,AnaSavaspaneli);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti; //"_oyun.GecenSureDegisti" tetiklendiğinde "Oyun_GecenSureDegisti" çalışsın
        }

        private void Anasayfa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;

                case Keys.Right:
                    _oyun.UcagıHareketEttir(Enum.Yon.Saga);
                    break;

                case Keys.Left:
                    _oyun.UcagıHareketEttir(Enum.Yon.Sola);
                    break;

                case Keys.Space:
                    _oyun.AtesEt();
                    break;

            }
        }
        private void Oyun_GecenSureDegisti(object sender , EventArgs e)
        {
            lblSüre.Text = _oyun.GecenSure.ToString(@"m\:ss"); 
            /*$"{_oyun.GecenSure.Minutes}:{_oyun.GecenSure.Seconds.ToString("D2")}";*/
        }
    }
}

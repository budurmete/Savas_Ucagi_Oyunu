using Savas_Ucagi_Oyunu.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas_Ucagi_Oyunu.Concrete
{
    internal class Mermi: Cisim
    {
        public Mermi(Size HareketAlaniBoyutlari,int namluOrtasiX): base(HareketAlaniBoyutlari)
        {
            BaslangicKonumunuAyarla( namluOrtasiX);
            hareketMesafesi = Height * 2;
        }

        private void BaslangicKonumunuAyarla(int namluOrtasiX)
        {
            Bottom = HareketAlaniBoyutlari.Height;
            Center = namluOrtasiX;
        }
    }
}

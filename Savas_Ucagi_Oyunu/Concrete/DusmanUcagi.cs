using Savas_Ucagi_Oyunu.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas_Ucagi_Oyunu.Concrete
{
   internal class DusmanUcagi : Cisim
    {
        private static readonly Random Random = new Random();
        public DusmanUcagi(Size hareketAlaniBoyutlari) : base (hareketAlaniBoyutlari)
        {
            hareketMesafesi = (int)(Height * 0.1);
            Left = Random.Next(hareketAlaniBoyutlari.Width-Width+1);
        }
        public Mermi VurulduMu(List<Mermi> Mermiler)
        {
            foreach (var mermi in Mermiler)
            {
                var vurulduMu = mermi.Top < Bottom && mermi.Right > Left && mermi.Left < Right;
                if (vurulduMu) return mermi;
            }
            return null;
        }
    }
}

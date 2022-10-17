using Savas_Ucagi_Oyunu.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Savas_Ucagi_Oyunu.Interface
{
   internal interface Ioyun
    {
        event EventHandler GecenSureDegisti;
        bool DevamEdiyormu { get; }
        TimeSpan GecenSure { get; }

        void Baslat();
        void AtesEt();
        void UcagıHareketEttir(Yon yon);
    }
}

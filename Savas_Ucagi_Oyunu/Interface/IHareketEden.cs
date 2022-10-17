using Savas_Ucagi_Oyunu.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas_Ucagi_Oyunu.Interface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }
        int hareketMesafesi { get; }
        /// <summary>
        /// Cismi istenilen yönde  Harekekt ettirir
        /// </summary>
        /// <param name="yon">Hangi yöne edileceği</param>
        /// <returns>Cisim Duvara carparsa true döndür.</returns>
       bool HareketEttir(Yon yon); //duvara carpıysa true değeri döndürecek 
    }
}

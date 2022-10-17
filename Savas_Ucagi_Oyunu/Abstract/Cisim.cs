using Savas_Ucagi_Oyunu.Enum;
using Savas_Ucagi_Oyunu.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas_Ucagi_Oyunu.Abstract
{
   internal abstract class Cisim : PictureBox,IHareketEden
    {

        public Size HareketAlaniBoyutlari { get; }

        public int hareketMesafesi { get; protected set; }

        public new int Right
        { 
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom 
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;//orta nokta
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height/2;
        }

        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari:
                    return YukariHareketEttir();
                case Yon.Saga:
                    return SagaHareketEttir();
                case Yon.Asagi:
                    return AsagiHareketEttir();
                case Yon.Sola:
                    return SolaHareketEttir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon),yon,null);
            }
        }

        private bool YukariHareketEttir()
        {
            if (Top == 0) return true;

            var yeniTop = Top - hareketMesafesi;
            var tasacakmi = yeniTop < 0;
            Top = tasacakmi ? 0 : yeniTop;

            return Top == 0;
        }

        private bool SolaHareketEttir()
        {
            if (Left == 0) return true;

            var yeniLeft = Left - hareketMesafesi;
            var tasacakmi = yeniLeft < 0;
            Left = tasacakmi ? 0 : yeniLeft;

            return Left == 0;
        }

        private bool AsagiHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Width) return true;

            var yeniBottom = Bottom + hareketMesafesi;
            var tasacakMi = yeniBottom > HareketAlaniBoyutlari.Height;

            Bottom = tasacakMi ? HareketAlaniBoyutlari.Height /*eğer tasacaksa */ : yeniBottom; /*Taşmıyorsa*/

            return Bottom == HareketAlaniBoyutlari.Height;
        }

        private bool SagaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;

            var yeniRight = Right + hareketMesafesi;
            var tasacakMi = yeniRight > HareketAlaniBoyutlari.Width;

            Right = tasacakMi ? HareketAlaniBoyutlari.Width /*eğer tasacaksa */ : yeniRight; /*Taşmıyorsa*/

            return Right == HareketAlaniBoyutlari.Width;
        }

        protected Cisim(Size hareketAlaniBoyutlari)
        {
            Image = Image.FromFile($@"Resimler\{GetType().Name}.png");
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

    }
}

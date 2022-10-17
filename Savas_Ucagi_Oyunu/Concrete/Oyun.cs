using Savas_Ucagi_Oyunu.Enum;
using Savas_Ucagi_Oyunu.Interface;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas_Ucagi_Oyunu.Concrete
{
    internal class Oyun : Ioyun
    {
        #region Alanlar
        private readonly Timer _GecenSureTimer = new Timer { Interval = 1000};//  her 1 saniyede tetiklensin
        private readonly Timer _MermiHareketTimer = new Timer { Interval = 100};
        private readonly Timer _DusmanUcagiOlusturmatTimer = new Timer { Interval = 2000};
        private TimeSpan _gecenSure;
        private readonly Panel _AltUcakPaneli;
        private readonly Panel _AnaSavasPaneli;
        private Ucak _Ucak;
        private readonly List<Mermi> _mermiler = new List<Mermi>();
        private readonly List<DusmanUcagi> _DusmanUcagi = new List<DusmanUcagi>();
        #endregion

        #region Olaylar
        public event EventHandler GecenSureDegisti;
        #endregion

        #region Özellikler
        public bool DevamEdiyormu { get; private set; }

        public TimeSpan GecenSure 
        { 
            get => _gecenSure;
            private set /*oyunun içinden değer atamak istediğimiz için*/
            {
                _gecenSure = value;
                GecenSureDegisti?.Invoke(this, EventArgs.Empty); // GEcen Süreinin Değiştiğinden Tüm Sınıfların Haberi Olması İçin
            }
        }

        #endregion

        #region Metotlar
        public Oyun (Panel AltUcakPaneli, Panel AnaSavaspaneli)
        {
            _AnaSavasPaneli = AnaSavaspaneli;
            _AltUcakPaneli = AltUcakPaneli;
            _GecenSureTimer.Tick += GecenSureTimer_Tick;// ilişkilendirme Yaptık
            _MermiHareketTimer.Tick += HareketTimer_Tick;
            _DusmanUcagiOlusturmatTimer.Tick += DusmanUcagiOlusturmaTimer_Tick;
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            //her 1 saniyede bir ne olmalı 
            GecenSure += TimeSpan.FromSeconds(1); 
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            MermileriHareketEttir();
            DusmanUcagiHareketEttir();
            VurulanUcaklariSil();
        }

        private void VurulanUcaklariSil()
        {
            for (int i = _DusmanUcagi.Count -1; i >= 0; i--)
            {
                var DusmanUcagi = _DusmanUcagi[i];
                var VuranMermi = DusmanUcagi.VurulduMu(_mermiler);
                if (VuranMermi is null) continue;
                _DusmanUcagi.Remove(DusmanUcagi);
                _mermiler.Remove(VuranMermi);
                _AnaSavasPaneli.Controls.Remove(DusmanUcagi);
                _AnaSavasPaneli.Controls.Remove(VuranMermi);
            }
        }

        private void DusmanUcagiHareketEttir()
        {
            foreach (var DusmanUcagi in _DusmanUcagi)
            {
             var carptimi = DusmanUcagi.HareketEttir(Yon.Asagi);
                if (!carptimi) continue;

                Bitir();
                break;
            }
        }

        private void DusmanUcagiOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            DusmanUcagiOlustur();
        }

        private void MermileriHareketEttir()
        {
            for (int i = _mermiler.Count -1; i >= 0; i--)
            {
                var mermi = _mermiler[i];
                var carptimi = mermi.HareketEttir(Yon.Yukari);
                if (carptimi)
                {
                    _mermiler.Remove(mermi);
                    _AnaSavasPaneli.Controls.Remove(mermi);
                }
            }
        }

        public void AtesEt()
        {
            var mermi = new Mermi(_AnaSavasPaneli.Size,_Ucak.Center);
            _mermiler.Add(mermi);
            _AnaSavasPaneli.Controls.Add(mermi);
        }

        public void Baslat() 
        {
            if (DevamEdiyormu) /*eğer DEVAM ETMİYORSA*/ return;
               DevamEdiyormu = true;
               ZamanlayicilariBaslat();
               UcakOlustur();                                                                                               
               DusmanUcagiOlustur();     
            
        }

        private void DusmanUcagiOlustur()
        {
            var DusmanUcagi = new DusmanUcagi(_AnaSavasPaneli.Size);
            _DusmanUcagi.Add(DusmanUcagi);
            _AnaSavasPaneli.Controls.Add(DusmanUcagi);
        }

        private void ZamanlayicilariBaslat()
        {
            _GecenSureTimer.Start();
            _MermiHareketTimer.Start();
            _DusmanUcagiOlusturmatTimer.Start();
        }

        private void UcakOlustur()
        {
            _Ucak = new Ucak (_AltUcakPaneli.Width,_AltUcakPaneli.Size); /*2. yöntem*/
            _AltUcakPaneli.Controls.Add(_Ucak); 
        }

        private void Bitir()
        {
            if (!DevamEdiyormu) /*eğer DEVAM ETMİYORSA*/
            return;
            DevamEdiyormu = false;
            ZamanlayicilariDurdur();
        }

        private void ZamanlayicilariDurdur()
        {
            _GecenSureTimer.Stop();
            _MermiHareketTimer.Stop();
            _DusmanUcagiOlusturmatTimer.Stop();
        }

        public void UcagıHareketEttir(Yon yon)
        {
            if (!DevamEdiyormu) return;
            _Ucak.HareketEttir(yon);
        }
        #endregion
    }
}

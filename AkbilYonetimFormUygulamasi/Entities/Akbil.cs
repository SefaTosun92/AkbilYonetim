using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbilYonetimFormUygulamasi.Entities
{
    public class Akbil
    {
        public int Id { get; set; }

        public string AkbilSahibi { get; set; }


        private string _seriNumarasi;
        public string SeriNumarasi
        {
            get
            { return _seriNumarasi; }
            set
            {
                if (!TumKarakterlerRakamMi(value))
                {
                    throw new Exception("Seri numarası yalnızca rakamlardan oluşmaktadır!");
                }

                _seriNumarasi = value;
            }
        }

        public DateTime KayitTarihi { get; set; } = DateTime.Now;

        public DateTime? GuncellenmeTarihi { get; set; }

        public bool AktifMi { get; set; }

        public decimal Bakiye { get; set; }

        static bool TumKarakterlerRakamMi(string metin) //IsAllCharacterDigit
        {
            foreach (var item in metin)
            {
                if (!char.IsDigit(item)) // bu karakter digit mi? 
                {
                    return false;
                }
            }

            return true;
        }
    }
    
}

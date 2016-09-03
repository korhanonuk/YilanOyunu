using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Tuslar
    {
        //Tuşları bulunduran dizi.
        private static Hashtable tuslar = new Hashtable();

        //basılan tuşu bulma

        public static bool TusaBasildi(Keys key)
        {
            if (tuslar[key] == null)
                tuslar[key] = false;
            return (bool)tuslar[key];



        }

        //klavyeden bir tuşa basıldı mı?
        public static void DurumDegisti(Keys key, bool state)
        {
            tuslar[key] = state;
        }

    }
}

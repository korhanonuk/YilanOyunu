using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Yon { Up, Down, Left, Right };

    class GameSettings
    {
        public static int Genislik { get; set; }
        public static int Yukseklik { get; set; }
        public static int HizSeviyesi { get; set; }
        public static int Skor { get; set; }
        public static int Puanlar { get; set; }
        public static bool OyunBitti { get; set; }
        public static Yon Yon { get; set; }

        public GameSettings(int X, int Y, int Z, int L, bool M )
        {
            Genislik = X;
            Yukseklik = Y;
            HizSeviyesi = Z;
            Skor = 0;
            Puanlar = L; 
            OyunBitti = M;
            Yon = Yon.Down;
        }
    }


}

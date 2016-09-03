using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class MediumForm : Form
    {
             private List<Circle> yilan
            = new List<Circle>();
        private Circle yem = new Circle();

        public MediumForm()
        {
            InitializeComponent();

            //Oyunun hız ayarları, boyutu.
            new GameSettings(16, 16, 20, 7, false);
            gameTimer.Interval = 1000 / GameSettings.HizSeviyesi;
            gameTimer.Tick += EkraniYenile;
            gameTimer.Start();

            //Oyunu başlatalım 

            OyunuBaslat();



        }


        public void OyunuBaslat()
        {

            lblGameOver.Visible = false;
            new GameSettings(16, 16, 20, 7, false);

            yilan.Clear();
            Circle yilaninBasi = new Circle();
            yilaninBasi.X = 10;
            yilaninBasi.Y = 5;
            yilan.Add(yilaninBasi);

            lblScore.Text = GameSettings.Skor.ToString();
            YemOlustur();
        }

        private void YemOlustur()
        {
            int maksimumXPozisyonu = pbGameArea.Size.Width / GameSettings.Genislik;
            int maksimumYPozisyonu = pbGameArea.Size.Height / GameSettings.Yukseklik;

            //yemin oluşacağı maksimum pozisyonları belirledik. Şimdi yem için bir Random atamalıyız.

            Random rnd = new Random();
            yem = new Circle();
            yem.X = rnd.Next(0, maksimumXPozisyonu);
            yem.Y = rnd.Next(0, maksimumYPozisyonu);

        }



        private void EkraniYenile(object sender, EventArgs e)
        {
            if (GameSettings.OyunBitti == true)
            {
                if (Tuslar.TusaBasildi(Keys.Enter))
                {
                    OyunuBaslat();
                }
            }
            else
            {
                if (Tuslar.TusaBasildi(Keys.D) && GameSettings.Yon != Yon.Left)
                {
                    GameSettings.Yon = Yon.Right;
                }

                else if (Tuslar.TusaBasildi(Keys.A) && GameSettings.Yon != Yon.Right)
                {
                    GameSettings.Yon = Yon.Left;
                }

                else if (Tuslar.TusaBasildi(Keys.W) && GameSettings.Yon != Yon.Down)
                {
                    GameSettings.Yon = Yon.Up;
                }

                else if (Tuslar.TusaBasildi(Keys.S) && GameSettings.Yon != Yon.Up)
                {
                    GameSettings.Yon = Yon.Down;
                }

                HareketEt();

            }
            pbGameArea.Invalidate();
        }




        private void pbGameArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics gameArea = e.Graphics;

            if (!GameSettings.OyunBitti)
            {
                //yılanın rengi
                Brush yilanRengi;

                for (int i = 0; i < yilan.Count; i++)
                {
                    if (i == 0)
                    {
                        yilanRengi = Brushes.Blue;
                    }
                    else
                    {
                        yilanRengi = Brushes.White;

                    }

                    //Yılanı çizecek
                    gameArea.FillEllipse(yilanRengi, new Rectangle(yilan[i].X * GameSettings.Genislik, yilan[i].Y * GameSettings.Yukseklik, GameSettings.Genislik, GameSettings.Yukseklik));
                    //Yemi çizecek.

                    gameArea.FillEllipse(Brushes.Red, new Rectangle(yem.X * GameSettings.Genislik, yem.Y * GameSettings.Yukseklik, GameSettings.Genislik, GameSettings.Yukseklik));
                }
            }
            else
            {
                string oyunBitti = "Oyun bitti, Puanınız = " + GameSettings.Skor + "Tekrar oynamak için Enter'a basın!";
                lblGameOver.Text = oyunBitti;
                lblGameOver.Visible = true;


                //MessageBox.Show("Oyun Bitti, tekrar oynamak ister misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo);

            }
        }

       public void HareketEt()
        {
            for (int i = yilan.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (GameSettings.Yon)
                    {

                        case Yon.Up:
                            yilan[i].Y--;
                            break;
                        case Yon.Down:
                            yilan[i].Y++;
                            break;
                        case Yon.Left:
                            yilan[i].X--;
                            break;
                        case Yon.Right:
                            yilan[i].X++;
                            break;

                    }

                    //Maksimum X ve Y

                    int maksimumXPozisyonu = pbGameArea.Size.Width / GameSettings.Genislik;
                    int maksimumYPozisyonu = pbGameArea.Size.
                        Height / GameSettings.Yukseklik;

                    //Duvarlar
                    if (yilan[i].X < 0 || yilan[i].Y < 0 || yilan[i].X >= maksimumXPozisyonu || yilan[i].Y >= maksimumYPozisyonu)
                    {
                        OyunuBitir();
                    }

                    for (int j = 1; j < yilan.Count; j++)
                    {
                        if (yilan[i].X == yilan[j].X && yilan[i].Y == yilan[j].Y)
                        {
                            OyunuBitir();
                        }
                    }

                    //Yemi yeme

                    if (yilan[0].X == yem.X && yilan[0].Y == yem.Y)
                    {
                        YemiYut();
                    }

                }
                else
                {
                    yilan[i].X = yilan[i - 1].X;
                    yilan[i].Y = yilan[i - 1].Y;
                }
            }
        }


        private void EasyForm_KeyDown(object sender, KeyEventArgs e)
        {
            Tuslar.DurumDegisti(e.KeyCode, true);
        }

        private void EasyForm_KeyUp(object sender, KeyEventArgs e)
        {
            Tuslar.DurumDegisti(e.KeyCode, false);
        }

        public void OyunuBitir()
        {
            GameSettings.OyunBitti = true;
        }

        public void YemiYut()
        {
            Circle yem = new Circle();
            yem.X = yilan[yilan.Count - 1].X;
            yem.Y = yilan[yilan.Count - 1].Y;

            yilan.Add(yem);

            GameSettings.Skor += GameSettings.Puanlar;
            lblScore.Text = GameSettings.Skor.ToString();

            YemOlustur();
        }

        private void pbGameArea_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics gameArea = e.Graphics;

            if (!GameSettings.OyunBitti)
            {
                //yılanın rengi
                Brush yilanRengi;

                for (int i = 0; i < yilan.Count; i++)
                {
                    if (i == 0)
                    {
                        yilanRengi = Brushes.Blue;
                    }
                    else
                    {
                        yilanRengi = Brushes.White;

                    }

                    //Yılanı çizecek
                    gameArea.FillEllipse(yilanRengi, new Rectangle(yilan[i].X * GameSettings.Genislik, yilan[i].Y * GameSettings.Yukseklik, GameSettings.Genislik, GameSettings.Yukseklik));
                    //Yemi çizecek.

                    gameArea.FillEllipse(Brushes.Red, new Rectangle(yem.X * GameSettings.Genislik, yem.Y * GameSettings.Yukseklik, GameSettings.Genislik, GameSettings.Yukseklik));
                }
            }
            else
            {
                string oyunBitti = "Oyun bitti, Puanınız = " + GameSettings.Skor + "Tekrar oynamak için Enter'a basın!";
                lblGameOver.Text = oyunBitti;
                lblGameOver.Visible = true;


                //MessageBox.Show("Oyun Bitti, tekrar oynamak ister misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo);

            }
        }

        private void MediumForm_KeyDown(object sender, KeyEventArgs e)
        {
            Tuslar.DurumDegisti(e.KeyCode, true);
        }

        private void MediumForm_KeyUp(object sender, KeyEventArgs e)
        {
            Tuslar.DurumDegisti(e.KeyCode, false);
        }
    }
}

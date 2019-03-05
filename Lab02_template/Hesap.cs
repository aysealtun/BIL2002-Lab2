namespace Lab02_template
{

    public class Hesap
    {
        static public Koordinat DikdorgenMerkezHesapla( Dikdortgen sekil )
        {
            int h = sekil.yukseklik / 2;
            int g = sekil.genislik / 2;
            return new Koordinat( h , g );
        }

        static public int DikdörtgenCevre( Dikdortgen sekil )
        {
            return 2 * sekil.genislik + 2 * sekil.yukseklik;
        }

        static public int DikdörtgenAlan( Dikdortgen sekil )
        {
            return sekil.yukseklik * sekil.genislik;
        }

        static public Koordinat DaireMerkezHesapla( Daire sekil )
        {
            int x = sekil.solUst.X - sekil.r;
            int y = sekil.solUst.Y - sekil.r;
            return new Koordinat( x , y );
        }

        static public double DaireCevre(Daire sekil)
        {
            return 2 * System.Math.PI * sekil.r;
        }

        static public double DaireAlan( Daire sekil )
        {
            return System.Math.PI * System.Math.Pow( sekil.r , 2 );
        }

        public struct Koordinat
        {
            public int X;
            public int Y;
            public Koordinat( int p_x , int p_y )
            {
                //Constructor metot
                this.X = p_x;
                this.Y = p_y;

            }
        }
        public struct Daire
        {
            public Koordinat solUst; //Sol üst köşe koordinat
            public int r;

            public Daire( Koordinat solUst , int r )
            {
                this.solUst = solUst;
                this.r = r;
            }
        }
        public struct Dikdortgen
        {
            public int yukseklik;
            public int genislik;
            public Koordinat solUst;

            public Dikdortgen( int yukseklik , int genislik , Koordinat solUst )
            {
                this.yukseklik = yukseklik;
                this.genislik = genislik;
                this.solUst = solUst;
            }

        }
    }
}

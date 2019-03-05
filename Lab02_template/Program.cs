using System;

namespace Lab02_template
{
    class Program
    {
        static void Main( string[] args )
        {
            Hesap.Dikdortgen dikdörtgen = new Hesap.Dikdortgen( 20 , 16 , new Hesap.Koordinat( 12 , 14 ) );
            Hesap.Daire daire = new Hesap.Daire( new Hesap.Koordinat( 16 , 7 ) , 5 );
            Hesap.Koordinat dikdörtgenMerkez = Hesap.DikdorgenMerkezHesapla( dikdörtgen );
            int dikdörtgenCevre = Hesap.DikdörtgenCevre( dikdörtgen );
            int dikdörtgenAlan = Hesap.DikdörtgenAlan( dikdörtgen );
            Hesap.Koordinat daireMerkez = Hesap.DaireMerkezHesapla( daire );
            double daireCevre = Hesap.DaireCevre( daire );
            double daireAlan = Hesap.DaireAlan( daire );
            Console.WriteLine("Dikdörtgen merkezi: "+dikdörtgenMerkez.X+" "+dikdörtgenMerkez.Y+ " Dikdörtgen cevre: "+ dikdörtgenCevre+" Dikdörtgen alan : "+dikdörtgenAlan);
            Console.WriteLine( "Daire merkezi: " + daireMerkez.X + " " + daireMerkez.Y + " Daire cevre: " + daireCevre + " Daire alan : " + daireAlan );
        
            Console.ReadKey();

        }
    }




}

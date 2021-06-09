using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do
{
    public class Card
    {
        public enum Buyukluk
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }

        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public Buyukluk buyukluk { get; set; }
      


        public Card(string baslik,string icerik, Buyukluk buyukluk1)
        {
            Baslik = baslik;
            Icerik = icerik;
            buyukluk = buyukluk1;
          
        }

        public Card()
        {

        }
    }
   
    
}

using System;

namespace Struct_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dikdortgen dk = new Dikdortgen();
            dk.kisakenar = 3;
            dk.uzunkenar = 4;
            Console.WriteLine("Alan: {0}", dk.AlanHesapla());

            DikDortgenStruct dkst; // new ile oluşturmadan da kullanılabilir.
            dkst.kisakenar = 3;
            dkst.uzunkenar = 4;
            Console.WriteLine("Alan: {0}", dkst.AlanHesapla());
        }
    }

    internal class Dikdortgen
    {
        public int kisakenar;
        public int uzunkenar;

        public long AlanHesapla()
        {
            return this.kisakenar * this.uzunkenar;
        }
    }

    internal struct DikDortgenStruct
    {
        public int kisakenar;
        public int uzunkenar;

        public long AlanHesapla()
        {
            return this.kisakenar * this.uzunkenar;
        }
    }
}
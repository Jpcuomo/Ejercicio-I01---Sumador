using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class Sumador
    {
        private int _cantidadSumas;


        public int CantidadSumas
        {
            get { return _cantidadSumas; }
            private set { _cantidadSumas = value;}
        }


        public Sumador() : this(0)
        { 

        }


        public Sumador(int cantidadSumas) 
        {
            _cantidadSumas = cantidadSumas;
        }


        public long Sumar(long a, long b)
            {
                CantidadSumas++;
                return a + b;
            }


        public string Sumar(string a, string b)
        {
            CantidadSumas++;
            return a + b;
        }


        public static explicit operator int(Sumador s)
        {
            return s.CantidadSumas;
        }


        public static bool operator | (Sumador s1, Sumador s2)
        {
            if(s1.CantidadSumas == s2.CantidadSumas)
            {
                return true;
            }
            return false;
        }


        public static long operator + (Sumador s1, Sumador s2)
        {
            return s1.CantidadSumas + s2.CantidadSumas;
        }
    }
}

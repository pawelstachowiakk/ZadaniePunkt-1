using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePunkt
{
    class Punkt
    {

        public static int Licznik { get; private set; }

        public int X { get; private set; }// właściwość 1
        

        public int Y { get; private set; }// właściwość 2


        public Punkt()
        {
            Licznik++;
        }

        public Punkt(int wspx, int wspy) : this() //konstruktor
        {
            X = wspx;
            Y = wspy;
        }

        public void Prawo(int ileP) //metoda 1
        {
            X += ileP;

        }

        public void Lewo(int ileL) //metoda 2
        {
            X -= ileL;

        }

        public void Gora(int ileG) //metoda 3
        {
            Y += ileG;

        }

        public void Dol(int ileD) //metoda 4
        {
            Y -= ileD;

        }


        public void Wyswietl()
        {

            Console.WriteLine("Współrzędna X: {0}",X);
            Console.WriteLine("Współrzędna Y: {0}",Y);

            
        }

        const int Z = 0;
        public static void Method()
        {
            
        }

        public static void Method(int i)
        {

        }

        public static Punkt operator +(Punkt p1, Punkt p2)
        {
            p1.X += p2.X;
            p1.Y += p2.Y;
            return p1;
        }

        public static Punkt operator *(Punkt p1, int m)
        {
            Punkt result = new Punkt(p1.X * m, p1.Y * m);
            return result;
        }

        public static Punkt operator *(int m, Punkt p1)
        {
            return p1 * m;
        }

    }
}

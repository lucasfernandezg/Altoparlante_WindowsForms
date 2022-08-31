using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AltoparlanteGUI
{
    static public class Matriz
    {
        static public Complex[,] Dot(Complex[,] a, Complex[,] b)
        {   
            Complex[,] c = new Complex[2, 2];
            c[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            c[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            c[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            c[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            return c;
        }

        static public Complex[] Dot(Complex[,] a, Complex[] b)
        {
            Complex[] c = new Complex[2];
            c[0] = a[0, 0] * b[0] + a[0, 1] * b[1];
            c[1] = a[1, 0] * b[1] + a[1, 1] * b[1];
            return c;
        }

        static public Complex Det(Complex[,] a)
        {
            Complex c = (a[0, 0] * a[1, 1]) - (a[0, 1] * a[1, 0]);
            return c;
        }

        static public Complex[,] Inv(Complex[,] z)
        {
            Complex[,] inv = new Complex[2, 2];
            Complex d = Matriz.Det(z);
            Console.WriteLine($"det = {d}");
            inv[0, 0] = (z[1, 1] / d);
            inv[0, 1] = -(z[0, 1] / d);
            inv[1, 0] = -(z[1, 0] / d);
            inv[1, 1] = (z[0, 0] / d);
            return inv;
        }

        static public void Print(Complex[,] z)
        {
            try
            {
                Console.WriteLine($"| {z[0,0]} {z[0,1]} |\n" +
                $"| {z[1,0]} {z[1,1]} |");
            }
            catch
            {
                Console.WriteLine("Not 2x2 Matrix");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AltoparlanteGUI
{  
    class Altoparlante
    {
        public double Re { get; set; }
        public double Le { get; set; }
        public double Bl { get; set; }
        public double Mm { get; set; }
        public double Cm { get; set; }
        public double Rm { get; set; }
        public double Fs { get;private set; }
        public double Qm { get;private set; }
        public double Qe { get;private set; }
        public double Qt { get;private set; }
        public Complex ZLe { get; private set; }
        public Complex ZMm { get; private set; }
        public Complex ZCm { get; private set; }

        public Altoparlante(double re = 5.4, double le = 0.00047, double bl = 11, double mm = 0.011, double cm = 0.0014, double rm = 0.14)
        {
            Re = re;
            Le = le;
            Bl = bl;
            Mm = mm;
            Cm = cm;
            Rm = rm;
            

        }
        public void Process()
        {
            Fs = 1 / (2 * Math.PI * Math.Sqrt(Mm * Cm));
            Qm = 2 * Math.PI * Fs * (Mm) / Rm;
            Qe = 2 * Math.PI * Fs * (Mm) * Math.Pow(Bl, 2) / Rm;
            Qt = Qm * Qe / (Qm + Qe);
            ZLe = new Complex(0, Le);
            ZMm = new Complex(0, Mm);
            ZCm = new Complex(0, 1 / Cm);
            Console.WriteLine($"Fs: {Fs}");
        }


        public (List<Complex[,]>, double[], double[], double[]) Motor(double[] freq)
        {
            double[] w = new double[freq.Length];
            List<Complex[,]> T_Motor = new List<Complex[,]>(); //Lista de Matrices para cada frecuencia. T_Le[1] matriz para primera freq.
            Complex[] Z_in = new Complex[freq.Length];
            //List<Complex[]> Out = new List<Complex[]>();
            double[] Z_abs = new double[freq.Length];
            double[] Z_pha = new double[freq.Length];
            double[] Vel_abs = new double[freq.Length];

            Complex[,] T_Re = new Complex[2, 2] { { 1, Re }, { 0, 1 } };
            Complex[,] G_Bl = new Complex[2, 2] { { 0, Bl }, { 1 / Bl, 0 } };
            Complex[,] T_Rm = new Complex[2, 2] { { 1, Rm }, { 0, 1 } };

            for (int i = 0; i < freq.Length;i++)
            {
                w[i] = freq[i] * 2 * Math.PI;
                Console.WriteLine($"w= {w[i]} para {i}");
                //Hago las matrices con el W correspondiente:
                Complex[,] T_Lei = new Complex[2, 2] { { 1, ZLe*w[i] }, { 0, 1 } }; //W[i] es la frecuencia angular correspondiente
                Complex[,] T_Mmi = new Complex[2, 2] { { 1, ZMm*w[i] }, { 0, 1 } };
                Complex[,] T_Cmi = new Complex[2, 2] { { 1, -ZCm/w[i] }, { 0, 1 } };
                //Console.WriteLine($"w= {T_Lei[0,1]} para {i}");
                //Las multiplico todas:
                Complex[,] Ti = new Complex[2, 2];
                Ti = Matriz.Dot(T_Re, Matriz.Dot(T_Lei,Matriz.Dot(G_Bl,Matriz.Dot(T_Mmi, Matriz.Dot(T_Cmi,T_Rm)))));
                //Console.WriteLine($"{Ti[0, 1]}, {i}");


                Complex[,] inv = Matriz.Inv(Ti);
                Matriz.Print(Ti);
                Console.WriteLine($"DETERMINANTE {Matriz.Det(Ti)}");
                //Console.WriteLine($"{inv[0, 1]}, inv para {i}");

                Z_in[i] = Ti[0, 1] / Ti[1, 1];
                //Console.WriteLine($"{Z_in[i]}, {i}");
                //El resultado lo agrego a mi lista de matrices Motor:
                T_Motor.Add(inv);
                Complex[] vin = new Complex[2] {2.83, 2.83/Z_in[i] };
                //Console.WriteLine($"{vin[0]},{vin[1]}, para {i}");
                //Out.Add(Matriz.Dot(inv, vin));
                Z_abs[i] = Complex.Abs(Z_in[i]);
                Z_pha[i] = Z_in[i].Phase;
                Vel_abs[i] = Complex.Abs(Matriz.Dot(inv, vin)[1]);
            }            

            return (T_Motor, Z_abs, Vel_abs, Z_pha);
        }

        public double[] Freq()
        {
            double[] f = new double[3000];
            for (int i = 0; i < f.Length; i++)
            {
                //f[i] = 5*Math.Pow(2,i/12);
                f[i] = i+1;
            }
            return f;
        }

        //public double[] W()
        //{
        //    double[] w = new double[20000];
        //    for (int i = 1; i < w.Length; i++)
        //    {
        //        w[i] = i*2*Math.PI;
        //    }
        //    return w;
        //}
    }
}

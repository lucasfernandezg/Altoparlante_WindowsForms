using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace AltoparlanteGUI
{
    public partial class Form1 : Form
    {
        Altoparlante a1 = new Altoparlante(0,0,0);
        
         
        public Form1()
        {
            InitializeComponent();
            //ReBox.Text = Convert.ToString(a1.Re);
            //Complex c = new Complex(1,1);
            


        }

        private void OnClick(object sender, EventArgs e)
        {   
            if (ReBox.validate && LeBox.validate && BlBox.validate && MmBox.validate && CmBox.validate && RmBox.validate)
            {
                //Assign values:
                a1.Re = Convert.ToDouble(ReBox.Text);
                a1.Le = Convert.ToDouble(LeBox.Text);
                a1.Bl = Convert.ToDouble(BlBox.Text);
                a1.Mm = Convert.ToDouble(MmBox.Text);
                a1.Cm = Convert.ToDouble(CmBox.Text);
                a1.Rm = Convert.ToDouble(RmBox.Text);
                a1.Process();
                (List<Complex[,]> TMotor, double[] Z_abs, double[] Vel_abs, double[] Z_pha) = a1.Motor(a1.Freq());
                Console.WriteLine($"Chequeando: {TMotor[1][0,1]}");


                //MessageBox.Show($"Re={a1.Re}\n" +
                //    $"Le={a1.Le}\n" +
                //    $"Bl={a1.Bl}\n" +
                //    $"a");

                //Chart Manager:
                //List<double> f = a1.Freq().ToList();
                //List<double> imp = Z_abs.ToList();
                //List<double> vel = Vel_abs.ToList();
                double[] f = a1.Freq();
                Console.WriteLine(a1.Freq()[121]);
                

                // Use a custom formatter to control the label for each tick mark
                
                formsPlot1.Plot.AddScatter(a1.Freq(), Z_abs);
                formsPlot1.Refresh();
                formsPlot2.Plot.AddScatter(a1.Freq(), Z_pha);
                formsPlot2.Refresh();

                


                //chart.Series["Curva"].Points.AddXY(2, a1.Re);
                //double[,] m1 = new double[2, 2] { { 1, 2.2 },{ 3, 4 } };
                //double[,] m2 = new double[2, 2] { { 1, 2.2 }, { 3, 4 } };
                //Console.WriteLine($"{Matriz.Dot(m1, Matriz.Dot(m1,m2))[0,0]}");
            }
            else
            {
                MessageBox.Show("Error: Wrong Input Format!");
                Complex[,] q = new Complex[2, 2]{ {new Complex(1,3), new Complex(2,2) }, { 2, 3 } };
                Console.WriteLine($"{Matriz.Det(q)}");
            }
            
        }


        private void OnTextChange(object sender, EventArgs e) // Para todos los TextBox
        {
            MyTextBox tBox = sender as MyTextBox;
            if (!String.IsNullOrEmpty(tBox.Text) && Double.TryParse(tBox.Text, out double w))
            {
                tBox.BackColor = Color.White;
                tBox.validate = true;
            }
            else
            {
                tBox.BackColor = Color.Red;
                tBox.validate = false;
            }

        }

    }

    public class MyTextBox : TextBox
    {
        public bool validate { get; set; } = false;
    }
}

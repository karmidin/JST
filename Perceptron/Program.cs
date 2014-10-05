using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x1, x2, x3,x4, t, y;
            float[] net;

            x1 = new int[4];
            x2 = new int[4];
            x3 = new int[4];
            x4 = new int[4];
            
            int b = new int();
            int w1 = new int();
            int w2 = new int();
            int w3 = new int();
            int w4 = new int();
            int a = new int();
            int count = new int();

            t = new int[5];
            net = new float[6];
            y = new int[5];

            Console.Write("Masukkan nilai alpha : ");
            a = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Masukkan input 1, input 2 dan target untuk pattern " + (i + 1));
                Console.Write("x1 : ");
                x1[i] = int.Parse(Console.ReadLine());
                Console.Write("x2 : ");
                x2[i] = int.Parse(Console.ReadLine());
                Console.Write("x3 : ");
                x3[i] = int.Parse(Console.ReadLine());
                Console.Write("x4 : ");
                x4[i] = int.Parse(Console.ReadLine());
                Console.Write("t : ");
                t[i] = int.Parse(Console.ReadLine());



            }
            while (t[0] != y[0] || t[1] != y[1] || t[2] != y[2] || t[3] != y[3] || t[4] != y[4])
            {
          
                for (int i = 0; i < 4; i++)
                {

                    if (y[i] != t[i])
                    {
                        w1 = (x1[i] * t[i] * a) + w1;
                        w2 = (x2[i] * t[i] * a) + w2;
                        w3 = (x3[i] * t[i] * a) + w3;
                        w4 = (x4[i] * t[i] * a) + w4;
                        b = (1 * t[i] * a) + b;

                        Console.WriteLine(w1 + "|" + w2 + "|" + w3 + "|"+w4 + "|" + b);
                    }else{
                        Console.WriteLine(w1 + "|" + w2 + "|" + w3 + "|"+w4 + "|" + b);
                    }
                        
                }

                Console.Write("Net = ");
                
                for (int i = 0; i < 4; i++)
                {
                    net[i] = (x1[i] * w1) + (x2[i] * w2) + (x3[i] * w3) + (x4[i] * w4) + b;
                    if (net[i] > 0)
                    {
                        y[i] = 1;
                    }
                    else if(net[i] == 0)
                    {
                        y[i] = 0;
                    }else{
                        y[i] = -1;
                    }

                    Console.Write(net[i] + "|");
                }
                Console.WriteLine();
                Console.Write("Nilai Y = ");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(y[i] + "|");
                }
                Console.WriteLine("");
                count++;
            }
            Console.Write("Jumlah Epok = " + count);

        }
    }
}

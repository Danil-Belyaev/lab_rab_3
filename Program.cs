using System;
using System.IO;

namespace Управление_потоком_выполнения_в_программе
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int t = 0, N = 1;
            double X = 0, Y = 0, Z = 0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            int i = 1, step_chisl = 1, znam = 1;
            double  chisl = 1;

            if (t == 0)
                {
                    for (i = 1; i <= N; i++)
                        {
                            step_chisl = i;
                            znam *= step_chisl;

                                if (i % 2 == 1)
                                    chisl = Math.Pow(X, step_chisl) + Math.Pow(Y, step_chisl);
                                else
                                    chisl = -(Math.Pow(Y, step_chisl) + Math.Pow(X, step_chisl));

                    Z += chisl / znam;
                        }
                }

            if (t == 1)
            {
                i = 1;
                while (i <= N)
                {
                    step_chisl = i;
                    znam *= step_chisl;

                    if (i % 2 == 1)
                        chisl = Math.Pow(X, step_chisl) + Math.Pow(Y, step_chisl);
                    else
                        chisl = -(Math.Pow(Y, step_chisl) + Math.Pow(X, step_chisl));

                    Z += chisl / znam;
                    i++;
                }
            }

            if (t == 2)
            {
                i = 1;
                do
                {
                    step_chisl = i;
                    znam *= step_chisl;

                    if (i % 2 == 1)
                        chisl = Math.Pow(X, step_chisl) + Math.Pow(Y, step_chisl);
                    else
                        chisl = -(Math.Pow(Y, step_chisl) + Math.Pow(X, step_chisl));

                    Z += chisl / znam;
                    i++;
                }
                while (i <= N);
            }

            Console.WriteLine("{0:0.0000000000000}", Z);

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}

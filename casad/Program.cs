using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casad
{
    class Program
    {
        static Casa app = new Casa();
        static Menu m = new Menu();
        static MenuLuzs ls = new MenuLuzs();
        static Menutv t = new Menutv();
        static Menug g = new Menug();
        static Mc1 c = new Mc1();
        static Mc2 l = new Mc2();
        static Mle z = new Mle();


        static void Main(string[] args)
        {
            int opciones = 0;

            //integrantes: Giuliana, Lineli, Isabel, Osmar y Fatima"
            //Link de programa de tinkercad: https://www.tinkercad.com/things/g22j7ceScJw-shiny-amur-luulia/editel?sharecode=lhL1BIAEkBAdHA1R1NFs-FRMDWA3uf6n9mpcXctal4k



            while (opciones != 7)

            {

                opciones = m.ListaMenu();
                Console.Clear();

                if (opciones == 1)
                {
                    while (opciones != 2)
                    {
                        opciones = ls.ListMenu();
                        Console.Clear();

                        if (opciones == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("q");
                            Console.WriteLine(" luz de la sala encendida ");
                            Console.WriteLine(" \n ");
                        }                      

                        else if (opciones == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            Console.WriteLine(" luz de la sala apagada");
                            app.EnviarCaracter("w");
                            Console.WriteLine(" \n ");
                        }

                        Console.ReadKey();
                    }
                }

                else if (opciones == 2)
                {
                    opciones = 0;

                    while (opciones != 2)
                    {
                        opciones = t.ListatMenu();
                        Console.Clear();

                        if (opciones == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("\n");
                            app.EnviarCaracter("e");
                            Console.WriteLine("televisor encendido");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("\n");
                            app.EnviarCaracter("r");
                            Console.WriteLine("televisor apagado");
                            Console.WriteLine(" \n ");
                        }

                        Console.ReadKey();
                    }
                }


                else if (opciones == 3)

                {
                    opciones = 0;

                    while (opciones != 3)
                    {

                        opciones = g.LissMenu();
                        Console.Clear();

                        if (opciones == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("t");
                            Console.WriteLine("garage abierto");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("y");
                            Console.WriteLine("medio garage abierto");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 3)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            Console.WriteLine("garage cerrado");
                            app.EnviarCaracter("u");
                            Console.WriteLine(" \n ");
                        }

                        Console.ReadKey();
                    }
                }

                else if (opciones == 4)

                {
                    while (opciones != 2)
                    {
                        opciones = c.ListsMenu();
                        Console.Clear();

                        if (opciones == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("z");
                            Console.WriteLine("cortina 1 abierta");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            Console.WriteLine("cortina 1 cerrada");
                            app.EnviarCaracter("b");
                            Console.WriteLine(" \n ");
                        }



                        Console.ReadKey();
                    }
                }

                else if (opciones == 5)
                {
                    while (opciones != 2)
                    {
                        opciones = l.ListsMenu();
                        Console.Clear();

                        if (opciones == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("c");
                            Console.WriteLine("cortina 2 abierta");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            Console.WriteLine("cortina 2 cerrada");
                            app.EnviarCaracter("d");
                            Console.WriteLine(" \n ");
                        }

                        Console.ReadKey();
                    }
                }

                else if (opciones == 6)

                {
                    opciones = 0;

                    while (opciones != 6)

                    {
                        opciones = z.ListsxMenu();
                        Console.Clear();

                        if (opciones == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("i");
                            Console.WriteLine("intensidad 1 de la luz del estudio");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("o");
                            Console.WriteLine("intensidad 2 de la luz del estudio");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 3)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("p");
                            Console.WriteLine("intensidad 3 de la luz del estudio");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 4)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("a");
                            Console.WriteLine("intensidad 4 de la luz del estudio");
                            Console.WriteLine(" \n ");
                        }


                        else if (opciones == 5)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("s");
                            Console.WriteLine("intensidad 5 de la luz del estudio");
                            Console.WriteLine(" \n ");
                        }

                        else if (opciones == 6)
                        {
                            Console.Clear();
                            Console.WriteLine(" \n ");
                            Console.WriteLine("luz del estudio apagada");
                            app.EnviarCaracter("h");
                            Console.WriteLine(" \n ");
                        }

                        Console.ReadKey();
                    }

                }

                Console.ReadKey();
            }
        }
    }
}
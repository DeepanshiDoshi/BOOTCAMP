using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basics
{
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr = 20,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    class demo
    {
        #region constreadonly
        public const int a = 14;
        readonly int b = 14;
        int c = 25;

        public demo(int n)
        {
            b = n;
        }
        #endregion

        #region Exception
        public void DemoException()
        {
            try
            {
                int a = 25;
                Console.WriteLine("Exception");
                Console.WriteLine("a is" + a);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
#endregion

        #region ref-out
        static void prg1(ref int a)
        {
            a = 1;
        }
        static void prg2(out int b)
        {
            b = 2;
        }
        static void prg3(int c)
        {
            Console.WriteLine("ref-out");
            Console.WriteLine(c);
            c = 3;
            Console.WriteLine(c);
        }
        #endregion
        static void Main(string[] args)
        {
            #region const-readonly
            demo d = new demo(30);
            Console.WriteLine("Const-readonly");
            Console.WriteLine(d.b);
            d.c = 25;

            Console.ReadKey();
            #endregion
            #region ref-out
            int val1 = 14;
            int val2 = 54;

            demo.prg1(ref val1);
            Console.WriteLine("ref value");
            Console.WriteLine(val1);

            demo.prg2(out val2);
            Console.WriteLine("Out value");
            Console.WriteLine(val2);

            int a = 43;

            prg3(a);
            Console.WriteLine("Normal");
            Console.WriteLine(a);

            var v = 10;
            v = 20;
            Console.WriteLine(v);

            var v2 = "Deepanshi";
            v2 = "Doshi";
            Console.WriteLine(v2);

            Object O1 = 10;
            O1 = "Deepanshi";
            O1 = true;
            O1 = 20.20f;
            O1 = 'A';

            Console.ReadKey();
            #endregion
            #region Enum
            {
                Console.WriteLine("Enum");
                Console.WriteLine(Convert.ToInt32(Months.May) + 11);


                Console.ReadKey();
            }
            #endregion
        }

       

       
    }
}

   

  





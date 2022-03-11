


namespace Interface

{
    interface I1
    {
        void ABC(int x);
    }

    interface I2
    {

        void IJK(int a, int b);

    }

    class child2 : I1, I2
    {
        public void IJK(int a, int b)
        {
            Console.WriteLine("Interface2 method Implemented in  child class");
            int c = a + b;
            Console.WriteLine(a + "+" + b + "=" + c);
        }

        public void XYZ()
        {
            Console.WriteLine("Child class own normal method");

        }

        public void ABC(int x)
        {

            Console.WriteLine("Interface1 method Implemented in 2nd Child class");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {

            I1 i1 = new child2();

            I2 i2 = new child2();
            child2 c2 = new child2();
            c2.XYZ();
            c2.IJK(1, 2);
            c2.ABC(12);

        }
    }
}

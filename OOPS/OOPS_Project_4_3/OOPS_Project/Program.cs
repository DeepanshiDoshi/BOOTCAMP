namespace OOPS
{
   class demo
    {
        protected int id=1;
        protected string name="Deepanshi";

        public void XYZ()
        {
            Console.WriteLine("Hello World");
        }
        #region overloading
        public void XYZ(int a, int b)
        {
            Console.WriteLine("Overloading");
            Console.WriteLine("A is"+a);
            Console.WriteLine("B is"+b);

        }
        #endregion


    }
    class childdemo : demo
    {
      
       public void ABC()
        {
            Console.WriteLine("Id is"+ id);
            Console.WriteLine("Name is"+name);
               
        }
       public  void IJK()
        {
            Console.WriteLine("Hello");
        }

    }

    class  subchilddemo : childdemo
    {
    #region overriding
        public void IJK()
        {
            Console.WriteLine("Python");
        }
        #endregion
    }

    #region encapsulation
    public class Encapsulation
    {
        private int a;
        protected int b;
        public int c;
    }

    public class EncapsulationDemo : Encapsulation
    {

        public void EnDemoFun()
        {
            b = 20;
        }
    }
    #endregion

    #region abstraction
    abstract class ABS_Parent
    {
        public void DemoAbstract()
        {
            Console.WriteLine("Normal Method of Normal Class Named - ABS_Parent is called.");
        }
        public abstract void DemoAbstract_Fun();
    }
    

    abstract class ABS_Child : ABS_Parent
    {
        public abstract void DemoAbs_Fun();
        public void Normal_Fun()
        {
            Console.WriteLine("Normal Method of Class - ABS_Child is called.");
        }

        public override void DemoAbstract_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - ABS_parent is called IN ABS_Child.");
        }
    }

    class ABS_Child_Fun : ABS_Child
    {
        public override void DemoAbs_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - ABS_Child is called.");
        }

        public void DemoChildFun()
        {
            Console.WriteLine("Normal Method of Child Class Named - ABS_Child_Fun is called.");
        }
        public void DemoAbstract_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - ABS_Child is called IN ABS_Child_Fun.");
        }
    }
    #endregion

    #region static
    public static class StaticClass
    {
        public static int a;
    }
    public class StaticClass2
    {
        public int a1;
        public static int b;
    }
    #endregion
    #region sealed
    class NotSealed
    {
        public int a = 100;
    }
    sealed class SealedClass : NotSealed
    {
        public int b;
    }
    #endregion
    #region Partial
    public partial class P1
    {
        public int p1;
    }
    public partial class P1
    {
        public int p2;
    }
    public class P3 : P1
    {
        public int Child;
    }
    #endregion

    class Example
    {
        static void Main(string [] args)
        {
            childdemo d = new childdemo();
            subchilddemo d2 = new subchilddemo();
            d2.ABC();
            d2.XYZ();
            d2.XYZ(1,2);
            d2.IJK();
            d.IJK();
            #region Encapsulation
            Encapsulation en = new Encapsulation();
            en.c = 100;
            Console.WriteLine("Public Variable of Encapulation Class : " + en.c);
            #endregion
            #region abstraction
            ABS_Child_Fun ABSDemo1 = new ABS_Child_Fun();
            ABSDemo1.Normal_Fun();
            ABSDemo1.DemoAbs_Fun();
            ABSDemo1.DemoChildFun();
            ABSDemo1.DemoAbstract();
            ABSDemo1.DemoAbstract_Fun();

            ABS_Child aBS_Child = new ABS_Child_Fun();
            aBS_Child.Normal_Fun();
            aBS_Child.DemoAbs_Fun();
            aBS_Child.DemoAbstract();
            aBS_Child.DemoAbstract_Fun();
            #endregion
            #region Static
            StaticClass.a = 10;
            StaticClass2 SC = new StaticClass2();
            SC.a1 = 10;
            StaticClass2.b = 20;
            #endregion
            #region Partial
            P1 par = new P1();
            par.p2 = 100;
            par.p1 = 200;

            P3 par1 = new P3();
            par1.p2 = 300;
            par1.p1 = 400;
            #endregion


        }
    }

 
}
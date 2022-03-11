namespace dependenciesinjection
{




    #region Constructor Injection
    public interface I3
    {
        void program();
    }

    //child1 class
    class dclass : I3
    {


        public void program()
        {
            Console.WriteLine("Interface method implemented in child 1");
        }

    }

    //child2 class
    class dclass2 : I3
    {
        public void program()
        {
            Console.WriteLine("Interface method implemented in child 1");
        }
    }

    //constructor injection class
    class constructorinjection
    {
        private I3 _i3;
        public constructorinjection(I3 _i3)
        {
            this._i3 = _i3;
        }
        public void program()
        {
            _i3.program();
        }
    }
    #endregion
    #region Method Injection
    public interface I4
    {
        void prg();
    }

    //child1 class
    class child1 : I4
    {


        public void prg()
        {
            Console.WriteLine("Interface method implemented in child 1(method inje)");
        }

    }

    class methodinjection
    {
        private I4 _i4;
        public void methodi(I4 _i4)
        {
            this._i4 = _i4;
            Console.WriteLine("Methodinjection method");
            this._i4.prg();
        }
    }
    #endregion
    #region Property injection
    public interface I5
    {
        void prgm();
    }

    //child1 class
    class child2 : I5
    {


        public void prgm()
        {
            Console.WriteLine("Interface method implemented in child 1(Property inje)");
        }

    }

    class propertyinjection
    {
        private I5 _i5;
        public void prop(I5 _i5,int a)
        {
            this._i5 = _i5;
            Console.WriteLine("Propertyinjection method");
            this._i5.prgm();
        }
    }
    #endregion
    class Main2
    {
        static void Main(String[] args)
        {
            #region Constructor Injection
            constructorinjection ci = null;
            ci = new constructorinjection(new dclass());
            ci.program();

            ci = new constructorinjection(new dclass2());
            ci.program();
            #endregion
            #region Method Injection
            methodinjection mi = new methodinjection();
            mi.methodi(new child1());
            #endregion
            #region Property Injection
            propertyinjection pi = new propertyinjection();
            pi.prop(new child2(), 14);
            #endregion
        }
    }
}




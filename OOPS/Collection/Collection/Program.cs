using ModelList;
using System.Collections;
namespace Collection
{
    class DemoCollection
    {
        static void Main(string[] args)
        {
            #region Nongenerics

            ArrayList A = new ArrayList();
            Queue Q = new Queue();
            Stack S = new Stack();
            Console.WriteLine("Arraylist");
            A.Add("KCS");
            A.Add(14);

            foreach (Object O in A)
            {

                Console.WriteLine(O);
                Console.WriteLine();
            }
            Console.WriteLine("Queue");

            Q.Enqueue("Business Analyst");
            Q.Enqueue(890);

            foreach (Object O in Q)
            {

                Console.WriteLine(O);
                Console.WriteLine();
            }
            Console.WriteLine("Stack");
            S.Push("Deepanshi");
            S.Push(25);
            foreach (Object O in S)
            {

                Console.WriteLine(O);
                Console.WriteLine();
            }

            #endregion

            #region generics

            List<String> list = new List<String>();
            list.Add("Hello");
            list.AddRange(new String[] { "Java", "Python", "PHP", "C#" });

            foreach (String I in list)
            {
                Console.WriteLine(I);
            }


            #endregion

            Console.ReadKey();





            EmployeeModel EM = new EmployeeModel();

            EM.EmpId = 1;
            EM.EmpFname = "Deepanshi";
            EM.EmpLname = "Doshi";
            EM.EmpContact = "9033976003";
            EM.EmpEmail = "deepanshidoshi1999@gmail.com";
            EM.EmpGender = 'F';

            Console.WriteLine("Employee Id:{0}", EM.EmpId);
            Console.WriteLine("Employee First Name:{0}", EM.EmpFname);
            Console.WriteLine("Employee Last Name:{0}", EM.EmpLname);
            Console.WriteLine("Employee Contact No.:{0}", EM.EmpContact);
            Console.WriteLine("Employee Email Id:{0}", EM.EmpEmail);
            Console.WriteLine("Employee Gender:{0}", EM.EmpGender);

            //List Of Model Class Object - Multiple Model Class.
            int NoOfEmp;
            List<EmployeeModel> EmpList = new List<EmployeeModel>();

            Console.WriteLine("Enter The Number Of Employee You Want To Submit: ");
            NoOfEmp = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NoOfEmp; i++)
            {
                EmployeeModel Emp = new EmployeeModel();

                Console.WriteLine("Enter Employee Id: ");
                Emp.EmpId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Employee First Name: ");
                Emp.EmpFname = Console.ReadLine();

                Console.WriteLine("Enter Employee Last Name: ");
                Emp.EmpLname = Console.ReadLine();

                Console.WriteLine("Enter Employee Contact No.: ");
                Emp.EmpContact = Console.ReadLine();

                Console.WriteLine("Enter Employee Email Id: ");
                Emp.EmpEmail = Console.ReadLine();

                Console.WriteLine("Enter Employee Gender: ");
                Emp.EmpGender = Convert.ToChar(Console.ReadLine());

                EmpList.Add(Emp);
            }

            Console.WriteLine("Member Data Records Are:");
            for (int i = 0; i < EmpList.Count; i++)
            {
                Console.WriteLine("Employee No.: {0}", i);

                Console.WriteLine("Employee Id:{0}", EmpList[i].EmpId);
                Console.WriteLine("Employee First Name:{0}", EmpList[i].EmpFname);
                Console.WriteLine("Employee Last Name:{0}", EmpList[i].EmpLname);
                Console.WriteLine("Employee Contact No.:{0}", EmpList[i].EmpContact);
                Console.WriteLine("Employee Email Id:{0}", EmpList[i].EmpEmail);
                Console.WriteLine("Employee Gender:{0}", EmpList[i].EmpGender);
            }
            Console.ReadKey();

        }
    }
}

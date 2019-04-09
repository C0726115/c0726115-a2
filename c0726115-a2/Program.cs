
using System;
using System.Text;



using System.Threading.Tasks;











namespace delegateAndEvents



{



    class Program



    {



        static void Main(string[] args)



        {







            //Name 1 - Robin Bhatia



            //ID - c0726115














        }











        public class DelegateExcercises



        {



            public delegate void MyDelegate();



            void Method1()



            {







                Console.WriteLine("Method 1");



                Console.ReadLine();



            }



            public void Method2()



            {



                MyDelegate myDelegate = new MyDelegate(Method1);



                myDelegate();



            }
        }
    }
}
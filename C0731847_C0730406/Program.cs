using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847_C0730406
{
    //Gagandeep Kaur Waraich (C0731847)
    //Manpreet Kaur (C0730406)
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises mg = new DelegateExercises();

            mg.Method3();
            Console.Read();

        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises
    {
        public void Method1()
        {

        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            System.Console.WriteLine(myDelegate.ToString());
        }
    }
}


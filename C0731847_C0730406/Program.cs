using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847_C0730406
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gagandeep Kaur Waraich(C0731847)
            //Manpreet Kaur(C0730406)
        }
        
public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }




}


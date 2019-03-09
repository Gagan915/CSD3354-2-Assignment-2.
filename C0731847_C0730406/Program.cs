using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847_C0730406 { 
//Gagandeep Kaur Waraich (C0731847)
//Manpreet Kaur (C0730406)
 class Program {
 static void Main(string[] args)
    {
        DelegateExercises mg = new DelegateExercises();

            mg.Method2(60);
         
    }
}
public class DelegateExercises
{
  
            public delegate void MyDelegate(int i);
        public void Method1(int i)
    {
        Console.WriteLine("Method1");
            Console.WriteLine(i);
        Console.ReadLine();
    }
 
     public void Method2(int i)
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
   
            myDelegate(60);
    }
}
}



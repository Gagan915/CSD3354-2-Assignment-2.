﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847_C0730406 { 
//Gagandeep Kaur Waraich(C0731847)
//Manpreet Kaur(C0730406)
 class Program {
    public static void Main(string[] args)
    {
        DelegateExercises mg = new DelegateExercises();
        mg.Method2();
    }
}
public class DelegateExercises
{
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



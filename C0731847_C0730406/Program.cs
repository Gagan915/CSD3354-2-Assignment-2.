using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731847_C0730406
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            DelegateExercises mg = new DelegateExercises();
            mg.Method3();
            Console.ReadLine();
        }
    }
    delegate int MyDelegate(out int i);
    public class DelegateExercises
    {
        int Method1(out int i)
        {
            Console.WriteLine("Method 1");
            i = 10;
            return 0;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intValue;
            myDelegate2(out intValue);
        }

    }
}


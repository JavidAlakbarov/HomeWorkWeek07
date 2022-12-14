using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Task0702delegateExercises
namespace HomeWorkWeek07
{
    public class DelegateExercises
    {
        public delegate int MyDelegate(int intValue);
        public int Method1(int intMethod1)
        {
            return intMethod1 * 2; 
        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10; 
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            Console.WriteLine(result2);
        }
    }
}
#endregion
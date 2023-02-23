using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.Calculator();
            Console.ReadLine();
        }
       
       public void Calculator()
        {
            Console.WriteLine("Enter num1 \n ");
            int num1 = int.Parse(Console.ReadLine()); //type Casting
            Console.WriteLine("Enter num1 \n ");
            int num2 = Convert.ToInt32(Console.ReadLine()); //type Casting
            int mul = multi(num1, num2);
            int sum = Add(num1, num2);
            int sub = Sub(num1, num2);
            int  div = Div(num1, num2);
            Console.WriteLine("The Sum  are  " + sum);
            Console.WriteLine("The Product are  " + mul);
            Console.WriteLine("The Results  are  " + div);
            Console.WriteLine("The Differences  are  " + sub);
        }
       public  int multi(int x, int y)
        {
            return x * y;
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        static int Div(int x, int y)
        {
           
            return x / y;
        }
    }
}

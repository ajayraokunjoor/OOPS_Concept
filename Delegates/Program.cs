using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Defining Delegates
    //Note: The access specifeis, return type and the number, order and type of parameters of delegate
    //should be same as the function it refers to.
    public delegate void AddDelegate(int a, int b);
    public delegate string GreetingsDelegate(string name);
    class Program
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(@"The Sum of {0} and {1} is {2}", x, y, (x+y));
            Console.WriteLine($"The Sum of {x} and {y} is {(x+y)}");

        }

        public static string Greetings(string name)
        {
            return "Hello @" + name;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            //Instantiating delegate by passing the target function Name
            //The Add method is non static so here we are calling method using object
            AddDelegate ad = new AddDelegate(obj.Add);

            GreetingsDelegate gd = new GreetingsDelegate(Program.Greetings);

            //Invoking The Delegates
            ad(10, 20);

            string GreetingsMesage = gd("Ajay Rao Kunjoor");

            //We can also use Invoke method to execute delegates
            // ad.Invoke(100, 50);
            // string GreetingsMessage = gd.Invoke("Ajay Rao Kunjoor");
            Console.WriteLine(GreetingsMesage);
            Console.ReadLine();
        }
    }
}

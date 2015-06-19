using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var helloWorld = new HelloWorldChallenge();
            helloWorld.Run();
        }
    }

    public class HelloWorldChallenge
    {
        public void Run()
        {
            this.Challenge_01();
        }

        private void Challenge_01()
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}

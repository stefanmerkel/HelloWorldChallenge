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
            helloWorld.Value = "Hello World!";
            helloWorld.Challenge_01();
            helloWorld.Challenge_02();
            helloWorld.Challenge_03();
            Console.ReadLine();
        }
    }

    public class HelloWorldChallenge
    {
        private string _value = String.Empty;

        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        public void Challenge_01()
        {
            Console.WriteLine(this._value);
        }

        public void Challenge_02(string value = "")
        {
            value = String.IsNullOrWhiteSpace(value) ? this._value : value;
            Console.WriteLine(value + "\n" + value);
        }

        public void Challenge_03()
        {
            Challenge_02(this.Reverse(this._value));
        }

        private string Reverse(string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

using System.Globalization;
using CS50;
using System;
using System.Collections;
using System.Text;

namespace CSharpDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Console.WriteLine(circle.Area());
        }
    }

}
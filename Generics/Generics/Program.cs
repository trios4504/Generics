using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<string> myClass = new MyClass<string>();
        }
    }
}

public class MyClass<T>
{

}
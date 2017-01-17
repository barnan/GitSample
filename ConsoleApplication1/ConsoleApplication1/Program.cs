using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public class Calc : ICalc
    {
        public void Add()
        {
            Console.WriteLine("add");
        }

        public void Div()
        {
        }

        public void DivB()
        {
        }

        public void DivD()
        {
        }

        public void Mult()
        {
            throw new NotImplementedException();
        }

        //hehhe
    }

    interface ICalc
    {
        void Add();
        void Div();
        void DivB();
        void DivD();

        void Mult();
    }


    class Program
    {
        static void Main(string[] args)
        {
            //hehe
            //brühühü

            // task 7- es változtatás 1
            // task 7- es változtatás 2
            // task 7- es változtatás 3

        }
    }
}

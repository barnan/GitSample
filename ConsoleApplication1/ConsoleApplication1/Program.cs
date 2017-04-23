using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{

    public interface IAlapfunkcio1
    {
        void WriteTo();
    }

    public interface IAlapfunkció2
    {
        void WriteTo();
    }


    public interface IAlapfunkció3
    {
        void writeTo();
    }


    public class AlapClass : IAlapfunkcio1
    {
        public void WriteTo()
        {
            Console.WriteLine("Functionality of IAlapfunkció1");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}

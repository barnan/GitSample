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

    public interface IAlapfunkcio2
    {
        void WriteTo();
    }
    
    public interface IAlapfunkcio3
    {
        void WriteTo();
    }
    
    public class AlapClass1 : IAlapfunkcio1
    {
        public void WriteTo()
        {
            Console.WriteLine("Functionality of IAlapfunkció1");
        }
    }
    
    public class AlapClass2 : IAlapfunkcio2
    {
        public void WriteTo()
        {
            Console.WriteLine("Functionality of IAlapfunkció2");
        }
    }

    public class AlapClass3 : IAlapfunkcio3
    {
        public void WriteTo()
        {
            Console.WriteLine("Functionality of IAlapfunkció3");
        }
    }


    public interface IExtrafunkcio1
    {
        void ExtreWriteTo();
    }

    public interface IExtrafunkcio2
    {
        void ExtreWriteTo();
        void PushTheLimit1();
        void PushTheLimit2();
    }



    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}

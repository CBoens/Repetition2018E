using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition2018E
{
    class Program
    {
        static void Main(string[] args)
        {
            Collections c = new Collections();
            c.TestArray();
            c.TestList();
            
            try
            {
                int sumOfPositiveNumbers = 0;
                sumOfPositiveNumbers =c.SumList();
                Console.WriteLine($"Sum of numbers {sumOfPositiveNumbers}");
            }
            catch (NegativeNumberExcpetion nex)
            {
                Console.WriteLine(nex.Message);
            }
            finally
            {
                Console.WriteLine("Afsluttet beregning af sum");
            }
            //c.TestDictionary();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# supports the following data types
            // byte, short, integer, long, float, double
            byte myByte = 10;
            short myShort = 12323;
            int myInt = 12321312;
            long myLong = 123231312323;

            float myFloat = 1.3231F;
            double myDouble = 12.2323;

            /* Other types and their alias
             *  
             *  object:  System.Object
                string:  System.String
                bool:    System.Boolean
                byte:    System.Byte
                sbyte:   System.SByte
                short:   System.Int16
                ushort:  System.UInt16
                int:     System.Int32
                uint:    System.UInt32
                long:    System.Int64
                ulong:   System.UInt64
                float:   System.Single
                double:  System.Double
                decimal: System.Decimal  // more precision
                char:    System.Char
                */

            // We can obtain the range of values as follows
            Console.WriteLine("Byte range is : " + byte.MinValue + " -> " + byte.MaxValue);
            Console.WriteLine("Byte range is : " + short.MinValue + " -> " + short.MaxValue);
            Console.WriteLine("Byte range is : " + int.MinValue + " -> " + int.MaxValue);
            Console.WriteLine("Byte range is : " + long.MinValue + " -> " + long.MaxValue);
            Console.WriteLine("Byte range is : " + float.MinValue + " -> " + float.MaxValue);
            Console.WriteLine("Byte range is : " + double.MinValue + " -> " + double.MaxValue);

            // We can parse strings into any value
            Console.Write("Enter an integer value: ");
            string input = Console.ReadLine();

            try
            {
                myInt = int.Parse(input);
                Console.WriteLine("Value read is {0}", myInt);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}'.", input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is out of range of the Int32 type.", input);
            }

            // Press key to finish
            Console.ReadKey();
        }
    }
}

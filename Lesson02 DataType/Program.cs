using System;
using System.Text;

namespace Lesson02_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 01 int
            //int int1 = 1234567890;
            //int int2 = 2145678900;
            //Console.WriteLine(int1 + int2); //int is bigger then 2147483647
            ////output is "-914720506"
            ////false

            //// 02 int + sum
            //int Int01 = 1234567891;
            //int Int02 = 1945678900;
            //int IntSum = Int01 * Int02; //int is bigger then 2147483647
            //Console.WriteLine(IntSum);
            ////output is "-237179172"
            ////false

            //// 03 byte
            //byte Byte1 = 255;
            //byte Byte2 = 250;
            //Console.WriteLine(Byte1 + Byte2); //what type is here? ---> output is "505"
            ////true ----> why?

            //// 04 byte
            //byte byte1 = 255;
            //byte byte2 = 250;
            //byte bytesum = byte1 + byte2; //error --> when type in byte
            //Console.WriteLine(bytesum);
            ////false

            //// 05 byte
            //byte byte1 = 255;
            //byte byte2 = 250;
            //byte bytesum = (byte)(byte1 * byte2);
            //Console.WriteLine(bytesum); //output is "5" --> false
            //bytesum = (byte)(byte1 + byte2);
            //Console.WriteLine(bytesum); //Output is "249" --> false
            ////false

            //// 06 sbyte
            //sbyte Sbyte1 = 125;
            //sbyte Sbyte2 = 127;
            //sbyte SbyteType = (sbyte)(Sbyte1 * Sbyte2); 
            //Console.WriteLine(SbyteType); //output is "3"  --> false
            //Sbyte2 = -127;
            //SbyteType = (sbyte)(Sbyte1 / Sbyte2);
            //Console.WriteLine(SbyteType); //output is "0"  --> false
            ////false

            //// 07 char 
            //char char1 = 'A';
            //Console.WriteLine((byte)char1);
            //char1 = 'Ա';
            //Console.WriteLine((sbyte)char1); // output is "49" --->false
            //Console.WriteLine((int)char1); // output is "1329" ---> why?

            //// 08 int
            //int a = 25;
            //int b = 256;
            //float c = b / a;
            //Console.WriteLine(c); // output is 10 int type ---> why?
            //float d = 256;
            //c = d / a;
            //Console.WriteLine(c); // output is 20.24 float type ---why?

        }
    }
}

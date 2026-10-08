using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = -0.0;
            double b = 0.0;

            // Сравнение значений: -0.0 == 0.0 → true
            bool res = a == b;
            Console.WriteLine($"-0.0 == 0.0 = {res}"); // True

            // Но знак у них разный — это видно через Math.Sign
            int signA = Math.Sign(a); // 0, но внутренне знак есть
            int signB = Math.Sign(b); // 0
            Console.WriteLine($"Math.Sign(-0.0) = {signA}, Math.Sign(0.0) = {signB}"); // оба 0

            // Самый надёжный способ увидеть разницу в знаке — посмотреть битовое представление
            long bitsA = BitConverter.DoubleToInt64Bits(a);
            long bitsB = BitConverter.DoubleToInt64Bits(b);

            Console.WriteLine($"Биты -0.0: {bitsA:X16}");
            Console.WriteLine($"Биты  0.0: {bitsB:X16}");

            // Разница ровно в одном старшем бите (знаковом)
            Console.WriteLine($"Отличаются ли биты? {bitsA != bitsB}"); // True
        }
    }
}
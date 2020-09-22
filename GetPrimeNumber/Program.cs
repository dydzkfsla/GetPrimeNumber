using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GetPrimeNumber
{
    class PrimeNumber
    {
        public void Run(ulong temp)
        {
            for(ulong i = 1; i <= temp; i++)
            {
                if (Prime(i))
                {
                    Console.Write($"{i}, ");
                }
            }
        }

        public bool Prime(ulong temp)
        {
            if ((temp & 1) == 0)    // 2의 배수 체크
            {
                if (temp == 2) return true;
                return false;
            }

            for(ulong i = 3; i * i <= temp; i++)
            {
                if (temp % i == 0) return false;
            }
            if(temp != 1) return true;
            return false;
        }
    }

    class Prime
    {
        public void Run(ulong len)
        {
            bool[] result = new bool[len + 1];
            for (ulong k = 1; k <= len; k++)
                result[k] = true;

            for(ulong i = 2; i * i <= len; i++)
            {
                if (result[i])
                {
                    for (ulong j = i * i; j <= len; j += i) { result[j] = false; }
                }
            }

            for(ulong k = 1; k <= len; k++)
            {
                if(result[k])
                    Console.Write($"{k} ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber primeNumber = new PrimeNumber();
            Prime prime = new Prime();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("소수의 범위를 입력하시오");
                ulong x = ulong.Parse(Console.ReadLine());
                prime.Run(x);
                Console.ReadLine();

                Console.Clear();
                primeNumber.Run(x);
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HW16
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathRead = @"D:\repos\HomeWork16\HW16\INPUT.txt";
            var pathWrite = @"D:\repos\HomeWork16\HW16\OUTPUT.txt";
            var numberList = new List<int>();
            using (StreamReader stream = new StreamReader(pathRead))
            {
                var text = stream.ReadLine();
                text = text.Replace(",", "");
                var stringNums = text.Split(' ');
                for (var i = 0; i < stringNums.Length; i++)
                {
                    int.TryParse(stringNums[i], out int tmpNumber);
                    numberList.Add(tmpNumber);
                }
                var fiboCnt = numberList.Count;
                for (int i = 0; i < fiboCnt; i++)
                {
                    int tmpNumber = numberList[numberList.Count - 2] + numberList[numberList.Count - 1];
                    numberList.Add(tmpNumber);
                }
            }
            using (StreamWriter streamWriter = new StreamWriter(pathWrite))
            {
                foreach (var number in numberList)
                {
                    streamWriter.Write($"{number}, ");
                }
            }
        }
    }
}

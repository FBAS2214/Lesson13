using System;
using System.Collections;

namespace Lesson13_2
{
    class OwnClass : IEnumerable
    {
        public string[] Names = { "Aga", "Nihad", "Elgun" };

        public IEnumerator GetEnumerator()
            => Names.GetEnumerator();
    }


    class Program
    {
        static void Main()
        {
            // IEnumerable
            // IEnumerator


            /*
            List<int> list = new List<int>();
            list.Add(34);
            list.Add(23);
            list.Add(11);
            list.Add(5654);
            list.Add(123);

            IEnumerator<int> iterator = list.GetEnumerator();

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);

                // if (iterator.Current == 11)
                //     iterator.Reset();
            }
            */




            // IEnumerable own = new OwnClass();
            // 
            // foreach (var name in own)
            //     Console.WriteLine(name);






            // foreach (var digit in GetSingleDigitNumbers())
            //     Console.WriteLine(digit);

        }



        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;

            yield break;

            // yield return 5;
        }
    }
}
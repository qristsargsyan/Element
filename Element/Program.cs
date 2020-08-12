using System;
using System.Collections;

namespace Element
{
    class Program
    {
        static void Main(string[] args)
        {
            UserController user = new UserController();

            user[0] = new Elements(1, 2);
            user[1] = new Elements(3, 4);
            user[2] = new Elements(5, 6);
            user[3] = new Elements(7, 8);
            user[4] = new Elements(9, 9);

            foreach (Elements item in user)
            {
                Console.WriteLine("{0},{1} ", item.Num1, item.Num2);
            }

            Console.WriteLine(new string('-', 10));

            foreach (Elements item in user)
            {
                Console.WriteLine("{0},{1} ", item.Num1, item.Num2);
            }

            Console.WriteLine(new string('-', 10));

            IEnumerator enumerator = (user as IEnumerable).GetEnumerator();

            while (enumerator.MoveNext())
            {
                Elements elements = enumerator.Current as Elements;
                Console.WriteLine("{0},{1} ", elements.Num1, elements.Num2);

            }



        }
    }
}

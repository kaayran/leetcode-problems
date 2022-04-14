using System;

namespace Solution
{
    public class Program {
        public static void Main(){
            var numRows = 5;

            var result = Generate(numRows);

            foreach (var list in result)
            {
                foreach (var n in list)
                {
                    Console.Write(n);
                    Console.Write("\t");
                }

                Console.WriteLine("\n");
            }
        }

        public static List<List<int>> Generate(int numRows) {
            var triangle = new List<List<int>>();
            
            for (int i = 0; i < numRows; i++)
            {
                triangle.Add(new List<int>());

                for (int j = 0; j < i + 1; j++)
                {
                    triangle[i].Add(1);
                }
            }

            return triangle;
        }

    }
}
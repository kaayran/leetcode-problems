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

        public static IList<IList<int>> Generate(int numRows) {
            IList<IList<int>> triangle = new List<IList<int>>();
            
            for (int i = 0; i < numRows; i++)
            {
                triangle.Add(new List<int>());

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i) {
                        triangle[i].Add(1);    
                    }
                    else
                    {
                        var value = triangle[i - 1][j - 1] + triangle[i - 1][j];
                        triangle[i].Add(value);
                    }                                    
                }
            }

            return triangle;
        }

    }
}
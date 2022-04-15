using System;

namespace Solution
{
    public class Program {
        public static void Main(){
            var rowIndex = 0;

            var result = GetRow(rowIndex);

            foreach (var n in result)
            {
                Console.Write(n);
                Console.Write("\t");
            }
        }

        public static IList<int> GetRow(int rowIndex) {
            IList<int> temp = new List<int>();
            IList<int> row = new List<int>();
                       
            for (int i = 0; i < rowIndex + 1; i++)
            {
                row.Clear();

                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0 || j == i) {
                        row.Add(1);    
                    }
                    else
                    {
                        var value = temp[j - 1] + temp[j];
                        row.Add(value);
                    }                                    
                }

                temp = new List<int>(row);
            }

            return row;
        }

    }
}
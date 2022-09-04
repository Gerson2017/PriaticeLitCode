using System;
using System.Collections.Generic;

namespace PriaticeLitCode
{
    public class NQuene
    {
        public NQuene()
        {
        }



        static List<string> results =new List<string>();
        static List<int> pie = new List<int>();
        static List<int> na = new List<int>();
        //行
        static List<int> cols = new List<int>();

        static string[,] strings;


        public static void CalculateNQuene(int n)
        {
            strings = new string[n, n];
            DelNQuene(n,0);
            for (int i = 0; i < n; i++)
            {
                string str = "";
                for (int j = 0; j < n; j++)
                {
                    if (string.IsNullOrEmpty(strings[i, j]))
                        str += ".";
                    else
                        str += strings[i, j];
                }

                Console.WriteLine(str);
            }
        }


        static void DelNQuene( int n,int raw) {

            if (raw >= n)
            {
                return;
            }

            //列
            for (int col = 0; col < n; col++)
            {
                if (cols.Contains(col))
                    continue;
                if (pie.Contains(raw + col))
                    continue;
                if (na.Contains(raw - col))
                    continue;

                strings[raw, col] = "Q";
                Console.WriteLine($"add raw {raw} col {col}");

                cols.Add(col);
                pie.Add(raw + col);
                na.Add(raw- col);

                DelNQuene(n,raw+1);

                strings[raw, col] = ".";
                Console.WriteLine($"remove raw {raw} col {col}");
                cols.Remove(col);
                pie.Remove(col + raw);
                na.Remove(raw - col);

            }
        }




    }
}

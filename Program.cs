using System;

using System.Linq;
using System.Text;
using static System.Text.RegularExpressions.Regex;

namespace CodeWar
{
    class Program
    {
        private static double square(double a)
        {
            return a * a;
        }
        public class Kata
        {
            public static double Square(double t) => t * t;
        }
        public static double Square(double n)
        {
            return Convert.ToDouble(Math.Pow(n, 2));
        }
        public static string Speedify(string input)
        {
            //var ar = String.Join(" ", input);


            char temp;
            input = input.ToUpper();
            char[] charstr = input.ToCharArray();

            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }

            string Str = new string(charstr);



            return Str;
        }
        public static int Enough(int cap, int on, int wait)
        {
            string text;
            int fit = (on + wait) - cap;

            if (fit <= 0)
            {
                text = $"0, He can fit all {wait} passengers";
                Console.WriteLine(text);
                return 0;
            }
            else
            {
                text = $"{fit}, He can't fit {fit} out of {wait} waiting";
                Console.WriteLine(text);
                return fit;
            }
        }

        public static class Kata0
        {
            public static int Enough(int cap, int on, int wait) => Math.Max(on + wait - cap, 0);
        }

        public static int Past(int h, int m, int s)
        {
            int res = (h * 3600 + m * 60 + s) * 1000;

            return res;
        }

        public static int Past2(int h, int m, int s)
        {
            return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
        }

        public static string FormatMoney(double amount)
        {
            return $"${amount:F2}";
        }

        public static bool IsSquare(int n)
        {
            if (Math.Sqrt(n) % 1 != 0 || n == 0)
            {
                return false;
            }
            else return true;
        }

        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            str = str.ToLower();
            char[] charstr = str.ToCharArray();
            char[] vo = "aeiou".ToCharArray();

            foreach (var item in charstr)
            {
                foreach (var l in vo)
                {
                    if (item == l)
                    {
                        vowelCount++;
                    }
                }
            }

            return vowelCount;
        }

        public static int GetVowelCount2(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }

        public static string SolveBeta(string a, string b)
        {
            char[] A = a.ToCharArray();
            char[] B = b.ToCharArray();

            var differences1 = A.Except(B).ToList();
            var differences2 = B.Except(A).ToList();
            var overAllDifferences = differences1.Union(differences2).ToList();

            var str = new StringBuilder();

            foreach (var c in overAllDifferences)
            {
                str.Append(c);
            }


            return str.ToString();
        }

        public static string Solve(string a, string b)

        {
            //var str = new StringBuilder(a + b);
            string str = a + b;


            char[] C = str.ToCharArray();
            char[] A = a.ToCharArray();
            char[] B = b.ToCharArray();

            for (int i = 0; i < A.Length; i++)
            {
                if (B.Contains(A[i]))
                {
                    //C.r;
                }
            }


            //foreach (var c in A)
            //{
            //    if (B.Contains(c))
            //    {
            //        str.Remove(c)
            //    }

            //}


            //int max = A.Length > B.Length ? A.Length : B.Length;

            //var str = new StringBuilder();

            //for (int i = 0; i < max; i++)
            //{
            //    if( A[i] = )
            //    {

            //    }
            //}

            //foreach (var i in A)
            //{
            //    foreach (var l in B)
            //    {
            //        if (i != l)
            //        {
            //            str.Append(i);

            //        }
            //    }
            //}           



            //    var differences1 = A.Except(B).ToList();
            //var differences2 = B.Except(A).ToList();
            //var overAllDifferences = differences1.Union(differences2).ToList();




            //var str = new StringBuilder();

            //foreach (var c in overAllDifferences)
            //{
            //    str.Append(c);
            //}


            return str;
        }

        //public static string Solve2(string a, string b)

        //{

        //    return a.Count(i => "aeiou".Contains(i));

        //}

        public static string SolveAlpha(string a, string b)
        {
            var str = new StringBuilder();

            for (int i = 0; i < a.Length; i++)
            {

                if (!b.Contains(a[i]))
                {
                    str.Append(a[i]);
                }

            }
            for (int i = 0; i < b.Length; i++)
            {
                if (!a.Contains(b[i]))
                {
                    str.Append(b[i]);
                }
            }
            return str.ToString();
        }

        public static string SolveOrigin(string a, string b)
        {
            return Replace(a, $"[{b}]", "") + Replace(b, $"[{a}]", "");
        }
        public static string SolveOri2(string a, string b)
        {
            return string.Concat(a.Where(x => !b.Contains(x)).Concat(b.Where(x => !a.Contains(x))));
        }

        public static int[] Arr(int N)
        {
            int[] terms = new int[N];
            for (int i = 0; i < N; i++)
            {
                terms[i] = i;
            }
            return terms;
        }
        public static int CockroachSpeed(double x)
        {

            return (int)Math.Floor(x / 0.036);
        }

        public static string Shark(
      float pontoonDistance,
       float sharkDistance,
       float yourSpeed,
       float sharkSpeed,
      bool dolphin)
        {
            sharkSpeed = dolphin == true ? sharkSpeed / 2 : sharkSpeed;
            return sharkDistance / sharkSpeed > pontoonDistance / yourSpeed ? "Alive!" : "Shark Bait!";
        }

        public static string SharkAlpha(int pontoonDistance, int sharkDistance, int yourSpeed, int sharkSpeed, bool dolphin)
        {
            return pontoonDistance * sharkSpeed < yourSpeed * sharkDistance * (dolphin ? 2 : 1)
              ? "Alive!"
              : "Shark Bait!";
        }
        public static int ToBinary(int n)
        {
            return Convert.ToInt32(Convert.ToString(n, 2));
            //return int.Parse(Convert.ToString(n, 2));
        }
        public static int ToBinary2(int n) =>
    Convert.ToInt32(Convert.ToString(n, 2));

        public static string Derive(double coefficient, double exponent)
        {

            return $"{coefficient * exponent}x^{ exponent - 1}";
            //public static string Derive(double c, double e) => $"{c * e}x^{e - 1}";
        }
        public static double SumArrayb(double[] array)
        {

            return array != null ? array.Sum() : 0;
        }
        public static double SumArray(double[] array)
        {
            return array.Sum();
        }
        public static string Solutionb(string str)
        {
            var strn = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                strn.Append(str[i]);
            }

            return strn.ToString();
        }
        public static string Solution(string str)
        {
            return new String(str.Reverse().ToArray());
        }

        public static double Index(int[] array, int n)
        {

            return n + 1 > array.Length ? -1 : Math.Pow(array[n], n);
        }
        public static double Indexb(int[] array, int n)
        {
            try
            {
                return Math.Pow(array[n], n);
            }
            catch
            {
                return -1;
            }
        }

        public static string SwitchItUp(int number)
        {
            string str = "";
            switch (number)
            {
                case 0:
                    str = "Zero";
                    break;
                case 1:
                    str = "One";
                    break;
                case 2:
                    str = "Two";
                    break;
                case 3:
                    str = "Three";
                    break;
                case 4:
                    str = "Four";
                    break;
                case 5:
                    str = "Five";
                    break;
                case 6:
                    str = "six";
                    break;
                case 7:
                    str = "Seven";
                    break;
                case 8:
                    str = "Eight";
                    break;
                case 9:
                    str = "Nine";
                    break;
                default:
                    str = "out of range";
                    break;
            }

            return str;
        }
        public static string SwitchItUpb(int number)
        {
            switch (number)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: return "Wrong number.";
            }
        }

        public static int Litresb(double time)
        {
            //The fun begins here.
            return Convert.ToInt32(Math.Floor((time * 0.5)));
        }
        public static int Litres(double time) => (int)time >> 1;

        public static int[] ReverseSeq(int n)
        {
            int[] arr = new int[n];


            for (int i = 1; i < n + 1; i++)
            {
                arr[n - i] = i;
            }
            return arr;
        }
        public static int[] ReverseSeqb(int n)
        {
            return Enumerable.Range(1, n).Reverse().ToArray();
        }
        public static int[] ReverseSeqc(int n)
        {
            return new int[n].Select(_ => n--).ToArray();
        }

        public static object FirstNonConsecutive(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    return arr[i + 1];
                }
            }

            return null;
        }

        public static object FirstNonConsecutiveb(int[] arr) => arr.Cast<int?>().Skip(1).FirstOrDefault(i => i != ++arr[0]);
        public static object GetMissingElement(int[] arr) => arr.Cast<int?>().OrderBy(i => i).Skip(1).FirstOrDefault(i => i != ++arr[0]); //nao funciona

        public static int GetMissingElementb(int[] superImportantArray)
        {
            int[] sorted = superImportantArray.OrderBy(i => i).ToArray();

            for (int i = 0; i < sorted.Length - 1; i++)
            {
                if (sorted[i] + 1 != sorted[i + 1])
                {
                    if (sorted[i] + 1 == 9)
                    {
                        return 9;
                    }
                    else
                        return sorted[i] + 1;
                }
            }
            return 0;
        }
        public static int GetMissingElementc(int[] superImportantArray)
        {
            int[] mod = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var differences1 = mod.Except(superImportantArray).FirstOrDefault();
            return (int)differences1;
        }

        public static int GetMissingElementd(int[] superImportantArray)
        {
            return (int)Enumerable.Range(0, 9).Except(superImportantArray).FirstOrDefault();
        }

        public static int GetAverage(int[] marks)
        {
            return (int)Math.Floor(marks.Average());
        }

        public static string ReverseWords(string str)
        {
            string[] splitResult = str.Split(' ');
            for (int i = 0; i < splitResult.Length / 2; i++)
            {
                string tmp = splitResult[i];
                splitResult[i] = splitResult[splitResult.Length - i - 1];
                splitResult[splitResult.Length - i - 1] = tmp;
            }
            return string.Join(" ", splitResult);

        }

        public static string ReverseWordsa(string str)
        {
            return string.Join(" ", str.Split(' ').Reverse());
        }
        public static int SquareSum(int[] n)
        {
            int[] sum = new int[n.Length];


            for (int i = 0; i < n.Length; i++)
            {
                sum[i] = (int)Math.Pow(n[i], 2);
            }
            return sum.Sum();
        }
        public static int SquareSumb(int[] n) => n.Sum(i => i * i);
        static void Main(string[] args)
        {
            //double a = square(3);

            //string a = Speedify("dfrga");
            //Enough(100, 60, 50);

            //Console.WriteLine(FormatMoney(39.99));
            //bool a = IsSquare(-25);
            //int a = GetVowelCount("armentu");
            //string a = SolveAlpha("abbcd", "acefm");
            //int a = Arr(3)[0];
            //int b = Arr(3)[2];
            //int a = CockroachSpeed(1.09);
            //int a = ToBinary(3);
            //string a = Derive(2, 4);
            int[] a = new int[] { 3, 2, 9, 1, 4, 5, 6, 7 };
            //double[] b = new double[] { };

            //Console.WriteLine(Index(a, 2));
            //Console.WriteLine(SumArray(b));
            //string b = SwitchItUp(3);
            //int[] b = ReverseSeq(5);
            //Console.WriteLine(GetMissingElementc(a));
            string b = ReverseWords(" eu sou o cara");

            Console.WriteLine(SquareSum(a));



        }
    }
}

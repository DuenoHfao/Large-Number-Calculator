using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Large_Number_Calculator
{
    public class readOperator
    {

    }
    internal class Program
    {
        static int calc_operator(string user_input, int index_of_operator)
        {
            var two_nums = return_numbers(user_input, index_of_operator);
            if (user_input[index_of_operator] == '*')
            {

            }

            else if (user_input[index_of_operator] == '/')
            {

            }
            else if (user_input[index_of_operator] == '+')
            {

            }
            else if (user_input[index_of_operator] == '-')
            {

            }
            return -1;
        }

        public static Tuple<int[], int[]> return_numbers(string user_input, int index_of_operator)
        {
            List<int> reversed_num1 = new List<int>(); ;
            List<int> reversed_num2 = new List<int>();

            for (int i= index_of_operator - 1; i >= 0; i--)
            {
                reversed_num1.Add(user_input[i]);
                // Console.WriteLine($"Appending: {user_input[i]}");
            }
            /*foreach (var i in reversed_num1)
            {
                Console.WriteLine($"i: {i}");
            } */

            for (int i = user_input.Length-1; i > index_of_operator; i--)
            {
                reversed_num2.Add(user_input[i]);
            }

            int[] array_num1 = reversed_num1.ToArray();
            int[] array_num2 = reversed_num2.ToArray();

            return Tuple.Create(array_num1, array_num2);
        }

        static void Main(string[] args)
        {
            int[] result = new int[10000000];
            Console.Write("Please input equation: ");
            var unseralized_input = Console.ReadLine();
            string user_input = Regex.Replace(unseralized_input, @"\s", "");
            var special_char = new Regex("^[a-zA-Z0-9 ]*$");
            var index_of_operator = -1;

            for (var i=0; i<user_input.Length; i++)
            {
                Console.Write("{0}:{1}\t", user_input[i], special_char.IsMatch(user_input[i].ToString()));
                if (!special_char.IsMatch(user_input[i].ToString()) && user_input[i] != '.')
                {
                    index_of_operator = i;
                    Console.WriteLine($"\n {index_of_operator}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"User inputted string {user_input} with the index of the operator {index_of_operator}");
            calc_operator(user_input, index_of_operator);
        }
    }
}
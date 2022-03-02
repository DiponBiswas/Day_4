using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unique();
            //CompareOperation();
            //SplitSentence();
            //BasicStringDemo();
        }

        private static void Unique()
        {
            Console.WriteLine("Enter a sentence");
            string s = Console.ReadLine();
            string[] word = words(s);
            int count = 0;

            for (int i = 0; i < word.Length - 1; i++)
            {
                int c = 0;
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[j] == word[i])
                    {
                        c++;
                        break;
                    }
                }
                if (c == 0)
                {
                    count++;
                }

            }
            Console.WriteLine("Number of Unique words is {0}", count + 1);
        }

        private static void CompareOperation()
        {
            Console.WriteLine("Enter 1st String");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd String");
            string s2 = Console.ReadLine();
            bool b = CompareStrings(s1, s2);
            Console.WriteLine("The equality check of {0} and {1} is {2}", s1, s2, b);
        }

        public static bool CompareStrings(string s1, string s2)
        {
            if(Equals(s1,s2))
                return true;
            else
                return false;
        }
        private static void SplitSentence()
        {
            Console.WriteLine("Enter a sentence");
            string s = Console.ReadLine();
            string[] word = words(s);
            foreach (var i in word)
            {
                Console.WriteLine(i);
            }
        }

        public static string[] words(string s)
        {
            string[] w= s.Split(' ');
            return w;
        }

        private static void BasicStringDemo()
        {
            string name = "Dipon";
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };
            string str = new string(chars);
            //string string1 = new string('D', 10);
            Console.WriteLine(name);
            Console.WriteLine(str);

            String st = "Hello ! this String is starting with upper case";
            Console.WriteLine(st);
            bool data = str.Equals(st);
            Console.WriteLine(data);
            string str1 = "Hello";
            Console.WriteLine(str.Equals(str1));
            Console.WriteLine(Equals(st, str1));

            string str2 = null;
            Console.WriteLine("str2 : {0}", str2);
            str2 = "Some value";
            Console.WriteLine("now str2 : {0}", str2);
            str2 = "new literal";
            Console.WriteLine(str2);

            Console.WriteLine(str1 + st);

            Console.WriteLine(st.Substring(5));
            Console.WriteLine(st.Substring(0, 5));
            Console.WriteLine(st.Substring(8, 4));
            Console.WriteLine(st.Substring(12));
            if (str == "Hello")
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            string str3 = "welcome";
            char[] cs = str3.ToArray();
            foreach (var c in cs)
            {
                Console.Write("{0} ", c);
            }
            Console.WriteLine("{0} ", cs);// it will show the type of cs is char[]
            char[] ca = str3.ToCharArray();
            foreach (var c in ca)
            {
                Console.Write("{0} ", c);
            }

            string uper = str3.ToUpper();
            Console.WriteLine(uper);
            string strupper = "HELLO";
            Console.WriteLine(strupper.ToLower());
            Console.WriteLine("No of charcaters in {0} are {1}", str3, str3.Length);

            Console.WriteLine("indexof c in welcome is {0}", str3.IndexOf('c'));
            Console.WriteLine(str3.Insert(0, "Hi "));
            Console.WriteLine(str3.Insert(6, " All"));
            Console.WriteLine(str3.PadLeft(5));

            string[] words = st.Split(' ');
            foreach (var wrd in words)
            {
                Console.WriteLine(wrd);
            }
            Console.WriteLine("There are {0} words in string- {1} ", words.Length, st);
            string js = string.Join(" ", words);
            Console.WriteLine(js);

            string cts = js + " Great!!";
            Console.WriteLine(cts);
        }
    }
}

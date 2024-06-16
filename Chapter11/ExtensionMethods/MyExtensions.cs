using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExtensionMethods
{
    static class MyExtensions
    {

        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}\n", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        public static int ReverseDigits(this int i)
        {
            char[] digits = i.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            return int.Parse(newDigits);
        }   

        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string Reverse(this String str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string ToTitleCase(this String str)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static string ToSentenceCase(this String str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }

        public static string ToCamelCase(this String str)
        {
            return str.Substring(0, 1).ToLower() + str.Substring(1);
        }

        public static string ToPascalCase(this String str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }

        public static string ToSnakeCase(this String str)
        {
            return str.Replace(" ", "_");
        }

        public static string ToKebabCase(this String str)
        {
            return str.Replace(" ", "-");
        }

        public static string ToDotCase(this String str)
        {
            return str.Replace(" ", ".");
        }

        public static string ToPathCase(this String str)
        {
            return str.Replace(" ", "/");
        }

        public static string ToConstantCase(this String str)
        {
            return str.Replace(" ", "_").ToUpper();
        }

        public static string ToLowerCase(this String str)
        {
            return str.ToLower();
        }

        public static string ToUpperCase(this String str)
        {
            return str.ToUpper();
        }

        public static string ToCapitalize(this String str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }

        public static string ToDecapitalize(this String str)
        {
            return str.Substring(0, 1).ToLower() + str.Substring(1);
        }

        public static string ToReverseCase(this String str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                    arr[i] = char.ToLower(arr[i]);
                else if (char.IsLower(arr[i]))
                    arr[i] = char.ToUpper(arr[i]);
            }
            return new string(arr);
        }

        public static string ToAlternatingCase(this String str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    arr[i] = char.ToUpper(arr[i]);
                else
                    arr[i] = char.ToLower(arr[i]);
            }
            return new string(arr);
        }

        public static string ToTitleCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToTitleCase();
            }
            return string.Join(" ", words);
        }

        public static string ToSentenceCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToSentenceCase();
            }
            return string.Join(" ", words);
        }

        public static string ToCamelCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToCamelCase();
            }
            return string.Join(" ", words);
        }

        public static string ToPascalCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToPascalCase();
            }
            return string.Join(" ", words);
        }

        public static string ToSnakeCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToSnakeCase();
            }
            return string.Join(" ", words);
        }

        public static string ToKebabCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToKebabCase();
            }
            return string.Join(" ", words);
        }

        public static string ToDotCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToDotCase();
            }
            return string.Join(" ", words);
        }

        public static string ToPathCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToPathCase();
            }
            return string.Join(" ", words);
        }

        public static string ToConstantCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToConstantCase();
            }
            return string.Join(" ", words);
        }

        public static string ToLowerCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToLowerCase();
            }
            return string.Join(" ", words);
        }

            
        public static string ToUpperCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToUpperCase();
            }
            return string.Join(" ", words);
        }

        public static string ToCapitalize(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToCapitalize();
            }
            return string.Join(" ", words);
        }

        public static string ToDecapitalize(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToDecapitalize();
            }
            return string.Join(" ", words);
        }

        public static string ToReverseCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToReverseCase();
            }
            return string.Join(" ", words);
        }

        public static string ToAlternatingCase(this String str, string[] exceptions)
        {
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToAlternatingCase();
            }
            return string.Join(" ", words);
        }

        public static string ToTitleCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToTitleCase();
            }
            return string.Join(" ", words);
        }

        public static string ToSentenceCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToSentenceCase();
            }
            return string.Join(" ", words);
        }

        public static string ToCamelCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToCamelCase();
            }
            return string.Join(" ", words);
        }

        public static string ToPascalCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToPascalCase();
            }
            return string.Join(" ", words);
        }

        public static string ToSnakeCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToSnakeCase();
            }
            return string.Join(" ", words);
        }

        public static string ToKebabCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToKebabCase();
            }
            return string.Join(" ", words);
        }

        public static string ToDotCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToDotCase();
            }
            return string.Join(" ", words);
        }

        public static string ToPathCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToPathCase();
            }
            return string.Join(" ", words);
        }

        public static string ToConstantCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToConstantCase();
            }
            return string.Join(" ", words);
        }

        public static string ToLowerCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToLowerCase();
            }
            return string.Join(" ", words);
        }

        public static string ToUpperCase(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToUpperCase();
            }
            return string.Join(" ", words);
        }

        public static string ToCapitalize(this String str, string[] exceptions, string[] separators)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (!exceptions.Contains(words[i]))
                    words[i] = words[i].ToCapitalize();
            }
            return string.Join(" ", words);
        }

    }
}

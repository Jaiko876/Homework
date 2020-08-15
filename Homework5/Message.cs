using System;
using System.Text;
namespace Homework5
{
    public static class Message
            { 
                public static void WordsByLength(string text, int lengthStrict)
                {
                    StringBuilder sb = new StringBuilder();
                    string[] strings = text.Split(" ");
                    for (int i = 0; i < strings.Length; i++)
                    {
                        if (strings[i].Length <= lengthStrict)
                        {
                            sb.Append(strings[i]);
                            sb.Append(" ");
                        }
                    }
                    Console.WriteLine($"Слова, которые содержат не более {lengthStrict} букв: {sb.ToString()}");
                }
    
                public static void DeleteWordsByLastChar(string text, char c)
                {
                    StringBuilder sb = new StringBuilder();
                    string[] strings = text.Split(" ");
                    for (int i = 0; i < strings.Length; i++)
                    {
                        if (!strings[i].EndsWith(c))
                        {
                            sb.Append(strings[i]);
                            sb.Append(" ");
                        }
                    }
                    Console.WriteLine($"Удалены все слова, которые оканчивались на символ {c}: {sb.ToString()}");
                }
    
                public static void FindLongestWord(string text)
                {
                    string longestWord = "";
                    string[] strings = text.Split(" ");
                    for (int i = 0; i < strings.Length; i++)
                    {
                        if (strings[i].Length > longestWord.Length)
                        {
                            longestWord = strings[i];
                        }
                    }
                    Console.WriteLine($"Самое длинное слово: {longestWord}");
                }
            }
}
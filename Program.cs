using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string text = " Mey, Mey, Mey. Prrrr, Im a cat, and I have pufs.";
            words(text);
        }

        public static void words(string text) {
            List<string> word = new List<string>();
            int words_cout = 0;
            string curent_word = "";
            for (int i = 0; i < text.Length; i++) {
                if (text[i] == ' ') {
                    words_cout++;
                    for (int j = i + 1; j < text.Length; j++) {
                        if (text[j] != ' '  || text[j] != ',' || text[j] != '.')
                        {
                            curent_word = curent_word + text[j];
                            

                        }
                        if(text[j] == ' ' || text[j] == ',' || text[j] == '.') {

                            word.Add(curent_word.Substring(0, curent_word.Length - 1)); // так делать нельзя, но мне лень думать над нормальным способом удаления лишних знаков
                            curent_word = "";

                            break;
                        }
                    }
                }
            }

            Console.WriteLine(word[0]);
        }
    }
}

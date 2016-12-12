using Brain.Elements;
using System;
using System.Collections.Generic;

namespace Brain
{
    public class ConverstationManager
    {
        private WordBook book;

        public ConverstationManager(WordBook book)
        {
            this.book = book;
        }

        public void ProcessSentance(string inputSentance)
        {
            inputSentance = inputSentance.ToLower();
            inputSentance = inputSentance.Replace(",", " , ");
            inputSentance = inputSentance.Replace("?", " ? ");
            inputSentance = inputSentance.Replace(".", " . ");
            inputSentance = inputSentance.Replace("!", " ! ");
            Console.WriteLine("input" + inputSentance);
            var words = inputSentance.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCollection = new List<Word>();

            foreach (var textWord in words)
            {
                Console.WriteLine(textWord);
                var word = book.GetWord(textWord);
                wordCollection.Add(word);
            }

            var sentance = new Sentance(wordCollection);
            Console.WriteLine(sentance.ToString());
        }
    }
}

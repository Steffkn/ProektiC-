using Brain;
using Brain.Elements;
using System.Collections.Generic;

namespace Catalog
{
    public class Person
    {
        private WordBook words;

        public Person(HashSet<Word> words)
        {
            this.words = new WordBook(words);
        }

        public void SendMessage(string message)
        {
            ConverstationManager cm = new ConverstationManager(words);
            cm.ProcessSentance(message);
        }

        public void LearnWord(Word word)
        {
            words.SetWord(word);
        }
    }
}

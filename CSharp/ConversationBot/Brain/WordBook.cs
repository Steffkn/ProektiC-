namespace Brain
{
    using Brain.Elements;
    using System.Collections.Generic;
    using System.Linq;

    public class WordBook
    {
        /// <summary>
        /// int[8]  
        /// </summary>
        private HashSet<Word> words;

        public WordBook(HashSet<Word> words)
        {
            this.words = words;
        }

        public void SetWord(Word newWord)
        {
            words.Add(newWord);
        }

        public Word GetWord(string word)
        {
            word = word.ToLower();
            return words.FirstOrDefault(w => w.Text.ToLower() == word);
        }
    }
}

namespace AI
{
    using Brain.Elements;
    using Catalog;
    using System.Collections.Generic;

    class AI
    {
        static void Main()
        {
            var dictionary = new HashSet<Word>();
            dictionary.Add(new Word("hi", new byte[] { 2, 0, 0, 2, 0, 0, 0, 0, }));
            dictionary.Add(new Word("friend", new byte[] { 3, 3, 0, 0, 0, 0, 0, 0, }));
            dictionary.Add(new Word("!", new byte[] { 0, 0, 0, 3, 0, 0, 0, 0, }));
            dictionary.Add(new Word(".", new byte[] { 0, 0, 0, 1, 0, 0, 0, 0, }));
            dictionary.Add(new Word("?", new byte[] { 0, 0, 0, 1, 0, 0, 0, 0, }));
            dictionary.Add(new Word(",", new byte[] { 0, 0, 0, 1, 0, 0, 0, 0, }));
            dictionary.Add(new Word("kill", new byte[] { 0, 0, 1, 0, 2, 1, 3, 0, }));
            dictionary.Add(new Word("dog", new byte[] { 0, 2, 0, 2, 0, 0, 0, 3, }));
            dictionary.Add(new Word("zezao", new byte[] { 0, 0, 0, 0, 0, 3, 0, 0, }));
            dictionary.Add(new Word("is", new byte[] { 0, 1, 0, 0, 0, 0, 0, 0, }));
            dictionary.Add(new Word("hot-dog", new byte[] { 3, 0, 0, 0, 0, 0, 0, 0, }));
            dictionary.Add(new Word("idiot", new byte[] {0, 0, 1, 0, 0, 1, 0, 0, }));
            dictionary.Add(new Word("bonnie", new byte[] { 2, 1, 0, 0, 0, 0, 0, 0, }));

            var sentance = "bonnie is hot-dog";

            var person = new Person(dictionary);

            person.SendMessage(sentance);
        }
    }
}

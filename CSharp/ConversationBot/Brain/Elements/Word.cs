using System.Collections.Generic;
using System.Text;

namespace Brain.Elements
{
    public class Word
    {
        public Word(string word, byte[] meaning)
        {
            this.Text = word;
            this.EmotionList = new List<Emotion>();

            for (int i = 0; i < GlobalVariables.emotions.Length; i++)
            {
                EmotionList.Add(
                    new Emotion()
                    {
                        Name = GlobalVariables.emotions[i].ToLower().Trim(),
                        Score = meaning[i]
                    });
            }
        }

        public IList<Emotion> EmotionList { get; set; }

        public string Text { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Text);

            foreach (var emotion in EmotionList)
            {
                sb.AppendFormat("{0}: {1}", emotion.Name, emotion.Score);
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public override bool Equals(object otherWord)
        {
            if (otherWord is Word)
            {
                return this.Text.Equals((otherWord as Word).Text);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

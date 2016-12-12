using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brain.Elements
{
    class Sentance
    {
        public Sentance(IList<Word> words)
        {
            this.Words = words;
            this.EmotionList = new List<Emotion>();
            this.FeelingsList = new Dictionary<string, int>();

            for (int i = 0; i < GlobalVariables.emotions.Length; i++)
            {
                int score = 0;
                int wordsUsed = 0;
                foreach (var word in words)
                {
                    var wordScore = word.EmotionList[i].Score;
                    if (wordScore != 0)
                    {
                        score += word.EmotionList[i].Score;
                        wordsUsed++;
                    }
                }

                if (wordsUsed == 0)
                {
                    wordsUsed = 1;
                }

                EmotionList.Add(
                    new Emotion()
                    {
                        Name = GlobalVariables.emotions[i].ToLower().Trim(),
                        Score = (byte)(score / wordsUsed)
                    });
            }

            var feels = GlobalVariables.feelings;
            for (int i = 0; i < feels.Length; i++)
            {
                byte leftEmotionScore = 0;
                byte rightEmotionScore = 0;

                if (i != feels.Length - 1)
                {
                    leftEmotionScore = EmotionList.ElementAt(i).Score;
                    rightEmotionScore = EmotionList.ElementAt(i + 1).Score;
                }
                else
                {
                    leftEmotionScore = EmotionList.ElementAt(i).Score;
                    rightEmotionScore = EmotionList.ElementAt(0).Score;
                }

                FeelingsList.Add(feels[i], leftEmotionScore + rightEmotionScore);
            }
        }

        public IList<Emotion> EmotionList { get; set; }

        public Dictionary<string, int> FeelingsList { get; set; }

        public IList<Word> Words { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Emotions in the sentance");


            foreach (var emotion in EmotionList)
            {
                if (emotion.Score != 0)
                {
                    sb.AppendFormat("{1} <- {0}", emotion.Name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[emotion.Score - 1], emotion.Score);
                    sb.AppendLine();
                }
            }

            sb.AppendLine("\nFeelings in the sentance");

            foreach (var feel in FeelingsList)
            {
                if (feel.Value != 0)
                {
                    sb.AppendFormat("{1} <- {0}", feel.Key, feel.Value);
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
}

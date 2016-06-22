using Novacode;
using System.Collections.Generic;
using System.Diagnostics;

namespace DocXManipulator
{
    public class Program
    {
        static void Main()
        {
            // Modify to suit your machine:
            string fileName = @"F:\DocXExample.docx";

            Dictionary<string, string> propartiesDict = new Dictionary<string, string>();
            propartiesDict.Add("[USER_NAME]", "Стефан Николов Петров");
            propartiesDict.Add("[USER_FNUMBER]", "111210045");
            propartiesDict.Add("[USER_ADDRESS]", "гр. Кюстендил, кв. 'Запад', бл. 71, ап.21");
            propartiesDict.Add("[USER_TEL]", "0883332383");
            propartiesDict.Add("[USER_EMAIL]", "steff.kn@abv.bg");
            propartiesDict.Add("[DOC_TITLE]", "Very long title of diploma for making a system that makes diplomas. Amazing");
            propartiesDict.Add("[DOC_TECH]", "list of dechs");
            propartiesDict.Add("[DOC_BEGINDATE]", "01/2016");
            propartiesDict.Add("[DOC_ENDDATA]", "01/2017");

            // Create a document in memory:
            var doc = DocX.Create(fileName);
            doc.ApplyTemplate(@"F:\sp-temp.docx");

            foreach (var prop in propartiesDict)
            {
                doc.ReplaceText(prop.Key, prop.Value);
            }

            // Save to the output directory:
            doc.Save();

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);
        }
    }
}

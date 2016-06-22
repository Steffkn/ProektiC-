using AngleSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ImageDownloader
{
    public class Program
    {
        static void Main()
        {
            var configuration = Configuration.Default.WithDefaultLoader();
            var browsingContext = BrowsingContext.New(configuration);
            var location = @"f:\temp";
            var repo = $"http://www...";

            IList<string> galleries = new List<string>();

            var site = @"http://www...";
            var documentSite = browsingContext.OpenAsync(site).Result;
            var aTags = documentSite.QuerySelectorAll("#gallery-list a");

            foreach (var item in aTags)
            {
                foreach (var attr in item.Attributes)
                {
                    if (attr.Name == "href")
                    {
                        var names = attr.Value.Split('/');
                        galleries.Add(names[1]);
                        break;
                    }
                }
            }

            for (int g = 0; g < galleries.Count; g++)
            {
                var gallery = galleries[g];
                Console.WriteLine("{0} [{1}/{2}]", gallery, g, galleries.Count);
                var file = gallery.Substring(0, gallery.IndexOf('-'));

                Directory.CreateDirectory(string.Format(@"{0}\{1}\{2}", location, file, gallery));

                for (int i = 1; i <= 20; i++)
                {
                    var url = string.Format("{0}{1}/{2}-{3}", repo, gallery, file, i);
                    var document = browsingContext.OpenAsync(url).Result;

                    try
                    {
                        var imageTag = document.QuerySelector(".theCell img").Attributes;

                        foreach (var item in imageTag)
                        {
                            if (item.Name == "src")
                            {
                                Console.WriteLine("Downloading.. {0}", item.Value);
                                using (WebClient client = new WebClient())
                                {
                                    var imgDir = string.Format(@"{0}\{1}\{2}\{3}", location, file, gallery, item.Value.Substring(item.Value.LastIndexOf('/') + 1));
                                    client.DownloadFile(new Uri(item.Value), imgDir);
                                }

                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

        }
    }
}

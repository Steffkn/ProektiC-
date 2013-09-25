using System;
using System.IO;

namespace FindFilesInDIr
{
    class FindFilesInDIr
    {
        static void Main()
        {
            string folderPath = string.Empty;
            string filePath = string.Empty;
            try
            {
                Console.WriteLine("Enter folder/file path");
                Console.Write("Folder: ");
                folderPath = Console.ReadLine();
                Console.Write("\nFile: ");
                filePath = Console.ReadLine();

                DirectoryInfo d = new DirectoryInfo(Environment.CurrentDirectory);
                Console.WriteLine("1");
                string fullFilePath = d + Path.DirectorySeparatorChar.ToString() + folderPath;
                Console.WriteLine("2");
                using (StreamWriter sw = new StreamWriter(fullFilePath + Path.DirectorySeparatorChar.ToString() + filePath))
                {
                    Console.WriteLine("3");
                    foreach (var file in d.GetFiles("*.cfg", SearchOption.AllDirectories))
                    {
                        sw.WriteLine("echo \"{0}\"", file.FullName.Substring(d.FullName.Length));
                        //sw.WriteLine("echo \"{0}\"", file.FullName.Substring(
                        //    file.FullName.LastIndexOf(folderPath)
                        //    ));
                        //Directory.Move(file.FullName, filepath + "\\TextFiles\\" + file.Name);
                    }
                }

            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
                Console.ReadLine();
                return;
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine("File not found: {0}", fileNotFound.FileName);
                Console.ReadLine();
                return;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
                Console.WriteLine("Done: {0}\\{1}", filePath, folderPath);
                Console.ReadLine();
            }
        }
    }
}

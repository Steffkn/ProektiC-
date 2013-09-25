using System;
using System.Windows;

namespace LoLClient
{
    public partial class StartUp : Application
    {
        void StartUp_Startup(object sender, StartupEventArgs e)
        {
            // Application is running 
            // Process command line args 
            bool startMinimized = false;
            for (int i = 0; i != e.Args.Length; ++i)
            {
                if (e.Args[i] == "/StartMinimized")
                {
                    startMinimized = true;
                }
            }

            // Create main application window, starting minimized if specified
            LoLMainWindow mainWindow = new LoLMainWindow();
            if (startMinimized)
            {
                mainWindow.WindowState = WindowState.Minimized;
            }
            mainWindow.Show();
        }
    }
}

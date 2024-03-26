using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUserInterface
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PasswordScreen passwordScreen = new PasswordScreen();
            passwordScreen.ShowDialog();
            string selectedFramework = passwordScreen.Framework;
            string selectedUserName = passwordScreen._userName;
            Form1 form1 = new Form1(selectedFramework, selectedUserName);
            Application.Run(form1);
        }
    }
    
}

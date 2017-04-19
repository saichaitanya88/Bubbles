using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubbles
{
    class Program
    {
        const string NOTES_FILENAME = "notes.txt";

        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory() + "\\" + NOTES_FILENAME;

            Bubbles bubbles = new Bubbles(path);
            Application.ApplicationExit += bubbles.Application_ApplicationExit;
            bubbles.Start();
            Application.Run();
        }
    }
}
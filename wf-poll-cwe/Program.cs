using System;
using System.Windows.Forms;

namespace wf_poll_cwe
{
    static class Program
    {
        //The entry point for the application.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PollForm());
        }
    }
}


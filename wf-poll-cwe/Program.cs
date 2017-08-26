using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using wf_poll;

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


            //Configure basic data
            PollData config = new PollData(new List<string>() {"Iron Man, Captain America"});


            Application.Run(new PollForm());
        }
    }
}


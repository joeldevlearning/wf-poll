using System;
using System.Collections.Generic;
using System.Configuration;
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


            //Step 1, create model with basic data
            IPollModel model = new PollModel(new List<string>() {"Iron Man, Captain America"});

            //Step 2, create poller, inject model
            IPoller poller = new Poller(model);

            //Step 3, create viewmodel, inject poller and model
            //poller is for actions, model is for reading
            IPollViewModel viewModel = new PollViewModel(poller, model);

            //when ready, remove the view's dependency on poller
            //ALL view interaction should happen through viewmodel
            //PollForm should ONLY see viewmodel
            Application.Run(new PollForm(poller, viewModel));
        }
    }
}


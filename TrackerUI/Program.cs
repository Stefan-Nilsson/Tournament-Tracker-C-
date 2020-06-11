using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        // once the static void main method is done, the application closes.
        static void Main()
        {
            // the first two lines say, just do what microsoft has set up
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // dont end this line, untill this instance closes (tournamentdashboardform)
            // this means that if you close the dasboardform the application will close.

            // Initialize the database connections
            // add reference to your library while your in your form
            // by right clicking references and add reference and select the TrackerLibrary checkbox
            // Now everyone can use this information

            // this wires up which database we are going to talk to
            // In this case we're connected to both SQL and the text file
            TrackerLibrary.GlobalConfig.InitializeConnections(true, true);

            Application.Run(new CreatePrizeForm());

            // Application.Run(new TournamentDashboardForm());
        }
    }
}

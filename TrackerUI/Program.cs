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
            Application.Run(new TournamentDashboardForm());
        }
    }
}

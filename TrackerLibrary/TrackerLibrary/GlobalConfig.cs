using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    // Public static class == not a blueprint, it's the actual house and everyone uses the same house
    // Normally we wouldn't put any data in here.
    public static class GlobalConfig
        // private set == only methods inside of this GlobalConfig class can change the value of Connections
        // but everyone can read it
        // We use a List so we can add one or more datasources to save to and pull from
        // 
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        // this will hold anything that implements the IDataConnection contract
        // this method will be called on the startup of the application to say: these are the connections I want you to set up
        // keep in mind potential updates or changes in the future
        public static void InitializeConnections(bool database, bool textFiles)
        {
            // Two seperate ifs because in an else if the text files would never also be added if the first SQL if would be true
            if (database)
            {
                // here we add SqlConnector, the classtype, as sql an instance, to the Connections list
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create the Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}

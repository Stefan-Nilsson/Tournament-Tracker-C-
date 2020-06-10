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
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        // this method will be called on the startup of the application to say: these are the connections I want you to set up
        // keep in mind potential updates or changes in the future
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Set up the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create the Text Connection
            }
        }
    }
}

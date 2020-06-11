using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    // interface for all kinds of connections, could be SQL, Text or even if we later down the road want to add a MYSQL connection
    // we will specify what methods properties etc will be in here
    public interface IDataConnection
    {
        // contract for a method, ends with semicolons instead of curly braces
        // we can't put code in the interface
        PrizeModel CreatePrize(PrizeModel model);
    }
}

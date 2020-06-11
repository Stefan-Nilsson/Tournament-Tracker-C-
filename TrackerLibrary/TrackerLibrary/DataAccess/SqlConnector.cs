using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

//@PlaceNumber int,
//@PlaceName nvarchar(50),
//@PrizeAmount money,
//@PrizePercentage float,
//@id int = 0 output

namespace TrackerLibrary.DataAccess
{
    // when there's a  suggestion you can select the text and press ctrl + .
    // then I chose 
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // really safe way to connect to your database, in such a way that it doesn't leave connections open
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {

                var p = new DynamicParameters();
                // Creating a list of parameters and adding them all to p
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);

                // this one goes in another direction, it goes out not in (this is an output variable)
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                // this code will execute the stored procedure you can see above,
                // pass in all that information and then
                // get back information
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                // will look at the dynamic parameters list called p
                // will find this particular parameter @id
                // it will say give me the value of this, and it's of type int
                // therefore we can put it directly into the id because the id is also of type int
                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}

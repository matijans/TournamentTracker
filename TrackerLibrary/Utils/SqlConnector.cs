using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Interfaces;

namespace TrackerLibrary.Utils
{
    public class SqlConnector : IDataConnection
    {
        //TODO - Make to save to DB
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}

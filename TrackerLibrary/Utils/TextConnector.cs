using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Interfaces;

namespace TrackerLibrary.Utils
{
    public class TextConnector : IDataConnection
    {
        //TODO - Make to save to text file
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}

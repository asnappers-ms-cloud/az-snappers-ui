using azure_snappers_sal.Model;
using azure_snappers_sal.Sal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azure_snappers_sal.Controller
{
    internal class DataManager
    {
        internal HouseDetails GetHouseDetails()
        {
            IDataProvider mgr = new ServiceDataProvider();
            return mgr.GetDetails();
        }

    }
}

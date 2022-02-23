using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using azure_snappers_sal.Controller;
using azure_snappers_sal.Model;

namespace azure_snappers_sal
{
    public class ServiceAccess
    {
        public HouseDetails GetHouseDetails()
        {
            DataManager dm = new DataManager();
            var result= dm.GetHouseDetails();
            return result;
        }
    }
}

using azure_snappers_sal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azure_snappers_sal.Controller
{
    public interface IDataProvider
    {
        HouseDetails GetDetails();
    }
}

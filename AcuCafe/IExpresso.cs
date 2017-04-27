using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    interface IExpresso : IDrink
    {
        bool HasChocTopping { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{
    public interface IDrink
    {
        // The abstract skeleton all drinks are based on
        bool HasMilk { get; set; }
        bool HasSugar { get; set; }
        string Description { get; }
        string Message { get; set; }

        double Cost();
        void Prepare();
    }
}

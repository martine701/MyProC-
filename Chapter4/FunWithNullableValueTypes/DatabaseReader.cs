using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithNullableValueTypes
{
    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;

        //note the nullable return type
        public int? GetIntFromDatabase()
        { return numericValue; }

        //note the nullable return type
        public bool? GetBoolFromDatabase()
        { return boolValue; }

    }
}

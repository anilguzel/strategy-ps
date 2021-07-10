using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Core
{
    public class Enums
    {
        public enum Gender : short
        {
            Male = 0,
            Female = 1
        }

        public enum DocumentType : short
        {
            Passaport = 0,
            Visa = 1,
            TravelDocument = 2
        }

        public enum Country : short
        {
            USA = 0,
            UK = 1
        }

        public enum Scenario : short
        {
            Offline = 0,
            Online = 1
        }
    }
}

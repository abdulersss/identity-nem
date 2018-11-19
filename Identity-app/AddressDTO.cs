using System;
using System.Collections.Generic;
using System.Text;

namespace Identity_app
{
    class AddressDTO
    {
        public string Line1;
        public string Line2;
        public int BrgyID;
        public int CityID;
        public int ProvinceID;
        public int RegionID;


        public AddressDTO(string line1, string line2, int brgyID, int cityID, int provinceID, int regionID)
        {
            Line1 = line1;
            Line2 = line2;
            BrgyID = brgyID;
            CityID = cityID;
            ProvinceID = provinceID;
            RegionID = regionID;
        }
    }
}

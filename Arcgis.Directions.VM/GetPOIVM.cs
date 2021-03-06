﻿using Arcgis.Directions.Data.Model;
using System.Collections.Generic;

namespace Arcgis.Directions.VM
{
    public class GetPOIVM : ViewModelBase
    {
        public List<CusPoi> CusPoiList { get; set; }
        public CusPoi CusPoi { get; set; }
        public CusPoiInput CusPoiInput { get; set; }
        public List<Application> Applications { get; set; }

        public int PoiID { get; set; }
        public string PoiName { get; set; }
        public string PoiDesc { get; set; }
    }
}
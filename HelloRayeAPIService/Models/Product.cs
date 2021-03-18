using System.Collections.Generic;

namespace HelloRayeAPIService.Models
{
    public class Product
    {
        public string productName { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string designer { get; set; }
        public string category { get; set; }
        public string subCategory { get; set; }
        public string price { get; set; }
        public string isQuickShip { get; set; }
        public string fromWeeks { get; set; }
        public string toWeeks { get; set; }
        public string grade { get; set; }
        public string skuNumber { get; set; }
        public string warranty { get; set; }
        public string isCustomized { get; set; }
        public string customizedDetails { get; set; }
        public string marketSector { get; set; }
        public string dimensions { get; set; }
        public string keywords { get; set; }
        public string productStyle { get; set; }
        public string productMaterialKeyWords { get; set; }
        public string socialDistanceAppropriate { get; set; }
        public string workFromHome { get; set; }
        public string bespokeORCustom { get; set; }
        public string rentalOrTemporary { get; set; }
        public string certifications { get; set; }
        public string performances { get; set; }
        public List<Asset> assets { get; set; }
    }

    public class Asset
    {
        public string photo { get; set; }
        public string model3D { get; set; }
        public string productSheet { get; set; }
    }
}

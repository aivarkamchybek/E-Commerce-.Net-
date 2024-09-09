using System.Collections.Generic;

namespace MarketPlaceProject.ViewModels
{
    public class ProductVM
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategoryVM SubCategory { get; set; }
        public virtual ICollection<ADVM> AttributeDetails { get; set; }
    }
}
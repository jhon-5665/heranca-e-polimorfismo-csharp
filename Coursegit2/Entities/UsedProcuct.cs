using Microsoft.VisualBasic;
using System;
using System.Globalization;
namespace Coursegit2.Entities
{
    class UsedProcuct : Product
    {
        public DateTime ManufactureDate { get; set; }
        
        public UsedProcuct()
        {
        }

        public UsedProcuct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            return Name 
                + " (used) $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: " 
                + ManufactureDate.ToString("dd/MM/yyy") 
                + ")";
        }
    }
}

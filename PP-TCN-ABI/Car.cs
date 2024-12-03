using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_TCN_ABI
{
    internal class Car
    {
        public string brand {  get; set; }
        public string brandName { get; set; }
        public int yearModel { get; set; }
        public int km { get; set; }
        public string regNr { get; set; }
        public int price { get; set; }


        public Car(string Brand, string BrandName, int year, int Km, string RegNr) {
            
            brand = Brand;
            brandName = BrandName;
            yearModel = year;
            km= Km;
            regNr = RegNr;
            price = price;
        
        }





    }
}

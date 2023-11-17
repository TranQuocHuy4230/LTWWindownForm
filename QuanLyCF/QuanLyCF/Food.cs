using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class Food
    {
        public int idFood { get; set; }
        public string name { get; set; }
        public int idCategory { get; set; }
        public float price { get; set; }
        public Food(int id,string Name,int Idcate,float Pricee)
        {
            this.idFood = id;
            this.name = Name;
            this.idCategory = Idcate;
            this.price = Pricee;
        }
    }
}

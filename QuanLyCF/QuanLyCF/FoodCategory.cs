using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCF
{
    class FoodCategory
    {
        public int idCategory { get; set; }
        public string name { get; set; }
        public FoodCategory()
        {

        }
        public FoodCategory(int id, string Name)
        {
            this.idCategory = id;
            this.name = Name;
        }
    }
}

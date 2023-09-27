using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_03
{
    class Person
    {
         public string CMND { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public Person() { }
        public Person(string cmnd, string hoten, string dc)
        {
            this.CMND = cmnd;
            this.HoTen = hoten;
            this.DiaChi = dc;
        }
    }
}

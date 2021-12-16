using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;

namespace Muresan_Denisa_Lab10.Models
{
    class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }

        [OneToMany]
        public List<ListProduct> ListProducts { get; set; }
    }
}

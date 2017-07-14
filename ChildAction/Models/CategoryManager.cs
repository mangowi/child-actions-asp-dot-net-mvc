using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildAction.Models
{
    public class CategoryManager
    {
        public static List<Category> GetCategories()
        {
            List<Category> categories = new List<Category> {
                new Category {Name="Kwanza" },
                new Category {Name="Mbili" },
                new Category {Name="Tatu" },
            };


            return categories; 
        }
    }
}
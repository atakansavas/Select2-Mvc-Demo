using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Select2_Mvc_Sample.Data
{
    public static class Utility
    {
        public static List<Select2Item> GetItems()
        {
            var itemList = new List<Select2Item>();
            for (int i = 0; i < 1000; i++)
            {
                itemList.Add(
                    new Select2Item()
                    {
                        Id = i,
                        FirstName = "First " + i.ToString(),
                        LastName = "Last " + i.ToString()
                    }
                );
            }

            return itemList;
        }
    }

    public class Select2Item
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
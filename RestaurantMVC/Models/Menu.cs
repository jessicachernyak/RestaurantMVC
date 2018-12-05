using System;
namespace RestaurantMVC.Models
{
    public class Menu
    {
        public DateTime LastUpdate;
    }

    public class menuItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public menuItem(int ID, string name, decimal price, string description, string category)
        {
            this.ID = ID;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
        }
    }
}
using System;
namespace Menu1
{
    public class MenuItem
    {
        private string ItemName;

        private double ItemPrice;

        private string ItemDescrip;

        private string ItemCategory;



        public MenuItem(string name, double price, string descrip, string category)
        {
            this.ItemName = name;
            this.ItemPrice = price;
            this.ItemDescrip = descrip;
            this.ItemCategory = category;

        }
        public void PrintMenuItem()
        {
            Console.WriteLine($"{ItemCategory}");
            Console.WriteLine($"{ItemName}      {ItemPrice}");
            Console.WriteLine($"{ItemDescrip}");
        }
    }
        
}
    


using System;

namespace Menu1
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuItem breadsticks = new MenuItem("Bread Sticks", 3.99, "Bread sticks" +
                " with butter and garlic.", "Appetizer");
            breadsticks.PrintMenuItem();
            MenuItem chips = new MenuItem("Chips and Dip ", 4.99, "Chips" +
                " with mild salsa.", "Appetizer");
            chips.PrintMenuItem();
            MenuItem wings = new MenuItem("Wings", 5.99, "Buffalo Wings" +
                " with celery and ranch.", "Appetizer");
            wings.PrintMenuItem();
            MenuItem steak = new MenuItem("Steak", 15.99, "Porter Steak" +
                " with spicy A1 Sauce.", "Main");
            steak.PrintMenuItem();
            MenuItem burger = new MenuItem("Burger", 18.99, "Double Cheeseburger" +
                " with Lettuce and Sauce.", "Main");
            burger.PrintMenuItem();
            MenuItem pizza = new MenuItem("Pizza", 13.99, "Personal Pan Pizza" +
                " garlic bread.", "Main");
            pizza.PrintMenuItem();

            Menu update = new Menu();
            update.PrintMenuUpdate = new DateTime(2021, 6, 15);
            Console.WriteLine(update.Age);
        }
    }
}

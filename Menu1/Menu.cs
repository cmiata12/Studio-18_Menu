using System;
namespace Menu1
{
    public class Menu
    {
        public Menu()
        {

        }
       // public void PrintMenuUpdate
        // {
        //Menu MenuDate = new MenuDate();

        //Console.WriteLine("This menu was last updated " + DateTime.Today);
        // }
        public DateTime PrintMenuUpdate { get; set; }

        public int Age//menu age is what?
        {
            get
            {
                var LastUpdated = DateTime.Today - PrintMenuUpdate;
                var days = LastUpdated.Days / 7;
                return LastUpdated; 
            }
        }
    }
}

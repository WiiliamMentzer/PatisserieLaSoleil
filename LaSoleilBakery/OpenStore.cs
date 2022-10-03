using System.Collections.Generic;
using System;
using Bakery.Models;

public class OpenStore
{
 public static void Main()
 {
    Console.WriteLine("Welcome to Patisserie La Soleil");
    Console.WriteLine("---------------");
    Console.WriteLine("The current price of Sourdough is 5$ each loaf. For every 3 loaves you buy you will get 1 loaf free.");
    Console.WriteLine("The current price of Danishes are 2$ each danish. For every 3 danishes you buy you will get 1 danish for 1$.");
    Console.WriteLine("---------------");
    Console.WriteLine("Would you like to buy sourdough, danishes, or both? (Please enter in one of the options)");
    string stringBakerySelection = Console.ReadLine().ToLower();
    Console.WriteLine("------------------------------------------------");

    if (stringBakerySelection == "both") {
      Console.WriteLine("Please enter the ammount of Sourdough loaves you would wish to purchase.");
      int sourdoughQuantity = int.Parse(Console.ReadLine());
      Bread Sourdough = new Bread (5, sourdoughQuantity);
      Sourdough.breadDiscount();

      Console.WriteLine("Please enter the ammount of Danishes you would wish to purchase.");
      int danishQuantity = int.Parse(Console.ReadLine());
      Pastry Danish = new Pastry (2, danishQuantity);
      Danish.pastryDiscount();

      int bothPostDiscount = Danish.PastryTotalCost + Sourdough.BreadTotalCost;

      Console.WriteLine("The total cost for the danishes and loaves is " + "$" + bothPostDiscount + ".");

    } else if (stringBakerySelection == "sourdough") {
      Console.WriteLine("Please enter the ammount of Sourdough loaves you would wish to purchase.");
      int sourdoughQuantity = int.Parse(Console.ReadLine());
      Bread Sourdough = new Bread (5, sourdoughQuantity);
      Sourdough.breadDiscount();

      Console.WriteLine("The total cost for the danishes and loaves is " + "$" + Sourdough.BreadTotalCost + ".");

    } else if (stringBakerySelection == "danishes") {
      Console.WriteLine("Please enter the ammount of Sourdough loaves you would wish to purchase.");
      int danishQuantity = int.Parse(Console.ReadLine());
      Pastry Danish = new Pastry (2, danishQuantity);
      Danish.pastryDiscount();

      Console.WriteLine("The total cost for the danishes and loaves is " + "$" + Danish.PastryTotalCost + ".");

    } else {
      Console.Clear();
      Console.WriteLine("Error: You did not properly enter a value!");
      Console.WriteLine("---------------");
      Main();
    }
 }
}

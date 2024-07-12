using System;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Generic;


public class Resturant
{
    public int IDlist = 4;
    List<Menu> menuitems = new List<Menu> {

        new Menu{ ID=1, Name="Mansaf", Ingredients="A traditional Jordanian dish made of meat, dried yougurt balls, and rice sprinkled with glden fried almond pieces" },
        new Menu{ ID=2, Name="Shawerma", Ingredients="A Delish staple dish in the Jordanian kitchen made of chicken or meat, placed in a sandwich with garlic sauce and pickles. Usually served with potatoes"},
        new Menu{ ID=3, Name="Ma'aloubeh", Ingredients="A traditional Palestinian dish made of rice and eggplants or cauliflower made with chicken or meat" },
        new Menu{ ID=4, Name="Tabouleh", Ingredients="A lebanese salad made of parsley with bourgoul tomatoes and onion all chopped to tiny pieces with lemons and virgin olive oil" }
    };




    public Resturant()
	{

        Console.WriteLine("Please choose an action:");
        Console.WriteLine("Choose No. #1 to display Menu");
        Console.WriteLine("Choose No. #2 to add items");
        Console.WriteLine("Choose No. #3 to search for item");

        int x =int.Parse(Console.ReadLine());
        switch (x)
        {
            case 1:
                DisplayMenu();
                break;
            case 2:
                AddMenuItems();
                break;
            case 3: 
                Finditem();
                break;
            default:
                break;
        }


    }

    public void DisplayMenu()
    {
        Console.WriteLine("/////////////////////////////////////////////////////////////////");
        Console.WriteLine("///Item No.////item////////////////////////////////////////");
        Console.WriteLine("/////////////////////////////////////////////////////////////////");
        foreach (var menu in menuitems)
        { Console.WriteLine($"///{menu.ID}///{menu.Name}//////////////////////////////////////////////////////"); }
        Console.WriteLine("Please insert no. of item you wish to see its ingredients");
        int x =int.Parse(Console.ReadLine());
        foreach (var men1 in menuitems)
        { if (men1.ID == x)
                Console.WriteLine($"your plate {men1.Name}'s ingredients are {men1.Ingredients}");
        }
        Console.ReadLine();



    }


    public void AddMenuItems()
    {
        IDlist = IDlist+1;
        Console.WriteLine("Please enter your dish name");
        string y = Console.ReadLine();
        Console.WriteLine("Please enter your dish ingredients");
        string z = Console.ReadLine();
        menuitems.Add(new Menu { ID = IDlist, Name = y, Ingredients = z }); ;

        foreach (var menu in menuitems)
        { Console.WriteLine($"///{menu.ID}///{menu.Name}//////////////////////////////////////////////////////"); }

    }

    public void Finditem()
    {

        Console.WriteLine("please enter the dish name you are looking for");
        string CheckString = Console.ReadLine();
        foreach (var i in menuitems)
        {
            
            
            bool result = (i.Name).Contains(CheckString);
            if (result)
            { Console.WriteLine($"your item is {i.Name} with ID of {i.ID}"); }

        }



    }

}

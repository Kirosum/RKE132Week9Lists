string folderPath = @"C:\Users\rasmu\Downloads\data";
string fileName = "shopping.list.txt";
string filePath= Path.Combine(folderPath, fileName);
List<string> myShoppinglist = new List<string>();   

if (File.Exists(filePath))
{
    myShoppinglist = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppinglist);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppinglist = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppinglist);
}




static List<string> GetItemsFromUser()
{
    List<string> userlist = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userlist.Add(userItem);

        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }

    }
    return userlist;
}


static void ShowItemsFromList(List<string> somelist)
{ 
    Console.Clear();

    int listLength = somelist.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
    foreach (string item in somelist)
    {
    Console.WriteLine($"{i}. {item}");
    i++;
    }
}
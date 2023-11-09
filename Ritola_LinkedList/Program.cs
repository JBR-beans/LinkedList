namespace Ritola_LinkedList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LinkedList MyList = new LinkedList();

			while (true)
			{
				Console.WriteLine("Menu:");
				Console.WriteLine("1. Add Item");
				Console.WriteLine("2. Remove Item");
				Console.WriteLine("3. Search for Item");
				Console.WriteLine("4. Print");
				Console.WriteLine("5. Exit");

				int choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.Write("Enter name to add: ");
						string nameToAdd = Console.ReadLine();
						MyList.Add(nameToAdd);
						break;
					case 2:
						Console.Write("Enter name to remove: ");
						string nameToRemove = Console.ReadLine();
						bool removed = MyList.Remove(nameToRemove);
						Console.WriteLine(removed ? "Name removed successfully." : "Name not found.");
						break;
					case 3:
						Console.Write("Enter name to search: ");
						string nameToSearch = Console.ReadLine();
						bool contains = MyList.Contains(nameToSearch);
						Console.WriteLine(contains ? "Name found." : "Name not found.");
						break;
					case 4:
						Console.WriteLine("Printing all nodes:");
						MyList.PrintAllNodes();
						break;
					case 5:
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}
	}
}
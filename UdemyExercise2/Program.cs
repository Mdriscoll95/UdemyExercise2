namespace UdemyExercise2;

class Program
{
    static void Main(string[] args)
    {
        //enter string here
        Console.Write("enter string here: ");

        //read first input string
        string input = Console.ReadLine();
        //read the character input to search
        char searchInput = Console.ReadLine()[0];
        //get index pf the character of the string
        int searchIndex = input.IndexOf(searchInput);
        //prints index as a result on console
        Console.WriteLine("index of character {0} in string is {1}", searchInput, searchIndex);

        Console.Write("get first name of the user: ");
        //read first name
        string firstName = Console.ReadLine();

        Console.Write("Get Last Name of user: ");
        //read last name
        string lastName = Console.ReadLine();

        //concatinate the first and last name
        string fullName = string.Concat(firstName, " ", lastName);
        Console.ReadKey();


    }
}


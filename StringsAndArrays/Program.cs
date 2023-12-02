namespace StringsAndArrays
{
    class Program
    {
        // INSTRUCTIONS: Write you task related code answers under each specific comment/insturction
        static void Main(string[] args)
        {
            // PART 1: Strings

            // 1. Basic String Operations
            string helloWorld = "Hello, World!";

            // 1.1 Print the length of the string.
            Console.WriteLine("Length of string: "+helloWorld.Length);

            // 1.2 Print the first and the last character of the string.
            Console.WriteLine("First character: " + helloWorld[0]+". Last character: " + helloWorld[helloWorld.Length-1]);

            // 2. String Manipulation

            Console.Write("Please enter your name: ");
            // 2.1 Get the input from and assing it into new string variable called name
            string name = Console.ReadLine();

            // 2.2 Print a personalized welcome message including the name.
            Console.WriteLine("Welcome dear "+name);

            // 2.3 Convert name variable to uppercase and output the result
            Console.WriteLine("Name to uppercawse "+name.ToUpper());

            // 2.4 Convert name variable to lovercase and output the result
            Console.WriteLine("Name to lowercase " + name.ToLower());

            // 3. String Searching
            // 3.1 Create new boolean variable called containsWorld
            bool containsWorld=false;

            // 3.2 Check that the helloWorld variable contains the word "World".
            //     Assign the result to the created constainsWorld variable

            if (helloWorld.Contains("World")) containsWorld = true;

            // 3.3 If the word is found, get the index of the word from helloWorld string
            Console.WriteLine($"Word is found = {containsWorld}");
            if (containsWorld == true)
                Console.WriteLine($"Index of word: {helloWorld.IndexOf("World")}");

            // PART 2: Arrays

            // 1. Basic Array Operations
            // 1.1 initialize array called numbers containing array of int values
            //     Add these values to the array -> 2 3 5 7 11
            int[] numbers = { 2, 3, 5, 7, 11 };

            // 1.2 Output the numbers array -> hint use Join
            // Expected outcome: 2, 3, 5, 7, 11
            Console.Write("Array elements: ");
            foreach (int number in numbers)
                Console.Write($"{number}, ");
            Console.WriteLine();

            // 1.3 Output the value of the third (3th) item in the numbers array 
            // Expected outcome: 5
            Console.WriteLine($"Third element of array: {numbers[2]}");


            // 2. Array Manipulation
            Console.WriteLine("Please enter five names:");
            // 2.1 Initialize new names string array variable that has room for 5 items
            //     The maximum lenght of the string array should be 5
            string[] names = new string[5];

            // 2.2 Ask the user to input new names 5 times
            //     and assing each name to the names string array in the given order.
            //     The first name should be at index 0
            //     Hint: you might want to use some sort of a loop here
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Input the {i+1} name: ");
                names[i] = Console.ReadLine();
            }

            // 2.3 Output the array of given names.
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            // 2.4 Reverse the order of the items in the names array and outpu the result
            Array.Reverse(names);
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            // 3. Array Searching
            Console.Write("Please enter a name to search: ");
            string searchName = Console.ReadLine();
            // 3.1 Try to find out the searchName from the Task 2 names string array
            //     by finding out it's index.
            //     Assign the index value to new position integer variable
            Array.Reverse(names);
            int position = -1;
            if (names.Contains(searchName))
                position = Array.IndexOf(names, searchName);

            // 3.2 Check that the index position was found
            //     Hint: What is the result of IndexOf if nothing is found
            // 3.2.1 If position is found output the searchName and the found position
            // 3.2.2 Else output that the searchName was not found
            if (position != -1)
            {
                Console.WriteLine($"Name is {searchName}. Position is: {position}");
            }
            else
                Console.WriteLine("Name is not found");

            // 4. BONUS

            // 1. String to Array
            // 1.1 Create new empty words string array
            string[] words;

            // 1.2 Try to get each word from the helloWorld variable and assing the values to
            //     the created words string array
            words = helloWorld.Split(' ','!',',');
            words = words.Where(x => x != "").ToArray();

            // 1.3 Output the values of the words array
            foreach (var item in words)
            {
                Console.WriteLine($"Element - {item}, index - {Array.IndexOf(words,item)}");
            }

            Console.ReadLine();
        }
    }
}

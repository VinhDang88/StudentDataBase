string[] name = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
string[] hometown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };
string[] favoriteFood = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "tacos", "Pasta", "Pounded Yam" };
int index = 0;
bool runProgram = true;

while (runProgram)
{

    Console.WriteLine("Pick a student you'd like to learn about. Enter 1-17");
    int choice = int.Parse(Console.ReadLine());

    index = choice - 1;
    // Console.WriteLine(index); index will always be -1   
    //Console.WriteLine(name.Length);
    //Console.WriteLine(index);

    if (index >= name.Length || index < 0)
    {
        Console.WriteLine("Number not found.");
        continue;
    }


    Console.WriteLine($"Student {choice} is {name[index]}. What would you like to know? Enter 'hometown' or 'favorite food':");


    string choice2 = Console.ReadLine().ToLower();

    if (choice2.Contains("home"))
    {
        Console.WriteLine($" {name[index]} is from {hometown[index]}");
    }

    else if (choice2.Contains("food"))
    {
        Console.WriteLine($"{name[index]} likes {favoriteFood[index]}");
    }

    else
    {
        Console.WriteLine("Try again. Enter hometown or favorite food");
    }



    Console.WriteLine("Would you like to continue? y/n");
    string loopChoice = Console.ReadLine();
    if (loopChoice.ToLower().Trim() == "y")
    {
        //doesn't do anything yet
    }
    else if (loopChoice.ToLower().Trim() == "n")
    {
        runProgram = false;
    }

}



Console.WriteLine("Would you like to see a list of all the students? Type in 'k'.");
string choice3 = Console.ReadLine();
if (choice3 == "k")
{
   foreach(string n in name)
        Console.WriteLine(n);

} 
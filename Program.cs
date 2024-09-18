


bool playAgain = true;
string? userName;
DateTime wakeUpTime;
string breakLine = "---------------------------------------------------------";

Console.Clear();
Console.WriteLine(breakLine);
Console.WriteLine("Today we are going to be asking some questions.");
Console.WriteLine("When prompted please provide your name and then the time you woke up this morning.");
Console.WriteLine(breakLine);


while (playAgain)
{
    Console.WriteLine("So, what's your name?");

    static bool trueName(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }
        foreach (char b in input)
        {
            if (!char.IsLetter(b) && b != ' ')
            {
                return false;
            }
        }
        return true;
    }
    while (true)
    {
        Console.WriteLine("Please enter your name using only letters.");
        userName = Console.ReadLine();

        if (trueName(userName))
        {
            Console.Clear();
            Console.WriteLine($"Nice to meet you {userName}.");
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please only use letters the alphabet");
            // break;
        }
    }

    // updated time validation
    while (true)
    {
        Console.WriteLine("Enter the time you woke up (in 24-hour format, e.g., 07:30):");
        string userNum = Console.ReadLine()!;

        if (DateTime.TryParseExact(userNum, "HH:mm", null, System.Globalization.DateTimeStyles.None, out  wakeUpTime))
        {
            Console.Clear();
            // Console.WriteLine($"You woke up at: {wakeUpTime.ToString("h:mm tt")}");
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid format. Try using 24 hour format");
        }

    }


    Console.WriteLine(breakLine);
    Console.WriteLine($"Nice to meet you {userName}. {wakeUpTime.ToString("h:mm tt")} seems a bit early to me.");
    Console.WriteLine(breakLine);

    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("Type 'yes' to play again or 'no' to exit");
    // string? userInput = Console.ReadLine();
    // userInput = userInput?.ToLower();
    // if (userInput == "yes")
    // {
    //     Console.WriteLine("Here we go again!!!");
    // }
    // else
    // {
    //     playAgain = false;
    //     Console.WriteLine("Til next time.");
    // }
    bool yesNo = true;
    
    while(yesNo == true){
        string userPlay = Console.ReadLine()!.Trim().ToLower();
        if(userPlay == "yes" || userPlay == "y"){
            Console.WriteLine("Let's go again!");
            yesNo = false;
        }else if(userPlay == "no" || userPlay == "n"){
            Console.WriteLine("See you next time.");
            yesNo = false;
            playAgain = false;
        }else{
            Console.Clear();
            Console.WriteLine("That was not a yes or no. Try again.");
        }
    }


}

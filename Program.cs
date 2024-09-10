


bool playAgain =true;
string? userName;
int userNum;
string breakLine = "---------------------------------------------------------";

Console.Clear();
Console.WriteLine(breakLine);
Console.WriteLine("Today we are going to be asking some questions.");
Console.WriteLine("When prompted please provide your name and then the time you woke up this morning.");
Console.WriteLine(breakLine);


while(playAgain){
    Console.WriteLine("So, what's your name?");
    
    static bool trueName(string? input){
        if(string.IsNullOrEmpty(input)){
            return false;
        }
        foreach(char b in input){
            if(!char.IsLetter(b) && b != ' '){
                return false;
            }
        }
        return true;
    }
    while(true){
        Console.WriteLine("Please enter your name using only letters.");
        userName = Console.ReadLine();

        if(trueName(userName)){
            Console.Clear();
            Console.WriteLine($"Nice to meet you {userName}.");
            break;
        }else{
            Console.Clear();
            Console.WriteLine("Please only use letters the alphabet");
            // break;
        }
    }
    Console.WriteLine(breakLine);
    Console.WriteLine("Now, what time did you wake up today?");
    Console.WriteLine("Please only use military time format.");
    Console.WriteLine("Example: 0100 = 1:00am, 2300 = 11:00pm");
    Console.WriteLine(breakLine);
    bool succcess = Int32.TryParse(Console.ReadLine(), out userNum);    
    while(true){
        if(!succcess){
            Console.Clear();
            Console.WriteLine("That is not a number or the proper format.");
            Console.WriteLine("Please only use 1200 or 0930 format.");
            succcess = int.TryParse(Console.ReadLine(), out userNum);
        }else{
            Console.Clear();
            Console.WriteLine($"So you woke up at {userNum}.");
            break;
        }

    }
   
    Console.Clear();
    Console.WriteLine(breakLine);
    Console.WriteLine($"Nice to meet you {userName}. {userNum} seems a bit early to me.");
    Console.WriteLine(breakLine);

    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("Type 'yes' to play again or hit any key to exit");
    string? userInput = Console.ReadLine();
    userInput = userInput?.ToLower();

    if(userInput == "yes"){
        Console.WriteLine("Here we go again!!!");
    }else{
        playAgain = false;
        Console.WriteLine("Til next time.");
    }
    


}

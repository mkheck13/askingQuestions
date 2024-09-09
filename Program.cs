
Console.Clear();

bool playAgain =true;
string? userName;
int userNum;


Console.WriteLine("Today we are going to be asking some questions.");
Console.WriteLine("When prompted please provide your name and then the time you woke up this morning.");

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
            Console.WriteLine($"Nice to meet you {userName}.");
            break;
        }else{
            Console.WriteLine("Please only use letters the alphabet");
            // break;
        }
    }
    Console.WriteLine("Now, what time did you wake up today?");
    Console.WriteLine("Please only use 1200 or 930 format.");
    bool succcess = Int32.TryParse(Console.ReadLine(), out userNum);    
    while(true){
        if(!succcess){
            Console.WriteLine("That is not a number or the proper format.");
            Console.WriteLine("Please only use 1200 or 930 format.");
            succcess = int.TryParse(Console.ReadLine(), out userNum);
        }else{
            Console.WriteLine($"So you woke up at {userNum}.");
            break;
        }

    }
    string? userAnswer;
    Console.WriteLine("AM or PM?");
    static bool amOrPm(string? input){
        if(string.IsNullOrEmpty(input)){
            return false;
        }
        foreach(char b in input){
            if(!char.IsLetter(b) && b != ' '){
                return false;
            }
        }
        return true;
    while(true){

    }

















    // Console.WriteLine("AM or PM?");
    // string? userAnswer = Console.ReadLine();
    // userAnswer = userAnswer?.ToUpper();
    // while(true){
    //     if(userAnswer == "AM"){
    //         Console.WriteLine("Nice.");
    //         break;
    //     }
    //     if(userAnswer == "PM"){
    //         Console.WriteLine("Sweet.");
    //         break;
    //     }else{
    //         Console.WriteLine("Let's stick with the AM / PM format please.");
    //     }
    // }
    Console.Clear();
    Console.WriteLine($"Nice to meet you {userName}. {userNum}{userAnswer} seems a bit early to me.");


}
}
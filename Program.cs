//Kenneth Fujimura
//10-18-2022
//Mini Challenge # 4 - Greater Than Or Less Than
//Console program greets the user, asks for input of two different numbers, proceses those string values into intergers, ...
//...compares which value is larger, and then reports that information to the user.
//Peer Review by:

Console.Clear();
Console.WriteLine("Welcome! This program compare two numbers of your choice and determine if they are greater than, less than, or equal to each other.");

bool playAgain = true;

//play again loop
while (playAgain == true) {
    //declaring variables for various functions
    bool isConverted1 = false;
    int intNum1 = 0;

    bool isConverted2 = false;
    int intNum2 = 0;

    //taking first number input, with data validation
    Console.Write("\nOn the keyboard, please input one number: ");
    while (!isConverted1) {
        string stringNum = Console.ReadLine();
        bool isNumber = Int32.TryParse(stringNum, out intNum1);

        if (isNumber == true){
            isConverted1 = true;
        } else {
            Console.Write("\nInvalid entry. Please enter a whole number or 'Integer': ");
        }
    }

    //taking second number input, with data validation
    Console.Write("\nGreat! Now, please input the second number: ");
    while (!isConverted2) {
        string stringNum = Console.ReadLine();
        bool isNumber = Int32.TryParse(stringNum, out intNum2);

        if (isNumber == true){
            isConverted2 = true;
        } else {
            Console.Write("\nInvalid entry. Please enter a whole number or 'Integer': ");
        }
    }
    //old converstion method from legacy program
    //int intNum1 = Convert.ToInt32(stringNum1);
    //int intNum2 = Convert.ToInt32(stringNum2);

    //number comparisons
    NumberComp(intNum1, intNum2);

    //method for doing number comparisons
    void NumberComp(int num1, int num2){
        Console.WriteLine("");

        if(num1 > num2){
            Console.WriteLine("Your first number \"" + num1 + "\" is GREATER THAN your second number \"" + num2 + "\"");
        }else if(intNum1 < intNum2){
            Console.WriteLine("Your first number \"" + num1 + "\" is LESS THAN your second number \"" + num2 + "\"");
        }else{
            Console.WriteLine("Your first number \"" + num1 + "\" is EQUAL TO your second number \"" + num2 + "\"");
        }

        Console.WriteLine("Also...!");

        if(num2 > num1){
            Console.WriteLine("Your second number \"" + num2 + "\" is GREATER THAN your first number \"" + num1 + "\"");
        }else if(intNum2 < intNum1){
            Console.WriteLine("Your second number \"" + num2 + "\" is LESS THAN your first number \"" + num1 + "\"");
        }else{
            Console.WriteLine("Your second number \"" + num2 + "\" is EQUAL TO your first number \"" + num1 + "\"");
        }
    }

    //play again prompt with input validation
    Console.Write("\nWould you like to compare another pair of numbers? Y/N: ");
    bool answerCheck = true;
    while (answerCheck == true) {
        string playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == "y" || playAgainInput == "yes") {
            answerCheck = false;
            Console.WriteLine("Let's go again!");
        } else if (playAgainInput == "n" || playAgainInput == "no"){
            playAgain = false;
            answerCheck = false;
            Console.WriteLine("Ez Katka");
        } else {
            Console.Write("\nI do not understand. Please answer with 'Y' for yes, or 'N' for no: ");
            answerCheck = true;
        }
    }
}

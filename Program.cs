//Kenneth Fujimura
//09-12-2022 @10:08pm
//Mini Challenge # 4 - Greater Than Or Less Than
//Console program greets the user, asks for input of two different numbers, proceses those string values into intergers, ...
//...compares which value is larger, and then reports that information to the user.
//Peer Review by: see mini challenge #1

Console.Clear();
Console.WriteLine("Let's add two numbers!");

bool playAgain = true;

//play again loop
while (playAgain == true) {
    //declaring variables for various functions
    string stringNum1 = "";
    string stringNum2 = "";

    bool isConverted1 = false;
    bool isNumber1;
    int intNum1 = 0;

    bool isConverted2 = false;
    bool isNumber2;
    int intNum2 = 0;

    //taking first number input, with data validation
    Console.WriteLine("Welcome! This program will tell you if two numbers are greater than, less than, or equal to each other.");
    Console.WriteLine("On the keyboard, please input one number: ");
    while (!isConverted1) {
        stringNum1 = Console.ReadLine();
        isNumber1 = Int32.TryParse(stringNum1, out intNum1);

        if (isNumber1 == true){
            isConverted1 = true;
        } else {
            Console.WriteLine("Invalid entry. Please enter a whole number or 'Integer'.");
        }
    }

    //taking second number input, with data validation
    Console.WriteLine("Great! Now, please input the second number: ");
    while (!isConverted2) {
        stringNum2 = Console.ReadLine();
        isNumber2 = Int32.TryParse(stringNum2, out intNum2);

        if (isNumber2 == true){
            isConverted2 = true;
        } else {
            Console.WriteLine("Invalid entry. Please enter a whole number or 'Integer'.");
        }
    }
    //old converstion method from legacy program
    //int intNum1 = Convert.ToInt32(stringNum1);
    //int intNum2 = Convert.ToInt32(stringNum2);

    //number comparisons
    if(intNum1 > intNum2){
        Console.WriteLine("Your first number \"" + stringNum1 + "\" is GREATER THAN your second number \"" + stringNum2 + "\"");
    }else if(intNum1 < intNum2){
        Console.WriteLine("Your first number \"" + stringNum1 + "\" is LESS THAN your second number \"" + stringNum2 + "\"");
    }else{
        Console.WriteLine("Your first number \"" + stringNum1 + "\" is EQUAL TO your second number \"" + stringNum2 + "\"");
    }

    Console.WriteLine("Also...!");

    if(intNum2 > intNum1){
        Console.WriteLine("Your second number \"" + stringNum2 + "\" is GREATER THAN your first number \"" + stringNum1 + "\"");
    }else if(intNum2 < intNum1){
        Console.WriteLine("Your second number \"" + stringNum2 + "\" is LESS THAN your first number \"" + stringNum1 + "\"");
    }else{
        Console.WriteLine("Your second number \"" + stringNum2 + "\" is EQUAL TO your first number \"" + stringNum1 + "\"");
    }

    //play again prompt with input validation
    Console.WriteLine("Would you like to compare another pair of numbers? Y/N");
    bool answerCheck = true;
    while (answerCheck == true) {
        string playAgainInput = Console.ReadLine();
        if (playAgainInput == "y" || playAgainInput == "Y") {
            answerCheck = false;
            continue;
        } else if (playAgainInput == "n" || playAgainInput == "N"){
            playAgain = false;
            answerCheck = false;
        } else {
            Console.WriteLine("I do not understand. Please answer with 'Y' for yes, or 'N' for no.");
            answerCheck = true;
        }
    }
}
Console.WriteLine("Ez Katka");
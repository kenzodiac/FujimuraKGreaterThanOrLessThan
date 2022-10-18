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
    //declaring variables to hold user inputs
    decimal num1 = 0;
    decimal num2 = 0;

    //method for taking in user input and doing data validation on that input
    decimal InputAndValidation(decimal numPass) {
        bool isConverted = false;
        while (!isConverted) {
            string stringNum = Console.ReadLine();
            bool isNumber = Decimal.TryParse(stringNum, out numPass);

            if (isNumber == true){
                isConverted = true;
            } else {
                Console.Write("\nInvalid entry. Please enter a whole number or 'Integer': ");
            }
        }
        return numPass;
    }
    
    //taking first number input, with data validation
    Console.Write("\nOn the keyboard, please input one number: ");
    num1 = InputAndValidation(num1);
    
    //taking second number input, with data validation
    Console.Write("\nGreat! Now, please input the second number: ");
    num2 = InputAndValidation(num2);

    //number comparisons
    NumberComp();

    //method for doing number comparisons
    void NumberComp(){
        Console.WriteLine("");

        if(num1 > num2){
            Console.WriteLine("Your first number \"" + num1 + "\" is GREATER THAN your second number \"" + num2 + "\"");
        }else if(num1 < num2){
            Console.WriteLine("Your first number \"" + num1 + "\" is LESS THAN your second number \"" + num2 + "\"");
        }else{
            Console.WriteLine("Your first number \"" + num1 + "\" is EQUAL TO your second number \"" + num2 + "\"");
        }

        Console.WriteLine("Also...!");

        if(num2 > num1){
            Console.WriteLine("Your second number \"" + num2 + "\" is GREATER THAN your first number \"" + num1 + "\"");
        }else if(num2 < num1){
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

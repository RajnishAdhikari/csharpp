//sample test program
//Console.WriteLine("Hello, World!");


//variables in csharp
/*
string characterName = "John";
int characterAge;
characterAge = 35;

Console.WriteLine("There once was a man named " + characterName);
Console.WriteLine("He is "+ characterAge +  " years old");

characterName = "Mike";

Console.WriteLine("He really liked the name " + characterName);
Console.WriteLine("But he didn't like being " + characterAge);
*/


//data types in c#
/*
string phrase = "Giraffe Academy";
char grade = 'A'; // only one character can be stored in character data type 
int age = 20;  // integer can also handle negative numbers
//three type of data type can be used to notate float point numbers
// they are float, double, decimal -- decimal is super presize 
double gpa = 3.65;
//to store information in the form of True or False we use boolean
bool isMale = true;
bool isFemale = false;
*/
// we can represent this data type outside of the variable 


//strings in c#
//string phrase = "Giraffe Academy";
//Console.WriteLine(phrase);


//string concatenation 
/*
string greeting = "Good morning ";
string name = "RamdfjkdjfkdfhdjkffhjkY Shyam";
Console.WriteLine(greeting + name);
Console.WriteLine("Total character in greeting is " + greeting.Length);

//converting string to the uppercase using method
Console.WriteLine(name.ToUpper());

//if the string of text contain certain substring or not 
Console.WriteLine(name.Contains("p"));
Console.WriteLine(name.Contains("h"));

//figure out the first character in the string 
Console.WriteLine(name[0]);
Console.WriteLine(name[3]);
Console.WriteLine(name[7]);
Console.WriteLine(name[14]);

Console.WriteLine(name.IndexOf("Shyam"));
Console.WriteLine(name.IndexOf('Y'));

//-1 in the string indicated that the string isn't present in the string
Console.WriteLine(name.IndexOf('z'));

//grabbing the substring of the string
Console.WriteLine(name.Substring(24)); 



//working with numbers in c#
Console.WriteLine(-5.25555);
Console.WriteLine(4 + 2 * 5);
// Increment of the number 
int num = 9;
num++;
Console.WriteLine(num);

//Maths methods
Console.WriteLine(Math.Abs(-4552));  //for absolute value 
Console.WriteLine(Math.Pow(25,2));    // for power of any number 
Console.WriteLine(Math.Sqrt(49));   // to find the square root of any number
Console.WriteLine(Math.Max(49,25));     // to find the maximum number between any 2 number 
Console.WriteLine(Math.Min(49,24));     //finding minimum
Console.WriteLine(Math.Round(49.553));      // to round off the number





//Getting input with the users
Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.Write("Enter your age: ");
string age = Console.ReadLine();
Console.WriteLine("Hello " + name + " You are " + age );
*/

//Making calculator by taking input form the user 
//int num = Convert.ToInt32("45");  // converting string to the intergr and then adding 
//Console.WriteLine(num + 10);
/*
Console.Write("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num1 + num2);
Console.ReadLine();


//adding 2 decimal numbers
Console.Write("Enter a number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(num1 + num2);

Console.ReadLine();


//Building a mad libs Game
string color, pluralNoun, celebrity;
Console.Write("Enter a color: ");
color = Console.ReadLine();

Console.Write("Enter a plural noun : ");
pluralNoun = Console.ReadLine();

Console.Write("Enter a celebrity: ");
celebrity = Console.ReadLine();

Console.WriteLine("Roses are " + color);
Console.WriteLine(pluralNoun+ " are blue");
Console.WriteLine("I love " + celebrity);
Console.ReadLine();


//Array in c#
int [] luckyNumberes = {2,3,4, 5, 6, 7, 8, 9};
Console.WriteLine(luckyNumberes[0]);
//changing the elements in array
luckyNumberes[2] = 500;
Console.WriteLine(luckyNumberes[2]);
Console.WriteLine(luckyNumberes[7]);
//creating the array of strings
string[] friends = new string[5] { "roshan", "saphal", "ritik", "bhawishya", "anupam" };
foreach (string friend in friends)
{
    Console.WriteLine(friend);
}

Console.ReadLine();


//METHODS or function IN C#
//CREATING METHOD TO SAY HI TO THE 
SayHi("mike", 22);
SayHi("dada", 25);
static void SayHi(string name, int age)
{
    Console.WriteLine("Hello " + name + "you are " + age);
    
}




//RETURN STATEMENT IN C# METHODS
int cubedNumber = cube(6);
Console.WriteLine(cubedNumber);
Console.WriteLine(cube(5));
static int cube(int num)
{
    int result = num * num * num;
    return result;
}



//if SATEMENTS 
bool isMale = true;
bool isTall = true;
if (isMale && isTall)
{
    Console.WriteLine("You are a tall male");

}
else
{
    Console.WriteLine("You are not male or not tall or both");
}

bool isMalee = true;
bool isTalle = false;
if (isMalee && isTalle)
{
    Console.WriteLine("You are a tall male");

}
else
{
    Console.WriteLine("You are not male or not tall or both");
}

bool is_Male = true;
bool is_Tall = false;
if (is_Male || is_Tall)
{
    Console.WriteLine("You are a tall male");

}
else
{
    Console.WriteLine("You are not male or not tall or both");
}

bool is__Male = false;
bool is__Tall = true;
if (is__Male && is__Tall)
{
    Console.WriteLine("You are a tall male");

}
else if(is__Male && !is__Tall)
{
    Console.WriteLine("You are a short male");
}
else if(!is__Male && is__Tall)
{
    Console.WriteLine("You are not male but you are tall ");
}
else
{
    Console.WriteLine("You are not male and not tall");
}


//MORE IF STATEMENT
//PROGRAM TO FIND GREATER NUMBER BETWEEN TWO NUMBER AND RETURN THE GREATER ONE
Console.WriteLine(GetMax(200, 10));
static int GetMax(int num1, int num2)
{
    int result;
    if (num1 > num2)
    {
        result = num1;
    }
    else
    {
        result = num2; 
    }
    return result;
}




//PROGRAM TO FIND GREATER NUMBER BETWEEN 3 NUMBER AND RETURN THE GREATER ONE
Console.WriteLine(GetMax(15, 56, 25));
static int GetMax(int num1, int num2,int num3)
{
    int result;
    if(num1 >= num2 && num1 >= num3)
    {
        result = num1;
    } 
    else if(num2 >= num1 && num2 >= num3)
    {
        result=num2;
    }
    else
    {
        result = num3;  
    }



    return result;
}



//Program to build calculator
Console.WriteLine("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Operator: ");
string op = Console.ReadLine();

Console.WriteLine("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());


if (op == "+")
{
    Console.WriteLine(num1 + num2);
}
else if (op == "-")
{
    Console.WriteLine(num1 - num2);
}
else if (op == "*")
{
    Console.WriteLine(num1 * num2);
}
else if (op == "/")
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine("Invalid operator");
}


//SWITCH STATEMENT
//PROGRAM TO PRINT DAYS OF A WEEK IF WE PASS 0 TO 6  MAPPING NUMBER TO THE SPECIFIC DAY OF A WEEK
Console.WriteLine(GetDay(5));
Console.WriteLine(GetDay(0));
Console.WriteLine(GetDay(10));
static string GetDay (int dayNum)
{
    string dayName;

    switch (dayNum )
    {
        case 0:
            dayName = "Sunday";
            break;
        case 1:
            dayName = "Monday";
            break;
        case 2:
            dayName = "Tuesday";
            break;
        case 3:
            dayName = "Wednesday";
            break;
        case 4:
            dayName = "Thursday";
            break;
        case 5:
            dayName = "Friday";
            break;
        case 6:
            dayName = "Saturday";
            break;
        default:
            dayName = "Invalid day Number";
            break;
    }

    return dayName;
}



//WHILE LOOP
//IT ALLOWS TO REPEAT CERTAIN BLOCK OF CODE WHEN THE GIVEN CONDITION IS TRUE
int index = 1;
while(index <= 5)
{
    Console.WriteLine(index);
    index++;
}

//do while loop
int index = 6;
do
{
    Console.WriteLine(index);
    index++;  
}
while (index <= 5);



//BUILDING A GUESSING GAME
string word = "giraffe";
string guess = "";
int guessCount = 0;
int guessLimit = 3;
bool outofGuesses = false;

while (guess != word && !outofGuesses)
{
    if(guessCount < guessLimit )
    {
        Console.Write("Guess a word: ");
        guess = Console.ReadLine();
        guessCount++;
    }
    else
    {
        outofGuesses = true;
    }
    
}
if( outofGuesses )
{
    Console.WriteLine("You lose.");

}
else
{ 
    Console.Write("you win");
}

//FOR LOOP IN C#
//int i = 1;  we can initialize here or in the for loop itself

for(int i = 1; i<=5; i++)
{
    Console.WriteLine(i);
}
Console.ReadLine();



int i = 0;
for (i = 0; i <= 19; i++)
{
    Console.WriteLine(i);
}
Console.ReadLine();


//printing all the elements of an array
int[] luckyNumbers = {4,8,15,16,23,42};
for (int i = 0; i < luckyNumbers.Length; i++)
{
    Console.WriteLine(luckyNumbers[i]);
    
}
Console.ReadLine();


//EXPONENT FUNCTION IN C#
Console.WriteLine(GetPow(3, 2));
Console.WriteLine(GetPow(3, 3));
Console.WriteLine(GetPow(2, 6));
static int GetPow(int baseNum, int powNum)
{
    int result = 1;
    for(int i = 0; i < powNum; i++)
    {
        result = result * baseNum;
    }
    return result;
}



//2-D Array and accessing the elements in 2 dimensional array
int[,] numberGrid = {
    {1,2},
    {3,4},
    {5,6},
};
int[,] myArraay = new int[2, 3];
Console.WriteLine(numberGrid[0,0]);
Console.WriteLine(numberGrid[1,1]);


//BASIC OF WORKING AND HANDELING OF EXCEPTION  EXCEPTION HANDLING
try
{

    Console.WriteLine("Enter a number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num1 / num2);
}

catch
{
    Console.WriteLine("error");
}


try
{

    Console.WriteLine("Enter a number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num1 / num2);
}

catch(Exception e)
{
    Console.WriteLine(e.Message); //this method shows what actually the error is


//CLASSES AND OBJECT CONCEPT 




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "jk rolling";
            book1.pages = "400";
            //Console.WriteLine(book1.title);
            //Console.WriteLine(book1.author);

            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = "700";
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
        }
    }

}

*/

//CONSTRUCTORS
















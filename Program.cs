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
*/

//METHODS IN C#
//CREATING METHOD TO SAY HI TO THE 
SayHi();
static void SayHi()
{
    Console.WriteLine("Hello user");
    
}


















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
string greeting = "Good morning ";
string name = "Ramdfjkdjfkdfhdjkffhjkh Shyam";
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
Console.WriteLine(name.IndexOf('y'));

//-1 in the string indicated that the string isn't present in the string
Console.WriteLine(name.IndexOf('z'));




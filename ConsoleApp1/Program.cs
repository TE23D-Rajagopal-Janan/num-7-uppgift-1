using System.Formats.Asn1;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

int x = 6;
int y = 3;

if (x >= y)
{
    Console.WriteLine("Hello,World"); 
}

string name = "";
string password = "";


while (name != "kalleanka" || password != "12345")
{
Console.WriteLine("Type in Username");
name = Console.ReadLine();  

Console.WriteLine("Type in Password");
password = Console.ReadLine();


if (name != "kalleanka" || password != "12345" )
{
    Console.WriteLine("Wrong password or Wrong Username");
    Console.WriteLine("Try again");
    Console.WriteLine();  
}
}


int i = 0;  
while ( i < 32)
{
    Console.WriteLine("Hello,World");
    i++;
}
string tal; 
int a = 0; 
int t = 0;
while (a < 5)
{
a++;
Console.WriteLine("Välj ett tal");  
tal = Console.ReadLine();
int.TryParse(tal, out t);
if (t > 5)
{
    Console.WriteLine("högre än 5!");
}
}
// 7 
Console.WriteLine("vad är heter du");
string name2 = "";
int z;

name2 = Console.ReadLine();


while(int.TryParse(name2, out z))
{
    Console.WriteLine("Wrong password try again");
    name2 = Console.ReadLine(); 
}

// sista 8 
int talet;
string talet2 = "";
bool correctParse = int.TryParse(talet2, out talet );
if (correctParse || talet != 7)
Console.WriteLine("Guess the number");
talet2 = Console.ReadLine();
while (correctParse || talet != 7)
{
talet2 = Console.ReadLine();
int.TryParse(talet2, out talet );
if (talet > 7)
{
    Console.WriteLine("The correct number is less");

}
else if (talet < 7)
{
    Console.WriteLine("The correct number is larger");

}
else
{
    Console.WriteLine("Correct congrats");

}
}



Console.ReadLine();


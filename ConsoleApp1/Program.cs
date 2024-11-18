using System.Runtime.Serialization;

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
a++ ;
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
name2 = "";
name2 = Console.ReadLine();
while( name2 != "kalleanka")
{
    

}



Console.ReadLine();


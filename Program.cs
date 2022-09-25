// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many people are we making PB&J sandwiches for?");
int num = int.Parse(Console.ReadLine());

int totalSlicesPerloaf = 28;
int totalTableSpoonsPerPB= 32;
int totalTeaspoonPerJelly = 48;

int totalSlicesNeeded = (num * 2);
int totalTablespoonsofPB = (num * 2);
int totalTeaspoonsOfJelly = (num * 4);

Console.WriteLine("You Need");
Console.WriteLine("");

Console.WriteLine(totalSlicesNeeded + " slices of bread.");
Console.WriteLine(totalTablespoonsofPB + " tablespoons of peanut butter ");
Console.WriteLine(totalTeaspoonsOfJelly + " teaspoons of jelly ");

Console.WriteLine("Which is");
Console.WriteLine("");
 

int totalLoavesNeeded = (totalSlicesNeeded / totalSlicesPerloaf);
int totalJarsOfPB = (totalTablespoonsofPB / totalTableSpoonsPerPB);
int totalJarsOfJelly = (totalTeaspoonsOfJelly / totalTeaspoonPerJelly);

Console.WriteLine(totalLoavesNeeded +  " loaves of bread ");
Console.WriteLine(totalJarsOfPB + " jars of peanut butter ");
Console.WriteLine(totalJarsOfJelly + " jars of jelly ");
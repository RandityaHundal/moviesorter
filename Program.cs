string[] movies = new string[3];

Console.WriteLine("Input 3 movies.");
for (int i = 0; i < movies.Length; i++)
{
    movies[i] = Console.ReadLine();
}

Console.WriteLine("\nHere they are alphabetically");

Array.Sort(movies);

for (int i = 0; i < movies.Length; i++)
{
    Console.WriteLine(movies[i]);
}

// close key
Console.ReadKey();
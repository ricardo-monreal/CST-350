// See https://aka.ms/new-console-template for more information


// array of test scores
int[] scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 77, 74, 95, 97 };

// print the scores
foreach (var individualScores in scores)
{
    Console.WriteLine("One of the scores was {0}", individualScores);
}

Console.ReadLine();


// use a LINQ statement to filter the list.
var theBestStudents = 
    from individualScores in scores
    where individualScores > 90
    select individualScores;

// print only the best scores
foreach (var individualScores in theBestStudents)
{
    Console.WriteLine("one of the BEST scores was {0}", individualScores);
}

Console.ReadLine();

// use LINQ to sort the results
var sortedScores =
    from individualScores in scores
    orderby individualScores
    select individualScores;

// print the sorted list
foreach (var individualScores in sortedScores)
{
    Console.WriteLine("One of the scores was {0}", individualScores);
}
Console.ReadLine();

// challenge
var bStudents = 
    from individualScores in scores
    orderby individualScores ascending
    where individualScores > 80 && individualScores < 90
    select individualScores;
Console.WriteLine("#### Challenge #####");
foreach(var individualScores in bStudents)
{
    Console.WriteLine("One of the B scores was {0}", individualScores);
}
Console.ReadLine();
// See https://aka.ms/new-console-template for more information
using TestClassLibrary;

var instance = new Test();

int count = 15;
var pairEntities = new List<PairEntity>
{
    new PairEntity { Number = 5, Word = "BUZZ" },
    new PairEntity { Number = 3, Word = "FIZZ" },
};

var result = instance.ListCalculator(count, pairEntities);

foreach (var item in result)
{
    Console.WriteLine(item);
}
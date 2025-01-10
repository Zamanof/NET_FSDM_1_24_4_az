List<int> numbers = new();
fillList(numbers);
showList(numbers);

var evens = numbers.Where(isEven).ToList();
showList(evens);


// anonim metodlar
// delegate (param_list) { some_code; return value;}
// delegate(int x) {  return x % 2 != 0; }

var odds = numbers.Where(delegate (int x) { return x % 2 != 0; }).ToList();
showList(odds);

// Lambda expression
// (param_list) => {some_code; return value;}
// (x) => x % 2 != 0
var negative = numbers.Where(x => x < 0).ToList();

var func = (int x) => x < 0;

// Lambda ifadeleri bu shekilde chalisin istifade etmeyin
var fill = (List<int> numbs) =>
{
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
        numbs.Add(rnd.Next(-99, 99));
};

Console.WriteLine(func(26));
/*
    x => x < 0                              - lambda expression
    
    delegate(int x) {  return x < 0; }      - annonymous method
    
    bool isNegate(int x){return x < 0;}     - normal method
    
*/

/*
    lambdas:
    C++ :       [](int x){return x < 0;}
    Python:     lambda x: x < 0
    C#:         x => x < 0
 */



void fillList(List<int> ints)
{
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
        ints.Add(rnd.Next(-99, 99));
}

void showList(List<int> ints)
{
    for (int i = 0; i < ints.Count; i++)
        Console.Write($"{ints[i]}\t");
    Console.WriteLine();
}

bool isEven(int item)
{
    return item % 2 == 0;
}
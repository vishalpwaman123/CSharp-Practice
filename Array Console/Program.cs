using Array_Console;

//Problem 1 — Find Maximum Element
//ArrayExample1 obj1 = new();
//Console.WriteLine(obj1.FindMaximum([3, 7, 2, 9, 4]));
//Console.WriteLine(obj1.FindMaximum([-10, -5, -20, -3]));

//Problem 2 — Find the Second Largest Element
//ArrayExample2 obj2 = new();
//Console.WriteLine(obj2.FindSecondMaximum([3, 7, 2, 9, 4]));
//Console.WriteLine(obj2.FindSecondMaximum([10, 5, 10, 8, 3]));
//Console.WriteLine(obj2.FindSecondMaximum([-10, -5, -20, -3]));
//Console.WriteLine(obj2.FindSecondMaximum([-5, -10, -20]));
//Console.WriteLine(obj2.FindSecondMaximum([10, 10, 8, 5]));

//Problem 3 — Reverse an Array In Place
//ArrayExample3 obj3 = new();
//Console.WriteLine(string.Join(", ", obj3.ReverseArray([1, 2, 3, 4, 5])));
//Console.WriteLine(string.Join(", ", obj3.ReverseArray([1, 2, 3, 4])));
//Console.WriteLine(string.Join(", ", obj3.ReverseArray([7])));
//Console.WriteLine(string.Join(", ", obj3.ReverseArray([])));

//Problem 4 — Move All Zeroes to the End
ArrayExample4 obj4 = new();
Console.WriteLine(string.Join(", ", obj4.MoveZeroesToEnd([0, 1, 0, 3, 12])));
Console.WriteLine(string.Join(", ", obj4.MoveZeroesToEnd([1, 2, 3])));
Console.WriteLine(string.Join(", ", obj4.MoveZeroesToEnd([0, 0, 0])));
Console.WriteLine(string.Join(", ", obj4.MoveZeroesToEnd([0, 0, 5])));

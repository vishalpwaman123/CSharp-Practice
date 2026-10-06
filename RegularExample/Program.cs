using RegularExample;

// Magic Number

// Input : 45
// Output : 4 + 5 = 9
// Input : 89
// Output : 8 + 9 = 17
// Input : 4567
// Output 4 + 5 + 6 + 7 = 22 = 2 + 2 = 4
//Console.WriteLine("Magic Number : "+ MagicNumber.Run(47));

// Matrix Addition

int[,] matrix1 =
{
    { 1, 2 },
    { 3, 4 }
};

int[,] matrix2 =
{
    { 5, 6 },
    { 7, 8 }
};

int[,] result = Matrix.Add(matrix1, matrix2);
Matrix.Print(result);

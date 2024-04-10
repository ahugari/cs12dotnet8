//#region Exploring Unary operators

//int a = 3;
//int b = a++;
//WriteLine($"a is {a} and b is {b}");

//int c = 3;
//int d = ++c;
//WriteLine($"c is {c} and b is {d}");

//int e = 10;
//int f = 2;
//WriteLine($"e is {e} and f is {f}");
//WriteLine($"e+f is {e + f}");
//WriteLine($"e-f is {e - f}");
//WriteLine($"e*f is {e * f}");
//WriteLine($"e/f is {e / f}");
//WriteLine($"e%f is {e % f}");

//double g = 13.0;
//WriteLine($"g is {g:N1}, f is {f}");
//WriteLine($"g/f = {g / f}");

////int p = 6;
////p += 3;
////p -= 3;
////p /= 3;
////p %= 3;

//#endregion

//#region Exploring Coalescing operators

//string? authorName = ReadLine();
//int maxLength = authorName?.Length ?? 30;
//authorName ??= "unknown";
//WriteLine(authorName);

//#endregion

#region Exploring Booleans

bool p = true;
bool q = false;

WriteLine($"AND   |P      |Q");
WriteLine($"p     |{p & p,-5} | {p & q,-5}");
WriteLine($"q     |{q & p,-5} | {q & q,-5}");
WriteLine();
WriteLine($"OR    |P      |Q");
WriteLine($"P    |{p | p,-5}    | {p | q,-5}");
WriteLine($"Q    |{q | p,-5}    | {q | q,-5}");
WriteLine();
WriteLine($"XOR    |P      |Q");
WriteLine($"P    |{p ^ p,-5}    | {p ^ q,-5}");
WriteLine($"Q    |{q ^ p,-5}    | {q ^ q,-5}");

WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");
WriteLine();
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");

#endregion Exploring Booleans

#region Exploring conditional logical operators

static bool DoStuff()
{
    WriteLine("I am doing stuff");
    return true;
}

#endregion Exploring conditional logical operators

#region Exploring binary shift operators

WriteLine();
int x = 10;
int y = 6;
WriteLine($"Expression   |   Decimal   |   Binary");
WriteLine(new string('-', 35));
WriteLine($"x            |   {x,7}   |   {x:B8}");
WriteLine($"y            |   {y,7}   |   {y:B8}");
WriteLine($"x & y        |   {x & y,7}   |   {x & y:B8}");
WriteLine($"x | y        |   {x | y,7}   |   {x | y:B8}");
WriteLine($"x ^ y        |   {x ^ y,7}   |   {x ^ y:B8}");

WriteLine($"x << 3       |   {x << 3,7}   |   {x << 3:B8}");
WriteLine($"x * y        |   {x * y,7}   |   {x * y:B8}");
WriteLine($"x >> 1       |   {x >> 1,7}   |   {x >> 1:B8}");

#endregion Exploring binary shift operators
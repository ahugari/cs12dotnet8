for (int i = 1; i <= 100; i++)
{
    string fbResult;
    if (i % 3 == 0 && i % 5 == 0)
    {
        fbResult = "fizzbuzz";
    }
    else if (i % 3 == 0)
    {
        fbResult = "fizz";
    }
    else if (i % 5 == 0)
    {
        fbResult = "buzz";
    }
    else
    {
        fbResult = i.ToString();
    }
    Console.Write($"{fbResult} ");
}
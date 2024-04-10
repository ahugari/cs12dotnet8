uint naturalNumber = 21;
int integerNumber = -22;
float singlePrecisionFloatingPointNumber = 1.1f;
double doublePrecisionFloatingPointNumber = 2.9;

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001e_8480;

WriteLine(naturalNumber);
WriteLine(integerNumber);
WriteLine(singlePrecisionFloatingPointNumber);
WriteLine(doublePrecisionFloatingPointNumber);

Write("\n");

WriteLine(decimalNotation == binaryNotation);
WriteLine(decimalNotation == hexadecimalNotation);

//display numbers as decimals
WriteLine($"{decimalNotation:N0}");
WriteLine($"{binaryNotation:N0}");
WriteLine($"{hexadecimalNotation:N0}");
//display numbers as hexadecimals
WriteLine($"{decimalNotation:x}");
WriteLine($"{binaryNotation:x}");
WriteLine($"{hexadecimalNotation:x}");

Write("\n");

WriteLine($"int uses {sizeof(int)} bytes and stores number from the range {int.MinValue:N0} to {int.MaxValue:N0}");
WriteLine($"double uses {sizeof(double)} bytes and stores number from the range {double.MinValue:N0} to {double.MaxValue:N0}");
WriteLine($"float uses {sizeof(float)} bytes and stores number from the range {float.MinValue:N0} to {float.MaxValue:N0}");
WriteLine($"long uses {sizeof(long)} bytes and stores number from the range {long.MinValue:N0} to {long.MaxValue:N0}");
WriteLine($"decimal uses {sizeof(decimal)} bytes and stores number from the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

WriteLine("using doubles:\n");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    WriteLine($"{a} + {b} does not equal to {0.3}");
}

WriteLine("using floats:\n");

float c = 0.1F;
float d = 0.2F;
if (c + d == 0.3f)
    WriteLine($"{c} + {d} equals {0.3f}");
else
    WriteLine($"{c} + {d} does not equal to {0.3f}");

WriteLine("using decimals:\n");

decimal e = 0.1m;
decimal f = 0.2m;
if (e + f == 0.3m)
    WriteLine($"{e} + {f} equals {0.3m}");
else
    WriteLine($"{e} + {f} does not equal to {0.3m}");

unsafe
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range from {Half.MinValue:N0} to {Half.MaxValue:N0}");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range from {Int128.MinValue:N0} to {Int128.MaxValue:N0}");
}
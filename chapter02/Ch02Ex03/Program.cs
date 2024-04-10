WriteLine(new string('-', 113));
WriteLine("{0,-10} {1,-5} {2,38} {3,45}", "Type", "Byte(s) of memory", "Min", "Max");
WriteLine(new string('-', 113));
WriteLine($"{nameof(SByte),-10} {sizeof(sbyte),-5} {sbyte.MinValue,50} {sbyte.MaxValue,45}");
WriteLine($"{nameof(Byte),-10} {sizeof(byte),-5} {byte.MinValue,50} {byte.MaxValue,45}");
WriteLine($"{nameof(Int16),-10} {sizeof(Int16),-5} {Int16.MinValue,50} {Int16.MaxValue,45}");
WriteLine($"{nameof(UInt16),-10} {sizeof(UInt16),-5} {UInt16.MinValue,50} {UInt16.MaxValue,45}");
WriteLine($"{nameof(Int32),-10} {sizeof(Int32),-5} {Int32.MinValue,50} {Int32.MaxValue,45}");
WriteLine($"{nameof(UInt32),-10} {sizeof(UInt32),-5} {UInt32.MinValue,50} {UInt32.MaxValue,45}");
WriteLine($"{nameof(Int64),-10} {sizeof(Int64),-5} {Int64.MinValue,50} {Int64.MaxValue,45}");
WriteLine($"{nameof(UInt64),-10} {sizeof(UInt64),-5} {UInt64.MinValue,50} {UInt64.MaxValue,45}");
unsafe
{
    WriteLine($"{nameof(Int128),-10} {sizeof(Int128),-5} {Int128.MinValue,50} {Int128.MaxValue,45}");
    WriteLine($"{nameof(UInt128),-10} {sizeof(UInt128),-5} {UInt128.MinValue,50} {UInt128.MaxValue,45}");
    WriteLine($"{nameof(Half),-10} {sizeof(Half),-5} {Half.MinValue,50} {Half.MaxValue,45}");
}
WriteLine($"{nameof(Single),-10} {sizeof(Single),-5} {Single.MinValue,50} {Single.MaxValue,45}");
WriteLine($"{nameof(Double),-10} {sizeof(Double),-5} {Double.MinValue,50} {Double.MaxValue,45}");
WriteLine($"{nameof(Decimal),-10} {sizeof(Decimal),-5} {Decimal.MinValue,50} {Decimal.MaxValue,45}");
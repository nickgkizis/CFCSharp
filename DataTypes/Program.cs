namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte: {sizeof(byte) * 8}, min: {byte.MinValue}, max: {byte.MaxValue}");
            Console.WriteLine($"sbyte: {sizeof(sbyte) * 8}, min: {sbyte.MinValue}, max: {sbyte.MaxValue}");
            Console.WriteLine($"short: {sizeof(short) * 8}, min: {short.MinValue}, max: {short.MaxValue}");
            Console.WriteLine($"ushort: {sizeof(ushort) * 8}, min: {ushort.MinValue}, max: {ushort.MaxValue}");
            Console.WriteLine($"int: {sizeof(int) * 8}, min: {int.MinValue}, max: {int.MaxValue}");
            Console.WriteLine($"uint: {sizeof(uint) * 8}, min: {uint.MinValue}, max: {uint.MaxValue}");
            Console.WriteLine($"long: {sizeof(long) * 8}, min: {long.MinValue}, max: {long.MaxValue}");
            Console.WriteLine($"ulong: {sizeof(ulong) * 8}, min: {ulong.MinValue}, max: {ulong.MaxValue}");
            Console.WriteLine($"float: {sizeof(float) * 8}, min: {float.MinValue}, max: {float.MaxValue}");
            Console.WriteLine($"double: {sizeof(double) * 8}, min: {double.MinValue}, max: {double.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(decimal) * 8}, min: {decimal.MinValue}, max: {decimal.MaxValue}");
            Console.WriteLine($"char: {sizeof(char) * 8}, min: {(int)char.MinValue}, max: {(int)char.MaxValue}");
        }
    }
}

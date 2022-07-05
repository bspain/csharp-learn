namespace basics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Int32 to byte array
        Int32 i32 = 125;
        byte[] bytes = BitConverter.GetBytes(i32);
        Console.WriteLine($"BitConverter.GetBytes(125): {BitConverter.ToString(bytes)}"); // 7D-00-00-00

        // byte array to Int32
        double dValue = BitConverter.ToInt32(bytes);
        Console.WriteLine($"BitConverter.ToInt32(bytes): {dValue.ToString()}"); // 125

        // Int to binary string
        int value = 125;
        string binary = Convert.ToString(value, 2);
        Console.WriteLine($"Convert.ToString(value, 2): {binary}"); // 1111101
    }
}

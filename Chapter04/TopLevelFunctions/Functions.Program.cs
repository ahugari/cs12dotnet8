internal partial class Program
{
    private static void WhatsMyNamespace()
    {
        Console.WriteLine("Namespace of the Program class: {0}", arg0: typeof(Program).Namespace ?? "null");
    }
}
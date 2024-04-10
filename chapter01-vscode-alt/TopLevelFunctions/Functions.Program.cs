public partial class Program
{
    static void WhatsMyNameSpace()
    {
        System.Console.WriteLine("Namespace of Program: {0}", arg0: typeof(Program).Namespace ?? "null");
        FirstLocalFuntionCall();
        static void FirstLocalFuntionCall()
        {
            System.Console.WriteLine("This is my first local function call");
        }
    }
}

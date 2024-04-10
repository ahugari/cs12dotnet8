using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;

WriteLine($"This is an ahead-of-time (AOT) compiled console app.");
WriteLine("Current culture: {0}", CultureInfo.CurrentCulture.DisplayName);
WriteLine("OS Version: {0}", Environment.OSVersion);
WriteLine("Press any key to exit.");
ReadKey(intercept: true);// do not output the key that was pressed.

AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("MyAssembly"), AssemblyBuilderAccess.Run);
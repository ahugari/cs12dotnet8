using Microsoft.Extensions.Configuration;
using System.Diagnostics;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");
Console.WriteLine($"Writing to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));
Trace.Listeners.Add(logFile);

#if DEBUG
Trace.AutoFlush = true;
#endif

Debug.WriteLine("Debug says, I am watching.");
Trace.WriteLine("Trace says, I am watching.");

string settingsFile = "appsettings.json";
string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);
Console.WriteLine("Processing: {0}", settingsPath);
Console.WriteLine("--{0} contents--", settingsPath);
Console.WriteLine(File.ReadAllLines(settingsPath));
Console.WriteLine("---");
ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile(settingsFile, false, true);
IConfigurationRoot configuration = builder.Build();
TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "This switch is set via a JSON config.");
configuration.GetSection("PacktSwitch").Bind(ts);
Console.WriteLine($"Trace switch value:{ts.Value}");
Console.WriteLine($"Trace switch level:{ts.Level}");
Trace.WriteLineIf(ts.TraceError, "Trace Error");
Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace Information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

Debug.Close(); Trace.Close();
Console.WriteLine("Press enter to exit...");
Console.ReadLine();
﻿using System.Globalization;

internal partial class Program
{
    private static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false, bool showCulture = true)
    {
        OutputEncoding = System.Text.Encoding.UTF8;
        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        if (showCulture)
        {
            Console.WriteLine($"Current Culture: {CultureInfo.CurrentCulture.DisplayName}.");
        }
    }
}
using System;
using OSVersionExtension;

namespace NugetExample
{
    internal class Program
    {
        [Obsolete("Obsolete")]
        private static void Main()
        {
            Console.WriteLine(
                $"Windows version: " + $"{OSVersion.GetOSVersion().Version.Major}." +
                $"{OSVersion.GetOSVersion().Version.Minor}." +
                $"{OSVersion.GetOSVersion().Version.Build}" + $"");

            Console.WriteLine($"OS type: {OSVersion.GetOperatingSystem()}");
            Console.WriteLine($"is workstation: {OSVersion.IsWorkstation}");
            Console.WriteLine($"is server: {OSVersion.IsServer}");
            Console.WriteLine($"64-Bit OS: {OSVersion.Is64BitOperatingSystem}");

            if (OSVersion.GetOSVersion().Version.Major < 10)
            {
                return;
            }

            Console.WriteLine(
                $"Windows Release ID: {OSVersion.MajorVersion10Properties().ReleaseId ?? "(Unable to detect)"}");
            Console.WriteLine(
                $"Windows Display Version: {OSVersion.MajorVersion10Properties().DisplayVersion ?? "(Unable to detect)"}");
            Console.WriteLine(
                $"Windows Update Build Revision: {OSVersion.MajorVersion10Properties().UBR ?? "(Unable to detect)"}");
        }
    }
}

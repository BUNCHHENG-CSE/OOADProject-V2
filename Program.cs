using OOADPROV2.Forms;

namespace OOADPROV2;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new LoadingForm());
    }
}
public delegate void AmountCountEventHandler(object? sender, bool result);
public delegate void LoadingEventHandler(object? sender, bool result);
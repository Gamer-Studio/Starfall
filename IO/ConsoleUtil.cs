using System.Reflection;
using Spectre.Console;

namespace Starfall.IO
{
  public static class ConsoleUtil
  {
    public static Action StartCUIPart(bool cursorVisible = true)
    {
      ConsoleColor color = Console.ForegroundColor, background = Console.BackgroundColor;
      var visible = Console.CursorVisible;
      Console.CursorVisible = cursorVisible;

      return () =>
      {
        Console.BackgroundColor = background;
        Console.ForegroundColor = color;
        Console.CursorVisible = visible;
      };
    }

    public static void PrintTextFile(string path)
    {
      if (StorageController.TryGetResource(path, out var stream))
      {
        using var reader = new StreamReader(stream);
        AnsiConsole.MarkupLine(reader.ReadToEnd());
        reader.Close();
        stream.Close();
      }
    }
  }
}
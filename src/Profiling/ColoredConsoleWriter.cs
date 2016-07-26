using System;

namespace Profiling
{
	public class ColoredConsoleWriter : IColoredWriter
	{
		public void WriteLine(ConsoleColor color, string value)
		{
			lock (Console.Out)
			{
				var foregroundColor = Console.ForegroundColor;
				Console.ForegroundColor = color;
				Console.WriteLine(value);
				Console.ForegroundColor = foregroundColor;
			}
		}

		public void Write(ConsoleColor consoleColor, string value)
		{
			lock (Console.Out)
			{
				var foregroundColor = Console.ForegroundColor;
				Console.ForegroundColor = consoleColor;
				Console.Write(value);
				Console.ForegroundColor = foregroundColor;
			}
		}
	}
}

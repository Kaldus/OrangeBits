﻿using System;
using System.Diagnostics;
using OrangeBits;

namespace OrangeBits.Compilers
{
	public class JPGCompressor : ICompiler
	{
		public CompileResults Compile(string inPath, string outPath)
		{
			var info = new ProcessStartInfo();
			info.FileName = "optipng.exe";
			info.WindowStyle = ProcessWindowStyle.Hidden;
			info.Arguments = "\"" + inPath + "\" -o7";

			// Use Process for the application.
			using (var p = Process.Start(info))
			{
				p.WaitForExit();
			}

			return null;
		}
	}
}
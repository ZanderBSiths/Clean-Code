using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDProject;

namespace TDDProject
{
	public class ConsoleUI : IUI
	{
		public void Print(string text)
		{
			try
			{
				Console.WriteLine(text);
			}
			catch (Exception error)
			{

				throw new Exception($"Could not print string\n{error}");
			}

        }

		public string UserInput()
		{
			try
			{
				return Console.ReadLine();
			}
			catch (Exception error)
			{

				throw new Exception($"Could not get User input.\n{error}");
			}

		}
	}
}

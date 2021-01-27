using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırmalar
{
    class Program
    {
        static void Main(string[] args)
        {
			ValidatePIN("1234");
        }
		public static bool ValidatePIN(string pin)
		{
			int count = 0;
			string num = "1234567890";
			if (pin.Length != 4 && pin.Length != 6) return false;
			for (int i = 0; i < pin.Length; i++)
			{
				for (int j = 0; j < num.Length; j++)
				{
					if (pin[i] == num[j]) count++;
				}
			}
			if (count != pin.Length) return false;
			return true;
		}
	}
}

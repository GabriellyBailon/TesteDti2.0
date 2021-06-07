using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico
{
    public static class CalculaDia
    {
		public static int DiaDaSemana(DateTime data)
		{
			int diadasemana;
			int a, y, m, q, d;

			a = (14 - data.Month) / 12;
			y = data.Year - a;
			m = data.Month + (12 * a) - 2;
			q = data.Day + ((31 * m) / 12) + y + (y / 4) - (y / 100) + (y / 400);
			d = q % 7;

			diadasemana = d;

			return diadasemana;
		}
	}
}

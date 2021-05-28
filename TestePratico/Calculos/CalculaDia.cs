using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico
{
    public static class CalculaDia
    {
		public static int DiaDaSemana(int dia, int mes, int ano)
		{
			int diadasemana;
			int a, y, m, q, d;

			a = (14 - mes) / 12;
			y = ano - a;
			m = mes + (12 * a) - 2;
			q = dia + ((31 * m) / 12) + y + (y / 4) - (y / 100) + (y / 400);
			d = q % 7;

			diadasemana = d;

			return diadasemana;
		}
	}
}

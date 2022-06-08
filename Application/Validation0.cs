using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Performance
{
    public class Original {
        public static bool ValidarCPF(string nrCpf)
        {
                if (string.IsNullOrWhiteSpace(nrCpf))
                    return false;

                nrCpf = new string(nrCpf.Where(char.IsDigit).ToArray());

                if (nrCpf.Distinct().ToArray().Length == 1)
                {
                    return false;
                }

                if (nrCpf.Length < 11)
                {
                    return false;
                }

                List<int> digits = new List<int>();
                foreach (var element in nrCpf.Where(char.IsDigit).ToArray())
                {
                    digits.Add(int.Parse(element.ToString()));
                }
                for (var j = 0; j < 2; j++)
                {
                    var sum = 0;
                    for (var i = 0; i < 9 + j; i++)
                    {
                        sum += digits[i] * (10 + j - i);
                    }
                    var checkDigit = 11 - (sum % 11);
                    if (checkDigit == 10 || checkDigit == 11)
                    {
                        checkDigit = 0;
                    }
                    if (checkDigit != digits[9 + j])
                    {
                        return false;
                    }
                }
                return true;
        }
    }

}

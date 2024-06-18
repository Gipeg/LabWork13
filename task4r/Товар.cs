using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4r
{
        class Товар
        {
            public string Название { get; set; }
            public decimal Цена { get; set; }
            public DateTime СрокГодности { get; set; }

            public override string ToString()
            {
                string formattedPrice = Цена.ToString("0.00");
                string formattedDate = СрокГодности.ToString("yyyy-MM.dd");

                return $"{char.ToUpper(Название[0])}{Название.Substring(1)};{formattedPrice};{formattedDate}";
            }
        }
    }

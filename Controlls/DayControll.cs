using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFutebol.Controlls;

public static class DayControll
{
   public static string GetDayPtBR(DateTime time)
    {
        string output = time.DayOfWeek switch
        {
            DayOfWeek.Sunday => "Domingo",
            DayOfWeek.Monday => "Segunda-feira",
            DayOfWeek.Tuesday => "Terça-feira",
            DayOfWeek.Wednesday => "Quanta-feira",
            DayOfWeek.Thursday => "Quinta-feira",
            DayOfWeek.Friday => "Sexta-Feira",
            DayOfWeek.Saturday => "Sábado"
        };

        return output;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.ClasesDatosTablas
{
    public class Horario_Agenda
    {
        public long hag_id  { get; set; }
        public TimeSpan hag_horario_inicio { get; set; }
        public TimeSpan hag_horario_fin { get; set; }
        public long hag_id_agenda { get; set; }
        public int hag_dia_semana { get; set; }
        public int hag_disponible { get; set; }

        public DayOfWeek diaSemana()
        {
            DayOfWeek d;
            d = (DayOfWeek) hag_dia_semana - 1;
            return d;
        }

        public int cantMaxTurnos()
        {
            int turnos = 0;
            for (var hs = hag_horario_inicio.TotalMinutes; hs <= hag_horario_fin.TotalMinutes; hs+=30)
            {
                turnos++;
            }
            return turnos;
        }
    }
}

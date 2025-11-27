using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAssist
{
    public class Criticality
    {
        public enum TicketCriticality
        {
            [Description("Baixo")]
            Baixo = 1,

            [Description("Médio")]
            Medio = 2,

            [Description("Alto")]
            Alto = 3,

            [Description("Crítico")]
            Critico = 4
        }
    }
}

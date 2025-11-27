using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IAssist.Criticality;


namespace IAssist
{
    public class RootCauseResponse
    {
        public long Id { get; set; }
        public string RootCauseName { get; set; } = string.Empty;
        public TicketCriticality Criticality { get; set; }
        public string UpdatedAt { get; set; }
        public bool Active { get; set; }
    }
}

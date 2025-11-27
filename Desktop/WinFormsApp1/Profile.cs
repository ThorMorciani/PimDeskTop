using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAssist
{
    public class Profiles
    {
        public long Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        [Column("Profile")]
        public string ProfileName { get; set; } = string.Empty;

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime UpdatedAt { get; set; }

        public string UpdatedBy { get; set; } = string.Empty;

        public bool Active { get; set; }

        public ICollection<Users>? Users { get; set; }
    }
}

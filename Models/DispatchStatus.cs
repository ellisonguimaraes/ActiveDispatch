using System;
using System.Collections.Generic;

namespace ActiveDispatchProject.Models
{
    public class DispatchStatus
    {
        public long IdDispatchStatus { get; set; }
        public string StatusName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual List<Dispatch> Dispatches { get; set; }
    }
}

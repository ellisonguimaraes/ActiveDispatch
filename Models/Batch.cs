using System;

namespace ActiveDispatchProject.Models
{
    public class Batch
    {
        public long IdBatch { get; set; }
        public int BatchNumber { get; set; }
        public int Amount { get; set; }
        public DateTime SchedulingDate { get; set; }
        public bool Sent { get; set; }
        public DateTime CreatedAt { get; set; }

        public long FkCampaign { get; set; }
        public virtual Campaign Campaign { get; set; }

        public long FkDispatch { get; set; }
        public virtual Dispatch Dispatch { get; set; }
    }
}

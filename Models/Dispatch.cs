using System;
using System.Collections.Generic;

namespace ActiveDispatchProject.Models
{
    public class Dispatch
    {
        public long IdDispatch { get; set; }
        public string TemplateName { get; set; }
        public int CurrentBatch { get; set; }
        public int TotalBatches { get; set; }
        public int AwaitingCount { get; set; }
        public int SentCount { get; set; }
        public int ReceivedCount { get; set; }
        public int ViewedCount { get; set; }
        public int FailedCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public long FkCampaign { get; set; }
        public virtual Campaign Campaign { get; set; }

        public long FkUser { get; set; }
        public virtual CampaignUser CampaignUser { get; set; }

        public long FkDispatchStatus { get; set; }
        public virtual DispatchStatus DispatchStatus { get; set; }

        public virtual List<Batch> Batches { get; set; }
    }
}

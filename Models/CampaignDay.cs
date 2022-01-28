using System;

namespace ActiveDispatchProject.Models
{
    public class CampaignDay
    {
        public long IdCampaignDay { get; set; }
        public int WeekdayNumber { get; set; }
        public DateTime CreatedAt { get; set; }

        public long FkCampaign { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}

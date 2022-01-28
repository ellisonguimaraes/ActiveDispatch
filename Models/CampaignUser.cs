using System;
using System.Collections.Generic;

namespace ActiveDispatchProject.Models
{
    public class CampaignUser
    {
        public long IdCampaignUser { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public long FkCampaign { get; set; }
        public virtual Campaign Campaign { get; set; }

        public virtual List<Dispatch> Dispatches { get; set; }
    }
}

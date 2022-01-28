using System;
using System.Collections.Generic;

namespace ActiveDispatchProject.Models
{
    public class Campaign
    {
		public long IdCampaign { get; set; }
		public string CampaignName { get; set; }
		public string CampaignKey { get; set; }
		public int DailyLimit { get; set; }
		public string BotIdentifier { get; set; }
		public string FlowIdentifier { get; set; }
		public string StateId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public DateTime StartHour { get; set; }
		public DateTime EndHour { get; set; }
		public bool Active { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }

		public virtual List<Batch> Batches { get; set; }
		public virtual List<CampaignDay> CampaignDays { get; set; }
		public virtual List<CampaignUser> CampaignUsers { get; set; }
		public virtual List<Template> Templates { get; set; }
		public virtual List<Dispatch> Dispatches { get; set; }
	}
}

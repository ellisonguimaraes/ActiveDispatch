using System;

namespace ActiveDispatchProject.Models
{
    public class Template
    {
        public long IdTemplate { get; set; }
        public string TemplateName { get; set; }
        public DateTime CreatedAt { get; set; }

        public long FkCampaign { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}

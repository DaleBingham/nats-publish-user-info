using System;
namespace nats_publish_user_info.Models
{
    public class BaseClass
    {
        public long Id {get;set;}
        public DateTime Created  {get;set;}
        public DateTime? Updated {get;set;}
        public string CreatedString { get { return Created.ToString("MM/dd/yyyy hh:mm:ss"); }}
        public string UpdatedString { get { return (Updated.HasValue)? Updated.Value.ToString("MM/dd/yyyy hh:mm:ss") : null; }}
    }
}
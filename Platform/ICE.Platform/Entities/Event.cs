using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace ICE.Platform.Entities
{
    using Core;

    [Table("EVENTS")]
    public class Event : IPlatformEvent
    {
        [Column("EVENTID")]
        [Key]
        [JsonProperty(PropertyName = "eventId")]
        public string Id { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("MESSAGE")]
        public string Message { get; set; }
        [Column("SUBSCRIBERID")]
        public string SubscriberId { get; set; }

        #region "Audit Fields"
        [Column("CREATEDBY")]
        public string CreatedBy { get; set; }
        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }
        [Column("LASTMODIFIEDBY")]
        public string LastModifiedBy { get; set; }
        [Column("LASTMODIFIEDDATE")]
        public DateTime LastModifiedDate { get; set; }        
        #endregion
    }
}

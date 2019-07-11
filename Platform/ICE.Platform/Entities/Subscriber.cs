using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace ICE.Platform.Entities
{
    using Core;

    [Table("SUBSCRIBERS")]
    public class Subscriber : IPlatformEntity
    {
        [Column("SUBSCRIBERID")]
        [Key]
        [JsonProperty(PropertyName = "subscriberId")]
        public string Id { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        [Column("EVENTNAME")]
        public string EventName { get; set; }
        [Column("ACTIONTYPE")]
        public string ActionType { get; set; }

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

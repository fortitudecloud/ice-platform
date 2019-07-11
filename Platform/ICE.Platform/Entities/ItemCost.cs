using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace ICE.Platform.Entities
{
    using Core;

    [Table("ITEMCOST")]
    public class ItemCost : IPlatformEntity
    {
        [Column("ITEMCOSTID")]
        [Key]
        [JsonProperty(PropertyName = "itemCostId")]
        public string Id { get; set; }
        [Column("ITEMID")]
        public string ItemId { get; set; }
        [Column("ITEMCOST")]
        [JsonProperty(PropertyName = "itemCost")]
        public decimal _ItemCost { get; set; }
        [Column("EFFECTIVEDATE")]
        public DateTime EffectiveDate { get; set; }
        [Column("GSTINCLUSIVE")]
        public bool GstInclusive { get; set; }

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

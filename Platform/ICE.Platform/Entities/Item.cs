using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace ICE.Platform.Entities
{
    using Core;

    [Table("ITEMS")]
    public class Item : IPlatformEntity
    {
        [Column("ITEMID")]
        [Key]
        [JsonProperty(PropertyName = "itemId")]
        public string Id { get; set; }
        [Column("ITEMNAME")]
        public string ItemName { get; set; }
        [Column("ITEMDESCRIPTION")]
        public string ItemDescription { get; set; }
        [Column("GLACCOUNT")]
        public string GlAccount { get; set; }
        [Column("GLSUBACCOUNT")]
        public string GlSubAccount { get; set; }
        [Column("RETAINONCANCELFLG")]
        public bool RetainOnCancelFlg { get; set; }
        [Column("SERVICEITEMFLG")]
        public bool ServiceItemFlg { get; set; }
        [Column("PROPOSALITEMFLG")]
        public bool ProposalItemFlg { get; set; }
        [Column("PAYMENTGROUPID")]
        public string PaymentGroupId { get; set; }

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

using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

namespace ICE.Platform.Entities
{
    using Core;

    [Table("PAYMENTGROUP")]
    public class PaymentGroup : IPlatformEntity
    {
        [Column("PAYMENTGROUPID")]
        [Key]
        [JsonProperty(PropertyName = "paymentGroupId")]
        public string Id { get; set; }
        [Column("PAYMENTGROUPNAME")]
        public string PaymentGroupName { get; set; }
        [Column("PAYMENTGROUPDESCRIPTION")]
        public string PaymentGroupDescription { get; set; }
        [Column("DEFAULTGROUPFLG")]
        public bool DefaultGroupFlg { get; set; }
        [Column("RECALCULATEFLG")]
        public bool RecalculateFlg { get; set; }
        [Column("ALLOCATIONORDER")]
        public int AllocationOrder { get; set; }
        [Column("BILLABLEFLG")]
        public bool BillableFlg { get; set; }

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

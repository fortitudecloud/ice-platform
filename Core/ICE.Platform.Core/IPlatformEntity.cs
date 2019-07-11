using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Core
{
    /// <summary>
    /// Represents an entity type. E.g. An object relating to a given data table
    /// </summary>
    public interface IPlatformEntity
    {
        /// <summary>
        /// Primary key value on the record
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// Platform User ID value who created the record
        /// </summary>
        string CreatedBy { get; set; }
        /// <summary>
        /// Datetime the record was created
        /// </summary>
        DateTime CreatedDate { get; set; }
        /// <summary>
        /// Platform User ID value who last modified the record
        /// </summary>
        string LastModifiedBy { get; set; }
        /// <summary>
        /// Datetime the record was modified
        /// </summary>
        DateTime LastModifiedDate { get; set; }
    }
}

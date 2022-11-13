/* 
 * Xero AppStore API
 *
 * These endpoints are for Xero Partners to interact with the App Store Billing platform
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Appstore
{
    /// <summary>
    /// Response to get usage record
    /// </summary>
    [DataContract]
    public partial class UsageRecordsList :  IEquatable<UsageRecordsList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageRecordsList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public UsageRecordsList() 
        {  
          UsageRecords = new List<UsageRecord>(); 
        }
        
        /// <summary>
        /// A collection of usage records
        /// </summary>
        /// <value>A collection of usage records</value>
        [DataMember(Name="usageRecords", EmitDefaultValue=false)]
        public List<UsageRecord> UsageRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageRecordsList {\n");
            sb.Append("  UsageRecords: ").Append(UsageRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UsageRecordsList);
        }

        /// <summary>
        /// Returns true if UsageRecordsList instances are equal
        /// </summary>
        /// <param name="input">Instance of UsageRecordsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsageRecordsList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UsageRecords == input.UsageRecords ||
                    this.UsageRecords != null &&
                    input.UsageRecords != null &&
                    this.UsageRecords.SequenceEqual(input.UsageRecords)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.UsageRecords != null)
                    hashCode = hashCode * 59 + this.UsageRecords.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

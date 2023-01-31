/* 
 * Xero Finance API
 *
 * The Finance API is a collection of endpoints which customers can use in the course of a loan application, which may assist lenders to gain the confidence they need to provide capital.
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

namespace Xero.NetStandard.OAuth2.Model.Finance
{
    /// <summary>
    /// PrepaymentResponse
    /// </summary>
    [DataContract]
    public partial class PrepaymentResponse :  IEquatable<PrepaymentResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Xero Identifier of prepayment
        /// </summary>
        /// <value>Xero Identifier of prepayment</value>
        [DataMember(Name="prepaymentId", EmitDefaultValue=false)]
        public Guid? PrepaymentId { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ContactResponse Contact { get; set; }

        /// <summary>
        /// Total of Invoice tax inclusive (i.e. SubTotal + TotalTax); Not included in summary mode
        /// </summary>
        /// <value>Total of Invoice tax inclusive (i.e. SubTotal + TotalTax); Not included in summary mode</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Not included in summary mode
        /// </summary>
        /// <value>Not included in summary mode</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemResponse> LineItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrepaymentResponse {\n");
            sb.Append("  PrepaymentId: ").Append(PrepaymentId).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
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
            return this.Equals(input as PrepaymentResponse);
        }

        /// <summary>
        /// Returns true if PrepaymentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PrepaymentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrepaymentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrepaymentId == input.PrepaymentId ||
                    (this.PrepaymentId != null &&
                    this.PrepaymentId.Equals(input.PrepaymentId))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
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
                if (this.PrepaymentId != null)
                    hashCode = hashCode * 59 + this.PrepaymentId.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
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
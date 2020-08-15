/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.2.12
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Tracking categories for Employees and Timesheets
    /// </summary>
    [DataContract]
    public partial class SettingsTrackingCategories :  IEquatable<SettingsTrackingCategories>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets EmployeeGroups
        /// </summary>
        [DataMember(Name="EmployeeGroups", EmitDefaultValue=false)]
        public SettingsTrackingCategoriesEmployeeGroups EmployeeGroups { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetCategories
        /// </summary>
        [DataMember(Name="TimesheetCategories", EmitDefaultValue=false)]
        public SettingsTrackingCategoriesTimesheetCategories TimesheetCategories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingsTrackingCategories {\n");
            sb.Append("  EmployeeGroups: ").Append(EmployeeGroups).Append("\n");
            sb.Append("  TimesheetCategories: ").Append(TimesheetCategories).Append("\n");
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
            return this.Equals(input as SettingsTrackingCategories);
        }

        /// <summary>
        /// Returns true if SettingsTrackingCategories instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingsTrackingCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingsTrackingCategories input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeGroups == input.EmployeeGroups ||
                    (this.EmployeeGroups != null &&
                    this.EmployeeGroups.Equals(input.EmployeeGroups))
                ) && 
                (
                    this.TimesheetCategories == input.TimesheetCategories ||
                    (this.TimesheetCategories != null &&
                    this.TimesheetCategories.Equals(input.TimesheetCategories))
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
                if (this.EmployeeGroups != null)
                    hashCode = hashCode * 59 + this.EmployeeGroups.GetHashCode();
                if (this.TimesheetCategories != null)
                    hashCode = hashCode * 59 + this.TimesheetCategories.GetHashCode();
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
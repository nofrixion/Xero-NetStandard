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
    /// SuperFund
    /// </summary>
    [DataContract]
    public partial class SuperFund :  IEquatable<SuperFund>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public SuperFundType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SuperFund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SuperFund() 
        {  
          ValidationErrors = new List<ValidationError>(); 
        }
        
        /// <summary>
        /// Xero identifier for a super fund
        /// </summary>
        /// <value>Xero identifier for a super fund</value>
        [DataMember(Name="SuperFundID", EmitDefaultValue=false)]
        public Guid? SuperFundID { get; set; }

        /// <summary>
        /// Name of the super fund
        /// </summary>
        /// <value>Name of the super fund</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ABN of the self managed super fund
        /// </summary>
        /// <value>ABN of the self managed super fund</value>
        [DataMember(Name="ABN", EmitDefaultValue=false)]
        public string ABN { get; set; }

        /// <summary>
        /// BSB of the self managed super fund
        /// </summary>
        /// <value>BSB of the self managed super fund</value>
        [DataMember(Name="BSB", EmitDefaultValue=false)]
        public string BSB { get; set; }

        /// <summary>
        /// The account number for the self managed super fund.
        /// </summary>
        /// <value>The account number for the self managed super fund.</value>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The account name for the self managed super fund.
        /// </summary>
        /// <value>The account name for the self managed super fund.</value>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The electronic service address for the self managed super fund.
        /// </summary>
        /// <value>The electronic service address for the self managed super fund.</value>
        [DataMember(Name="ElectronicServiceAddress", EmitDefaultValue=false)]
        public string ElectronicServiceAddress { get; set; }

        /// <summary>
        /// Some funds assign a unique number to each employer
        /// </summary>
        /// <value>Some funds assign a unique number to each employer</value>
        [DataMember(Name="EmployerNumber", EmitDefaultValue=false)]
        public string EmployerNumber { get; set; }

        /// <summary>
        /// The SPIN of the Regulated SuperFund. This field has been deprecated. It will only be present for legacy superfunds. New superfunds will not have a SPIN value. The USI field should be used instead of SPIN.
        /// </summary>
        /// <value>The SPIN of the Regulated SuperFund. This field has been deprecated. It will only be present for legacy superfunds. New superfunds will not have a SPIN value. The USI field should be used instead of SPIN.</value>
        [DataMember(Name="SPIN", EmitDefaultValue=false)]
        public string SPIN { get; set; }

        /// <summary>
        /// The USI of the Regulated SuperFund
        /// </summary>
        /// <value>The USI of the Regulated SuperFund</value>
        [DataMember(Name="USI", EmitDefaultValue=false)]
        public string USI { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperFund {\n");
            sb.Append("  SuperFundID: ").Append(SuperFundID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ABN: ").Append(ABN).Append("\n");
            sb.Append("  BSB: ").Append(BSB).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ElectronicServiceAddress: ").Append(ElectronicServiceAddress).Append("\n");
            sb.Append("  EmployerNumber: ").Append(EmployerNumber).Append("\n");
            sb.Append("  SPIN: ").Append(SPIN).Append("\n");
            sb.Append("  USI: ").Append(USI).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as SuperFund);
        }

        /// <summary>
        /// Returns true if SuperFund instances are equal
        /// </summary>
        /// <param name="input">Instance of SuperFund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperFund input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuperFundID == input.SuperFundID ||
                    (this.SuperFundID != null &&
                    this.SuperFundID.Equals(input.SuperFundID))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ABN == input.ABN ||
                    (this.ABN != null &&
                    this.ABN.Equals(input.ABN))
                ) && 
                (
                    this.BSB == input.BSB ||
                    (this.BSB != null &&
                    this.BSB.Equals(input.BSB))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.ElectronicServiceAddress == input.ElectronicServiceAddress ||
                    (this.ElectronicServiceAddress != null &&
                    this.ElectronicServiceAddress.Equals(input.ElectronicServiceAddress))
                ) && 
                (
                    this.EmployerNumber == input.EmployerNumber ||
                    (this.EmployerNumber != null &&
                    this.EmployerNumber.Equals(input.EmployerNumber))
                ) && 
                (
                    this.SPIN == input.SPIN ||
                    (this.SPIN != null &&
                    this.SPIN.Equals(input.SPIN))
                ) && 
                (
                    this.USI == input.USI ||
                    (this.USI != null &&
                    this.USI.Equals(input.USI))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.SuperFundID != null)
                    hashCode = hashCode * 59 + this.SuperFundID.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ABN != null)
                    hashCode = hashCode * 59 + this.ABN.GetHashCode();
                if (this.BSB != null)
                    hashCode = hashCode * 59 + this.BSB.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.ElectronicServiceAddress != null)
                    hashCode = hashCode * 59 + this.ElectronicServiceAddress.GetHashCode();
                if (this.EmployerNumber != null)
                    hashCode = hashCode * 59 + this.EmployerNumber.GetHashCode();
                if (this.SPIN != null)
                    hashCode = hashCode * 59 + this.SPIN.GetHashCode();
                if (this.USI != null)
                    hashCode = hashCode * 59 + this.USI.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
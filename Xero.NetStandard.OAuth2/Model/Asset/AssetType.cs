/* 
 * Xero Assets API
 *
 * This is the Xero Assets API
 *
 * The version of the OpenAPI document: 2.2.15
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

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// AssetType
    /// </summary>
    [DataContract]
    public partial class AssetType :  IEquatable<AssetType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AssetType() 
        { 
        }
        
        /// <summary>
        /// Xero generated unique identifier for asset types
        /// </summary>
        /// <value>Xero generated unique identifier for asset types</value>
        [DataMember(Name="assetTypeId", EmitDefaultValue=false)]
        public Guid? AssetTypeId { get; set; }

        /// <summary>
        /// The name of the asset type
        /// </summary>
        /// <value>The name of the asset type</value>
        [DataMember(Name="assetTypeName", EmitDefaultValue=false)]
        public string AssetTypeName { get; set; }

        /// <summary>
        /// The asset account for fixed assets of this type
        /// </summary>
        /// <value>The asset account for fixed assets of this type</value>
        [DataMember(Name="fixedAssetAccountId", EmitDefaultValue=false)]
        public Guid? FixedAssetAccountId { get; set; }

        /// <summary>
        /// The expense account for the depreciation of fixed assets of this type
        /// </summary>
        /// <value>The expense account for the depreciation of fixed assets of this type</value>
        [DataMember(Name="depreciationExpenseAccountId", EmitDefaultValue=false)]
        public Guid? DepreciationExpenseAccountId { get; set; }

        /// <summary>
        /// The account for accumulated depreciation of fixed assets of this type
        /// </summary>
        /// <value>The account for accumulated depreciation of fixed assets of this type</value>
        [DataMember(Name="accumulatedDepreciationAccountId", EmitDefaultValue=false)]
        public Guid? AccumulatedDepreciationAccountId { get; set; }

        /// <summary>
        /// Gets or Sets BookDepreciationSetting
        /// </summary>
        [DataMember(Name="bookDepreciationSetting", EmitDefaultValue=false)]
        public BookDepreciationSetting BookDepreciationSetting { get; set; }

        /// <summary>
        /// All asset types that have accumulated depreciation for any assets that use them are deemed ‘locked’ and cannot be removed.
        /// </summary>
        /// <value>All asset types that have accumulated depreciation for any assets that use them are deemed ‘locked’ and cannot be removed.</value>
        [DataMember(Name="locks", EmitDefaultValue=false)]
        public int? Locks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetType {\n");
            sb.Append("  AssetTypeId: ").Append(AssetTypeId).Append("\n");
            sb.Append("  AssetTypeName: ").Append(AssetTypeName).Append("\n");
            sb.Append("  FixedAssetAccountId: ").Append(FixedAssetAccountId).Append("\n");
            sb.Append("  DepreciationExpenseAccountId: ").Append(DepreciationExpenseAccountId).Append("\n");
            sb.Append("  AccumulatedDepreciationAccountId: ").Append(AccumulatedDepreciationAccountId).Append("\n");
            sb.Append("  BookDepreciationSetting: ").Append(BookDepreciationSetting).Append("\n");
            sb.Append("  Locks: ").Append(Locks).Append("\n");
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
            return this.Equals(input as AssetType);
        }

        /// <summary>
        /// Returns true if AssetType instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetTypeId == input.AssetTypeId ||
                    (this.AssetTypeId != null &&
                    this.AssetTypeId.Equals(input.AssetTypeId))
                ) && 
                (
                    this.AssetTypeName == input.AssetTypeName ||
                    (this.AssetTypeName != null &&
                    this.AssetTypeName.Equals(input.AssetTypeName))
                ) && 
                (
                    this.FixedAssetAccountId == input.FixedAssetAccountId ||
                    (this.FixedAssetAccountId != null &&
                    this.FixedAssetAccountId.Equals(input.FixedAssetAccountId))
                ) && 
                (
                    this.DepreciationExpenseAccountId == input.DepreciationExpenseAccountId ||
                    (this.DepreciationExpenseAccountId != null &&
                    this.DepreciationExpenseAccountId.Equals(input.DepreciationExpenseAccountId))
                ) && 
                (
                    this.AccumulatedDepreciationAccountId == input.AccumulatedDepreciationAccountId ||
                    (this.AccumulatedDepreciationAccountId != null &&
                    this.AccumulatedDepreciationAccountId.Equals(input.AccumulatedDepreciationAccountId))
                ) && 
                (
                    this.BookDepreciationSetting == input.BookDepreciationSetting ||
                    (this.BookDepreciationSetting != null &&
                    this.BookDepreciationSetting.Equals(input.BookDepreciationSetting))
                ) && 
                (
                    this.Locks == input.Locks ||
                    this.Locks.Equals(input.Locks)
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
                if (this.AssetTypeId != null)
                    hashCode = hashCode * 59 + this.AssetTypeId.GetHashCode();
                if (this.AssetTypeName != null)
                    hashCode = hashCode * 59 + this.AssetTypeName.GetHashCode();
                if (this.FixedAssetAccountId != null)
                    hashCode = hashCode * 59 + this.FixedAssetAccountId.GetHashCode();
                if (this.DepreciationExpenseAccountId != null)
                    hashCode = hashCode * 59 + this.DepreciationExpenseAccountId.GetHashCode();
                if (this.AccumulatedDepreciationAccountId != null)
                    hashCode = hashCode * 59 + this.AccumulatedDepreciationAccountId.GetHashCode();
                if (this.BookDepreciationSetting != null)
                    hashCode = hashCode * 59 + this.BookDepreciationSetting.GetHashCode();
                hashCode = hashCode * 59 + this.Locks.GetHashCode();
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

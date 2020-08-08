/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.11
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Quote
    /// </summary>
    [DataContract]
    public partial class Quote :  IEquatable<Quote>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public QuoteStatusCodes Status { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public CurrencyCode CurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets LineAmountTypes
        /// </summary>
        [DataMember(Name="LineAmountTypes", EmitDefaultValue=false)]
        public QuoteLineAmountTypes LineAmountTypes { get; set; }
        
        /// <summary>
        /// QuoteID GUID is automatically generated and is returned after create or GET.
        /// </summary>
        /// <value>QuoteID GUID is automatically generated and is returned after create or GET.</value>
        [DataMember(Name="QuoteID", EmitDefaultValue=false)]
        public Guid? QuoteID { get; set; }

        /// <summary>
        /// Unique alpha numeric code identifying a quote (Max Length &#x3D; 255)
        /// </summary>
        /// <value>Unique alpha numeric code identifying a quote (Max Length &#x3D; 255)</value>
        [DataMember(Name="QuoteNumber", EmitDefaultValue=false)]
        public string QuoteNumber { get; set; }

        /// <summary>
        /// Additional reference number
        /// </summary>
        /// <value>Additional reference number</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Terms of the quote
        /// </summary>
        /// <value>Terms of the quote</value>
        [DataMember(Name="Terms", EmitDefaultValue=false)]
        public string Terms { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// See LineItems
        /// </summary>
        /// <value>See LineItems</value>
        [DataMember(Name="LineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Date quote was issued – YYYY-MM-DD. If the Date element is not specified it will default to the current date based on the timezone setting of the organisation
        /// </summary>
        /// <value>Date quote was issued – YYYY-MM-DD. If the Date element is not specified it will default to the current date based on the timezone setting of the organisation</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Date the quote was issued (YYYY-MM-DD)
        /// </summary>
        /// <value>Date the quote was issued (YYYY-MM-DD)</value>
        [DataMember(Name="DateString", EmitDefaultValue=false)]
        public string DateString { get; set; }

        /// <summary>
        /// Date the quote expires – YYYY-MM-DD.
        /// </summary>
        /// <value>Date the quote expires – YYYY-MM-DD.</value>
        [DataMember(Name="ExpiryDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Date the quote expires – YYYY-MM-DD.
        /// </summary>
        /// <value>Date the quote expires – YYYY-MM-DD.</value>
        [DataMember(Name="ExpiryDateString", EmitDefaultValue=false)]
        public string ExpiryDateString { get; set; }

        /// <summary>
        /// The currency rate for a multicurrency quote
        /// </summary>
        /// <value>The currency rate for a multicurrency quote</value>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public double? CurrencyRate { get; set; }

        /// <summary>
        /// Total of quote excluding taxes.
        /// </summary>
        /// <value>Total of quote excluding taxes.</value>
        [DataMember(Name="SubTotal", EmitDefaultValue=false)]
        public decimal? SubTotal { get; private set; }

        /// <summary>
        /// Total tax on quote
        /// </summary>
        /// <value>Total tax on quote</value>
        [DataMember(Name="TotalTax", EmitDefaultValue=false)]
        public decimal? TotalTax { get; private set; }

        /// <summary>
        /// Total of Quote tax inclusive (i.e. SubTotal + TotalTax). This will be ignored if it doesn’t equal the sum of the LineAmounts
        /// </summary>
        /// <value>Total of Quote tax inclusive (i.e. SubTotal + TotalTax). This will be ignored if it doesn’t equal the sum of the LineAmounts</value>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public decimal? Total { get; private set; }

        /// <summary>
        /// Total of discounts applied on the quote line items
        /// </summary>
        /// <value>Total of discounts applied on the quote line items</value>
        [DataMember(Name="TotalDiscount", EmitDefaultValue=false)]
        public decimal? TotalDiscount { get; private set; }

        /// <summary>
        /// Title text for the quote
        /// </summary>
        /// <value>Title text for the quote</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Summary text for the quote
        /// </summary>
        /// <value>Summary text for the quote</value>
        [DataMember(Name="Summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// See BrandingThemes
        /// </summary>
        /// <value>See BrandingThemes</value>
        [DataMember(Name="BrandingThemeID", EmitDefaultValue=false)]
        public Guid? BrandingThemeID { get; set; }

        /// <summary>
        /// Last modified date UTC format
        /// </summary>
        /// <value>Last modified date UTC format</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// A string to indicate if a invoice status
        /// </summary>
        /// <value>A string to indicate if a invoice status</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

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
            sb.Append("class Quote {\n");
            sb.Append("  QuoteID: ").Append(QuoteID).Append("\n");
            sb.Append("  QuoteNumber: ").Append(QuoteNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateString: ").Append(DateString).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  ExpiryDateString: ").Append(ExpiryDateString).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  BrandingThemeID: ").Append(BrandingThemeID).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  LineAmountTypes: ").Append(LineAmountTypes).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
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
            return this.Equals(input as Quote);
        }

        /// <summary>
        /// Returns true if Quote instances are equal
        /// </summary>
        /// <param name="input">Instance of Quote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteID == input.QuoteID ||
                    (this.QuoteID != null &&
                    this.QuoteID.Equals(input.QuoteID))
                ) && 
                (
                    this.QuoteNumber == input.QuoteNumber ||
                    (this.QuoteNumber != null &&
                    this.QuoteNumber.Equals(input.QuoteNumber))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DateString == input.DateString ||
                    (this.DateString != null &&
                    this.DateString.Equals(input.DateString))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.ExpiryDateString == input.ExpiryDateString ||
                    (this.ExpiryDateString != null &&
                    this.ExpiryDateString.Equals(input.ExpiryDateString))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    this.CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    this.CurrencyRate.Equals(input.CurrencyRate)
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    this.SubTotal.Equals(input.SubTotal)
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    this.TotalTax.Equals(input.TotalTax)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.TotalDiscount == input.TotalDiscount ||
                    this.TotalDiscount.Equals(input.TotalDiscount)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.BrandingThemeID == input.BrandingThemeID ||
                    (this.BrandingThemeID != null &&
                    this.BrandingThemeID.Equals(input.BrandingThemeID))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.LineAmountTypes == input.LineAmountTypes ||
                    this.LineAmountTypes.Equals(input.LineAmountTypes)
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
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
                if (this.QuoteID != null)
                    hashCode = hashCode * 59 + this.QuoteID.GetHashCode();
                if (this.QuoteNumber != null)
                    hashCode = hashCode * 59 + this.QuoteNumber.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DateString != null)
                    hashCode = hashCode * 59 + this.DateString.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.ExpiryDateString != null)
                    hashCode = hashCode * 59 + this.ExpiryDateString.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                hashCode = hashCode * 59 + this.TotalTax.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                hashCode = hashCode * 59 + this.TotalDiscount.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.BrandingThemeID != null)
                    hashCode = hashCode * 59 + this.BrandingThemeID.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                hashCode = hashCode * 59 + this.LineAmountTypes.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
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
            // QuoteNumber (string) maxLength
            if(this.QuoteNumber != null && this.QuoteNumber.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for QuoteNumber, length must be less than 255.", new [] { "QuoteNumber" });
            }

            // Reference (string) maxLength
            if(this.Reference != null && this.Reference.Length > 4000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 4000.", new [] { "Reference" });
            }

            // Terms (string) maxLength
            if(this.Terms != null && this.Terms.Length > 4000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Terms, length must be less than 4000.", new [] { "Terms" });
            }

            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 100.", new [] { "Title" });
            }

            // Summary (string) maxLength
            if(this.Summary != null && this.Summary.Length > 3000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Summary, length must be less than 3000.", new [] { "Summary" });
            }

            yield break;
        }
    }

}

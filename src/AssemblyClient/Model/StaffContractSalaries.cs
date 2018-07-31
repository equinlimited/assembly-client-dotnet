/* 
 * assembly.education
 *
 * Developer API for assembly.education.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = AssemblyClient.Client.SwaggerDateConverter;

namespace AssemblyClient.Model
{
    /// <summary>
    /// No description
    /// </summary>
    [DataContract]
    public partial class StaffContractSalaries :  IEquatable<StaffContractSalaries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffContractSalaries" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="hoursPerWeek">No description.</param>
        /// <param name="fte">No description.</param>
        /// <param name="weeksPerYear">No description.</param>
        /// <param name="payRange">No description.</param>
        /// <param name="startDate">No description.</param>
        /// <param name="endDate">No description.</param>
        /// <param name="payScaleFramework">No description.</param>
        /// <param name="regionalSpine">No description.</param>
        /// <param name="basePay">No description.</param>
        /// <param name="actualPay">No description.</param>
        /// <param name="safeguardedSalary">No description.</param>
        public StaffContractSalaries(string _object = default(string), float? hoursPerWeek = default(float?), float? fte = default(float?), float? weeksPerYear = default(float?), string payRange = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string payScaleFramework = default(string), string regionalSpine = default(string), float? basePay = default(float?), float? actualPay = default(float?), bool? safeguardedSalary = default(bool?))
        {
            this.Object = _object;
            this.HoursPerWeek = hoursPerWeek;
            this.Fte = fte;
            this.WeeksPerYear = weeksPerYear;
            this.PayRange = payRange;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.PayScaleFramework = payScaleFramework;
            this.RegionalSpine = regionalSpine;
            this.BasePay = basePay;
            this.ActualPay = actualPay;
            this.SafeguardedSalary = safeguardedSalary;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="hours_per_week", EmitDefaultValue=false)]
        public float? HoursPerWeek { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="fte", EmitDefaultValue=false)]
        public float? Fte { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="weeks_per_year", EmitDefaultValue=false)]
        public float? WeeksPerYear { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="pay_range", EmitDefaultValue=false)]
        public string PayRange { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="pay_scale_framework", EmitDefaultValue=false)]
        public string PayScaleFramework { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="regional_spine", EmitDefaultValue=false)]
        public string RegionalSpine { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="base_pay", EmitDefaultValue=false)]
        public float? BasePay { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="actual_pay", EmitDefaultValue=false)]
        public float? ActualPay { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="safeguarded_salary", EmitDefaultValue=false)]
        public bool? SafeguardedSalary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffContractSalaries {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  HoursPerWeek: ").Append(HoursPerWeek).Append("\n");
            sb.Append("  Fte: ").Append(Fte).Append("\n");
            sb.Append("  WeeksPerYear: ").Append(WeeksPerYear).Append("\n");
            sb.Append("  PayRange: ").Append(PayRange).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PayScaleFramework: ").Append(PayScaleFramework).Append("\n");
            sb.Append("  RegionalSpine: ").Append(RegionalSpine).Append("\n");
            sb.Append("  BasePay: ").Append(BasePay).Append("\n");
            sb.Append("  ActualPay: ").Append(ActualPay).Append("\n");
            sb.Append("  SafeguardedSalary: ").Append(SafeguardedSalary).Append("\n");
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
            return this.Equals(input as StaffContractSalaries);
        }

        /// <summary>
        /// Returns true if StaffContractSalaries instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffContractSalaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffContractSalaries input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.HoursPerWeek == input.HoursPerWeek ||
                    (this.HoursPerWeek != null &&
                    this.HoursPerWeek.Equals(input.HoursPerWeek))
                ) && 
                (
                    this.Fte == input.Fte ||
                    (this.Fte != null &&
                    this.Fte.Equals(input.Fte))
                ) && 
                (
                    this.WeeksPerYear == input.WeeksPerYear ||
                    (this.WeeksPerYear != null &&
                    this.WeeksPerYear.Equals(input.WeeksPerYear))
                ) && 
                (
                    this.PayRange == input.PayRange ||
                    (this.PayRange != null &&
                    this.PayRange.Equals(input.PayRange))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.PayScaleFramework == input.PayScaleFramework ||
                    (this.PayScaleFramework != null &&
                    this.PayScaleFramework.Equals(input.PayScaleFramework))
                ) && 
                (
                    this.RegionalSpine == input.RegionalSpine ||
                    (this.RegionalSpine != null &&
                    this.RegionalSpine.Equals(input.RegionalSpine))
                ) && 
                (
                    this.BasePay == input.BasePay ||
                    (this.BasePay != null &&
                    this.BasePay.Equals(input.BasePay))
                ) && 
                (
                    this.ActualPay == input.ActualPay ||
                    (this.ActualPay != null &&
                    this.ActualPay.Equals(input.ActualPay))
                ) && 
                (
                    this.SafeguardedSalary == input.SafeguardedSalary ||
                    (this.SafeguardedSalary != null &&
                    this.SafeguardedSalary.Equals(input.SafeguardedSalary))
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
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.HoursPerWeek != null)
                    hashCode = hashCode * 59 + this.HoursPerWeek.GetHashCode();
                if (this.Fte != null)
                    hashCode = hashCode * 59 + this.Fte.GetHashCode();
                if (this.WeeksPerYear != null)
                    hashCode = hashCode * 59 + this.WeeksPerYear.GetHashCode();
                if (this.PayRange != null)
                    hashCode = hashCode * 59 + this.PayRange.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.PayScaleFramework != null)
                    hashCode = hashCode * 59 + this.PayScaleFramework.GetHashCode();
                if (this.RegionalSpine != null)
                    hashCode = hashCode * 59 + this.RegionalSpine.GetHashCode();
                if (this.BasePay != null)
                    hashCode = hashCode * 59 + this.BasePay.GetHashCode();
                if (this.ActualPay != null)
                    hashCode = hashCode * 59 + this.ActualPay.GetHashCode();
                if (this.SafeguardedSalary != null)
                    hashCode = hashCode * 59 + this.SafeguardedSalary.GetHashCode();
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
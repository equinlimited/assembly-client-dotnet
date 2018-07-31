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
    /// A staff contract object represents a contract for a staff member within a school.
    /// </summary>
    [DataContract]
    public partial class StaffContractListData :  IEquatable<StaffContractListData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffContractListData" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="id">Internal stable ID given to each contract in the Platform.</param>
        /// <param name="staffMemberId">The ID of the staff member.</param>
        /// <param name="startDate">Contract start date.</param>
        /// <param name="endDate">Contract end date.</param>
        /// <param name="nationalInsuranceNumber">Employee NI number.</param>
        /// <param name="payrollNumber">Employee payroll number.</param>
        /// <param name="contractType">Contract type.</param>
        /// <param name="post">No description.</param>
        /// <param name="origin">No description.</param>
        /// <param name="destination">Completed after a contract has been terminated; this captures a post-holder’s destination.</param>
        /// <param name="dailyRate">No description.</param>
        /// <param name="payReviewDate">No description.</param>
        /// <param name="roles">No description.</param>
        /// <param name="salaries">No description.</param>
        /// <param name="allowances">No description.</param>
        public StaffContractListData(string _object = default(string), int? id = default(int?), string staffMemberId = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string nationalInsuranceNumber = default(string), string payrollNumber = default(string), string contractType = default(string), string post = default(string), string origin = default(string), string destination = default(string), bool? dailyRate = default(bool?), DateTime? payReviewDate = default(DateTime?), List<StaffContractRoles> roles = default(List<StaffContractRoles>), List<StaffContractSalaries> salaries = default(List<StaffContractSalaries>), List<StaffContractAllowances> allowances = default(List<StaffContractAllowances>))
        {
            this.Object = _object;
            this.Id = id;
            this.StaffMemberId = staffMemberId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.NationalInsuranceNumber = nationalInsuranceNumber;
            this.PayrollNumber = payrollNumber;
            this.ContractType = contractType;
            this.Post = post;
            this.Origin = origin;
            this.Destination = destination;
            this.DailyRate = dailyRate;
            this.PayReviewDate = payReviewDate;
            this.Roles = roles;
            this.Salaries = salaries;
            this.Allowances = allowances;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Internal stable ID given to each contract in the Platform
        /// </summary>
        /// <value>Internal stable ID given to each contract in the Platform</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The ID of the staff member
        /// </summary>
        /// <value>The ID of the staff member</value>
        [DataMember(Name="staff_member_id", EmitDefaultValue=false)]
        public string StaffMemberId { get; set; }

        /// <summary>
        /// Contract start date
        /// </summary>
        /// <value>Contract start date</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Contract end date
        /// </summary>
        /// <value>Contract end date</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Employee NI number
        /// </summary>
        /// <value>Employee NI number</value>
        [DataMember(Name="national_insurance_number", EmitDefaultValue=false)]
        public string NationalInsuranceNumber { get; set; }

        /// <summary>
        /// Employee payroll number
        /// </summary>
        /// <value>Employee payroll number</value>
        [DataMember(Name="payroll_number", EmitDefaultValue=false)]
        public string PayrollNumber { get; set; }

        /// <summary>
        /// Contract type
        /// </summary>
        /// <value>Contract type</value>
        [DataMember(Name="contract_type", EmitDefaultValue=false)]
        public string ContractType { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="post", EmitDefaultValue=false)]
        public string Post { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }

        /// <summary>
        /// Completed after a contract has been terminated; this captures a post-holder’s destination
        /// </summary>
        /// <value>Completed after a contract has been terminated; this captures a post-holder’s destination</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="daily_rate", EmitDefaultValue=false)]
        public bool? DailyRate { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="pay_review_date", EmitDefaultValue=false)]
        public DateTime? PayReviewDate { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<StaffContractRoles> Roles { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="salaries", EmitDefaultValue=false)]
        public List<StaffContractSalaries> Salaries { get; set; }

        /// <summary>
        /// No description
        /// </summary>
        /// <value>No description</value>
        [DataMember(Name="allowances", EmitDefaultValue=false)]
        public List<StaffContractAllowances> Allowances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffContractListData {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StaffMemberId: ").Append(StaffMemberId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  NationalInsuranceNumber: ").Append(NationalInsuranceNumber).Append("\n");
            sb.Append("  PayrollNumber: ").Append(PayrollNumber).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  Post: ").Append(Post).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  DailyRate: ").Append(DailyRate).Append("\n");
            sb.Append("  PayReviewDate: ").Append(PayReviewDate).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Salaries: ").Append(Salaries).Append("\n");
            sb.Append("  Allowances: ").Append(Allowances).Append("\n");
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
            return this.Equals(input as StaffContractListData);
        }

        /// <summary>
        /// Returns true if StaffContractListData instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffContractListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffContractListData input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.StaffMemberId == input.StaffMemberId ||
                    (this.StaffMemberId != null &&
                    this.StaffMemberId.Equals(input.StaffMemberId))
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
                    this.NationalInsuranceNumber == input.NationalInsuranceNumber ||
                    (this.NationalInsuranceNumber != null &&
                    this.NationalInsuranceNumber.Equals(input.NationalInsuranceNumber))
                ) && 
                (
                    this.PayrollNumber == input.PayrollNumber ||
                    (this.PayrollNumber != null &&
                    this.PayrollNumber.Equals(input.PayrollNumber))
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) && 
                (
                    this.Post == input.Post ||
                    (this.Post != null &&
                    this.Post.Equals(input.Post))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.DailyRate == input.DailyRate ||
                    (this.DailyRate != null &&
                    this.DailyRate.Equals(input.DailyRate))
                ) && 
                (
                    this.PayReviewDate == input.PayReviewDate ||
                    (this.PayReviewDate != null &&
                    this.PayReviewDate.Equals(input.PayReviewDate))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Salaries == input.Salaries ||
                    this.Salaries != null &&
                    this.Salaries.SequenceEqual(input.Salaries)
                ) && 
                (
                    this.Allowances == input.Allowances ||
                    this.Allowances != null &&
                    this.Allowances.SequenceEqual(input.Allowances)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StaffMemberId != null)
                    hashCode = hashCode * 59 + this.StaffMemberId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.NationalInsuranceNumber != null)
                    hashCode = hashCode * 59 + this.NationalInsuranceNumber.GetHashCode();
                if (this.PayrollNumber != null)
                    hashCode = hashCode * 59 + this.PayrollNumber.GetHashCode();
                if (this.ContractType != null)
                    hashCode = hashCode * 59 + this.ContractType.GetHashCode();
                if (this.Post != null)
                    hashCode = hashCode * 59 + this.Post.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.DailyRate != null)
                    hashCode = hashCode * 59 + this.DailyRate.GetHashCode();
                if (this.PayReviewDate != null)
                    hashCode = hashCode * 59 + this.PayReviewDate.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Salaries != null)
                    hashCode = hashCode * 59 + this.Salaries.GetHashCode();
                if (this.Allowances != null)
                    hashCode = hashCode * 59 + this.Allowances.GetHashCode();
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
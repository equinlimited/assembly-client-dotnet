/* 
 * Assembly Developer API
 *
 * The Assembly API is built around the REST and a collection of open standards/protocols in order to comply with as many consumers as possible.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: help@assembly.education
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
using OpenAPIDateConverter = AssemblyClient.Client.OpenAPIDateConverter;

namespace AssemblyClient.Model
{
    /// <summary>
    /// RegistrationGroup
    /// </summary>
    [DataContract]
    public partial class RegistrationGroup :  IEquatable<RegistrationGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationGroup" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="supervisorIds">supervisorIds.</param>
        /// <param name="studentIds">studentIds.</param>
        /// <param name="subject">subject.</param>
        public RegistrationGroup(int? id = default(int?), string name = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), List<int?> supervisorIds = default(List<int?>), List<int?> studentIds = default(List<int?>), Subject subject = default(Subject))
        {
            this.Id = id;
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.SupervisorIds = supervisorIds;
            this.StudentIds = studentIds;
            this.Subject = subject;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets SupervisorIds
        /// </summary>
        [DataMember(Name="supervisor_ids", EmitDefaultValue=false)]
        public List<int?> SupervisorIds { get; set; }

        /// <summary>
        /// Gets or Sets StudentIds
        /// </summary>
        [DataMember(Name="student_ids", EmitDefaultValue=false)]
        public List<int?> StudentIds { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public Subject Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegistrationGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  SupervisorIds: ").Append(SupervisorIds).Append("\n");
            sb.Append("  StudentIds: ").Append(StudentIds).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as RegistrationGroup);
        }

        /// <summary>
        /// Returns true if RegistrationGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.SupervisorIds == input.SupervisorIds ||
                    this.SupervisorIds != null &&
                    this.SupervisorIds.SequenceEqual(input.SupervisorIds)
                ) && 
                (
                    this.StudentIds == input.StudentIds ||
                    this.StudentIds != null &&
                    this.StudentIds.SequenceEqual(input.StudentIds)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.SupervisorIds != null)
                    hashCode = hashCode * 59 + this.SupervisorIds.GetHashCode();
                if (this.StudentIds != null)
                    hashCode = hashCode * 59 + this.StudentIds.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
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

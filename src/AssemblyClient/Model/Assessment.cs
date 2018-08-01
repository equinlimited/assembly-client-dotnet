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
    /// Assessment
    /// </summary>
    [DataContract]
    public partial class Assessment :  IEquatable<Assessment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Assessment" /> class.
        /// </summary>
        /// <param name="familyId">familyId.</param>
        /// <param name="familyName">familyName.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        public Assessment(int? familyId = default(int?), string familyName = default(string), int? id = default(int?), string name = default(string))
        {
            this.FamilyId = familyId;
            this.FamilyName = familyName;
            this.Id = id;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets FamilyId
        /// </summary>
        [DataMember(Name="family_id", EmitDefaultValue=false)]
        public int? FamilyId { get; set; }

        /// <summary>
        /// Gets or Sets FamilyName
        /// </summary>
        [DataMember(Name="family_name", EmitDefaultValue=false)]
        public string FamilyName { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Assessment {\n");
            sb.Append("  FamilyId: ").Append(FamilyId).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Assessment);
        }

        /// <summary>
        /// Returns true if Assessment instances are equal
        /// </summary>
        /// <param name="input">Instance of Assessment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Assessment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FamilyId == input.FamilyId ||
                    (this.FamilyId != null &&
                    this.FamilyId.Equals(input.FamilyId))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.FamilyId != null)
                    hashCode = hashCode * 59 + this.FamilyId.GetHashCode();
                if (this.FamilyName != null)
                    hashCode = hashCode * 59 + this.FamilyName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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

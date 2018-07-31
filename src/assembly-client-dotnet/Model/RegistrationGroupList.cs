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
using SwaggerDateConverter = assembly-client-dotnet.Client.SwaggerDateConverter;

namespace assembly-client-dotnet.Model
{
    /// <summary>
    /// A page of registration_group objects
    /// </summary>
    [DataContract]
    public partial class RegistrationGroupList :  IEquatable<RegistrationGroupList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationGroupList" /> class.
        /// </summary>
        /// <param name="_object">Object type.</param>
        /// <param name="totalCount">Total number of objects available.</param>
        /// <param name="totalPages">Total number of pages available.</param>
        /// <param name="currentPage">Current page in pages available.</param>
        /// <param name="prevPage">Previous page number.</param>
        /// <param name="nextPage">Next page number.</param>
        /// <param name="data">The paged data.</param>
        public RegistrationGroupList(string _object = default(string), int? totalCount = default(int?), int? totalPages = default(int?), int? currentPage = default(int?), int? prevPage = default(int?), int? nextPage = default(int?), List<RegistrationGroupListData> data = default(List<RegistrationGroupListData>))
        {
            this.Object = _object;
            this.TotalCount = totalCount;
            this.TotalPages = totalPages;
            this.CurrentPage = currentPage;
            this.PrevPage = prevPage;
            this.NextPage = nextPage;
            this.Data = data;
        }
        
        /// <summary>
        /// Object type
        /// </summary>
        /// <value>Object type</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Total number of objects available
        /// </summary>
        /// <value>Total number of objects available</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Total number of pages available
        /// </summary>
        /// <value>Total number of pages available</value>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Current page in pages available
        /// </summary>
        /// <value>Current page in pages available</value>
        [DataMember(Name="current_page", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Previous page number
        /// </summary>
        /// <value>Previous page number</value>
        [DataMember(Name="prev_page", EmitDefaultValue=false)]
        public int? PrevPage { get; set; }

        /// <summary>
        /// Next page number
        /// </summary>
        /// <value>Next page number</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public int? NextPage { get; set; }

        /// <summary>
        /// The paged data
        /// </summary>
        /// <value>The paged data</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<RegistrationGroupListData> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegistrationGroupList {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PrevPage: ").Append(PrevPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as RegistrationGroupList);
        }

        /// <summary>
        /// Returns true if RegistrationGroupList instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationGroupList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationGroupList input)
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
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.PrevPage == input.PrevPage ||
                    (this.PrevPage != null &&
                    this.PrevPage.Equals(input.PrevPage))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.PrevPage != null)
                    hashCode = hashCode * 59 + this.PrevPage.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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

/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Infobip.Api.Client.Model
{
    /// <summary>
    ///     EmailBulkRescheduleRequest
    /// </summary>
    [DataContract(Name = "EmailBulkRescheduleRequest")]
    public class EmailBulkRescheduleRequest : IEquatable<EmailBulkRescheduleRequest>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmailBulkRescheduleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailBulkRescheduleRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="EmailBulkRescheduleRequest" /> class.
        /// </summary>
        /// <param name="sendAt">sendAt (required).</param>
        public EmailBulkRescheduleRequest(DateTimeOffset sendAt = default(DateTimeOffset))
        {
            SendAt = sendAt;
        }

        /// <summary>
        ///     Gets or Sets SendAt
        /// </summary>
        [DataMember(Name = "sendAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset SendAt { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailBulkRescheduleRequest {\n");
            sb.Append("  SendAt: ").Append(SendAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as EmailBulkRescheduleRequest);
        }

        /// <summary>
        ///     Returns true if EmailBulkRescheduleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailBulkRescheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailBulkRescheduleRequest input)
        {
            if (input == null)
                return false;

            return
                SendAt == input.SendAt ||
                SendAt != null &&
                SendAt.Equals(input.SendAt);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (SendAt != null)
                    hashCode = hashCode * 59 + SendAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
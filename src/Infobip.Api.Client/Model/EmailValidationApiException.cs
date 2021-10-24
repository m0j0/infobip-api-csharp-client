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
    ///     EmailValidationApiException
    /// </summary>
    [DataContract(Name = "EmailValidationApiException")]
    public class EmailValidationApiException : IEquatable<EmailValidationApiException>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="EmailValidationApiException" /> class.
        /// </summary>
        /// <param name="requestError">requestError.</param>
        public EmailValidationApiException(EmailValidationApiRequestError requestError = default)
        {
            RequestError = requestError;
        }

        /// <summary>
        ///     Gets or Sets RequestError
        /// </summary>
        [DataMember(Name = "requestError", EmitDefaultValue = false)]
        public EmailValidationApiRequestError RequestError { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailValidationApiException {\n");
            sb.Append("  RequestError: ").Append(RequestError).Append("\n");
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
            return Equals(input as EmailValidationApiException);
        }

        /// <summary>
        ///     Returns true if EmailValidationApiException instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailValidationApiException to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailValidationApiException input)
        {
            if (input == null)
                return false;

            return
                RequestError == input.RequestError ||
                RequestError != null &&
                RequestError.Equals(input.RequestError);
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
                if (RequestError != null)
                    hashCode = hashCode * 59 + RequestError.GetHashCode();
                return hashCode;
            }
        }
    }
}
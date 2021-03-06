// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Api error base.
    /// </summary>
    public partial class ApiErrorBase
    {
        /// <summary>
        /// Initializes a new instance of the ApiErrorBase class.
        /// </summary>
        public ApiErrorBase() { }

        /// <summary>
        /// Initializes a new instance of the ApiErrorBase class.
        /// </summary>
        /// <param name="code">the error code.</param>
        /// <param name="target">the target of the particular error.</param>
        /// <param name="message">the error message.</param>
        public ApiErrorBase(string code = default(string), string target = default(string), string message = default(string))
        {
            Code = code;
            Target = target;
            Message = message;
        }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the target of the particular error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}

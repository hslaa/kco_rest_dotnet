﻿using System;
using Newtonsoft.Json;

namespace Klarna.Rest.Core.Model
{
    /// <summary>
    /// Customer token details object
    /// </summary>
    [Obsolete("This model is being deprecated. Use the CustomerTokenV1 model from Klarna.Rest.Core.Model.CustomerToken namespace instead")]
    public class CustomerTokenDetails
    {
        /// <summary>
        /// Selected payment method
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "payment_method_type")]
        public string PaymentMethodType { get; set; }
        /// <summary>
        /// Status of token, can be active, cancelled, suspended
        /// </summary>
        /// <remarks>Required</remarks>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// The card details of the token. Is only populated if the token is a card-token
        /// </summary>
        /// <value>The card details.</value>
        [JsonProperty(PropertyName = "card")]
        public CustomerToken.CardInformation CardDetails { get; set; }
        /// <summary>
        /// The direct debit details of the token. Is only populated if the token is based on direct debit
        /// </summary>
        /// <value>The direct debit token details.</value>
        [JsonProperty(PropertyName = "direct_debit")]
        public CustomerToken.DirectDebitInformation DirectDebitTokenDetails  { get; set; }
    }


}

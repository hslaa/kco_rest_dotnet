﻿using System;
using Newtonsoft.Json;

namespace Klarna.Rest.Core.Model
{
    /// <summary>
    ///
    /// </summary>
    [Obsolete("This model is being deprecated. Use the UpdateCustomer model from Klarna.Rest.Core.Model.OrderManagement namespace instead")]
    public class OrderManagementCustomerAddresses
    {
        /// <summary>
        /// Customer shipping address.
        /// </summary>
        [JsonProperty(PropertyName = "shipping_address")]
        public OrderManagementAddressInfo ShippingAddress { get; set; }
        /// <summary>
        /// Customer billing address.
        /// </summary>
        [JsonProperty(PropertyName = "billing_address")]
        public OrderManagementAddressInfo BillingAddress { get; set; }
    }
}
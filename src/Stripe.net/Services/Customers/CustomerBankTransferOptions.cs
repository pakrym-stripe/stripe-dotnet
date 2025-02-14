// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CustomerBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// List of address types that should be returned in the financial_addresses response. If
        /// not specified, all valid types will be returned.
        ///
        /// Permitted values include: <c>zengin</c>.
        /// </summary>
        [JsonProperty("requested_address_types")]
        public List<string> RequestedAddressTypes { get; set; }

        /// <summary>
        /// The type of the <c>bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Klarna.Rest.Core.Model.Settlements {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Payout: SettlementsPayout {
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Payout {\n");
      sb.Append("  Totals: ").Append(Totals).Append("\n");
      sb.Append("  PaymentReference: ").Append(PaymentReference).Append("\n");
      sb.Append("  PayoutDate: ").Append(PayoutDate).Append("\n");
      sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
      sb.Append("  MerchantSettlementType: ").Append(MerchantSettlementType).Append("\n");
      sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

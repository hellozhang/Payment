using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDetailQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 自定义报表规则条件的详细信息
        /// </summary>
        [JsonProperty("report_condition_info")]
        public CustomReportCondition ReportConditionInfo { get; set; }
    }
}

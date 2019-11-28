using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DYSDK.Model
{
    public class FansData:BaseData
    {
        [JsonProperty("all_fans_num")]
        public int AllFansNum { get; set; }

        [JsonProperty("gender_distributions")]
        public List<FansProfileDistribution> Gender { get; set; }

        [JsonProperty("age_distributions")]
        public List<FansProfileDistribution> Age { get; set; }

        [JsonProperty("geographical_distributions")]
        public List<FansProfileDistribution> GeoGraphical { get; set; }

        [JsonProperty("active_days_distributions")]
        public List<FansProfileDistribution> ActiveDays { get; set; }

        [JsonProperty("device_distributions")]
        public List<FansProfileDistribution> Device { get; set; }

        [JsonProperty("interest_distributions")]
        public List<FansProfileDistribution> Interest { get; set; }

        [JsonProperty("flow_contributions")]
        public List<FansProfileFlowContribution> FlowContributions { get; set; }
    }

    public class FansProfileDistribution
    {
        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class FansProfileFlowContribution
    {
        [JsonProperty("flow")]
        public string Flow { get; set; }

        [JsonProperty("fans_sum")]
        public int FansSum { get; set; }

        [JsonProperty("all_sum")]
        public int AllSum { get; set; }
    }

}

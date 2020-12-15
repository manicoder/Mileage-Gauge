using MileageGauge.CSharp.Abstractions.Services.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileageGauge.CSharp.Abstractions.Services.ServiceResponses
{
    public class OptionQueryResponse
    {

        [JsonConverter(typeof(SingleOrCollectionConverter<OptionQueryResponseItem>))]
        public List<OptionQueryResponseItem> MenuItem { get; set; }
    }

    public class OptionQueryResponseItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
    }
}

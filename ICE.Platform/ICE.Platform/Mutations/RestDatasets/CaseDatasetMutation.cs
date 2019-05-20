using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.Platform.Mutations.RestDatasets
{
    using System.Threading.Tasks;
    using Core;
    using Core.Attributes;
    using Core.Bases;
    using Core.Structs;
    using Entities;

    [Mutation(typeof(Case), MutationType.HttpResponse)]
    public class CaseDatasetMutation : HttpMutationBase
    {
        public override async Task<object> Mutate(object input)
        {
            bool isDatasetRequest;

            if (Parameters.ContainsKey("dataset") && bool.TryParse(Parameters["dataset"], out isDatasetRequest) && isDatasetRequest)
            {
                await Task.Delay(0); // TODO: build dataset object

                return new
                {
                    Data = input,
                    Dataset = new
                    {
                        Status = new List<string> { "ListValue1", "ListValue2" }
                    }
                };
            }

            return input;
        }
    }
}

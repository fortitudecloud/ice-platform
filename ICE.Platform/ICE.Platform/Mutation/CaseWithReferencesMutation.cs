using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Mutation
{    
    using Entities;

    [Mutation(MutationType.Response, MutationOperation.Read, typeof(Case))]
    public class CaseWithReferencesMutation : PlatformMutationBase
    {
        public override async Task<object> Mutate(object input)
        {
            if (!Parameters.ContainsKey("references")) return input;

            bool withReferences;

            if (!bool.TryParse(Parameters["references"], out withReferences)) return input;

            if (!withReferences) return input;

            // Return Case reference tables in response

            await Task.Delay(0);

            return new
            {
                Data = IsCollection ? input : ((IEnumerable<Case>)input).First(),
                References = new
                {
                    Status = new List<string> { "ListValue1", "ListValue2" }
                }
            };
        }
    }
}

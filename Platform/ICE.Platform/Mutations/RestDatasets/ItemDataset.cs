using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Platform.Mutations.RestDatasets
{
    using Core;
    using Core.Attributes;
    using Core.Bases;
    using Core.Structs;
    using Entities;

    [Mutation(typeof(Item), MutationType.HttpResponse)]
    public class ItemDataset : HttpMutationBase
    {
        public override bool Condition()
        {
            bool isDatasetRequest;

            if (Parameters.ContainsKey("dataset") && 
                bool.TryParse(Parameters["dataset"], out isDatasetRequest) && 
                isDatasetRequest)
            {
                return true;
            }

            return false;
        }

        public override async Task<object> Mutate(object input)
        {
            var item = input as Item;

            if (item == null) return input;

            var paymentGroupSet = Context.Set<PaymentGroup>();
            var itemCostSet = Context.Set<ItemCost>();

            return new
            {
                Data = input,
                Dataset = new
                {
                    PaymentGroup = await paymentGroupSet.Read(item.PaymentGroupId),
                    ItemCosts = await itemCostSet.Query(string.Format("ItemId = '{0}'", item.Id))
                }
            };
        }
    }
}

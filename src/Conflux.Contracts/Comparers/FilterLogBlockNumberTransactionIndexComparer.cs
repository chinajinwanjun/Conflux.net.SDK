using System.Collections.Generic;
using Conflux.RPC.Eth.DTOs;

namespace Conflux.Contracts.Comparers
{
    public class FilterLogBlockNumberTransactionIndexComparer : IComparer<FilterLog>
    {
        //TODO: Move to Nethereum RPC
        public int Compare(FilterLog x, FilterLog y)
        {
            if (x.BlockNumber.Value == y.BlockNumber.Value)
                return x.TransactionIndex.Value.CompareTo(y.TransactionIndex.Value);
            return x.BlockNumber.Value.CompareTo(y.BlockNumber.Value);
        }
    }
}
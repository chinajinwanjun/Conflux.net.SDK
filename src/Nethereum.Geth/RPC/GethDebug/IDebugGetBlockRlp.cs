﻿using System.Threading.Tasks;
using Conflux.JsonRpc.Client;

namespace Conflux.Geth.RPC.Debug
{
    public interface IDebugGetBlockRlp
    {
        RpcRequest BuildRequest(ulong blockNumber, object id = null);
        Task<string> SendRequestAsync(ulong blockNumber, object id = null);
    }
}
using System.Threading.Tasks;
using Conflux.JsonRpc.Client;

namespace Conflux.Pantheon.RPC.Permissioning
{
    public interface IPermRemoveAccountsFromWhitelist
    {
        Task<string> SendRequestAsync(string[] addresses, object id = null);
        RpcRequest BuildRequest(string[] addresses, object id = null);
    }
}
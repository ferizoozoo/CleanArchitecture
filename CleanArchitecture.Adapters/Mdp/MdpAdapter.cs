using CleanArchitecture.Externals.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Adapters.Mdp
{
    public class MdpAdapter : IMdpAdapter
    {
        private readonly IClient _client;
        private readonly string url = "https://google.com";

        public MdpAdapter(IClient client)
            => _client = client;

        public async Task<MdpDataReadModel> ReadAsync()
        {
            await _client.GetAsync<MdpDataReadModel>(url);

            return await Task.FromResult(new MdpDataReadModel
            {
                Stockname = "Hello",
                Price = 15839.23
            });
        }
    }
}

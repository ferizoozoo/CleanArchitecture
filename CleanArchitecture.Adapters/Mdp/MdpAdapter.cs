using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Adapters.Mdp
{
    public class MdpAdapter
    {
        public async Task<MdpDataReadModel> ReadAsync()
        {
            return await Task.FromResult(new MdpDataReadModel
            {
                Stockname = "Hello",
                Price = 15839.23
            });
        }
    }
}

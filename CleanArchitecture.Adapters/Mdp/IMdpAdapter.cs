using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Adapters.Mdp
{
    public interface IMdpAdapter
    {
        Task<MdpDataReadModel> ReadAsync();
    }
}

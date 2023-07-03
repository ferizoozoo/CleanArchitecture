using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Externals.Requests
{
    public interface IClient
    {
        Task GetAsync<T>(string url);
    }
}

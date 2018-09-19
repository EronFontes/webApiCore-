using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Interfaces;

namespace WebApiCore.Factory
{
    public class WcfFactory : IWcfFactory
    {
        public async Task<string> GetData(int valor)
        {
            var client = new Service1Client(Service1Client.EndpointConfiguration.BasicHttpsBinding_IService1);

            var retornoWcf = await client.GetDataAsync(valor);

            await client.CloseAsync();

            return retornoWcf;
        }
    }
}

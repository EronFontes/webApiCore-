using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Interfaces;

namespace WebApiCore.Services
{
    public class Service : IService
    {
        private readonly IWcfFactory _wcfFactory;

        public Service(IWcfFactory wcfFactory)
        {
            _wcfFactory = wcfFactory;
        }

        public async Task<string> FindValues(int id)
        {
            try
            {
                return await _wcfFactory.GetData(id);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao conectar com o serviço de WCF");
            }
        }
    }
}

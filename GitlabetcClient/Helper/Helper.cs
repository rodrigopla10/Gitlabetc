using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitlabetcClient.Helper
{
    public class ClienteAPI
    {

        public HttpClient ApiAddress()
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri("https://localhost:44346/");
            return cliente;
        }
    }

}

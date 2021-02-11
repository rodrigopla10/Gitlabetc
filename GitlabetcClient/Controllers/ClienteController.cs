using GitlabetcClient.Helper;
using GitlabetcClient.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GitlabetcClient.Controllers
{
    public class ClienteController : Controller
    {
        ClienteAPI _api = new ClienteAPI();
        public async Task<IActionResult> Index()
        {
            List<ClienteData> clientes = new List<ClienteData>();
            HttpClient clientAPI = _api.ApiAddress();
            HttpResponseMessage res = await clientAPI.GetAsync("api/cliente");

            if (res.IsSuccessStatusCode)
            {
                var resultado = res.Content.ReadAsStringAsync().Result;
                clientes = JsonConvert.DeserializeObject<List<ClienteData>>(resultado);
            }

            return View(clientes);
        }


        public ActionResult CrearCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearCliente(ClienteData cliente)
        {
            HttpClient clientAPI = _api.ApiAddress();

            var postTask = clientAPI.PostAsJsonAsync<ClienteData>("api/cliente", cliente);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult ActualizarCliente(int idCliente, DateTime fechaCreacion)
        {
            return View(new ClienteData {idCliente=idCliente, fechaCreacion=fechaCreacion});
        }

        [HttpPost]
        public IActionResult ActualizarCliente(ClienteData cliente)
        {
            HttpClient clientAPI = _api.ApiAddress();

            var postTask = clientAPI.PutAsJsonAsync<ClienteData>("api/cliente", cliente);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int Id)
        {
            var cliente = new ClienteData();
            HttpClient clientAPI = _api.ApiAddress();
            HttpResponseMessage res = clientAPI.DeleteAsync($"api/cliente/{Id}").Result;

            return RedirectToAction("Index");
        }

    }
}

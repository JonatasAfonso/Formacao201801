using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using CadeMeuMedico.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace CadeMeuMedico.Models
{
    public class CidadeClient
    {
        private const string CaminhoApi = "http://localhost:54102/api/";


//        private readonly string _caminhoApi;
//private readonly IConfiguration _configuracao;

//        public CidadeClient(IConfiguration configuracao)
//        {
//            _configuracao = configuracao;
//            _caminhoApi = configuracao["CaminhoApi"];

//            var teste = configuracao["SenhaBD"];
//        }

        public IEnumerable<CidadeDto> ObterTodas()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(CaminhoApi);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("cidades").Result;

                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<IEnumerable<CidadeDto>>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool Criar(CidadeDto cidade)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(CaminhoApi);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("cidades", cidade).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public CidadeDto ObterPorId(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(CaminhoApi);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("cidades/" + id).Result;

                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsAsync<CidadeDto>().Result;
                return null;
            }
            catch
            {
                return null;
            }
        }

        public bool Atualizar(CidadeDto cidade)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(CaminhoApi);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("cidades/" + cidade.Id, cidade).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        public bool Apagar(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(CaminhoApi);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("cidades/" + id).Result;
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

    }
}

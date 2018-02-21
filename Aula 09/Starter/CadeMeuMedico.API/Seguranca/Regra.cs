using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CadeMeuMedico.API.Seguranca
{
    public class Regra : IAuthorizationRequirement
    {
        //Consultar o token ou sessao pra ver se o usuario tem acesso
    }
}

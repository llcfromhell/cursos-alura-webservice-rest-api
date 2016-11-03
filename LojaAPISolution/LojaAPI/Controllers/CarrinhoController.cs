﻿using LojaAPI.DAO;
using LojaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaAPI.Controllers
{
    public class CarrinhoController : ApiController
    {

        public string Get(int id)
        {
            return new CarrinhoDAO().Busca(id).ToXml();
        }

    }
}

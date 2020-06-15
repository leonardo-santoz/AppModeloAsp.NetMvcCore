﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevIOUI.Site.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("pedidos")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
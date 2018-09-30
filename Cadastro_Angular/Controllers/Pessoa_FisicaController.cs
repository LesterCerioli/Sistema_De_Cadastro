using Cadastro_Angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cadastro_Angular.Controllers
{
    public class Pessoa_FisicaController : Controller
    {
        //GET Pessoa_Fisica/GETPessoa_Fisica
        // métpdp para listar Pessoa Física
        public JsonResult GetPessoa_Fisica()
        {
            using (var db = new cadastros1Entities())
            {
                List<Pessoa_Fisica> listarPessoa_Fisica = db.Pessoa_Fisica.ToList();
                return Json(listarPessoa_Fisica, JsonRequestBehavior.AllowGet);
            }

                    
        }
    }
}
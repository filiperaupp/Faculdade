using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcNew.Models;

namespace MvcNew.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            Cliente filipe = new Cliente(1,"Filipe");
            // Questao 2)
            //return filipe.id + "  " + filipe.nome;
            CartaoDeCredito cartaoDeCredito = new CartaoDeCredito(1,1010101,new DateTime(2017,09,15), filipe);
            cartaoDeCredito.numero = 202020;
            // Questao 4)
            // return cartaoDeCredito.id + "  " + cartaoDeCredito.numero + "  " 
            //         + cartaoDeCredito.dataValidade + "  " + cartaoDeCredito.cliente.id
            //         + "  " + cartaoDeCredito.cliente.nome;
            Agencia banrisul = new Agencia(01,11111);
            Agencia bancoDoBrasil = new Agencia(02,121212);
            banrisul.numero = 0955;
            bancoDoBrasil.numero = 07781;
            // Questao 6)
            // return "Banrisul: " + banrisul.id + " " + banrisul.numero +
            //         "Banco do Brasil: " + bancoDoBrasil.id + " " + bancoDoBrasil.numero;
            Conta conta1 = new Conta(1,12121212,200, filipe);
            Conta conta2 = new Conta(2,21212121,100, filipe);
            conta1.numero = 9999999;
            conta2.numero = 8888888;
            // Questao 8
            // return conta1.id + " " + conta1.numero + " " + conta1.saldo + " " + conta1.limite
            //         + " "  +  conta2.id + " " + conta2.numero+ " " + conta2.saldo + " " + 
            //         conta2.limite;


            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

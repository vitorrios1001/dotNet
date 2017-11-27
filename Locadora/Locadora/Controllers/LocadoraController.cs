using System;
using System.Collections.Generic;
using Locadora.Models;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    public class LocadoraController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }

        public IActionResult ListaVeiculos(VeiculoModel veiculo)
        {
            ViewBag.ListaCores = RetornaListaCores();
            ViewBag.ListaModelos = RetornaListaModelos();
            ViewBag.ListaVeiculos = RetornaListaVeiculos(new VeiculoModel());
            
            return View();
        }
        
        
        public IActionResult Novo()
        {
            ViewBag.ListaCores = RetornaListaCores();
            ViewBag.ListaModelos = RetornaListaModelos();
            return View(new VeiculoModel());
        }
        
        [HttpPost]
        public IActionResult Inserir(VeiculoModel veiculo)
        {
            ViewBag.ListaCores = RetornaListaCores();
            ViewBag.ListaModelos = RetornaListaModelos();
            ViewBag.ListaVeiculos = RetornaListaVeiculos(veiculo);
            
            return View("ListaVeiculos");

        }
        

        private List<VeiculoModel> RetornaListaVeiculos(VeiculoModel veiculo)
        {
            var lista = new List<VeiculoModel>();
            
            if (veiculo != null)
            {
                lista.Add(veiculo);
            }
            
            /*
            lista.Add(new VeiculoModel
            {
                Placa = "JEE-1280",
                Chassi = "4564121354654",
                Modelo = "Gol",
                Marca = "VolksWagen",
                DataFabricacao = "22/01/2011",
                Cor = "Vermelho"
            });
            
            lista.Add(new VeiculoModel
            {
                Placa = "JEE-1280",
                Chassi = "4564121354654",
                Modelo = "Gol",
                Marca = "VolksWagen",
                DataFabricacao = "22/01/2011",
                Cor = "Azul"
            });
            
            lista.Add(new VeiculoModel
            {
                Placa = "JEE-1280",
                Chassi = "4564121354654",
                Modelo = "Gol",
                Marca = "VolksWagen",
                DataFabricacao = "22/01/2011",
                Cor = "Verde"
            });
            
            lista.Add(new VeiculoModel
            {
                Placa = "JEE-1280",
                Chassi = "4564121354654",
                Modelo = "Gol",
                Marca = "VolksWagen",
                DataFabricacao = "22/01/2011",
                Cor = "Amarelo"
            });
            
            lista.Add(new VeiculoModel
            {
                Placa = "JEE-1280",
                Chassi = "4564121354654",
                Modelo = "Gol",
                Marca = "VolksWagen",
                DataFabricacao = "22/01/2011",
                Cor = "Verde"
            });
            
            lista.Add(new VeiculoModel
            {
                Placa = "JEE-1280",
                Chassi = "4564121354654",
                Modelo = "Gol",
                Marca = "VolksWagen",
                DataFabricacao = "22/01/2011",
                Cor = "Azul"
            });
            */
            
            return lista;

        }

        private List<VeiculoModeloModel> RetornaListaModelos()
        {

            var modelos = new List<VeiculoModeloModel>();

            modelos.Add(new VeiculoModeloModel
            {
                NomeModelo = "Gol"
                //DataFabricacao = "01/01/2017"
            });
            
            modelos.Add(new VeiculoModeloModel
            {
                NomeModelo = "Polo"
                //DataFabricacao = "01/01/2017"
            });
            
            modelos.Add(new VeiculoModeloModel
            {
                NomeModelo = "Civic"
                //DataFabricacao = "01/01/2017"
            });
            
            modelos.Add(new VeiculoModeloModel
            {
                NomeModelo = "Marea"
                //DataFabricacao = "01/01/2017"
            });
            
            modelos.Add(new VeiculoModeloModel
            {
                NomeModelo = "i30"
                //DataFabricacao = "01/01/2017"
            });
            
            
            return modelos;
        }

        private List<VeiculoCor> RetornaListaCores()
        {

            var cores = new List<VeiculoCor>();


            cores.Add(new VeiculoCor
            {
                NomeCor = "Azul"
            });
            
            cores.Add(new VeiculoCor
            {
                NomeCor = "Verde"
            });
            
            cores.Add(new VeiculoCor
            {
                NomeCor = "Amarelo"
            });
            
            cores.Add(new VeiculoCor
            {
                NomeCor = "Preto"
            });
            
            cores.Add(new VeiculoCor
            {
                NomeCor = "Branco"
            });
            
            return cores;
        }
        
    }
}
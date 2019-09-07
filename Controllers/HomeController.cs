using System;
using Microsoft.AspNetCore.Mvc;
using practicaProto.models;

namespace practicaProto.controllers{
    public class HomeController:Controller{
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context){
            _context = context;
        }

        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }

        [HttpPost]
        public IActionResult calculo(Company com){
            Console.WriteLine("calculo");
            double p_ini1=com.precio_ini;
            if(com.t_impuestos.Equals("extran")){
                p_ini1 = p_ini1 * 1.3;
            }else if(com.t_impuestos.Equals("naci")) {
                p_ini1 = p_ini1 * 1.1;
            }

            if(com.categoria.Equals("cam")){
                com.precio_fin = p_ini1 * 1.05;
            }else if(com.categoria.Equals("auto")){
                com.precio_fin = p_ini1 * 1.03;
            }
            Console.WriteLine("Precio final: " + com.precio_fin);
            
            _context.Add(com);
            _context.SaveChanges();

            return View(com);
        }
    }
}
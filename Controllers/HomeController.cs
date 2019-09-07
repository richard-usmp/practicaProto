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
        public IActionResult calculo (Company com){

        }
    }
}
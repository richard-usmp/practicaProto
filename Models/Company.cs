using System;
using System.ComponentModel.DataAnnotations;

namespace practicaProto.models
{

    public class Company{
        [Key]
        public int ID { get; set; }
        public String producto {get; set;}
        public String categoria {get; set;}

        public String t_impuestos {get; set;} 

        public int precio_ini {get; set;} 
        public int precio_fin {get; set;}

    }

}
using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
public class Libros{
    [Key]
    public String? codigoLibro {get; set;}
    public String? nombreLibro {get; set;}
    public int existenciasLibro {get; set;}
    public float precioLibro {get; set;}
    public String? descripcionLibro {get; set;}
   
    
   
}    
}
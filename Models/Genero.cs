using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
public class Genero{
    [Key]
    public String? idGenero {get; set;}
    public String? NombreGenero {get; set;}
    public String? descripcionGenero {get ; set;}
   
    
   
   
}    
}
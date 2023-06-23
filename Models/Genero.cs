using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
public class Genero{
    [Key]
    public int Id {get; set;}
    public String? Nombre_Genero {get; set;}
    public String? Descripcion_Genero {get ; set;}
   
    
   
   
}    
}
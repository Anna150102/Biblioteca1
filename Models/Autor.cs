using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Models
{
public class Autor{
   
   [Key]
    public int Id {get; set;}
    public string? Nombre_Autores {get; set;}
    public string? Nacionalidad_Autor {get ; set;}
}    
}
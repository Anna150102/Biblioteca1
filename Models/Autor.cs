using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Models
{
public class Autor{
   
   [Key]
    public string? codigoAutor {get; set;}
    public string? nombreAutores {get; set;}
    public string? NacionalidadAutor {get ; set;}
}    
}
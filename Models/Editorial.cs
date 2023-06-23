using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
public class Editorial{
    [Key]
    public  int Id {get; set;}
    public String? Nombre_Editorial {get; set;}
    public String? Telefono_Editorial {get ; set;}
   
    public String? Contacto_Editorial {get; set;}
   
   
}    
}
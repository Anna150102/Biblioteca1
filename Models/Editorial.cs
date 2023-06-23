using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
public class Editorial{
    [Key]
    public String? codigoEditorial {get; set;}
    public String? nombreEditorial {get; set;}
    public String? TelefonoEditorial {get ; set;}
   
    public String? ContactoEditorial {get; set;}
   
   
}    
}
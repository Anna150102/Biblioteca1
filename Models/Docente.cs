using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
public class Docente{
    [Key]
    public int Id {get; set;}
    public String? NombreDocente {get; set;}
    
    public String? FacultadDocente {get ; set;}
}    
}
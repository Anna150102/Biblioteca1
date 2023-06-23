using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Models
{
public class Prestamo{
   
   [Key]
    public string? Codigo_Prestamo {get; set;}
    public string? Fecha_Prestamo {get; set;}
    public string? Descripcion_Prestamo {get ; set;}
    public int Libros_Id{get;set;}
    public int Docete_Id{get;set;}
    public Libros? Libros{get;set;}
    public Docente? Docente{get;set;}
}    
}
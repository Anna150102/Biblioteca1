using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
public class Editorial{
    [Key]
    public  int Id {get; set;}
    [Required]
    [Display(Name = "Nombre de la Editorial")]
    [StringLength(100,MinimumLength =2)]
    public String? Nombre {get; set;}
    [Required]
    [Display(Name = "Telefono de Editorial")]
    [DataType(DataType.PhoneNumber)]
    public String? Telefono_Editorial {get ; set;}
    [Required]
    [Display(Name = "Nombre de contacto de Editorial")]
    [StringLength(100,MinimumLength =2)]
   
    public String? Contacto {get; set;}
   
   
}    
}
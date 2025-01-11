using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TiagoVieia.models;

public class Student
{
    
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }
    
    
    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "O nome deve conter no máximo 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter pelo menos 5 caracteres")]
    [DisplayName("Nome completo")]
    public string? Name { get; set; }


    [Required(ErrorMessage = "Informe a email")]
    [EmailAddress(ErrorMessage = "E-mail")]
    [DisplayName("E-mail")]
    public string? Email { get; set; }

    public List<Premiuns>? listaDosPremiuns { get; set; }
    
    
}
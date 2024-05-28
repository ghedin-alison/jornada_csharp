using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

//Flunt
//Fluent Validation
public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "Titulo Inválido.")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 caracteres.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição Inválida.")]
    public string Description { get; set; } = string.Empty;
}
using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;
using Fina.Core.Models;

namespace Fina.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Titulo Invalido")]
    public string Title { get; set; }  =String.Empty;

    [Required(ErrorMessage = "Tipo Invalido")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
    
    [Required(ErrorMessage = "Valor Invalido")]
    public decimal Amount { get; set; }
    
    [Required(ErrorMessage = "Categoria Invalida")]
    public long CategoryID { get; set; }

    [Required(ErrorMessage = "Data Invalida")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
using System.Dynamic;

public class CartaoDebito

{
    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Mastercard;
    }

    public string Numero { get; set; }
    public BandeiraCartao Bandeira { get; set; }

    public DateTime Vencimento { get; set; }

    public string Portador { get; set; }
    
    public string Cvv { get; set; }


} 

public enum BandeiraCartao //enum -> lista de verificação que pode usar
{
    Visa,
    Mastercard,
    Amex, 
    Elo
}


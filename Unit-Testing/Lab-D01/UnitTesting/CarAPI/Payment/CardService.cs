namespace CarAPI.Payment
{
    public class CardService : IPaymentService
    {
        public string Pay(double amount)
        {
            return $"{amount} is paid successfully through card";
        }
    }
}

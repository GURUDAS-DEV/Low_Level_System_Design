interface IProcessPayment{
    void Processing(double amount, string currency);
    bool IsPaymentSuccessfully();
    string GetId();
}
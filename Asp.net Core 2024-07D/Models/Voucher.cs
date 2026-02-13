namespace Asp.net_Core_2024_07D.Models
{
    public class Voucher
    {
        public int Id { get; set; }
        public string ReceiptNo { get; set; }

        public DateTime Date { get; set; }

        public string EnrollmentNum { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentReference { get; set; }
        public string CashAmount { get; set; }
        public string OnlineAmount { get; set; }
        public string Status { get; set; }
    }
}

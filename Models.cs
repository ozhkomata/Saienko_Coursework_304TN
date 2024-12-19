using System;

namespace InternetProviderMenu
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PlanId { get; set; }
        public int? ServiceId { get; set; }
        public string PlanName { get; set; }
        public string ServiceName { get; set; } 
    }

    public class Plan
    {
        public int PlanId { get; set; }
        public string PlanName { get; set; }
        public decimal Price { get; set; }
        public string Speed { get; set; }
    }

    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }

    public class Payment
    {
        public int PaymentId { get; set; }
        public int ClientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ClientName { get; set; }
    }

    public class ConnectionHistory
    {
        public int HistoryId { get; set; }
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ClientName { get; set; }
    }

    public class SupportTicket
    {
        public int TicketId { get; set; }
        public int ClientId { get; set; }
        public string IssueDescription { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ClientName { get; set; }
    }
}
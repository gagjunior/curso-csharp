using ConsoleOrderSistem.Entities.Enums;
using System.Text;

namespace ConsoleOrderSistem.Entities
{
    class Order
    {
        public Order() 
        {
        }

        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) 
        { 
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine($"Order Moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order Staus: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("Order Items");

            foreach(OrderItem item in Items) 
            { 
                sb.AppendLine(item.ToString()); 
            }

            sb.AppendLine($"Total price: {Total():F2}");

            return sb.ToString();
        }
    }
}

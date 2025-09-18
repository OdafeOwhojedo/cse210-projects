//Represents a customer's order
public class Order
{
    private int _orderID;
    private Customer _customer;
    private DateTime _orderDate;
    private List<OrderItem> _items;

    public Order(int orderID, Customer myCustomer)
    [
        _orderID = orderID;
        _customer = myCustomer;
        _orderDate = DateTime.Now;
        _items = new List<OrderItem>();

        public void AddItem(Product product, int quantity)
        {
            _items.Add(new OrderItem(product, quantity));
        }

        public float GetTotalOrderPrice()
        {
            return _items.Sum(item => item.totalPrice);
        }

        public override string ToString()
        {
            string orderDetails = $"Order ID: {_orderID}\nCustomer: {_customer._firstName} {_customer._lastName}\nOrder Date: {_orderDate.ToShortDateString()}\nItems: \n";
            foreach (var item in _items)
            {
                orderDetails += $"  - {item}\n";
            }
            orderDetails += $"Total Price: {GetTotalOrderPrice():C}";
            return orderDetails;
        }

    ]
}
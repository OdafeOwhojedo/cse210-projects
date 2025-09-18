//Represents an item within an order, including quantity
public class OrderItem
{
    private Product _product;
    private int _quantity;

    public OrderItem(Product product, int quantity)
    {
        _product = product;
        _quantity = quantity;
    }
 
    private float totalPrice => Product._price * _quantity;

    public override string ToString()
    {
        return $"{Product._name} (x{_quantity}) - {totalPrice:C}";
    }
}
using system;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
}

public Order(List<Product> products, Customer customer)
{
    _products = products;
    _customer = customer;
}

public double CalculateTotalCost()
{
    double totalProductCost = _products.Sum(p => p.GetTotalCost());
    double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
    return totalProductCost + shippingCost;
}

public string GetPackingLabel()
{
    string label = "Packing Label:\n";
    foreach (Product product in _products)
    {
       label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
    }
    return label;
}

public string GetShippingLabel()
{
    string label = "Shipping Label:\n";
    label += $"Customer Name: {_customer.GetName()}\n";
    label += $"Customer Address:\n{_customer.GetAddress().GetFullAddressString()}";
    return label;
}
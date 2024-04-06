//Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
public class Order
{
    //Contains a list of products and a customer.
    List<Product> _products;
    Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
    public float TotalOrderCost()
    {
        float totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.TotalCost();
        }

        //This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
        if (_customer.GetAddress().LivesInAmerica())
        {
            totalCost += 5;
        }

        else 
        {
            totalCost += 35;
        }

        return totalCost;
    }

    //A packing label should list the name and product id of each product in the order.
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()}\nProduct ID: {product.GetProductId()}\n";
        }
        return label;
    }

    //A shipping label should list the name and address of the customer
    public string ShippingLabel()
    {
        string label = "\nShipping Label:\n";
        label += $"Customer: {_customer.GetCustomerName()}\n{_customer.GetAddress().DisplayAddress()}";
        return label;
    }
}
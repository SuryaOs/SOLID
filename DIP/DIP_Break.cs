namespace SOLID.DIP_Break;

// Breaking DIP, Concrete Class Directly Depending on Another Concrete Class
public class ProductController
{
    private readonly ProductService _productService;

    public ProductController()
    {
        _productService = new ProductService();
    }
}

public class ProductService
{
    private readonly ProductRepository _productRepository;
    public ProductService()
    {
        _productRepository = new ProductRepository();
    }
}

public class ProductRepository
{

}

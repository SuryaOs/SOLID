namespace SOLID.DIP;

// Class Depending on Abstractions.
// Getting object from Constructor Injection
// Note : Current implementation won't work -> we need to register service to IOC containers
public class ProductController
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
}

public interface IProductService { }
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
}
public interface IProductRepository { }
public class ProductRepository { }
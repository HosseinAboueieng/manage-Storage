using AutoMapper;
using Dto;
using Entity.EntityPrometre;
using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;


namespace Service;

public class ProductService:IProductService
{
    private readonly IRepositoryManager _repository;
    private readonly IloggerManager _logger;
    private readonly IMapper _mapper;
    public ProductService(IRepositoryManager repositoryManager,
    IloggerManager logger,IMapper mapper)
    {
        _repository=repositoryManager;
        _logger=logger;
        _mapper=mapper;
    }

    public IEnumerable<ProductDto> FindAllProductByName( bool trackChanges)
    {
        var products = _repository.Product.GetProducts(trackChanges);

    IEnumerable<ProductDto> productDto = products.Select(product =>
    new ProductDto(
        product.id,
        product.ProductsName,
        product.companyName,
        product.groupOfProduct.groupName) );

        return productDto;
    }


    public ProductDto findProductById(Guid id,bool trackChanges)
    {
        var product=_repository.Product.productById(id,trackChanges);
        if(product==null)
        {
            _logger.LogInfo($"Product with id:{id} not found");
            return null;
        }
        else
        {
            _logger.LogInfo($"Product with id:{id} found");
            return 
                new ProductDto(
                     product.id,
                    product.ProductsName,
                    product.companyName,
                    product.groupOfProduct.groupName) ; 
        }
    }

    public ProductDto findProductByName(ProductParametre productParametre, bool trackChanges)
    {
        var poduct=_repository.Product.productByName(productParametre,trackChanges);
        if(poduct==null)
        {
            _logger.LogInfo($"Product with name:{productParametre.search} not found");
            return null;
        }
        else
        {
            _logger.LogInfo($"Product with name:{productParametre.search} found");
        }
        return new ProductDto(
            poduct.id,
            poduct.ProductsName,
            poduct.companyName,
            poduct.groupOfProduct.groupName
            );
    }

}

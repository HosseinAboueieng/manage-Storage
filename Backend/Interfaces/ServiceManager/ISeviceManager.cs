namespace Interfaces.ServiceManager;

public interface ISeviceManager
{
    IProductService productService {get;}
    IDistibuterSevice distibuterSevice{get;}
    IStorageService storageService{get;}
    IGroupOfProductSevice groupOfProductSevice{get;}
    IBuyFactor buyFactor{get;}
}

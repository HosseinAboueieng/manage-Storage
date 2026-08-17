using Dto;

namespace Interfaces.ServiceManager;

public interface IGroupOfProductSevice
{
   Task<GroupOfProductDto> CtreateGroupOfProudct(GroupOfProductCreatDto groupOfProductCreatDto);
   Task <IEnumerable<GroupOfProductDto>> getAllGroupOfProduce (bool trackChange);
}

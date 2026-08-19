using AutoMapper;
using Dto;
using Entity.Models;
using Interfaces;
using Interfaces.RepositoryInterFace;
using Interfaces.ServiceManager;


namespace Service
{
    internal class GroupOfProuductService : IGroupOfProductSevice
    {
        private readonly IRepositoryManager _repository;
        private readonly IloggerManager _logger;
        private readonly IMapper _mapper;
        public GroupOfProuductService(IRepositoryManager repositoryManager,
        IloggerManager logger,IMapper mapper)
        {
            _repository = repositoryManager;
            _logger = logger;
            _mapper=mapper;
        }

        public async Task<GroupOfProductDto> CtreateGroupOfProudct(GroupOfProductCreatDto groupOfProductCreatDto)
        {
            var groupOfProduct= _mapper.Map<GroupOfProduct>(groupOfProductCreatDto);
            await _repository.GoupOfProduct.CreateGroupOfProduct(groupOfProduct);
            await _repository.save();
            return _mapper.Map<GroupOfProductDto>(groupOfProduct); 
        }

        public async Task<IEnumerable<GroupOfProductDto>> getAllGroupOfProduce(bool trackChange)
        {
           var groupOfProduct= await _repository.GoupOfProduct.FindAllGroupOfProudct(trackChange);

           return _mapper.Map<IEnumerable<GroupOfProductDto>>(groupOfProduct);
        }
    }
}

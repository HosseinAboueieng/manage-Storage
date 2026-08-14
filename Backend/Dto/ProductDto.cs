namespace Dto;

public record ProductDto(Guid id,String productName, string companyName ,String? groupName=null);

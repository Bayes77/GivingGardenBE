using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface IOrganizationServices
    {
        Task<List<Organization>> GetAllOrganizations();
        Task<List<Organization?>> GetOrganizationById(int id);
        Task<Organization?> CreateOrganization(Organization organization);
        Task<Organization?> UpdateOrganization(int id, Organization organization);
        Task<Organization> DeleteOrganization(int id);
      /* Task<List<Subscription>> GetSubscriptionsByOrgId(int orgId);
        Task<List<User>> GetUsersByOrgId(int orgId);
        Task<List<Subscription>> GetSubscriptionsByUserId(int userId);
        Task<List<Organization>> GetOrganizationsByUserId(int userId);*/
    }
}

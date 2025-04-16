using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Services
{
    public class OrganizationServices : IOrganizationServices
    {
        private readonly IOrganizationRepositroy _organizationRepository;
        public OrganizationServices(IOrganizationRepositroy organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }
        public async Task<List<Organization>> GetAllOrganizations()
        {
            return await _organizationRepository.GetAllOrganizations();
        }
        public async Task<List<Organization?>> GetOrganizationById(int id)
        {
            return await _organizationRepository.GetOrganizationById(id);
        }
        public async Task<Organization?> CreateOrganization(Organization organization)
        {
            return await _organizationRepository.CreateOrganization(organization);
        }
        public async Task<Organization?> UpdateOrganization(int id, Organization organization)
        {
            return await _organizationRepository.UpdateOrganization(id, organization);
        }
        public async Task<Organization> DeleteOrganization(int id)
        {
            return await _organizationRepository.DeleteOrganization(id);
        }
       /* public async Task<List<Subscription>> GetSubscriptionsByOrgId(int orgId)
        {
            return await _organizationRepository.GetSubscriptionsByOrgId(orgId);
        }
        public async Task<List<User>> GetUsersByOrgId(int orgId)
        {
            return await _organizationRepository.GetUsersByOrgId(orgId);
        }
        public async Task<List<Subscription>> GetSubscriptionsByUserId(int userId)
        {
            return await _organizationRepository.GetSubscriptionsByUserId(userId);
        }
        public async Task<List<Organization>> GetOrganizationsByUserId(int userId)
        {
            return await _organizationRepository.GetOrganizationsByUserId(userId);
        }*/
    }
}

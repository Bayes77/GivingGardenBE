using Microsoft.EntityFrameworkCore;
using GivingGardenBE.Data;
using GivingGardenBE.Models;
using GivingGardenBE.Interfaces;
using System.Linq;


namespace GivingGardenBE.Repositories
{
    public class OrganizationRepository : IOrganizationRepositroy
    {
        private readonly GivingGardenBEDbContext _context;
        public OrganizationRepository(GivingGardenBEDbContext context)
        {
            _context = context;
        }
        public async Task<List<Organization>> GetAllOrganizations()
        {
            return await _context.Organizations.ToListAsync();
        }
        public async Task<List<Organization?>> GetOrganizationById(int id)
        {
            return await _context.Organizations.Where(o => o.Id == id).ToListAsync();
        }
        public async Task<Organization?> CreateOrganization(Organization organization)
        {
            var result = await _context.Organizations.AddAsync(organization);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Organization?> UpdateOrganization(int id, Organization organization)
        {
            var existingOrg = await _context.Organizations.FindAsync(id);
            if (existingOrg == null) return null;
            existingOrg.Title = organization.Title;
            existingOrg.Description = organization.Description;
            await _context.SaveChangesAsync();
            return existingOrg;
        }
        public async Task<Organization> DeleteOrganization(int id)
        {
            var orgToDelete = await _context.Organizations.FindAsync(id);
            if (orgToDelete == null) throw new Exception("Organization not found");
            _context.Organizations.Remove(orgToDelete);
            await _context.SaveChangesAsync();
            return orgToDelete;
        }
        public async Task<List<Subscription>> GetSubscriptionsByOrgId(int orgId)
        {
            return await _context.Subscriptions.Where(s => s.OrganizationId == orgId).ToListAsync();
        }
        /*public async Task<List<User>> GetUsersByOrgId(int orgId)
        {
            var subscriptions = await GetSubscriptionsByOrgId(orgId);
            var userIds = subscriptions.Select(s => s.UserId).Distinct().ToList(); // Ensure userIds is a list of integers
            return await _context.Users.Where(u => userIds.Contains(u.Id)).ToListAsync(); // Ensure u.Id is an integer
        }*/
        public async Task<List<Subscription>> GetSubscriptionsByUserId(int userId)
        {
            return await _context.Subscriptions.Where(s => s.UserId == userId.ToString()).ToListAsync(); // Convert userId to string
        }
        public async Task<List<Organization>> GetOrganizationsByUserId(int userId)
        {
            var subscriptions = await GetSubscriptionsByUserId(userId);
            var orgIds = subscriptions.Select(s => s.OrganizationId).Distinct();
            return await _context.Organizations.Where(o => orgIds.Contains(o.Id)).ToListAsync();
        }
    }
}


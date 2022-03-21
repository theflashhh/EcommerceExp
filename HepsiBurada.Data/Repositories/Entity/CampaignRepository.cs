using System;
using System.Collections.Generic;
using System.Linq;
using HepsiBurada.Data.Context;
using HepsiBurada.Data.Repositories.Interfaces;
using HepsiBurada.Domain;

namespace HepsiBurada.Data.Repositories.Entity
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly HepsiBuradaContext _context;

        public CampaignRepository(HepsiBuradaContext context) => _context = context;

        public CampaignRequestDto AddCampaign(CampaignRequestDto campaignRequestDto)
        {
            _context.CampaignRequestDto.Add(campaignRequestDto);
            _context.SaveChanges();
            return campaignRequestDto;
        }

        public CampaignRequestDto FindByName(string name)
        {
            return _context.CampaignRequestDto.FirstOrDefault(x => x.Name.ToLower().Contains(name.ToLower()) && x.Active);
        }

        public IList<CampaignRequestDto> FindActiveCampaigns()
        {
            return _context.CampaignRequestDto.Where(x => x.Active && x.Duration > 0 && x.EndDate >= DateTime.Now).ToList();
        }

        public CampaignRequestDto UpdateCampaign(CampaignRequestDto campaignRequestDto)
        {
            _context.CampaignRequestDto.Update(campaignRequestDto);
            _context.SaveChanges();
            return campaignRequestDto;
        }

        public CampaignRequestDto FindRandomCampaign()
        {
            var campaigns = FindActiveCampaigns();
            var random = new Random().Next(0, campaigns.Count - 1);
            return campaigns[random];
        }
    }
}
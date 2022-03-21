using System.Collections.Generic;
using HepsiBurada.Domain;

namespace HepsiBurada.Data.Repositories.Interfaces
{
    public interface ICampaignRepository
    {
        CampaignRequestDto AddCampaign(CampaignRequestDto campaignRequestDto);
        CampaignRequestDto FindByName(string name);
        IList<CampaignRequestDto> FindActiveCampaigns();
        CampaignRequestDto UpdateCampaign(CampaignRequestDto campaignRequestDto);
        CampaignRequestDto FindRandomCampaign();
    }
}
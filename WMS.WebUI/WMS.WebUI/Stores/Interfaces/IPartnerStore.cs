﻿using WMS.WebUI.ViewModels;
using WMS.WebUI.ViewModels.PartnerViewModels;

namespace WMS.WebUI.Stores.Interfaces;

public interface IPartnerStore
{
    Task<List<PartnerViewModel>> GetPartnersAsync(string? search="", string? type = "");
    Task<PartnerViewModel> GetByIdAndTypeAsync(int id, PartnerType type);
    Task<PartnerViewModel> CreateAsync(CreatePartnerViewModel partner);
    Task UpdateAsync(EditPartnerViewModel partner);
    Task DeleteAsync(int id, PartnerType type);
}

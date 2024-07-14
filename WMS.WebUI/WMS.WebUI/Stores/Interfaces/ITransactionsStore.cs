﻿using WMS.WebUI.ViewModels;

namespace WMS.WebUI.Stores.Interfaces;

public interface ITransactionsStore
{
    Task<List<TransactionView>> GetTransactionsAsync(string? search, string? type);
    Task<List<PartnerViewModel>> GetPartnersAsync();
    Task<TransactionView> Create(CreateTransactionViewModel transaction);
}

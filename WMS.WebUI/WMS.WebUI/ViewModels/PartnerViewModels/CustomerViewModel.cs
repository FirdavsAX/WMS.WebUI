﻿namespace WMS.WebUI.ViewModels.PartnerViewModels;

public class CustomerViewModel
{
    public int Id { get; set; }
    public string FullName { get; init; }
    public string PhoneNumber { get; init; }
    public string? Address { get; init; }
    public decimal Balance { get; init; }
    public decimal Discount { get; init; }
}

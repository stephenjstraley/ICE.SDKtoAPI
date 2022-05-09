using System;
using System.Collections.Generic;
using System.Text;

namespace LenderApi_Tests
{
    public partial class Program
    {
        static void ResidencesAndMore()
        {
            Console.Clear();

            _api.GetLoanGuidAsync(UseThisLoan).Wait();

            if (_api.HasLoanGuid)
            {
                #region Residences
                Console.WriteLine("---- Residences ----");
                var bors = _api.GetResidencesAsync(1, true).Result;
                if (_api.IsOkStatus)
                {
                    var cobors = _api.GetResidencesAsync(1, false).Result;
                    if (_api.IsOkStatus)
                    {
                        Console.WriteLine("----Borrowers");
                        bors.ForEach(t => Console.WriteLine(t.AddressStreetLine1));
                        Console.WriteLine("----CoBorrowers");
                        cobors.ForEach(t => Console.WriteLine(t.AddressStreetLine1));

                        // temp delete all coborrowers
                        _api.DeleteResidenceAsync(1, cobors, false).Wait();

                        List<ICE.SDKtoAPI.LenderApiContractsV3.ResidenceContract> toAdd =
                            new List<ICE.SDKtoAPI.LenderApiContractsV3.ResidenceContract>();

                        _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                        toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.ResidenceContract()
                        {
                            ResidencyType = "Current",
                            AddressCity = "Washington",
                            AddressState = "DC",
                            DurationTermMonths = 6,
                            DurationTermYears = 25,
                            AddressStreetLine1 = "New Test Street"
                        });

                        var addedAddress = _api.AddResidenceAsync(1, toAdd, false).Result;

                        if (_api.IsOkStatus)
                        {
                            Console.WriteLine($"Old Address: {addedAddress[0].AddressStreetLine1}");

                            addedAddress[0].AddressStreetLine1 = "Updated Test Street";

                            var updateAddress = _api.UpdateResidenceAsync(1, addedAddress, false).Result;

                            if (_api.IsOkStatus)
                            {
                                Console.WriteLine($"New Addesss: {updateAddress[0].AddressStreetLine1}");
                                Console.WriteLine();

                                bors = _api.GetResidencesAsync(1, true).Result;
                                cobors = _api.GetResidencesAsync(1, false).Result;
                                bors.ForEach(t => Console.WriteLine(t.AddressStreetLine1));
                                Console.WriteLine("----");
                                cobors.ForEach(t => Console.WriteLine(t.AddressStreetLine1));

                                Console.WriteLine();

                                Console.WriteLine("Now remove it!");
                                var didDelete = _api.DeleteResidenceAsync(1, updateAddress, false).Result;
                                if (didDelete)
                                    Console.WriteLine("Address Removed");
                                else
                                    Console.WriteLine($"Error: {_api.LastMessage}");
                            }

                        }


                    }
                }
                #endregion

                #region Gifts and Grants
                Console.WriteLine("---- Gifts and Grants ----");
                var ggs = _api.GetGiftsGrantsAsync(1).Result;
                if (_api.IsOkStatus)
                {
                    if (ggs.Count > 0)
                    {
                        Console.WriteLine($"{ggs[0].Amount}");
                    }

                    List<ICE.SDKtoAPI.LenderApiContractsV3.GiftGrantContract> toAdd =
                            new List<ICE.SDKtoAPI.LenderApiContractsV3.GiftGrantContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.GiftGrantContract()
                    {
                        HolderAddressCity = "Henderson",
                        HolderAddressPostalCode = "89014"
                    });

                    var added = _api.AddGiftsGrantsAsync(1, toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].Amount = (decimal)110000.58;
                        added[0].GiftorGrantDate = "2020-04-15";

                        var update = _api.UpdateGiftsGrantsAsync(1, added).Result;

                        if (_api.IsOkStatus)
                        {

                            update.ForEach(t => Console.WriteLine($"{t.HolderAddressCity} - {t.Amount}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteGiftsGrantsAsync(1, update).Result)
                                Console.WriteLine("GG Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Additional Loans
                Console.WriteLine("---- Additional Loans ----");
                var als = _api.GetAdditionalLoansAsync(1).Result;
                if (_api.IsOkStatus)
                {
                    if (als.Count > 0)
                        als.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.AdditionalLoanContract> toAdd =
                             new List<ICE.SDKtoAPI.LenderApiContractsV3.AdditionalLoanContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.AdditionalLoanContract()
                    {
                        BorrowerType = "Borrower",
                        HolderName = "Test User",
                        Attention = "Attention Test"
                    });

                    var added = _api.AddAdditionalLoansAsync(1, toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].HolderAddressStreetLine1 = "Street 11";
                        added[0].HolderAddressState = "NE";

                        var update = _api.UpdateAdditionalLoansAsync(1, added).Result;

                        if (_api.IsOkStatus)
                        {

                            update.ForEach(t => Console.WriteLine($"{t.HolderName} - {t.Attention}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteAdditionalLoansAsync(1, update).Result)
                                Console.WriteLine("Other Loans Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Other Assets
                Console.WriteLine("---- Other Assets ----");
                var oa = _api.GetOtherAssetsAsync(1).Result;
                if (_api.IsOkStatus)
                {
                    if (oa.Count > 0)
                        oa.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.OtherAssetContract> toAdd =
                             new List<ICE.SDKtoAPI.LenderApiContractsV3.OtherAssetContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.OtherAssetContract()
                    {
                        BorrowerType = "Borrower",
                        AssetType = "RelocationFunds",
                        HolderName = "OA Name"
                    });

                    var added = _api.AddOtherAssetsAsync(1, toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].Attention = "Other Assets Attention To";
                        added[0].OtherAssetDate = "2022-01-01";

                        var update = _api.UpdateOtherAssetsAsync(1, added).Result;

                        if (_api.IsOkStatus)
                        {

                            update.ForEach(t => Console.WriteLine($"{t.HolderName} - {t.Attention}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteOtherAssetsAsync(1, update).Result)
                                Console.WriteLine("Other Assets Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Other Income
                Console.WriteLine("---- Other Income Sources ----");
                var ois = _api.GetOtherIncomeSourcesAsync(1).Result;
                if (_api.IsOkStatus)
                {
                    ois.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.OtherIncomeSourceContract> toAdd =
                             new List<ICE.SDKtoAPI.LenderApiContractsV3.OtherIncomeSourceContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.OtherIncomeSourceContract()
                    {
                        Owner = "CoBorrower",
                        HolderName = "OtherIncomeSource",
                        HolderPhone = "9876543210"

                    });

                    var added = _api.AddOtherIncomeSorcesAsync(1, toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].Description = "Pension";
                        added[0].OtherIncomeSourceDate = "2022-01-01";

                        var update = _api.UpdateOtherIncomeSorcesAsync(1, added).Result;

                        if (_api.IsOkStatus)
                        {

                            update.ForEach(t => Console.WriteLine($"{t.HolderName} - {t.Attention}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteOtherIncomeSorcesAsync(1, update).Result)
                                Console.WriteLine("Other Income Sources Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Other Liabilities
                Console.WriteLine("---- Other Liabilities ----");
                var ol = _api.GetOtherLiabilitiesAsync(1).Result;
                if (_api.IsOkStatus)
                {
                    ol.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.OtherLiabilityContract> toAdd =
                             new List<ICE.SDKtoAPI.LenderApiContractsV3.OtherLiabilityContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.OtherLiabilityContract()
                    {
                        BorrowerType = "Borrower",
                        LiabilityOrExpenseType = "SeparateMaintenanceExpense",
                        MonthlyPayment = 1000,
                        HolderName = "Test OL"
                    });

                    var added = _api.AddOtherLiabilitiesAsync(1, toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].OtherDescription = "Updated";
                        added[0].Attention = "Me";

                        var update = _api.UpdateOtherLiabilitiesAsync(1, added).Result;

                        if (_api.IsOkStatus)
                        {

                            update.ForEach(t => Console.WriteLine($"{t.HolderName} - {t.Attention}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteOtherLiabilitiesAsync(1, update).Result)
                                Console.WriteLine("Other Liabilities Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Non Volds
                Console.WriteLine("---- Non Vols ----");
                var nonVol = _api.GetNonVolsAsync().Result;
                if (_api.IsOkStatus)
                {
                    nonVol.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.NonVolContract> toAdd =
                             new List<ICE.SDKtoAPI.LenderApiContractsV3.NonVolContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.NonVolContract()
                    {
                        AdjustmentDescription = "Desc- NonVol-Add1",
                        AdjustmentOtherDescription = "Other Desc- NonVol-Add1",
                        AdjustmentAmount = (decimal)2.5,
                        AdjustmentType = "Type1"
                    });

                    var added = _api.AddNonVolsAsync(toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].IncludedIndicator = true;
                        added[0].PaidBy = "Me";

                        var update = _api.UpdateNonVolsAsync(added).Result;

                        if (_api.IsOkStatus)
                        {

                            update.ForEach(t => Console.WriteLine($"{t.AdjustmentAmount} - {t.AdjustmentDescription}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteNonVolsAsync(update).Result)
                                Console.WriteLine("Non Vols Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Affiliated Business
                Console.WriteLine("---- Affiliated Business Arrangement ----");
                var aba = _api.GetAffiliatedBusinessArragementsAsync().Result;
                if (_api.IsOkStatus)
                {
                    aba.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.AffiliatedBusinessArrangementContract> toAdd =
                             new List<ICE.SDKtoAPI.LenderApiContractsV3.AffiliatedBusinessArrangementContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.AffiliatedBusinessArrangementContract()
                    {
                        LenderName = "astro Lenders",
                        LenderAddress = "1 Castro St",
                        LenderAddressCity = "Mountain View",
                        LenderAddressState = "CA"
                    });

                    var added = _api.AddAffiliatedBusinessArragementsAsync(toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].AffiliateName = "New Name";
                        added[0].ServiceDescription1 = "Me";

                        var update = _api.UpdateAffiliatedBusinessArragementsAsync(added).Result;

                        if (_api.IsOkStatus)
                        {

                            update.ForEach(t => Console.WriteLine($"{t.LenderName} - {t.AffiliateName}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteAffiliatedBusinessArragementsAsync(update).Result)
                                Console.WriteLine("Affiliated Business Arrangements");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Update Service Provider
                Console.WriteLine("---- Service Provider ----");
                var spc = _api.GetServiceProvidersAsync().Result;
                if (_api.IsOkStatus)
                {
                    spc.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.ServiceProviderContract> toAdd =
                             new List<ICE.SDKtoAPI.LenderApiContractsV3.ServiceProviderContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.ServiceProviderContract()
                    {
                        Address = "1144 Rosebud",
                        City = "San Ramon",
                        LineItemNumber = "42"
                    });

                    var added = _api.AddServiceProvidersAsync(toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        var fees = new List<ICE.SDKtoAPI.LenderApiContractsV3.ServiceProviderFeeContract>();
                        var fee = new ICE.SDKtoAPI.LenderApiContractsV3.ServiceProviderFeeContract()
                        {
                            ItemNumber = 1,
                            Amount = 400,
                            Description = "Added Fee"
                        };
                        fees.Add(fee);
                        added[0].ServiceProviderContactFees = fees;

                        var update = _api.UpdateServiceProvidersAsync(added).Result;

                        if (_api.IsOkStatus)
                        {
                            update.ForEach(t => Console.WriteLine($"{t.Id} - {t.ServiceProviderContactFees[0].Amount}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteServiceProvidersAsync(update).Result)
                                Console.WriteLine("Service Provider Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Home Counseling Providers
                Console.WriteLine("---- Home Counseling Providers ----");
                var hcp = _api.GetAffiliatedBusinessArragementsAsync().Result;
                if (_api.IsOkStatus)
                {
                    hcp.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.HomeCounselingProviderContract> toAdd =
                             new List<ICE.SDKtoAPI.LenderApiContractsV3.HomeCounselingProviderContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.HomeCounselingProviderContract()
                    {
                        AgencyName = "astro Lenders",
                        AgencyAddress = "1 Castro St",
                        AgencyAddressCity = "Mountain View",
                        AgencyAddressState = "CA"
                    });

                    var added = _api.AddHomeCounselingProvidersAsync(toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].AgencyAddressPostalCode = "17662";
                        added[0].DistanceMiles = 100;

                        var update = _api.UpdateHomeCounselingProvidersAsync(added).Result;

                        if (_api.IsOkStatus)
                        {
                            update.ForEach(t => Console.WriteLine($"{t.AgencyName} - {t.DistanceMiles}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteHomeCounselingProvidersAsync(update).Result)
                                Console.WriteLine("Home Counseling Provider removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                    }
                }
                #endregion

                #region Employments
                Console.WriteLine("---- Employments ----");
                var empbors = _api.GetEmploymentsAsync(1, true).Result;
                if (_api.IsOkStatus)
                {
                    var empcobors = _api.GetEmploymentsAsync(1, false).Result;
                    if (_api.IsOkStatus)
                    {
                        Console.WriteLine("----Borrowers");
                        empbors.ForEach(t => Console.WriteLine(t.Id));
                        Console.WriteLine("----CoBorrowers");
                        empcobors.ForEach(t => Console.WriteLine(t.Id));

                        List<ICE.SDKtoAPI.LenderApiContractsV3.EmploymentContract> toAdd =
                            new List<ICE.SDKtoAPI.LenderApiContractsV3.EmploymentContract>();

                        _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                        toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.EmploymentContract()
                        {
                            AddressCity = "Washington",
                            AddressState = "DC",
                            BaseIncome = 120000,
                            Title = "Programmer"
                        });

                        var emp = _api.AddEmploymentAsync(1, toAdd, false).Result;

                        if (_api.IsOkStatus)
                        {
                            empcobors = _api.GetEmploymentsAsync(1, false).Result;
                            Console.WriteLine("----CoBorrowers");
                            empcobors.ForEach(t => Console.WriteLine(t.Id));

                            emp[0].BonusAmount = 100;

                            var updateEmp = _api.UpdateEmploymentAsync(1, emp, false).Result;

                            if (_api.IsOkStatus)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Now remove it!");
                                var didDelete = _api.DeleteEmploymentAsync(1, updateEmp, false).Result;
                                if (didDelete)
                                    Console.WriteLine("Employment Removed");
                                else
                                    Console.WriteLine($"Error: {_api.LastMessage}");

                            }
                        }

                    }
                }
                #endregion

                #region REO Properties
                Console.WriteLine("---- REO Properties ----");
                var reo = _api.GetReoPropertiesAsync(1).Result;
                if (_api.IsOkStatus)
                {
                    reo.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.ReoPropertyContract> toAdd =
                            new List<ICE.SDKtoAPI.LenderApiContractsV3.ReoPropertyContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.ReoPropertyContract()
                    {
                        City = "Henderson",
                        YearBuilt = "2016"
                    });

                    var added = _api.AddReoPropertyAsync(1, toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].MaintenanceExpenseAmount = "2000";
                        added[0].Owner = "coborrower";

                        var update = _api.UpdateReoPropertyAsync(1, added).Result;

                        if (_api.IsOkStatus)
                        {
                            update.ForEach(t => Console.WriteLine($"{t.Owner} - {t.YearBuilt}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteReoPropertyAsync(1, update).Result)
                                Console.WriteLine("REO Property Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                        else
                            Console.WriteLine($"REO Update Error: {_api.LastMessage}");
                    }
                    else
                        Console.WriteLine($"REO Add Error: {_api.LastMessage}");
                }
                #endregion

                #region VOLS
                Console.WriteLine("---- Vols ----");
                var vol = _api.GetVolsAsync(1).Result;
                if (_api.IsOkStatus)
                {
                    vol.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.VolContract> toAdd =
                            new List<ICE.SDKtoAPI.LenderApiContractsV3.VolContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.VolContract()
                    {
                        AccountIdentifier = "21324231",
                        Attention = "Me"
                    });

                    var added = _api.AddVolAsync(1, toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].HolderAddressCity = "Pleaseanton";
                        added[0].Owner = "Coborrower";
                        added[0].Lates12Month120Day = 33;

                        var update = _api.UpdateVolAsync(1, added).Result;

                        if (_api.IsOkStatus)
                        {
                            update.ForEach(t => Console.WriteLine($"{t.Owner} - {t.AccountIdentifier}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteVolAsync(1, update).Result)
                                Console.WriteLine("Vol Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                        else
                            Console.WriteLine($"VOL Update Error: {_api.LastMessage}");
                    }
                    else
                        Console.WriteLine($"VOL Add Error: {_api.LastMessage}");
                }
                #endregion

                #region VODS
                Console.WriteLine("---- Vods ----");
                var vod = _api.GetVodsAsync(1).Result;
                if (_api.IsOkStatus)
                {
                    vod.ForEach(t => Console.WriteLine(t.Id));

                    List<ICE.SDKtoAPI.LenderApiContractsV3.VodContract> toAdd =
                            new List<ICE.SDKtoAPI.LenderApiContractsV3.VodContract>();

                    _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();


                    List<ICE.SDKtoAPI.LenderApiContractsV3.VodItemContract> items = new List<ICE.SDKtoAPI.LenderApiContractsV3.VodItemContract>();
                    var item = new ICE.SDKtoAPI.LenderApiContractsV3.VodItemContract()
                    {
                        ItemNumber = 1,
                        Type = "Checking Account",
                        AccountIdentifier = "12221",
                        CashOrMarketValueAmount = (decimal)100,
                        DepositoryAccountName = "My Account",
                        ForeignAddressIndicator = false,
                        Country = "USA"
                    };
                    items.Add(item);

                    toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.VodContract()
                    {
                        HolderName = "New Test",
                        Owner = "Borrower",
                        Items = items
                    });

                    var added = _api.AddVodAsync(1, toAdd).Result;

                    if (_api.IsOkStatus)
                    {
                        added[0].HolderAddressCity = "Pleaseanton";

                        var update = _api.UpdateVodAsync(1, added).Result;

                        if (_api.IsOkStatus)
                        {
                            update.ForEach(t => Console.WriteLine($"{t.Owner} - {t.HolderAddressCity}"));

                            Console.WriteLine();
                            Console.WriteLine("Now remove it!");
                            if (_api.DeleteVodAsync(1, update).Result)
                                Console.WriteLine("VoD Removed");
                            else
                                Console.WriteLine($"Error: {_api.LastMessage}");
                        }
                        else
                            Console.WriteLine($"VOD Update Error: {_api.LastMessage}");
                    }
                    else
                        Console.WriteLine($"VOD Add Error: {_api.LastMessage}");
                }
                #endregion

                #region Alternate Names
                Console.WriteLine("---- Alternate Names ----");
                var altnBor = _api.GetUrlaAlternateNamesAsync(1, true).Result;
                if (_api.IsOkStatus)
                {
                    var altnCoBor = _api.GetUrlaAlternateNamesAsync(1, false).Result;
                    if (_api.IsOkStatus)
                    {
                        altnBor.ForEach(t => Console.WriteLine(t.Id));
                        altnCoBor.ForEach(t => Console.WriteLine(t.Id));

                        List<ICE.SDKtoAPI.LenderApiContractsV3.UrlaAlternateNameContract> toAdd =
                            new List<ICE.SDKtoAPI.LenderApiContractsV3.UrlaAlternateNameContract>();

                        _api.UnlockLoanAsync(_api.LoanGuid, true).Wait();

                        toAdd.Add(new ICE.SDKtoAPI.LenderApiContractsV3.UrlaAlternateNameContract()
                        {
                            FirstName = "New Alice",
                            MiddleName = "J",
                            LastName = "Cooper"
                        });

                        var added = _api.AddUrlaAlternateNameAsync(1, toAdd, false).Result;

                        if (_api.IsOkStatus)
                        {
                            added[0].FullName = "This is Full name";

                            var updated = _api.UpdateUrlaAlternateNameAsync(1, added, false).Result;

                            updated.ForEach(t => Console.WriteLine($"{t.Id} - {t.FirstName} - {t.FirstName}"));

                            if (_api.IsOkStatus)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Now remove it!");
                                var didDelete = _api.DeleteUrlaAlternateNameAsync(1, updated, false).Result;
                                if (didDelete)
                                    Console.WriteLine("URL Alt Name Removed");
                                else
                                    Console.WriteLine($"Error: {_api.LastMessage}");
                            }
                            else
                                Console.WriteLine($"Error in updating: {_api.LastMessage}");
                        }
                        else
                            Console.WriteLine($"Error in adding: {_api.LastMessage}");
                    }
                    else
                        Console.WriteLine($"Error in getting: {_api.LastMessage}");

                }
                #endregion
            }
        }

    }
}

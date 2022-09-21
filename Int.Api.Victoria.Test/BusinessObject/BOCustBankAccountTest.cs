using AutoFixture;
using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Int.Api.Victoria.Test.BusinessObject
{
    public class BOCustBankAccountTest
    {
        private readonly BOCustBankAccount _sut;
        private readonly DBContext dBContext;
        private readonly IFixture fixture;

        public BOCustBankAccountTest()
        {
            var option = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            dBContext = new DBContext(option);
            _sut = new BOCustBankAccount(dBContext);
            fixture = new Fixture();
        }

        [Fact]
        public async Task GetBankAccount_ShouldReturn_WMS018()
        {
            //Arrange
            var data = fixture.Build<BMInqCustBankAccount>().Create();

            //Act
            var result = await _sut.GetBankAccount(data);

            //Assert
            Assert.Empty(result.Data.BankAccounts);
            Assert.False(result.IsOk);
            Assert.Equal("WMS018", result.ResponseCode);
            
        }

        [Theory]
        [InlineData("1234")]
        public async Task GetBankAccount_ShouldReturn_WMS006(string cif)
        {
            //Arrage                        
            var datacust = fixture.Build<Tcustomer>().With(x => x.UnitHolderIdno, "123").Without(x => x.TagentCustomers).
                Without(x => x.TassetTransferFromIdcustomerNavigations).
                Without(x => x.TassetTransferToIdcustomerNavigations).
                Without(x => x.TautoDebitMembers).
                Without(x => x.TautoSubRegisters).
                Without(x => x.TcustBankAccounts).
                Without(x => x.TcustProfileAnswers).
                Without(x => x.TcustomerAddresses).
                Without(x => x.TcustomerAuthContacts).
                Without(x => x.TcustomerBods).
                Without(x => x.TcustomerCardInformations).
                Without(x => x.TcustomerCorporateCardHolders).
                Without(x => x.TcustomerCustodies).
                Without(x => x.TcustomerHeirs).
                Without(x => x.TcustomerOwnerships).
                Without(x => x.TcustomerRegInvestmentPlans).
                Without(x => x.TcustomerRiskProfiles).
                Without(x => x.TcustomerSalesHistories).
                Without(x => x.TcustomerShareholders).
                Without(x => x.TextHighNetworkCustomers).
                Without(x => x.Tgoals).
                Without(x => x.TinsuranceCovers).
                Without(x => x.TproductBundlingRegistrations).
                Without(x => x.Tretirements).
                Without(x => x.TsubAccounts).
                Without(x => x.Ttransactions).
                Without(x => x.Profile).
                Without(x => x.TcustomerIndividual).
                Without(x => x.TcustomerInstitusi).
                Without(x => x.TcustomerDocuments)
                .Create();

            var datatref = fixture.Build<TreferenceDetail>().With(x => x.TreferenceGroupId, 1).With(x => x.Display, "IB").Without(x => x.TreferenceGroup).Create();
            var datatrefg = fixture.Build<TreferenceGroup>().With(x => x.TreferenceGroupId, 1).With(x => x.GroupName, "TRefTransactionGenerator").Without(x => x.TreferenceDetails).Create();

            dBContext.TreferenceDetails.Add(datatref);
            dBContext.TreferenceGroups.Add(datatrefg);
            dBContext.Tcustomers.Add(datacust);            
            dBContext.SaveChanges();

            var datamodel = fixture.Build<BMInqCustBankAccount>().With(x => x.CIF, cif).With(x => x.ChannelID, "IB").Create();

            //Act
            var result = await _sut.GetBankAccount(datamodel);

            //Assert
            Assert.Equal("WMS006", result.ResponseCode);
            Assert.False(result.IsOk);
        }

        [Theory]
        [InlineData("123")]
        public async Task GetBankAccount_ShouldReturn_WMS013(string cif)
        {
            //Arrage                        
            var datacust = fixture.Build<Tcustomer>().With(x => x.UnitHolderIdno, "123").Without(x => x.TagentCustomers).
                Without(x => x.TassetTransferFromIdcustomerNavigations).
                Without(x => x.TassetTransferToIdcustomerNavigations).
                Without(x => x.TautoDebitMembers).
                Without(x => x.TautoSubRegisters).
                Without(x => x.TcustBankAccounts).
                Without(x => x.TcustProfileAnswers).
                Without(x => x.TcustomerAddresses).
                Without(x => x.TcustomerAuthContacts).
                Without(x => x.TcustomerBods).
                Without(x => x.TcustomerCardInformations).
                Without(x => x.TcustomerCorporateCardHolders).
                Without(x => x.TcustomerCustodies).
                Without(x => x.TcustomerHeirs).
                Without(x => x.TcustomerOwnerships).
                Without(x => x.TcustomerRegInvestmentPlans).
                Without(x => x.TcustomerRiskProfiles).
                Without(x => x.TcustomerSalesHistories).
                Without(x => x.TcustomerShareholders).
                Without(x => x.TextHighNetworkCustomers).
                Without(x => x.Tgoals).
                Without(x => x.TinsuranceCovers).
                Without(x => x.TproductBundlingRegistrations).
                Without(x => x.Tretirements).
                Without(x => x.TsubAccounts).
                Without(x => x.Ttransactions).
                Without(x => x.Profile).
                Without(x => x.TcustomerIndividual).
                Without(x => x.TcustomerInstitusi).
                Without(x => x.TcustomerDocuments)
                .Create();

            var datatref = fixture.Build<TreferenceDetail>().With(x => x.TreferenceGroupId, 1).With(x => x.Display, "IB").Without(x => x.TreferenceGroup).Create();
            var datatrefg = fixture.Build<TreferenceGroup>().With(x => x.TreferenceGroupId, 1).With(x => x.GroupName, "TRefTransactionGenerator").Without(x => x.TreferenceDetails).Create();

            dBContext.TreferenceDetails.Add(datatref);
            dBContext.TreferenceGroups.Add(datatrefg);
            dBContext.Tcustomers.Add(datacust);
            dBContext.SaveChanges();

            var datamodel = fixture.Build<BMInqCustBankAccount>().With(x => x.CIF, cif).With(x => x.ChannelID, "IB").Create();

            //Act
            var result = await _sut.GetBankAccount(datamodel);

            //Assert
            Assert.Equal("WMS013", result.ResponseCode);
            Assert.False(result.IsOk);
        }

        [Theory]
        [InlineData("123")]
        public async Task GetBankAccount_ShouldReturn_success(string cif)
        {
            //Arrage                        
            var datacust = fixture.Build<Tcustomer>().With(x => x.UnitHolderIdno, "123").With(x => x.Idcustomer,101).Without(x => x.TagentCustomers).
                Without(x => x.TassetTransferFromIdcustomerNavigations).
                Without(x => x.TassetTransferToIdcustomerNavigations).
                Without(x => x.TautoDebitMembers).
                Without(x => x.TautoSubRegisters).
                Without(x => x.TcustBankAccounts).
                Without(x => x.TcustProfileAnswers).
                Without(x => x.TcustomerAddresses).
                Without(x => x.TcustomerAuthContacts).
                Without(x => x.TcustomerBods).
                Without(x => x.TcustomerCardInformations).
                Without(x => x.TcustomerCorporateCardHolders).
                Without(x => x.TcustomerCustodies).
                Without(x => x.TcustomerHeirs).
                Without(x => x.TcustomerOwnerships).
                Without(x => x.TcustomerRegInvestmentPlans).
                Without(x => x.TcustomerRiskProfiles).
                Without(x => x.TcustomerSalesHistories).
                Without(x => x.TcustomerShareholders).
                Without(x => x.TextHighNetworkCustomers).
                Without(x => x.Tgoals).
                Without(x => x.TinsuranceCovers).
                Without(x => x.TproductBundlingRegistrations).
                Without(x => x.Tretirements).
                Without(x => x.TsubAccounts).
                Without(x => x.Ttransactions).
                Without(x => x.Profile).
                Without(x => x.TcustomerIndividual).
                Without(x => x.TcustomerInstitusi).
                Without(x => x.TcustomerDocuments)
                .Create();

            var datatref = fixture.Build<TreferenceDetail>().With(x => x.TreferenceGroupId, 1).With(x => x.Display, "IB").Without(x => x.TreferenceGroup).Create();
            var datatrefg = fixture.Build<TreferenceGroup>().With(x => x.TreferenceGroupId, 1).With(x => x.GroupName, "TRefTransactionGenerator").Without(x => x.TreferenceDetails).Create();

            var datatcustAcc = fixture.Build<TcustBankAccount>().With(x => x.Idcustomer, 101)
                .With(x => x.Idcurrency, 1)
                .With(x => x.IdaccountBankType, 11)
                .With(x => x.IdbankBranch, 1)
                .Without(x => x.TautoSubRegisters)
                .Without(x => x.IdaccountBankTypeNavigation)
                .Without(x => x.IdbankBranchNavigation)
                .Without(x => x.IdcurrencyNavigation)
                .Without(x => x.IdcustomerNavigation).Create();

            var datarefcurr = fixture.Build<TrefCurrency>().With(x => x.Idcurrency, 1)
                .Without(x => x.TagentBankAccounts)
                .Without(x => x.TautoDebitMemberIdcurrencyFromNavigations)
                .Without(x => x.TautoDebitMemberIdcurrencyToNavigations)
                .Without(x => x.TcustBankAccounts)
                .Without(x => x.TexchangeRateByProductCcurrencies)
                .Without(x => x.TexchangeRateByProductTcurrencies)
                .Without(x => x.TexchangeRateCcurrencies)
                .Without(x => x.TexchangeRateTcurrencies)
                .Without(x => x.TholidayGenerals)
                .Without(x => x.Tholidays)
                .Without(x => x.Tkurs)
                .Without(x => x.TkursGenerals)
                .Without(x => x.TproductBankAccounts)
                .Without(x => x.Tproducts)
                .Without(x => x.TsharingFees).Create();

            var datarefaccbanktype = fixture.Build<TrefAccountBankType>().With(x => x.IdaccountBankType, 11)
                .Without(x => x.TagentBankAccounts)
                .Without(x => x.TautoDebitMemberIdaccountBankTypeFromNavigations)
                .Without(x => x.TautoDebitMemberIdaccountBankTypeToNavigations)
                .Without(x => x.TcustBankAccounts)
                .Without(x => x.TproductBankAccounts).Create();

            var datarefbankbranch = fixture.Build<TrefBankBranch>().With(x => x.IdbankBranch, 1).With(x => x.Idbank, 1)
                .Without(x => x.TagentBankAccounts)
                .Without(x => x.TautoDebitMemberIdbankBranchFromNavigations)
                .Without(x => x.TautoDebitMemberIdbankBranchToNavigations)
                .Without(x => x.TcustBankAccounts)
                .Without(x => x.TproductBankAccounts)
                .Without(x => x.IdbankNavigation).Create();

            var datarefbank = fixture.Build<TrefBank>().With(x => x.Idbank, 1)
                .Without(x => x.TautoDebitGroups)
                .Without(x => x.TrefBankBranches).Create();

            dBContext.TreferenceDetails.Add(datatref);
            dBContext.TreferenceGroups.Add(datatrefg);
            dBContext.Tcustomers.Add(datacust);
            dBContext.TcustBankAccounts.Add(datatcustAcc);
            dBContext.TrefCurrencies.Add(datarefcurr);
            dBContext.TrefAccountBankTypes.Add(datarefaccbanktype);
            dBContext.TrefBankBranches.Add(datarefbankbranch);
            dBContext.TrefBanks.Add(datarefbank);
            dBContext.SaveChanges();

            var datamodel = fixture.Build<BMInqCustBankAccount>().With(x => x.CIF, cif).With(x => x.ChannelID, "IB").Create();

            //Act
            var result = await _sut.GetBankAccount(datamodel);

            //Assert            
            Assert.True(result.IsOk);
            Assert.NotNull(result);
            Assert.Equal("000", result.ResponseCode);
        }
    }
}

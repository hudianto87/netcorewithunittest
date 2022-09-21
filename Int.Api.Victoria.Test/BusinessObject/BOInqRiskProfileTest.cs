using AutoFixture;
using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BusinessObject;
using Int.Api.Victoria.DataAccess.Context;
using Int.Api.Victoria.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Int.Api.Victoria.Test.BusinessObject
{
    public class BOInqRiskProfileTest
    {
        private readonly BOInqRiskProfile _sut;
        private readonly DBContext _dbContext;
        private readonly IFixture _fixture;

        public BOInqRiskProfileTest()
        {
            var option = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _dbContext = new DBContext(option);
            _sut   = new BOInqRiskProfile(_dbContext);
            _fixture = new Fixture();
        }

        [Fact]
        public async Task GetRiskProfile_ShouldReturn_WMS018()
        {
            //arrange
            var data = _fixture.Build<BMInqRiskProfile>().Create();

            //act
            var result = await _sut.GetRiskProfile(data);

            //assert
            Assert.False(result.IsOk);
            Assert.Equal("WMS018", result.ResponseCode);
            Assert.Null(result.Data);
        }

        [Fact]
        public async Task GetRiskProfile_ShouldReturn_WMS006()
        {
            //arrange
            var data = _fixture.Build<BMInqRiskProfile>().With(x => x.ChannelID,"IB").Create();
            var datarefgroup = _fixture.Build<TreferenceGroup>().With(x => x.GroupName, "TRefTransactionGenerator").With(x => x.TreferenceGroupId,17).Without(x => x.TreferenceDetails).Create();
            var dataref = _fixture.Build<TreferenceDetail>().With(x => x.TreferenceGroupId, 17).With(x => x.Display, "IB").Without(x => x.TreferenceGroup).Create();

            _dbContext.TreferenceGroups.Add(datarefgroup);
            _dbContext.TreferenceDetails.Add(dataref);
            _dbContext.SaveChanges();

            //act
            var result = await _sut.GetRiskProfile(data);

            //assert
            Assert.False(result.IsOk);
            Assert.Equal("WMS006", result.ResponseCode);
            Assert.Null(result.Data);
        }

        [Fact]
        public async Task GetRiskProfile_ShouldReturn_WMS017()
        {
            //arrange
            var data = _fixture.Build<BMInqRiskProfile>().With(x => x.ChannelID, "IB").With(x => x.CIF,"123").Create();
            var datarefgroup = _fixture.Build<TreferenceGroup>().With(x => x.GroupName, "TRefTransactionGenerator").With(x => x.TreferenceGroupId, 17).Without(x => x.TreferenceDetails).Create();
            var dataref = _fixture.Build<TreferenceDetail>().With(x => x.TreferenceGroupId, 17).With(x => x.Display, "IB").Without(x => x.TreferenceGroup).Create();
            var datacust = _fixture.Build<Tcustomer>().With(x => x.UnitHolderIdno, "123").Without(x => x.TagentCustomers).
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

            _dbContext.TreferenceGroups.Add(datarefgroup);
            _dbContext.TreferenceDetails.Add(dataref);
            _dbContext.Tcustomers.Add(datacust);
            _dbContext.SaveChanges();

            //act
            var result = await _sut.GetRiskProfile(data);

            //assert
            Assert.False(result.IsOk);
            Assert.Equal("WMS017", result.ResponseCode);
            Assert.Null(result.Data);            
        }

        [Fact]
        public async Task GetRiskProfile_ShouldReturn_success()
        {
            //arrange
            var data = _fixture.Build<BMInqRiskProfile>().With(x => x.ChannelID, "IB").With(x => x.CIF, "123").Create();
            var datarefgroup = _fixture.Build<TreferenceGroup>().With(x => x.GroupName, "TRefTransactionGenerator").With(x => x.TreferenceGroupId, 17).Without(x => x.TreferenceDetails).Create();
            var dataref = _fixture.Build<TreferenceDetail>().With(x => x.TreferenceGroupId, 17).With(x => x.Display, "IB").Without(x => x.TreferenceGroup).Create();
            var datacust = _fixture.Build<Tcustomer>().With(x => x.UnitHolderIdno, "123").With(x => x.Idcustomer, 100).Without(x => x.TagentCustomers).
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
            var datacustriskprofile = _fixture.Build<TcustomerRiskProfile>().Without(x => x.TcustomerRiskProfileAnswers).Without(x => x.IdcustomerNavigation).With(x => x.ProfileId, 1).With(x => x.Idcustomer, 100).Create();
            var datarefprofile = _fixture.Build<TrefProfile>().Without(x => x.Tcustomers).Without(x => x.Tproducts).With(x => x.ProfileId, 1).Create();

            _dbContext.TreferenceGroups.Add(datarefgroup);
            _dbContext.TreferenceDetails.Add(dataref);
            _dbContext.Tcustomers.Add(datacust);
            _dbContext.TcustomerRiskProfiles.Add(datacustriskprofile);
            _dbContext.TrefProfiles.Add(datarefprofile);
            _dbContext.SaveChanges();

            //act
            var result = await _sut.GetRiskProfile(data);

            //assert
            Assert.True(result.IsOk);
            Assert.Equal("000", result.ResponseCode);
            Assert.NotNull(result.Data);
            Assert.Equal("1", result.Data.RiskProfileID.ToString());
        }

        [Fact]
        public async Task GetRiskProfile_ShouldReturn_WMS0182()
        {
            //Arrange
            var data = _fixture.Build<BMInqRiskProfile>().Create();

            //Act
            var result = await _sut.GetRiskProfile(data);
            result.Data = new();

            //Assert
            Assert.Empty(result.Data.CIF);
            Assert.Empty(result.Data.RiskProfileID);
            Assert.Empty(result.Data.RiskProfileName);
            Assert.Empty(result.Data.RiskProfileExpDt);
            Assert.Empty(result.Data.SIDMF);
            Assert.False(result.Data.SIDMFProcessStatus);
            Assert.Empty(result.Data.IFUA);
            Assert.False(result.IsOk);
            Assert.Equal("WMS018", result.ResponseCode);
        }
        [Theory]
        [InlineData("1234")]
        public async Task GetRiskProfile_ShouldReturn_WMS0062(string cif)
        {
            //Arrage                        
            var datacust = _fixture.Build<Tcustomer>().With(x => x.UnitHolderIdno, "123").Without(x => x.TagentCustomers).
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

            var datatref = _fixture.Build<TreferenceDetail>().With(x => x.TreferenceGroupId, 1).With(x => x.Display, "IB").Without(x => x.TreferenceGroup).Create();
            var datatrefg = _fixture.Build<TreferenceGroup>().With(x => x.TreferenceGroupId, 1).With(x => x.GroupName, "TRefTransactionGenerator").Without(x => x.TreferenceDetails).Create();

            await _dbContext.TreferenceDetails.AddAsync(datatref);
            await _dbContext.TreferenceGroups.AddAsync(datatrefg);
            await _dbContext.Tcustomers.AddAsync(datacust);
            await _dbContext.SaveChangesAsync();

            var datamodel = _fixture.Build<BMInqRiskProfile>().With(x => x.CIF, cif).With(x => x.ChannelID, "IB").Create();

            //Act
            var result = await _sut.GetRiskProfile(datamodel);

            //Assert
            Assert.Equal("WMS006", result.ResponseCode);
            Assert.False(result.IsOk);
        }
    }
}
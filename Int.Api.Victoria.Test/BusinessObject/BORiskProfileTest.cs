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
    public class BORiskProfileTest
    {
        private readonly BORiskProfile _sut;
        private readonly DBContext _dbContext;
        private readonly IFixture _fixture;

        public BORiskProfileTest()
        {
            var option = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _dbContext = new DBContext(option);
            _sut = new BORiskProfile(_dbContext);
            _fixture = new Fixture();
        }
    }
}

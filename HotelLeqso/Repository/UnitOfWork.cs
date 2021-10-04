using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Data;
using HotelApi.GenericRepository;
using HotelApi.IRepository;

namespace HotelApi.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DatabaseContext _databaseContext;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotel> _hotels;

        public UnitOfWork(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_databaseContext);

        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_databaseContext);

        public void Dispose()
        {
            _databaseContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _databaseContext.SaveChangesAsync();
        }
    }
}

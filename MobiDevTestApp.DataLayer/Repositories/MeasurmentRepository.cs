using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.DataLayer.Repositories
{
    public class MeasurmentRepository: BaseRepository<Measurment>, IMeasurmentRepository
    {
        public MeasurmentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.DataLayer.Repositories.Interfaces
{
    public interface IDbSeeder
    {
        Task SeedDb();
    }
}

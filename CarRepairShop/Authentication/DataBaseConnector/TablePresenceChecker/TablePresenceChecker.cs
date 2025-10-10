using CarRepairShop.Repositories;
using System.Threading.Tasks;
using TableQueries = CarRepairShop.Queries.TableQueries;

namespace CarRepairShop.Authentication.DataBaseConnector.TablePresenceChecker
{
    public class TablePresenceChecker
    {
        private IGenericRepository _genericRepo;

        public TablePresenceChecker(IGenericRepository genericRepository)
        {
            _genericRepo = genericRepository;
        }

        public async Task<bool> CreateNeededTablesIfNeeded() => await _genericRepo.UseRawSqlAsync(TableQueries.GetTableChecksQuery());
    }
}

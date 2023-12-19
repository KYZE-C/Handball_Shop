using Handball_Shopv1.Server.Data;
using Handball_Shopv1.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Handball_Shopv1.Server.Services.Stats_Service
{
    public class Stats_Service_srv : IStats_Service_srv
    {
        public readonly Data_ctx data_ctx;
        public Stats_Service_srv(Data_ctx context)
        {
            data_ctx = context;
        }
        public async Task<int> GetVisits()
        {
            var stats = await data_ctx.Statistics.FirstOrDefaultAsync();
            if (stats != null)
            {
                return stats.Visits;
            }
            else { return 0; }
        }

        public async Task IncrementVisits()
        {
            var stats = await data_ctx.Statistics.FirstOrDefaultAsync();
            if (stats != null)
            {
                stats.Visits++;
                stats.LastUserVisit = DateTime.Now;
            }
            else
            {
                data_ctx.Statistics.Add(new Statistics { Visits = 1, LastUserVisit = DateTime.Now });
            }
            await data_ctx.SaveChangesAsync();//saves to database
        }
    }
}

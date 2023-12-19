namespace Handball_Shopv1.Server.Services.Stats_Service
{
    public interface IStats_Service_srv
    {
        Task<int> GetVisits();
        Task IncrementVisits();
    }
}

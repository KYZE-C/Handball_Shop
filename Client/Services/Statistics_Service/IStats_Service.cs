namespace Handball_Shopv1.Client.Services.Statistics_Service
{
    public interface IStats_Service
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}

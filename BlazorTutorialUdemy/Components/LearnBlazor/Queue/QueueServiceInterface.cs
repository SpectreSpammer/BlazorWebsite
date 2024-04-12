namespace BlazorTutorialUdemy.Components.LearnBlazor.Queue
{
    public interface QueueServiceInterface
    {
        Task<List<QueueItems>> GetQueues();
    }
}

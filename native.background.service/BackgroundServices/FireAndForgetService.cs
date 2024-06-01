namespace native.background.service.BackgroundServices
{
    public class FireAndForgetService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Execute the task
            Console.WriteLine("Fire-and-forget task executed!");
        }
    }
}

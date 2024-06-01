namespace native.background.service.BackgroundServices
{
    public class DelayedService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

            // Execute the task after the delay
            Console.WriteLine("Delayed task executed!");
        }
    }
}

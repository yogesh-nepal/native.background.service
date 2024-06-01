namespace native.background.service.BackgroundServices
{
    public class RecurringService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Execute the task at regular intervals
                Console.WriteLine("Recurring task executed!");

                // Simulate some work
                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
    }
}

namespace native.background.service.BackgroundServices
{
    public class FirstTaskService
    {
        public TaskCompletionSource<bool> _firstTaskCompleted = new TaskCompletionSource<bool>();
        public bool iscompleted { get; private set; }

        public async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                // Execute the first task
                Console.WriteLine("First task executed!");

                // Simulate some work
                await Task.Delay(3000, stoppingToken);

                // Signal that the first task has completed (only if not already completed)
                if (!_firstTaskCompleted.Task.IsCompleted)
                {
                    _firstTaskCompleted.SetResult(true);
                    iscompleted = true;
                }
            }
            finally
            {
                // Ensure that the task completion source is marked as completed even in case of exceptions
                if (!_firstTaskCompleted.Task.IsCompleted)
                {
                    _firstTaskCompleted.SetResult(false);
                }
            }
        }
    }

    public class SecondTaskService : BackgroundService
    {
        private readonly FirstTaskService _firstTaskService;

        public SecondTaskService(FirstTaskService firstTaskService)
        {
            _firstTaskService = firstTaskService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Wait for the completion of the first task
            await _firstTaskService.ExecuteAsync(stoppingToken);

            if (_firstTaskService.iscompleted)
            {
                // Execute the second task after the first task completes
                Console.WriteLine("Second task executed!");

                // Simulate some work
                await Task.Delay(2000, stoppingToken);
            }
        }
    }

}

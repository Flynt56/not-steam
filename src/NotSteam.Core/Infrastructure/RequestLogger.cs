using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using NotSteam.Core.Interfaces.Logging;

namespace NotSteam.Core.Infrastructure
{
    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly IAppLogger<TRequest> _logger;

        public RequestLogger(IAppLogger<TRequest> logger)
        {
            _logger = logger;
        }

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var name = typeof(TRequest).Name;

            // TODO: Add User Details

            _logger.LogInformation("NotSteam Request: {Name} {@Request}", name, request);

            return Task.CompletedTask;
        }
    }
}

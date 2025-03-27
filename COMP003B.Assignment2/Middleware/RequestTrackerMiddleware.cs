namespace COMP003B.Assignment2.Middleware
{
	public class RequestTrackerMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogger<RequestTrackerMiddleware> _log;
		public RequestTrackerMiddleware(RequestDelegate next, ILogger<RequestTrackerMiddleware> _log;
		{
			_next = next;
			_log = log;
		}
		public async Task InvokeAsync(HttpContent context)

		{
			_log.LogInfo($"Request the method: {context.Requesting.Method}");
			_log.LogInfo($"Request the path: {context.Requesting.Path}");
		}
	}
}

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace UnityDependencyOfRootOnChild
{
    /// <summary>
    /// An interface for a service providing
    /// current time.
    /// </summary>
    public interface ITimeAPI
    {
        /// <summary>
        /// Gets the current time
        /// </summary>
        /// <returns>A task which upon completion will return current date and time</returns>
        Task<DateTime> GetNow();
    }
    
    /// <summary>
    /// An online implementation of <see cref="ITimeAPI"/> using 
    /// http://www.timeapi.org
    /// </summary>
    public class TimeAPI : ITimeAPI
    {
        private readonly ILog _log;

        /// <summary>
        /// Constructor with resource intensive initialization
        /// </summary>
        public TimeAPI(ILog log)
        {
            _log = log;

            Startup();
        }

        public async Task<DateTime> GetNow()
        {
            var http = new HttpClient {BaseAddress = new Uri("http://www.timeapi.org")};
            http.DefaultRequestHeaders.UserAgent.Clear();
            http.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Mozilla", "5.0"));
            http.DefaultRequestHeaders.Accept.Clear();
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/*"));

            var result = await http.GetAsync("utc/now");

            if (!result.IsSuccessStatusCode)
            {
                _log.Info("Cannot fetch value");

                throw new InvalidOperationException();
            }

            var r = await result.Content.ReadAsStringAsync();
            _log.Info("Fetched data {0}", r);
            return DateTime.Parse(r);
        }

        /// <summary>
        /// This method is to emulate a long initialization time.
        /// Any issue is not related to this one...
        /// </summary>
        private void Startup()
        {
            Thread.Sleep(10000);
        }
    }
}
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using WebAPIApplication;

namespace UnitTest
{
    public abstract class BaseIntegrationTest
    {
        protected readonly TestServer Server;
        protected readonly HttpClient Client;
        protected readonly DataContext TestDataContext;

    }
}
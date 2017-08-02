using System;
using System.Net.Http;
using Microsoft.AspNetCore.TestHost;
using WebAPIApplication;

namespace UnitTest.Configuration
{
    public class BaseTestFixure : IDisposable
    {
        public readonly TestServer Server;
        public readonly HttpClient Client;
        public readonly DataContext TestDataContext;
        
        public BaseTestFixure()
        {
            
        }
    }
}
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SonExistence.Dto;
using SonExistence.Interfaces;
using SonExistence.Models;
using System;
using System.Net.Http;

namespace SonExistence.Repositories
{
    public class Repository : IRepository
    {
        private readonly ILogger _logger;
        private readonly AppSettings _configuration;
        private readonly HttpClient _client;

        public Repository(ILogger<Repository> logger, IOptions<AppSettings> options, HttpClient client)
        {
            _logger = logger;
            _client = client;
            _configuration = options.Value;
        }

        public Response Save(DocumentDto message)
        {
            try
            {
                _logger.LogInformation($"Received Text: {message}");
                return default;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "упс");
                throw;
            }
        }
    }
}
using _20220923_IMemoryCache.Models;
using System.Text.Json;

namespace _20220923_IMemoryCache.Infrastructure
{
    public class UserResponse
    {
        public User[]? Data { get; set; }
    }

    public interface IHttpClient
    {
        Task<IEnumerable<User>> Get();
    }

    public class HttpClient : IHttpClient
    {
        private readonly IHttpClientFactory _clientFactory;

        public HttpClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<User>> Get()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://reqres.in/api/users");
            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                await using var responseStream = await response.Content.ReadAsStreamAsync();
                var usersResponse = await JsonSerializer.DeserializeAsync
                    <UserResponse>(responseStream);
                var users = usersResponse.Data;
                return users;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}

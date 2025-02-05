namespace OnlineEdu.WebUI.Helpers
{
    public static class HttpClientInstancesss
    {
        public static HttpClient CreateInstancee()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7214/api");
            return httpClient;
        }
    }
}

HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("http://www.apple.com");
WriteLine($"The apple homepage has {response.Content.Headers.ContentLength:n0} bytes.");

#error version
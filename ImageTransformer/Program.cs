using ImageTransformer;

using var server = new Server();
await server.Start("http://localhost:8080/");

Console.ReadKey(true);
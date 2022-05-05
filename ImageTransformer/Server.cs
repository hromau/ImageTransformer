using System.Net;

namespace ImageTransformer;

public class Server : IDisposable
{
    private readonly HttpListener _listener;

    private bool _disposed;
    private volatile bool _isRunning;

    public Server()
    {
        _listener = new HttpListener();
    }

    public async ValueTask Start(string prefix)
    {
        if (!_isRunning)
        {
            _listener.Prefixes.Clear();
            _listener.Prefixes.Add(prefix);
            _listener.Start();
            
            // todo: make it as u can
            Task process = new Task(async () =>
            {
                if (_listener.IsListening)
                {
                    var context = await _listener.GetContextAsync();
                }
                else
                {
                }
            });
            await process;
            
            _isRunning = true;
        }
    }

    private void Stop()
    {
        if (!_isRunning)
            return;
        _listener.Stop();
        _isRunning = false;
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        _disposed = true;

        Stop();

        _listener.Close();
    }
}
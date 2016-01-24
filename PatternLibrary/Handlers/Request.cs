namespace PatternLibrary.Handlers
{
    public class Request : IRequest
    {
        private readonly string _data;

        public Request(string data)
        {
            this._data = data;
        }

        public string Data => _data;
    }
}

namespace PatternLibrary.Handlers
{
    public class Request : IRequest
    {
        private readonly string data;

        public Request(string data)
        {
            this.data = data;
        }

        public string Data
        {
            get
            {
                return data;
            }
        }
    }
}

namespace Demo.Models
{
    public class Response
    {

        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public Response()
        {
            IsSuccess = false;
        }
    }
}


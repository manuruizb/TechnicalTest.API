namespace TechnicalTest.Domain
{
    public class Result<T>
    {
        public Result()
        {
            Message = "Ok";
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }

    }
}

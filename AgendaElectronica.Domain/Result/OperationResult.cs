

namespace AgendaElectronica.Domain.Result
{
    public class OperationResult
    {
        public string message { get; set; }
        public bool success { get; set; }
        public dynamic Data { get; set; }
    }
}

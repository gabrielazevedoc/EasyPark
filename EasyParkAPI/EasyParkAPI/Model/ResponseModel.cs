namespace EasyParkAPI.Model
{
    public class ResponseModel<T>
    {
        public T? Dados { get; set; }
        public String Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}

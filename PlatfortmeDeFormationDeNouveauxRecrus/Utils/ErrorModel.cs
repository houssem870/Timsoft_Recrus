namespace PlatfortmeDeFormationDeNouveauxRecrus.Utils
{
    public class ErrorModel : Exception
    {
        
    

        string Message { get; set; }
        public ErrorModel(string v)
        {
            Message = v;
        }
    }
}

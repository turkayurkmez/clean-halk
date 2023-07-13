namespace Functions
{
    public class FileNotAvailableForReportException : Exception
    {
        public FileNotAvailableForReportException(string? message) : base(message)
        {

        }

        public override string Message => base.Message;
        public FileNotAvailableForReportException() : this("Dosya yok ya da format uygun değil")
        {

        }



    }
}

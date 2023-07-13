namespace Functions
{
    public class ReportGenerator
    {
        public ReportGenerator(string filePath)
        {

            try
            {
                validateFile(filePath);
            }
            catch (FileNotAvailableForReportException ex)
            {

                throw ex;
            }



        }

        private bool isFileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        private bool isFileFormatAvailable(string filePath)
        {
            return false;
        }

        private bool isValidFile(string filePath)
        {
            return !isFileExists(filePath) && !isFileFormatAvailable(filePath);
        }

        private void validateFile(string filePath)
        {
            if (!isValidFile(filePath))
            {
                throw new FileNotAvailableForReportException();

            }
        }
    }
}

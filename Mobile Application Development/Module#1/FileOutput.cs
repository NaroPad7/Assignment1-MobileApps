public class FileOutput
{
    private StreamWriter writer;
    private string fileName;

    public FileOutput(string fileName)
    {
        this.fileName = fileName;
        try
        {
            writer = new StreamWriter(new FileStream(fileName, FileMode.Create));
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + e);
        }
    }

    public void FileWrite(string line)
    {
        try
        {
            writer.WriteLine(line);
        }
        catch (Exception e)
        {
            Console.WriteLine("File Write Error: " + fileName + " " + e);
        }
    }

    public void FileClose()
    {
        if (writer != null)
        {
            try
            {
                writer.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("File Close Error: " + fileName + " " + e);
            }
        }
    }
}
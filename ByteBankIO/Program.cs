using System.Text;

class Program
{
    private static void Main(string[] args)
    {
        string filePath = "accounts.txt";
        int totalReadedBytes = -1;
        FileStream stream = new(filePath, FileMode.Open);

        byte[] buffer = new byte[1024]; // 1kb

        while (totalReadedBytes != 0)
        {
            totalReadedBytes = stream.Read(buffer, 0, 1024);
            WriteBuffer(buffer);
        }
    }

    static void WriteBuffer(byte[] buffer)
    {
        UTF8Encoding utf8 = new();
        string text = utf8.GetString(buffer);

        Console.Write(text);
    }
}
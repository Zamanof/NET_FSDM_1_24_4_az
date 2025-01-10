// FileStream, MemoryStream, BufferedStream -> Stream
/*
    Absolute path:
       - D:\Documents\NET_FSDM_1_24_4_az\NET 13. Files byte streams\file.txt
       - D:\Documents\NET_FSDM_1_24_4_az\NET 13. Files byte streams\Files\file.txt
       - D:\Documents\NET_FSDM_1_24_4_az\file.txt
       - D:\Documents\NET_FSDM_1_24_4_az\Files\file.txt

     Relative path (working directory-e nisbeten yerleshme yeri):
        - file.txt
        - Files/file.txt
        - ../file.txt
        - ../Files/file.txt
 
 */

using System.Text;

string filePath = "file.txt";
//string txt = Console.ReadLine();

//SaveToFile(filePath, txt);

Console.WriteLine(LoadFromFile(filePath));

void SaveToFile(string path, string text)
{
    using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
    {
        byte[] bytes = Encoding.Default.GetBytes(text);
        file.Write(bytes, 0, bytes.Length);
    }

}

string LoadFromFile(string path)
{
    using (FileStream file = new(path, FileMode.Open, FileAccess.Read, FileShare.Read))
    {
        byte[] bytes = new byte[(int)file.Length];
        file.Read(bytes, 0, bytes.Length);
        return Encoding.Default.GetString(bytes);
    }
}

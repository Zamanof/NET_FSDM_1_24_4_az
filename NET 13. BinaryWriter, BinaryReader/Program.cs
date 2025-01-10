using System.Text;

string filePath = "binaryFile.dat";

//string txt = "Metre bosh sheydi, duz deyil. Poputi";
//int number = 5943;
//float temperature = 10.6f;

//using (FileStream file = new(filePath, FileMode.Create))
//{
//    using (BinaryWriter bw = new BinaryWriter(file, Encoding.Unicode))
//    {
//        bw.Write(txt);
//        bw.Write(temperature);
//        bw.Write(number);
//    }
//}

using (FileStream file = new(filePath, FileMode.Open))
{
    using (BinaryReader br = new BinaryReader(file, Encoding.Unicode))
    {
        Console.WriteLine(br.ReadString());
        Console.WriteLine(br.ReadSingle());
        Console.WriteLine(br.ReadUInt32());
    }
}

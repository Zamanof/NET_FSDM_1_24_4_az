#region DirectoryInfo
//DirectoryInfo directory = new DirectoryInfo(".");
//Console.WriteLine(directory.FullName);
//Console.WriteLine(directory.CreationTime);

//FileInfo[] files = directory.GetFiles();
//foreach (FileInfo file in files)
//{
//    Console.WriteLine(file.FullName);
//}

//DirectoryInfo directory1 = new DirectoryInfo(@"C:\FSDM_1_24_4_az");
//if (!directory1.Exists) directory1.Create();

//DirectoryInfo directory2 = directory1.CreateSubdirectory("Dot NET");

#endregion

#region Directory
//string path = @"C:\FSDM_1_24_4_az";
//if (Directory.Exists(path))
//{
//    Console.WriteLine(Directory.GetCreationTime(path));
//    //foreach (var item in Directory.GetLogicalDrives())
//    //{
//    //    Console.WriteLine($"\t{item}");
//    //}

//    //foreach (var item in Directory.GetDirectories(@"C:\"))
//    //{
//    //    Console.WriteLine($"\t{item}");
//    //}

//    Directory.Delete(path, true);
//}
//else
//{
//    Console.WriteLine("Directory not found");
//    Directory.CreateDirectory(path);
//}
#endregion

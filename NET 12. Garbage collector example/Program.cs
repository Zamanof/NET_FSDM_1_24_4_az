// Garbage collector
/*
 1. Stack

 2. Heap
    - Managed Heap
        * Generation 0 - 255 kb ~ 2mb-ə qədər ölçüsü
        * Generation 1
        * Generation 2

    - LOH - Large Object Heap : 85000 byte-dan böyük olan obyektlər bu Heap-də yaranır
    
    - Pinned Heap : Garbage Collector tərəfindən obyektin yeri dəyişdirilə bilmir. Adətən unmanaged code ilə işləyərkən istifadə edilir
    
    - Unmanaged Heap
 */

//Console.WriteLine(GC.MaxGeneration);
GarbageHelper garbageHelper = new GarbageHelper();
//garbageHelper.MakeGarbage();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
//Console.WriteLine($"Memory: {GC.GetTotalMemory(false)} bytes");
//GC.Collect();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");
//GC.Collect();
//GC.Collect();
//Console.WriteLine($"Generation {GC.GetGeneration(garbageHelper)}");


for (int i = 0; i < 1000000; i++)
{
    garbageHelper.MakeGarbage();
    Console.WriteLine($"{i * 1000} - Generation {GC.GetGeneration(garbageHelper)}");
}
class GarbageHelper
{
    public void MakeGarbage()
    {
        for (int i = 0; i < 1000; i++) 
        {
            Person person = new Person();
        }
    }
}

class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public byte Age { get; set; }
}

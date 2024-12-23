using System.Collections;

class LastNameComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if(x is Student student && y is Student)
        {
            return string.Compare((x as Student)!.LastName, (y as Student)!.LastName);
        }
        throw new NotImplementedException();
    }
}
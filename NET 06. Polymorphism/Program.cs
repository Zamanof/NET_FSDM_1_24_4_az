// Polymorphism
Base @base = new();
Derived derived = new();
Child child = new();

Base obj = new Derived(); // up cast
//((Derived)obj).Show(); // down cast

//Base[] arr = [@base, derived, child];
//foreach (var item in arr)
//{
//    item.Show();
//}

//Foo(@base);
//Foo(derived);
Foo(child);
void Foo(Base @base)
{
    #region version 1
    //if(@base.GetType() == new Derived().GetType())
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base.GetType() == new Child().GetType())
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region version 2
    //try
    //{
    //    ((Derived)@base).Show();
    //}
    //catch (Exception) { }

    //try
    //{
    //    ((Child)@base).Show();
    //}
    //catch (Exception) { }

    //try
    //{
    //    @base.Show();
    //}
    //catch (Exception) { }

    #endregion

    #region version 3
    //if (@base is Derived)
    //{
    //    ((Derived)@base).Show();
    //}
    //else if (@base is Child)
    //{
    //    ((Child)@base).Show();
    //}
    //else
    //{
    //    @base.Show();
    //}
    #endregion

    #region version 4
    //var value = @base is Derived?(Derived)@base:null; // how as worked
    //var value1 = @base as Derived;
    //var value2 = @base as Child;
    //var value3 = @base as Base;
    //if (value1 is not null) value1.Show();
    //else if (value2 is not null) value2.Show();
    //else if(value3 is not null) value3.Show();
    #endregion

    @base.Show();
    (@base as Derived)?.Print();

}
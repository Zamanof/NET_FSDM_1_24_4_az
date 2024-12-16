// inheritance
// sealed - class-dan toremeni qadaqan edir
//Base @base = new();
//@base.Show();

//Derived derived = new("Hello", 36, 98);
//// BP, DP

Derived derived1 = new();
// BP, DP, DD
//derived1.Foo();
Some(derived1);

//GrandChild grandChild = new GrandChild();
//grandChild.Foo();

void Some(Base @base)
{
    @base.Show();  
}



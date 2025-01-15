// regular expressions
#region Classic way
// Classic variant for checking
//string password = "aallklkdaA";
//string mail = "nadir@google";
using System.Text.RegularExpressions;

List<bool> criteries = new List<bool>() { false, false, false};
//for (int i = 0; i < password.Length; i++)
//{
//    if (password[i] >= 'A' && password[i]<= 'Z')
//    {
//        criteries[0] = true;
//    }
//    if (password[i] >= 'a' && password[i] <= 'z')
//    {
//        criteries[1] = true;
//    }
//    if (password[i] >= '0' && password[i] <= '9')
//    {
//        criteries[2] = true;
//    }
//}
//if (password.Any(x=> x >= 'A' && x<= 'Z'))
//{
//    criteries[0] = true;
//}
//if (password.Any(x => x >= 'a' && x <= 'z'))
//{
//    criteries[1] = true;
//}
//if (password.Any(x => x >= '0' && x <= '9'))
//{
//    criteries[2] = true;
//}

//Console.WriteLine(criteries.All(x=> x== true));


#endregion

#region RegEx
// RegEx - Regular Expression
/*
 .          - istenilen 1 simvol
\w          - istenilen herf-reqem simvol
\W          - istenilen herf-reqem olmayan simvol
\s          - istenilen boshluq simvol
\S          - istenilen boshluq olmayan simvol
\d          - istenilen onluq reqem simvol
\D          - istenilen onluq reqem olmayan simvol
[symbols]   - moterize ichinde gosterilen simvollardan istenilen bir
[^symbols]  - moterize ichinde gosterilen simvollardan hech biri

*           - shablon 0 ve ya daha chox defe tekrarlanir
+           - shablon 1 ve ya daha chox defe tekrarlanir
?           - shablon 0 ve 1 defe tekrarlanir
{n, m}      - shablon n defeden az ve m defeden chox olmayaraq tekrarlanir
{n,}        - shablon n defeden az olmayaraq tekrarlanir
{n}         - shablon n defe tekrarlanir
^           - shablon metnin evvelinde olmalidir
$           - shablon metnin sonunda olmalidir
 
 */

//string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
//string password = "quertyQ1234";
//Regex regex = new Regex(passwordPattern);
//Console.WriteLine(regex.IsMatch(password));
//Regex mailPattern = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
//Console.WriteLine(mailPattern.IsMatch("Salam@salam.com"));
#endregion

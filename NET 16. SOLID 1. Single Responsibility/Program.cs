using System.Text.RegularExpressions;
#region Single Responsibility Principle - Bad example
//class SendMail
//{
//    public bool Send(string mailAddress, string message)
//    {
//        if (IsMailAddressValid(mailAddress))
//        {
//            return true;
//        }
//        return false;
//    }

//    private bool IsMailAddressValid(string mailAddress)
//    {
//        Regex mailPattern = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
//        return mailPattern.IsMatch(mailAddress);
//    }
//}
#endregion

#region Single Responsibility Principle - Good example
class MailAddressValidation
{
    public bool IsMailAddressValid(string mailAddress)
    {
        Regex mailPattern = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        return mailPattern.IsMatch(mailAddress);
    }
}

class SendMail
{
    private MailAddressValidation _validation = new();
    public bool Send(string mailAddress, string message)
    {
        if (_validation.IsMailAddressValid(mailAddress))
        {
            return true;
        }
        return false;
    }
}
#endregion

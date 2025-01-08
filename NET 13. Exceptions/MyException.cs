using System.Runtime.Serialization;

namespace NET_12._Exceptions;
/*
 * vacib olmayan qaydalar:
    İstifadəçi tərəfindən yaradılan bütün exception-lar ApplicationException-dan törəməlidir
 
 * vacib qaydalar:
    Exception üçün [Serializable] atributu tətbiq edilməlidir
    Exception-un default constructor-u olmalıdır
    Message property-ni təyin etmək üçün overload olunmuş constructor olmalıdır
    Inner exception-ları handle etmək üçün overload olunmuş constructor olmalıdır
    Tipi serializasiya etmək üçün overload olunmuş constructor olmalıdır
 
 
 */

[Serializable]
internal class MyException: ApplicationException
{
    public MyException(){}
    public MyException(string message): base(message){}
    public MyException(string message, Exception inner): base(message, inner){}
    protected MyException(SerializationInfo info, StreamingContext context)
        :base(info, context) { }
}

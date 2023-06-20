//means that each class or interface should be concercn with only one thing should have just one responsability

interface Iuser
{
    bool Login(string username, string password);
    bool Register(string username, string password, string email);
}

interface Iloger
{
    void Error(string message);
}

interface Iemail
{
    bool SendEmail(string emailContent);
}
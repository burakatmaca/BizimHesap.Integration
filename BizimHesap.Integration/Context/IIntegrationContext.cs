namespace BizimHesap.Integration
{
    public interface IIntegrationContext
    {
        string Host { get; }
        string Key { get; }
        string Token { get; }
    }
}

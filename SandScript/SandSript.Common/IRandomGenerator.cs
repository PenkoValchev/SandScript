namespace SandSript.Data.Common
{
    public interface IRandomGenerator
    {
        int GetRandomNumber(int min, int max);

        string GetRandomString(int len);

        string GetRandomStrigWithRandomLen(int min, int max);
    }
}

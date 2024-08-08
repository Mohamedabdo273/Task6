
namespace Generic
{
    internal class ClsCalculator
    {
        internal static bool AreEqual<T>(T v1, T v2)
        {
            if(v1.Equals(v2))
            {
                return true;
            }
            else return false;
        }
       
    }
}
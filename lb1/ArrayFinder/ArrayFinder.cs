namespace lb1.ArrayFinder;

public class ArrayFinder
{
    public static int[] LibFind(int[] arr, Func<int, bool> callback)
    {
        return arr.Where(callback).ToArray();
    }

    public static int[] OwnFind(int[] arr, Func<int, bool> callback)
    {
        int[] result = new int[arr.Length];
        int currentIdx = 0;

        foreach (var n in arr)
        {
            if (callback(n))
            {
                result[currentIdx] = n;
                currentIdx++;
            }
        }
        
        Array.Resize(ref result, currentIdx);

        return result;
    }
    
    public static Dictionary<string, int[]> BothApproachesFind(int[] arr, Func<int, bool> callback)
    {
        return new Dictionary<string, int[]>
        {
            {"Lib", LibFind(arr, callback)},
            {"Own", OwnFind(arr, callback)}
        };
    }
}
using System.Globalization;

namespace Tyuiu.CherkashinMM.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] nums1, int[] nums2)
        {
            int[] res = new int[5];
            for (int i = 0; i < nums1.Length; i++)
            {
                res[i] = nums1[i]+nums2[i];
            }
            return res;
        }
    }
}
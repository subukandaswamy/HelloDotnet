namespace CSharpPratice
{
    class MergeSort
    {
        public static List<int> merge(List<int> arr1, List<int> arr2)
        {
            List<int> res = new List<int>();
            if (arr1.Count == 0)
            {
                return arr2;
            }
            else if (arr2.Count == 0)
            {
                return arr1;
            }
            else if (arr1[0] > arr2[0])
            {
                res.Add(arr1[0]);
                arr1.RemoveAt(0);
            }
            else
            {
                res.Add(arr2[0]);
                arr2.RemoveAt(0);
            }
            res.AddRange(merge(arr1, arr2));
            return res;
        }
        public static List<int> sort(List<int> nums)
        {
            int pivot = nums.Count / 2;
            if (pivot == 0)
            {
                return nums;
            }
            else
            {
                return merge(
                    sort(nums.GetRange(0, pivot)),
                    sort(nums.GetRange(pivot, nums.Count - pivot))
                );
            }
        }

    }

    class MainClass
    {

        static void Main(string[] args)
        {
            int[] arr1 = { 11, 6, 2, 9, 7, 5 };
            //int[] arr2 = { 9, 7, 5 };
            List<int> list1 = new List<int>(arr1);
            //List<int> list2 = new List<int>(arr2);
            List<int> res = MergeSort.sort(list1);
            foreach (int r in res)
            {
                Console.WriteLine(r);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTen
{
    class WeekTenChallenge
    {
        public static void TestChallenge()
        {
            string s = "abcd";
            string t = "abcde";
            Console.WriteLine(@"string s = ""abcd"";, string t = ""abcde"";");
            Console.WriteLine(FindRandomChar(s, t).ToString());

            s = "aaaaaaa";
            t = "aaaaaaaa";

            Console.WriteLine(@"string s = ""aaaaaaa"";, string t = ""aaaaaaaa"";");
            Console.WriteLine(FindRandomChar(s, t).ToString());

            s = "tttuuup";
            t = "tttuuu";

            Console.WriteLine(@"string s = ""tttuuup"";, string t = ""tttuuu"";");
            Console.WriteLine(FindRandomChar(s, t).ToString());

            s = "zz99ii";
            t = "zz99i";

            Console.WriteLine(@"string s = ""zz99ii"";, string t = ""zz99i"";");
            Console.WriteLine(FindRandomChar(s, t).ToString());

            s = "99881";
            t = "998812";

            Console.WriteLine(@"string s = ""99881"";, string t = ""998812"";");
            Console.WriteLine(FindRandomChar(s, t).ToString());


            Console.WriteLine("Merge: ");
            // Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };

            Merge(nums1, nums2, 3, 3);
            Console.WriteLine(string.Join(", ", nums1));

            int[] nums3 = { 1 };
            int[] nums4 = {};

            Merge(nums3, nums4, 1, 0);
            Console.WriteLine(string.Join(", ", nums3));

            int[] nums5 = { 0 };
            int[] nums6 = { 1 };

            Merge(nums5, nums6, 0, 1);
            Console.WriteLine(string.Join(", ", nums5));

            int[] nums7 = { 1, 100, 101, 0, 0, 0 };
            int[] nums8 = { 7, 9, 102 };

            Merge(nums7, nums8, 3, 3);
            Console.WriteLine(string.Join(", ", nums7));

        }

        // use binary math to remove duplicates
        public static char FindRandomChar(string s, string t)
        {
            string st = s + t;
            char n = st[0];

            for(int i = 1; i < st.Length; i++)
            {
                n ^= st[i];
            }

            return n;
        }
        public static void Swap(ref int n, ref int m)
        {
            // tuple used to swap values... didn't know that was a thing
            // intelliscense suggestion
            (m, n) = (n, m);
        }

        // one-time insertion sort
        public static void OneInsertionSort(int[] nums2)
        {
            // do insertion sort for the first elemenent
            int index = 1;
            int elementToInsert = nums2[0];
            while (index < nums2.Length && elementToInsert > nums2[index])
            {
                nums2[index - 1] = nums2[index];
                index++;

            }
            nums2[index-1] = elementToInsert;
        }
        public static void Merge(int[] nums1, int[] nums2, int m, int n)
        {
            // swap nums1/nums2 values so nums1 has the lowest of the two
            // do insertion sort on nums2 
            if(nums2.Length == 0) { return; }

            for(int i = 0; i < m; i++)
            {
                if (nums1[i] > nums2[0])
                {
                    Swap(ref nums1[i], ref nums2[0]);
                    OneInsertionSort(nums2);
                } 
            }

            for(int i = m, j = 0; i < m+n && j < n; i++, j++)
            {
                nums1[i] = nums2[j];
            }
        }
    }
}

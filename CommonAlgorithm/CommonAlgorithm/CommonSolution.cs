using System;
using System.Collections.Generic;
using System.Text;

namespace CommonAlgorithm
{
    public class CommonSolution
    {
        #region 242
        /// <summary>
        /// 242. 有效的字母异位词
        /// 用字典，s存在一个就加1，然后t存在就减1，最后看这个字典的value是不是全为0
        /// 可以利用两个长度都为26的字符数组来统计每个字符串中小写字母出现的次数，然后再对比是否相等；
        /// 可以只利用一个长度为26的字符数组，将出现在字符串s里的字符个数加1，
        /// 而出现在字符串 t 里的字符个数减 1，最后判断每个小写字母的个数是否都为 0
        /// Ex:"anagram", "nagaram"
        /// "ab", "a"
        /// "aacc", "ccac"
        /// </summary>
        public bool IsAnagram(string s, string t)
        {
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            Dictionary<char, int> checkDic = new Dictionary<char, int>();
            foreach (var item in sArray)
            {
                if (checkDic.ContainsKey(item))
                {
                    checkDic[item]++;
                }
                else
                {
                    checkDic.Add(item, 1);
                }
            }
            foreach (var item in tArray)
            {
                if (checkDic.ContainsKey(item))
                {
                    checkDic[item]--;
                }
                else
                {
                    checkDic.Add(item, 1);
                }
            }
            foreach (var o in checkDic.Values)
            {
                if (o != 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 25 K 个一组翻转链表

        //public ListNode ReverseKGroup(ListNode head, int k)
        //{
            


        //}

        #endregion

        #region 20 有效的括号
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else if (c == '}')
                {
                    //pop出来后指针指向stack的最后一个元素
                    if (stack.Count == 0)
                        return false;

                    if (stack.Pop() != '{')
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    if (stack.Pop() != '[')
                        return false;
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                        return false;

                    if (stack.Pop() != '(')
                        return false;
                }
            }

            return stack.Count == 0;

        }


        #endregion

        #region 739 每日温度
        //public int[] DailyTemperatures(int[] T)
        //{

        //}

        #endregion

        #region 239 滑动窗口最大值
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            //O(n^2)的做法就是扫描比较
            //双端队列
            throw new Exception();
        }


        #endregion

        #region 230 二叉搜索树中第K小的元素

        /// <summary>
        /// root = [3,1,4,null,2], k = 1  输出1
        /// root = [5,3,6,2,4,null,null,1], k = 3 输出3
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int KthSmallest(TreeNode root, int k)
        {
            throw new Exception();
        }


        #endregion

        #region 347 前 K 个高频元素

        ///题目中有”前 k个“这样的字眼，应该很自然地联想到优先队列
        ///统计词频的最佳数据结构就是哈希表（Hash Map），利用一个哈希表，就能快速地知道每个单词出现的次数。
        ///知道词频后构建优先队列
        public IList<int> TopKFrequent(int[] nums, int k)
        {



            throw new Exception();
        }
        #endregion


        #region 785 判断二分图

        /// <summary>
        /// 
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public bool IsBipartite(int[][] graph)
        {
            throw new Exception();
        }

        #endregion

        #region 212 单词搜索 II

        public IList<string> FindWords(char[][] board, string[] words)
        {
            throw new Exception();
        }

        #endregion

        #region 315 计算右侧小于当前元素的个数

        /// <summary>
        /// 线段树
        /// 示例输入：[5,2,6,1]输出：[2,1,1,0]
        /// 解释5的右侧有2个更小的元素（2和1）
        /// 2的右侧仅有1个更小的元素（1）
        /// 6 的右侧有 1 个更小的元素（1）
        /// 1 的右侧有 0 个更小的元素
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> CountSmaller(int[] nums)
        {
            throw new Exception();
        }

        #endregion
    }

}

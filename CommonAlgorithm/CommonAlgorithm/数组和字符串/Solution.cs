using System;
using System.Collections.Generic;
using System.Text;

namespace CommonAlgorithm
{
    public class Solution
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
        public int[] DailyTemperatures(int[] T)
        {

        }

        #endregion
    }

}

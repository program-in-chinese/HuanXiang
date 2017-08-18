using System;
using System.Collections.Generic;
using System.Text;

namespace Cjing.Net
{
    public partial class 文本型
    {
        public override bool Equals(object obj) { return base.Equals(obj); }
        public override int GetHashCode() { return base.GetHashCode(); }
        public static bool operator ==(文本型 自己, 文本型 目标) { return 自己.变量值.Equals(目标.变量值); }
        public static bool operator !=(文本型 自己, 文本型 目标) { return 自己.变量值 != 目标.变量值; }
        public static bool operator >=(文本型 自己, 文本型 目标) { return 自己.变量值.CompareTo(目标.变量值) >= 0; }
        public static bool operator <=(文本型 自己, 文本型 目标) { return 自己.变量值.CompareTo(目标.变量值) <= 0; }
        public static bool operator >(文本型 自己, 文本型 目标) { return 自己.变量值.CompareTo(目标.变量值) > 0; }
        public static bool operator <(文本型 自己, 文本型 目标) { return 自己.变量值.CompareTo(目标.变量值) < 0; }

        public static bool operator ==(文本型 自己, string 目标) { return 自己.变量值.Equals(目标); }
        public static bool operator !=(文本型 自己, string 目标) { return 自己.变量值 != 目标; }
        public static bool operator >=(文本型 自己, string 目标) { return 自己.变量值.CompareTo(目标) >= 0; }
        public static bool operator <=(文本型 自己, string 目标) { return 自己.变量值.CompareTo(目标) <= 0; }
        public static bool operator >(文本型 自己, string 目标) { return 自己.变量值.CompareTo(目标) > 0; }
        public static bool operator <(文本型 自己, string 目标) { return 自己.变量值.CompareTo(目标) < 0; }

        public static 文本型 operator +(文本型 自己, 文本型 目标) { return new 文本型(自己.变量值 + 目标.变量值); }

        public static 文本型 operator +(文本型 自己, string 目标) { return new 文本型(自己.变量值 + 目标); }
    }
    public partial class 文本型
    {
        string 变量值 = 常量.空值;
        public bool 为空 { get => 变量值 == 常量.空值; }
        public bool 非空 { get => 变量值 != 常量.空值; }
        public string 内容 { get => 变量值; set => 变量值 = value; }
        public int 到整数 { get => int.Parse(变量值); }
        public decimal 到小数 { get => Convert.ToDecimal(变量值); }
        public 文本型(string 默认值 = 常量.空值) { 变量值 = 默认值; }
        public static 文本型 新建(string 默认值) { return new 文本型(默认值); }
        public static 文本型 新建(int 默认值) { return new 文本型(默认值.ToString()); }
        public static 文本型 新建(decimal 默认值) { return new 文本型(默认值.ToString()); }
        public void 赋值(int 新的值) { 变量值 = 新的值.ToString(); }
        public void 赋值(decimal 新的值) { 变量值 = 新的值.ToString(); }
        /// <summary>
        /// 用 CompareTo 比较文本型大小
        /// </summary>
        /// <param name="比较值">要比较大小的字符串</param>
        /// <returns>-1 小于 0 等于 1 大于</returns>
        public int 比较(文本型 比较值) { return 变量值.CompareTo(比较值.变量值); }
        /// <summary>
        /// 用 CompareTo 比较文本型大小
        /// </summary>
        /// <param name="比较值">要比较大小的字符串</param>
        /// <returns>-1 小于 0 等于 1 大于</returns>
        public int 比较(string 比较值) { return 变量值.CompareTo(比较值); }
        public 文本型 取左边(int 获取长度) { return new 文本型(变量值.Substring(0, 获取长度)); }
        public 文本型 取中间(int 开始位置, int 获取长度) { return new 文本型(变量值.Substring(开始位置, 获取长度)); }
        public 文本型 取右边(int 获取长度) { return new 文本型(变量值.Substring(变量值.Length - 获取长度)); }
    }
}

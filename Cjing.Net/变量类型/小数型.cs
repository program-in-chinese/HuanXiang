using System;
using System.Collections.Generic;
using System.Text;

namespace Cjing.Net
{
    public partial class 小数型
    {
        public override bool Equals(object obj) { return base.Equals(obj); }
        public override int GetHashCode() { return base.GetHashCode(); }
        public static bool operator ==(小数型 自己, 小数型 目标) { return 自己.变量值 == 目标.变量值; }
        public static bool operator !=(小数型 自己, 小数型 目标) { return 自己.变量值 != 目标.变量值; }
        public static bool operator >=(小数型 自己, 小数型 目标) { return 自己.变量值 >= 目标.变量值; }
        public static bool operator <=(小数型 自己, 小数型 目标) { return 自己.变量值 <= 目标.变量值; }
        public static bool operator >(小数型 自己, 小数型 目标) { return 自己.变量值 > 目标.变量值; }
        public static bool operator <(小数型 自己, 小数型 目标) { return 自己.变量值 < 目标.变量值; }

        public static bool operator ==(小数型 自己, decimal 目标) { return 自己.变量值 == 目标; }
        public static bool operator !=(小数型 自己, decimal 目标) { return 自己.变量值 != 目标; }
        public static bool operator >=(小数型 自己, decimal 目标) { return 自己.变量值 >= 目标; }
        public static bool operator <=(小数型 自己, decimal 目标) { return 自己.变量值 <= 目标; }
        public static bool operator >(小数型 自己, decimal 目标) { return 自己.变量值 > 目标; }
        public static bool operator <(小数型 自己, decimal 目标) { return 自己.变量值 < 目标; }

        public static 小数型 operator +(小数型 自己, 小数型 目标) { return new 小数型(自己.变量值 + 目标.变量值); }
        public static 小数型 operator -(小数型 自己, 小数型 目标) { return new 小数型(自己.变量值 - 目标.变量值); }
        public static 小数型 operator *(小数型 自己, 小数型 目标) { return new 小数型(自己.变量值 * 目标.变量值); }
        public static 小数型 operator /(小数型 自己, 小数型 目标) { return new 小数型(自己.变量值 / 目标.变量值); }
        public static 小数型 operator %(小数型 自己, 小数型 目标) { return new 小数型(自己.变量值 % 目标.变量值); }

        public static 小数型 operator +(小数型 自己, decimal 目标) { return new 小数型(自己.变量值 + 目标); }
        public static 小数型 operator -(小数型 自己, decimal 目标) { return new 小数型(自己.变量值 - 目标); }
        public static 小数型 operator *(小数型 自己, decimal 目标) { return new 小数型(自己.变量值 * 目标); }
        public static 小数型 operator /(小数型 自己, decimal 目标) { return new 小数型(自己.变量值 / 目标); }
        public static 小数型 operator %(小数型 自己, decimal 目标) { return new 小数型(自己.变量值 % 目标); }

        public static 小数型 operator ++(小数型 自己) { 自己.变量值++; return 自己; }
        public static 小数型 operator --(小数型 自己) { 自己.变量值++; return 自己; }

    }
    public partial class 小数型
    {
        decimal 变量值 = 常量.零值;
        public bool 为零 { get => 变量值 == 常量.零值; }
        public bool 非零 { get => 变量值 != 常量.零值; }
        public decimal 内容 { get => 变量值; set => 变量值 = value; }
        public string 到文本 { get => 变量值.ToString(); }
        public int 到整数 { get => Convert.ToInt32(变量值); }
        public 小数型(decimal 默认值 = 常量.零值) { 变量值 = 默认值; }
        public static 小数型 新建(string 默认值) { return new 小数型(Convert.ToDecimal(默认值)); }
        public static 小数型 新建(int 默认值) { return new 小数型(默认值); }
        public static 小数型 新建(decimal 默认值) { return new 小数型(默认值); }
        public static 小数型 新建(float 默认值) { return new 小数型(Convert.ToDecimal(默认值)); }
        public static 小数型 新建(double 默认值) { return new 小数型(Convert.ToDecimal(默认值)); }
        public void 赋值(string 新的值) { 变量值 = Convert.ToDecimal(新的值); }
        public void 赋值(int 新的值) { 变量值 = 新的值; }
        public string 四舍五入(int 保留小数 = 0)
        {
            return Math.Round(变量值,保留小数, MidpointRounding.AwayFromZero).ToString();
        }
    }
}

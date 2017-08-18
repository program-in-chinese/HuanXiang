using System;
using System.Collections.Generic;
using System.Text;

namespace Cjing.Net
{
    public partial class 整数型
    {
        public override bool Equals(object obj) { return base.Equals(obj); }
        public override int GetHashCode() { return base.GetHashCode(); }
        public static bool operator ==(整数型 自己, 整数型 目标) { return 自己.变量值 == 目标.变量值; }
        public static bool operator !=(整数型 自己, 整数型 目标) { return 自己.变量值 != 目标.变量值; }
        public static bool operator >=(整数型 自己, 整数型 目标) { return 自己.变量值 >= 目标.变量值; }
        public static bool operator <=(整数型 自己, 整数型 目标) { return 自己.变量值 <= 目标.变量值; }
        public static bool operator >(整数型 自己, 整数型 目标) { return 自己.变量值 > 目标.变量值; }
        public static bool operator <(整数型 自己, 整数型 目标) { return 自己.变量值 < 目标.变量值; }

        public static bool operator ==(整数型 自己, int 目标) { return 自己.变量值 == 目标; }
        public static bool operator !=(整数型 自己, int 目标) { return 自己.变量值 != 目标; }
        public static bool operator >=(整数型 自己, int 目标) { return 自己.变量值 >= 目标; }
        public static bool operator <=(整数型 自己, int 目标) { return 自己.变量值 <= 目标; }
        public static bool operator >(整数型 自己, int 目标) { return 自己.变量值 > 目标; }
        public static bool operator <(整数型 自己, int 目标) { return 自己.变量值 < 目标; }

        public static 整数型 operator +(整数型 自己, 整数型 目标) { return new 整数型(自己.变量值 + 目标.变量值); }
        public static 整数型 operator -(整数型 自己, 整数型 目标) { return new 整数型(自己.变量值 - 目标.变量值); }
        public static 整数型 operator *(整数型 自己, 整数型 目标) { return new 整数型(自己.变量值 * 目标.变量值); }
        public static 整数型 operator /(整数型 自己, 整数型 目标) { return new 整数型(自己.变量值 / 目标.变量值); }
        public static 整数型 operator %(整数型 自己, 整数型 目标) { return new 整数型(自己.变量值 % 目标.变量值); }

        public static 整数型 operator +(整数型 自己, int 目标) { return new 整数型(自己.变量值 + 目标); }
        public static 整数型 operator -(整数型 自己, int 目标) { return new 整数型(自己.变量值 - 目标); }
        public static 整数型 operator *(整数型 自己, int 目标) { return new 整数型(自己.变量值 * 目标); }
        public static 整数型 operator /(整数型 自己, int 目标) { return new 整数型(自己.变量值 / 目标); }
        public static 整数型 operator %(整数型 自己, int 目标) { return new 整数型(自己.变量值 % 目标); }

        public static 整数型 operator +(整数型 自己, decimal 目标) { return new 整数型(自己.变量值 + Convert.ToInt32(目标)); }
        public static 整数型 operator -(整数型 自己, decimal 目标) { return new 整数型(自己.变量值 - Convert.ToInt32(目标)); }
        public static 整数型 operator *(整数型 自己, decimal 目标) { return new 整数型(自己.变量值 * Convert.ToInt32(目标)); }
        public static 整数型 operator /(整数型 自己, decimal 目标) { return new 整数型(自己.变量值 / Convert.ToInt32(目标)); }
        public static 整数型 operator %(整数型 自己, decimal 目标) { return new 整数型(自己.变量值 % Convert.ToInt32(目标)); }

        public static 整数型 operator ++(整数型 自己) { 自己.变量值++; return 自己; }
        public static 整数型 operator --(整数型 自己) { 自己.变量值++; return 自己; }
    }
    public partial class 整数型
    {
        int 变量值 = 常量.零值;
        public bool 为零 { get => 变量值 == 常量.零值; }
        public bool 非零 { get => 变量值 != 常量.零值; }
        public int 内容 { get => 变量值; set => 变量值 = value; }
        public string 到文本 { get => 变量值.ToString(); }
        public decimal 到小数 { get => Convert.ToDecimal(变量值); }
        public 整数型(int 默认值 = 常量.零值) { 变量值 = 默认值; }
        public static 整数型 新建(string 默认值) { return new 整数型(Convert.ToInt32(默认值)); }
        public static 整数型 新建(int 默认值) { return new 整数型(默认值); }
        public static 整数型 新建(decimal 默认值) { return new 整数型(Convert.ToInt32(默认值)); }
        public void 赋值(string 新的值) { 变量值 = Convert.ToInt32(新的值); }
        public void 赋值(decimal 新的值) { 变量值 = Convert.ToInt32(新的值); }
    }
}

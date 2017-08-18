using System;
using System.Collections.Generic;
using System.Text;

namespace Cjing.Net
{
    public class 逻辑型
    {
        bool 变量值 = 常量.假;
        public bool 为真 { get => 变量值 == 常量.真; }
        public bool 为假 { get => 变量值 == 常量.假; }
        public bool 内容 { get => 变量值; set => 变量值 = value; }
        public string 到文本 { get => 变量值 == 常量.真 ? "真" : "假"; }
        /// <summary>
        /// 真时返回 1 ,假时返回 0
        /// </summary>
        public int 到整数 { get => 变量值 == 常量.真 ? 1 : 0; }
        public 逻辑型(bool 默认值 = 常量.假) { 变量值 = 默认值; }
        public 逻辑型(string 默认值) { 赋值(默认值); }
        public static 逻辑型 新建(bool 默认值 = 常量.假) { return new 逻辑型(默认值); }
        public static 逻辑型 新建(string 默认值) { return new 逻辑型(默认值); }
        public void 赋值(string 新的值) { 变量值 = 新的值 == "真" || 新的值 == "true" ? 常量.真 : 常量.假; }
        public override bool Equals(object obj) { return base.Equals(obj); }
        public override int GetHashCode() { return base.GetHashCode(); }
        public static bool operator ==(逻辑型 自己, 逻辑型 目标) { return 自己.变量值 == 目标.变量值; }
        public static bool operator !=(逻辑型 自己, 逻辑型 目标) { return 自己.变量值 != 目标.变量值; }
        public static bool operator ==(逻辑型 自己, bool 目标) { return 自己.变量值 == 目标; }
        public static bool operator !=(逻辑型 自己, bool 目标) { return 自己.变量值 != 目标; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.POCOModel
{
      
    using System;
    using System.Collections.Generic;
    
    public partial class POCO_WIND_WARN_STANDARD
    {
        public decimal 报警ID { get; set; }
        public string 报警条件 { get; set; }
        public string 报警内容 { get; set; }
        public Nullable<decimal> 报警风速低速 { get; set; }
        public Nullable<decimal> 报警风速高速 { get; set; }
        public string 报警颜色 { get; set; }
    }
}
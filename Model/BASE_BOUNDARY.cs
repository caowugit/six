//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BASE_BOUNDARY
    {
        public string BOUNDARY_ID { get; set; }
        public Nullable<decimal> MILE_START { get; set; }
        public Nullable<decimal> MILE_END { get; set; }
        public string SMALL_DEPT_CODE { get; set; }
        public string BIG_DEPT_CODE { get; set; }
    
        public virtual SYS_DEPT SYS_DEPT { get; set; }
        public virtual SYS_DEPT SYS_DEPT1 { get; set; }
    }
}
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
    
    public partial class RULE_PROBLEM_BLAME
    {
        public string PKID { get; set; }
        public string PROBLEM_PKID { get; set; }
        public string GWD_CODE { get; set; }
        public string DEPT_CODE { get; set; }
        public string CJ_CODE { get; set; }
        public string GQ_CODE { get; set; }
        public string MEMO { get; set; }
    
        public virtual RULE_PROBLEM RULE_PROBLEM { get; set; }
        public virtual SYS_DEPT SYS_DEPT { get; set; }
        public virtual SYS_DEPT SYS_DEPT1 { get; set; }
        public virtual SYS_DEPT SYS_DEPT2 { get; set; }
        public virtual SYS_DEPT SYS_DEPT3 { get; set; }
    }
}
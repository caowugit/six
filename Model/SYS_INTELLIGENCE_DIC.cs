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
    
    public partial class SYS_INTELLIGENCE_DIC
    {
        public SYS_INTELLIGENCE_DIC()
        {
            this.SYS_MEMBER = new HashSet<SYS_MEMBER>();
        }
    
        public string DIC_ID { get; set; }
        public string DIC_NAME { get; set; }
        public string DIC_ICON { get; set; }
        public Nullable<decimal> DIC_ORDER { get; set; }
        public string DEPT_CODE { get; set; }
        public string DIC_MEMO { get; set; }
        public string NOTE1 { get; set; }
        public string NOTE2 { get; set; }
    
        public virtual ICollection<SYS_MEMBER> SYS_MEMBER { get; set; }
    }
}

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
    
    public partial class GATE_GATEMNG_LONGDISHISTORY
    {
        public string AUTHHISTORY_ID { get; set; }
        public string GATE_NO { get; set; }
        public string AUTHOPT_USER { get; set; }
        public Nullable<System.DateTime> AUTHOPT_TIME { get; set; }
        public string AUTHOPT_RESULT { get; set; }
        public string COMMAND_NO { get; set; }
        public string OPEN_REASON { get; set; }
    
        public virtual GATE_BDATA_GATE GATE_BDATA_GATE { get; set; }
    }
}
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
    
    public partial class POCO_RAIN_PLAN
    {
        public string PKID { get; set; }
        public string RAIN_NAME { get; set; }
        public string RAIN_CODE { get; set; }
        public string LINE_NAME { get; set; }
        public string DEPT_NAME { get; set; }
        public string DEPT_CODE { get; set; }
        public Nullable<decimal> MILEAGE_BEGIN { get; set; }
        public Nullable<decimal> MILEAGE_END { get; set; }
        public string PHONE { get; set; }
        public string DIRECTION { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string ERRORINFO { get; set; }
        public Nullable<decimal> MILEAGE_BEGIN_PATROL { get; set; }
        public Nullable<decimal> MILEAGE_END_PATROL { get; set; }
    }
}

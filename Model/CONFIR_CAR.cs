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
    
    public partial class CONFIR_CAR
    {
        public string PKID { get; set; }
        public string TRAIN_NUM { get; set; }
        public string DEPARTURE_STARTTIME { get; set; }
        public string LINE_NAME { get; set; }
        public string DIRECTION { get; set; }
        public string PLAN_SECTION { get; set; }
        public string STATION_START { get; set; }
        public string CHANNEL_START { get; set; }
        public string STATION_END { get; set; }
        public string CHANNEL_END { get; set; }
        public string DEPARTURE_ENDTIME { get; set; }
        public string DEPT_CJNAME { get; set; }
        public string CONTENT { get; set; }
        public Nullable<decimal> MARS_LONGITUDE { get; set; }
        public Nullable<decimal> MARS_LATITUDE { get; set; }
        public string DEPT_CODE { get; set; }
        public Nullable<long> TRIP_TIME { get; set; }
    }
}
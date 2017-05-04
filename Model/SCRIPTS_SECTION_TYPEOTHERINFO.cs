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
    
    public partial class SCRIPTS_SECTION_TYPEOTHERINFO
    {
        public SCRIPTS_SECTION_TYPEOTHERINFO()
        {
            this.SCRIPTS_SECTION_LINE = new HashSet<SCRIPTS_SECTION_LINE>();
            this.SCRIPTS_SECTION_OTHER_PHOTO = new HashSet<SCRIPTS_SECTION_OTHER_PHOTO>();
        }
    
        public string INFO_ID { get; set; }
        public string TYPE_ID { get; set; }
        public string LINE_NAME { get; set; }
        public string LINE_DIR { get; set; }
        public Nullable<decimal> MILEAGE_CENTER { get; set; }
        public Nullable<decimal> MILEAGE_BEGIN { get; set; }
        public Nullable<decimal> MILEAGE_END { get; set; }
        public Nullable<decimal> MARSLONGITUDE { get; set; }
        public Nullable<decimal> MARSLATITUDE { get; set; }
        public string INFO_NOTE { get; set; }
        public string DEPT_CODE { get; set; }
        public string DEPT_NAME { get; set; }
        public string DOOR_NUM { get; set; }
        public string DOOR_NUM_UP { get; set; }
        public string DOOR_NUM_DOWN { get; set; }
        public string DOOR_GLDEPT { get; set; }
        public string DOOR_GLDEPT_PHONE { get; set; }
        public string DOOR_POLICE { get; set; }
        public string DOOR_POLICE_PHONE { get; set; }
        public string SPEED_LINE { get; set; }
        public string SPEED_LIMIT { get; set; }
        public string SPEED_CAUSE { get; set; }
        public string A_NUM { get; set; }
        public string A_NAME { get; set; }
        public string A_ADDR { get; set; }
        public string A_WAREA { get; set; }
        public string A_SAFE { get; set; }
        public string A_BETWEEN { get; set; }
        public string A_MILE { get; set; }
        public string A_DIS { get; set; }
        public string A_DISAREA { get; set; }
        public string A_BRIABLE { get; set; }
        public string A_STAD { get; set; }
        public string A_WATERLD { get; set; }
        public string A_CAPD { get; set; }
        public string A_DISCHARGED { get; set; }
        public string A_STAC { get; set; }
        public string A_WATERLC { get; set; }
        public string A_CAPC { get; set; }
        public string A_DISCHARGEC { get; set; }
        public string A_FLOODW { get; set; }
        public string A_FLOODCAP { get; set; }
        public string A_TYPE { get; set; }
        public string A_DAMH { get; set; }
        public string A_WALLH { get; set; }
        public string A_DAMAXH { get; set; }
        public string A_DAML { get; set; }
        public string A_YANH { get; set; }
        public string A_GATETYPE { get; set; }
        public string A_DISCHARM { get; set; }
        public string A_INH { get; set; }
        public string A_RADIUS { get; set; }
        public string A_DISCHARMO { get; set; }
        public string A_LEL { get; set; }
        public string A_MAN { get; set; }
        public string A_TEL { get; set; }
        public string A_PRO { get; set; }
        public string A_ISHEA { get; set; }
        public string A_PROTE { get; set; }
        public string A_CHECK { get; set; }
        public string A_LEAD { get; set; }
        public Nullable<System.DateTime> A_TIME { get; set; }
        public string A_MEMO { get; set; }
        public string A_LINENAME { get; set; }
        public string A_LINEDIR { get; set; }
    
        public virtual ICollection<SCRIPTS_SECTION_LINE> SCRIPTS_SECTION_LINE { get; set; }
        public virtual ICollection<SCRIPTS_SECTION_OTHER_PHOTO> SCRIPTS_SECTION_OTHER_PHOTO { get; set; }
        public virtual SCRIPTS_SECTION_TYPEOTHER SCRIPTS_SECTION_TYPEOTHER { get; set; }
    }
}
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
    
    public partial class VIDEO_BDATA_DEVICE
    {
        public VIDEO_BDATA_DEVICE()
        {
            this.VIDEO_FILE = new HashSet<VIDEO_FILE>();
        }
    
        public string 设备号 { get; set; }
        public string 设备名称 { get; set; }
        public string 线名 { get; set; }
        public string 行别 { get; set; }
        public Nullable<decimal> 里程 { get; set; }
        public Nullable<decimal> 火星经度 { get; set; }
        public Nullable<decimal> 火星纬度 { get; set; }
        public string DEPT_CODE { get; set; }
        public string 播放路径 { get; set; }
        public string 功能 { get; set; }
        public string 备注 { get; set; }
    
        public virtual SYS_DEPT SYS_DEPT { get; set; }
        public virtual ICollection<VIDEO_FILE> VIDEO_FILE { get; set; }
    }
}

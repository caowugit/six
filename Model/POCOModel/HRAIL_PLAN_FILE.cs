//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Model
{
	public partial class HRAIL_PLAN_FILE
	{
		public HRAIL_PLAN_FILE ToPOCO(bool isPOCO = true){
			return new HRAIL_PLAN_FILE(){
				FLOW_ID = this.FLOW_ID,
				PLAN_ID = this.PLAN_ID,
				FILE_ID = this.FILE_ID,
				FILE_CAT = this.FILE_CAT,
				FILE_NAME = this.FILE_NAME,
				FLAG = this.FLAG,
				CRT_USER = this.CRT_USER,
				CRT_TIME = this.CRT_TIME,
			};
		}
	} 
}

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
	public partial class HRAIL_PLAN_EMP
	{
		public HRAIL_PLAN_EMP ToPOCO(bool isPOCO = true){
			return new HRAIL_PLAN_EMP(){
				FLOW_ID = this.FLOW_ID,
				PLAN_ID = this.PLAN_ID,
				PLAN_EMP_ID = this.PLAN_EMP_ID,
				PLAN_DATE = this.PLAN_DATE,
				DEPT_CODE = this.DEPT_CODE,
				EMP_TOTAL = this.EMP_TOTAL,
				ATTENDANCE = this.ATTENDANCE,
				HOLIDAY = this.HOLIDAY,
				ON_RAILWAY = this.ON_RAILWAY,
				IN_STATION = this.IN_STATION,
				CHEF = this.CHEF,
				DRIVER = this.DRIVER,
				DOOR_GUARD = this.DOOR_GUARD,
				EMP_OTHER = this.EMP_OTHER,
				MEMO = this.MEMO,
			};
		}
	} 
}
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
	public partial class TASK_UNLOAD_STONE
	{
		public TASK_UNLOAD_STONE ToPOCO(bool isPOCO = true){
			return new TASK_UNLOAD_STONE(){
				PKID = this.PKID,
				DEPTID = this.DEPTID,
				IS_SUBMIT = this.IS_SUBMIT,
				CREATE_TIME = this.CREATE_TIME,
				CREATE_USER = this.CREATE_USER,
				GWD_CODE = this.GWD_CODE,
				DEPT_CODE = this.DEPT_CODE,
				GQ_CODE = this.GQ_CODE,
				YEAR = this.YEAR,
				MONTH = this.MONTH,
				DAILY = this.DAILY,
				ITEMNAME = this.ITEMNAME,
				FOUND_DATE = this.FOUND_DATE,
				SECTION = this.SECTION,
				REALLOCAL = this.REALLOCAL,
				FINISH_NUM = this.FINISH_NUM,
				GOTIME = this.GOTIME,
				REALTIME = this.REALTIME,
				BUSNUM = this.BUSNUM,
				DEPTNAME = this.DEPTNAME,
				FACTNAME = this.FACTNAME,
				FACT_MEMBER = this.FACT_MEMBER,
				MEMO = this.MEMO,
				REPLACE_FLAG = this.REPLACE_FLAG,
				REPLACE_DATE = this.REPLACE_DATE,
			};
		}
	} 
}
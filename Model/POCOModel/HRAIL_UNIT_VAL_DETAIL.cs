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
	public partial class HRAIL_UNIT_VAL_DETAIL
	{
		public HRAIL_UNIT_VAL_DETAIL ToPOCO(bool isPOCO = true){
			return new HRAIL_UNIT_VAL_DETAIL(){
				UNITVAL_ID = this.UNITVAL_ID,
				UNITVAL_DETAIL_ID = this.UNITVAL_DETAIL_ID,
				CHECK_TYPE = this.CHECK_TYPE,
				PROBLEM_ID = this.PROBLEM_ID,
				MEMO = this.MEMO,
			};
		}
	} 
}
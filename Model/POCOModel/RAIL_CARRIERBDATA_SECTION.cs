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
	public partial class RAIL_CARRIERBDATA_SECTION
	{
		public RAIL_CARRIERBDATA_SECTION ToPOCO(bool isPOCO = true){
			return new RAIL_CARRIERBDATA_SECTION(){
				SECTION_NAME = this.SECTION_NAME,
				DEPT_CODE = this.DEPT_CODE,
				START_MILE = this.START_MILE,
				END_MILE = this.END_MILE,
				SECTION_ID = this.SECTION_ID,
			};
		}
	} 
}

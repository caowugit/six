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
	public partial class RAIL_DEVICE_RECORD
	{
		public RAIL_DEVICE_RECORD ToPOCO(bool isPOCO = true){
			return new RAIL_DEVICE_RECORD(){
				PKID = this.PKID,
				SECTION = this.SECTION,
				LINE_NAME = this.LINE_NAME,
				LINE_DIR = this.LINE_DIR,
				MILE = this.MILE,
				LINE_POS = this.LINE_POS,
				TIME = this.TIME,
				STATUS = this.STATUS,
				DEPT_CODE = this.DEPT_CODE,
			};
		}
	} 
}

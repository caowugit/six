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
	public partial class SCRIPTS_SECTION_TYPECROSS
	{
		public SCRIPTS_SECTION_TYPECROSS ToPOCO(bool isPOCO = true){
			return new SCRIPTS_SECTION_TYPECROSS(){
				TYPECROSS_ID = this.TYPECROSS_ID,
				TYPECROSS_NAME = this.TYPECROSS_NAME,
				ICON = this.ICON,
				DEPT_CODE = this.DEPT_CODE,
				DEPT_NAME = this.DEPT_NAME,
				TYPECROSS_TYPE = this.TYPECROSS_TYPE,
				LINE_NAME = this.LINE_NAME,
				LINE_DIR = this.LINE_DIR,
				MILEAGE = this.MILEAGE,
				WIDTH = this.WIDTH,
				MARSLONGITUDE = this.MARSLONGITUDE,
				MARSLATITUDE = this.MARSLATITUDE,
				TYPECROSS_NOTE = this.TYPECROSS_NOTE,
			};
		}
	} 
}

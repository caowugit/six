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
	public partial class EMERGENCY_RESCUE
	{
		public EMERGENCY_RESCUE ToPOCO(bool isPOCO = true){
			return new EMERGENCY_RESCUE(){
				PKID = this.PKID,
				DEPT_CODE = this.DEPT_CODE,
				DEPT_NAME = this.DEPT_NAME,
				PERSON_NUM = this.PERSON_NUM,
				MANAGE = this.MANAGE,
				JOB = this.JOB,
				PHONE = this.PHONE,
				TRANSPORT = this.TRANSPORT,
				SECTION = this.SECTION,
				NOTES = this.NOTES,
				LINE_NAME = this.LINE_NAME,
				LINE_DIR = this.LINE_DIR,
				MILEAGE_CENTER = this.MILEAGE_CENTER,
				MARSLONGITUDE = this.MARSLONGITUDE,
				MARSLATITUDE = this.MARSLATITUDE,
				RESCUE_NAME = this.RESCUE_NAME,
			};
		}
	} 
}

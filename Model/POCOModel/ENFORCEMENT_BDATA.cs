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
	public partial class ENFORCEMENT_BDATA
	{
		public ENFORCEMENT_BDATA ToPOCO(bool isPOCO = true){
			return new ENFORCEMENT_BDATA(){
				PHONE = this.PHONE,
				VIDEO_PATH = this.VIDEO_PATH,
				COMMENTS = this.COMMENTS,
				DEPT_CODE = this.DEPT_CODE,
				PKID = this.PKID,
				NAME = this.NAME,
				DEVICE_CODE = this.DEVICE_CODE,
			};
		}
	} 
}
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
	public partial class HIK_PIC_INFO
	{
		public HIK_PIC_INFO ToPOCO(bool isPOCO = true){
			return new HIK_PIC_INFO(){
				PKID = this.PKID,
				CAMERA_ID = this.CAMERA_ID,
				CAMERA_NAME = this.CAMERA_NAME,
				SNAP_PIC_URL = this.SNAP_PIC_URL,
				DEVICE_CODE = this.DEVICE_CODE,
				DEVICE_NAME = this.DEVICE_NAME,
				ORIGINAL_CREATE_TIME = this.ORIGINAL_CREATE_TIME,
				NEW_PIC_URL = this.NEW_PIC_URL,
				CREATE_TIME = this.CREATE_TIME,
			};
		}
	} 
}
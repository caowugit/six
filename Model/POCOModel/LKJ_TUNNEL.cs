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
	public partial class LKJ_TUNNEL
	{
		public LKJ_TUNNEL ToPOCO(bool isPOCO = true){
			return new LKJ_TUNNEL(){
				PKID = this.PKID,
				BUREAU_NAME = this.BUREAU_NAME,
				BUREAU_NUM = this.BUREAU_NUM,
				LINE_NAME = this.LINE_NAME,
				LINE_NUM = this.LINE_NUM,
				LINE_DIR = this.LINE_DIR,
				TUNNEL_NUM = this.TUNNEL_NUM,
				TUNNEL_NAME = this.TUNNEL_NAME,
				CENTER_MILEAGE = this.CENTER_MILEAGE,
				TUNNEL_LENGTH = this.TUNNEL_LENGTH,
				AUXILIARY_LINE_NAME = this.AUXILIARY_LINE_NAME,
				AUXILIARY_LINE_NUM = this.AUXILIARY_LINE_NUM,
				MODIFY_TAG = this.MODIFY_TAG,
				CREATE_TIME = this.CREATE_TIME,
				USER_NAME = this.USER_NAME,
				DEPT_CODE = this.DEPT_CODE,
			};
		}
	} 
}
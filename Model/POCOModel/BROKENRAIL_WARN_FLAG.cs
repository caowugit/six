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
	public partial class BROKENRAIL_WARN_FLAG
	{
		public BROKENRAIL_WARN_FLAG ToPOCO(bool isPOCO = true){
			return new BROKENRAIL_WARN_FLAG(){
				SECTION_ID = this.SECTION_ID,
				NOTICE_FLAG = this.NOTICE_FLAG,
			};
		}
	} 
}

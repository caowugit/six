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
	public partial class WIND
	{
		public WIND ToPOCO(bool isPOCO = true){
			return new WIND(){
				PKID = this.PKID,
				手机号 = this.手机号,
				时间 = this.时间,
				风速 = this.风速,
				风向度 = this.风向度,
				风向 = this.风向,
				风力等级 = this.风力等级,
				瞬风 = this.瞬风,
				瞬风等级 = this.瞬风等级,
				设备状态 = this.设备状态,
			};
		}
	} 
}
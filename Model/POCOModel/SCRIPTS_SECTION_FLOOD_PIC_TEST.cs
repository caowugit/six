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
	public partial class SCRIPTS_SECTION_FLOOD_PIC_TEST
	{
		public SCRIPTS_SECTION_FLOOD_PIC_TEST ToPOCO(bool isPOCO = true){
			return new SCRIPTS_SECTION_FLOOD_PIC_TEST(){
				ID = this.ID,
				FK_FLOODID = this.FK_FLOODID,
				PHOTOPATH = this.PHOTOPATH,
			};
		}
	} 
}

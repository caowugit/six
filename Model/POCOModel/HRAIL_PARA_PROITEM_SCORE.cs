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
	public partial class HRAIL_PARA_PROITEM_SCORE
	{
		public HRAIL_PARA_PROITEM_SCORE ToPOCO(bool isPOCO = true){
			return new HRAIL_PARA_PROITEM_SCORE(){
				ITEMSCORE_ID = this.ITEMSCORE_ID,
				ITEM_CODE = this.ITEM_CODE,
				PEAK_IDX = this.PEAK_IDX,
				PEAK_MIN = this.PEAK_MIN,
				PEAK_MAX = this.PEAK_MAX,
				ITEM_LEVEL = this.ITEM_LEVEL,
				ITEM_SCORE = this.ITEM_SCORE,
				SPEED = this.SPEED,
				PEAK_DESC = this.PEAK_DESC,
				ITEM_LEVEL_DESC = this.ITEM_LEVEL_DESC,
				MEMO = this.MEMO,
			};
		}
	} 
}

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
	public partial class WUFENG_BIAOZHUN
	{
		public WUFENG_BIAOZHUN ToPOCO(bool isPOCO = true){
			return new WUFENG_BIAOZHUN(){
				ID = this.ID,
				DANWEIBIANHAO = this.DANWEIBIANHAO,
				XIANBIANHAO = this.XIANBIANHAO,
				XIANMING = this.XIANMING,
				LEIJIGU = this.LEIJIGU,
				LEIJISHEN = this.LEIJISHEN,
				SHANGYUEGU = this.SHANGYUEGU,
				SHANGYUESHEN = this.SHANGYUESHEN,
				ZUOYOU = this.ZUOYOU,
				GAODI = this.GAODI,
				XIANGLIN = this.XIANGLIN,
			};
		}
	} 
}

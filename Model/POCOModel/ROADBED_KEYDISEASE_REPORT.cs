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
	public partial class ROADBED_KEYDISEASE_REPORT
	{
		public ROADBED_KEYDISEASE_REPORT ToPOCO(bool isPOCO = true){
			return new ROADBED_KEYDISEASE_REPORT(){
				REPORT_ID = this.REPORT_ID,
				GWD_CODE = this.GWD_CODE,
				CJ_CODE = this.CJ_CODE,
				GQ_CODE = this.GQ_CODE,
				LINE_CODE = this.LINE_CODE,
				LINE_CAT = this.LINE_CAT,
				LINE_DIR = this.LINE_DIR,
				SIDE = this.SIDE,
				SECTION_STATION = this.SECTION_STATION,
				START_MILE = this.START_MILE,
				END_MILE = this.END_MILE,
				LEN = this.LEN,
				REPORT_DATE = this.REPORT_DATE,
				EQU_TOTAL = this.EQU_TOTAL,
				EQU_SCORE = this.EQU_SCORE,
				EQU_FINE = this.EQU_FINE,
				EQU_PASS = this.EQU_PASS,
				EQU_DISPASS = this.EQU_DISPASS,
				NOTICE_NUM = this.NOTICE_NUM,
				MEMO = this.MEMO,
			};
		}
	} 
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace prjCoreDemo.Models
{
	public class TCustomer
	{
		[Key]
		public int FId { get; set;}
		[DisplayName("姓名")]
		[Required(ErrorMessage = "姓名必填")]
		public string? FName { get; set;}
		[DisplayName("電話")]
		[Required(ErrorMessage = "電話必填")]
		public string? FPhone { get; set;}
		[DisplayName("信箱")]
		[Required(ErrorMessage = "信箱必填")]
		[EmailAddress(ErrorMessage = "信箱格式有誤")]
		public string? FEmail { get; set;}
		[DisplayName("地址")]
		[Required(ErrorMessage = "地址必填")]
		public string? FAddress { get; set;}
	}
}


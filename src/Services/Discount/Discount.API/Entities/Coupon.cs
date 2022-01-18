﻿using System.Text.Json.Serialization;

namespace Discount.API.Entities
{
	public class Coupon
	{
		public int Id { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }
	}
}
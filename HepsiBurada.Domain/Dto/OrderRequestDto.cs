﻿namespace HepsiBurada.Domain
{
    public class OrderRequestDto : BaseClass
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
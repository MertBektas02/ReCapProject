﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarID { get; set; }

        public int BrandID { get; set; }

        public int ColorID { get; set; }


        public string CarName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}

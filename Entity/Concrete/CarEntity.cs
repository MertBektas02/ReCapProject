
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class CarEntity:IEntity
    {
       //HATA ALIYORDUM: Entity type CarEntity, BrandEntity ve ColorEntity requires a primary key to be defined. Çözüm olarak Key denen bir şey buldum. Using comp.model. 
        [Key]
        public int CarID { get; set; }
        
        public int BrandID { get; set; }
        
        public int ColorID { get; set; }


        public string CarName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
       
    }
}

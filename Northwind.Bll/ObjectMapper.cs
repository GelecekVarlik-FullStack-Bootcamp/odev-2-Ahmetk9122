﻿using AutoMapper;
using Northwind.Entity.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    //Object mapper kalıtımla da yapılır türetim ile de 
    //Kalıtım ile yapılacaksa protected nesne türetme yöntemiyle yapılacaksa internal
    //Her bir classa tek tek kalıtım vermemek için türetme methodu ile yapıyoruz.
    class ObjectMapper
    {
        //Readonly => Sonradan müdahele edilemesin
        //lazy => Böyle bir tasarım var ama projede ihtiyaç yokken oluşmasın eğer ki ihtiyaç olursa kullanılacakas ozaman oluşsun sonradan oluşturulan anlamına gelir.
        static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            return config.CreateMapper(); 
        }
        );
        public static IMapper Mapper => lazy.Value;
    }
}

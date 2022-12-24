using AutoMapper;
using Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Mapper
{
    public class SupplierMapper:Profile
    {
        public SupplierMapper()
        {
            CreateMap<Supplier, SupplierSampleModel>();
        }
    }
}

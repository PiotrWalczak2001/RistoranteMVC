using AutoMapper;
using RistoranteMVC.Application.Features.Categories.Queries.GetAllCategories;
using RistoranteMVC.Application.Features.Categories.Queries.GetCategoryById;
using RistoranteMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryListVm>().ReverseMap();
            CreateMap<Category, CategoryVm>().ReverseMap();
        }
    }
}

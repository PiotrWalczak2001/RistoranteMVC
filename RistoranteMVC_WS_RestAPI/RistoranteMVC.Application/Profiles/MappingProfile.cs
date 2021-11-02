using AutoMapper;
using RistoranteMVC.Application.Features.Categories.Queries.GetAllCategories;
using RistoranteMVC.Application.Features.Categories.Queries.GetCategoryById;
using RistoranteMVC.Application.Features.Dishes.Queries.GetAllDishes;
using RistoranteMVC.Application.Features.Dishes.Queries.GetDishById;
using RistoranteMVC.Application.Features.Employees.Queries.GetAllEmployees;
using RistoranteMVC.Application.Features.Employees.Queries.GetEmployeeById;
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
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Dish, DishVm>().ReverseMap();
            CreateMap<Dish, DishListVm>().ReverseMap();

            CreateMap<Employee, EmployeeVm>().ReverseMap();
            CreateMap<Employee, EmployeeListVm>().ReverseMap();
        }
    }
}

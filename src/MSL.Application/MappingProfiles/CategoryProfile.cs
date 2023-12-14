using AutoMapper;
using MLS.Application.DTO.Category;
using MLS.Application.Features.Category.Commands.CreateCategoryCommand;
using MLS.Application.Features.Category.Commands.DeleteCategoryCommand;
using MLS.Application.Features.Category.Commands.UpdateCategoryCommand;
using MLS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Application.MappingProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<Category, CategoryDetailDto>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, UpdateCategoryCommand>();
            CreateMap<Category, DeleteCategoryCommand>();
        }
    }
}

﻿using Kreta.HttpService.Services;
using Kreta.Shared.Assamblers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kreta.Desktop.Extensions
{
    public static class KretaDesktopExtension
    {

        public static void ConfigureHttpCliens(this IServiceCollection services)
        {
            services.AddHttpClient("KretaApi", options =>
            {
                options.BaseAddress = new Uri("https://localhost:7090/");
            });
        }

        public static void ConfigureApiServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IParentService, ParentService>();
            services.AddScoped<IEducationLavelService, EducationLevelService>();
            services.AddScoped<IGradeService, GradeService>();
            services.AddScoped<IPublicSpaceService, PublicSpaceService>();
            services.AddScoped<ISchoolClassService, SchoolClassService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<ISubjectTypeService, SubjectTypeService>();
            services.AddScoped<ITypeOfEducationService, TypleOfEducationService>();
            services.AddScoped<IEducationLavelService, EducationLevelService>();

        }

        public static void ConfigureAssamblers(this IServiceCollection services)
        {
            services.AddScoped<TeacherAssambler>();
            services.AddScoped<GradeAssambler>();
            services.AddScoped<ParentAssambler>();
            services.AddScoped<StudentAssambler>();
            services.AddScoped<SubjectAssambler>();
            services.AddScoped<EducationLevelAssambler>();
            services.AddScoped<SchoolClassAssambler>();
            services.AddScoped<AddressAssambler>();
            services.AddScoped<PublicSpaceAssambler>();
            services.AddScoped<SchoolClassAssambler>();
            services.AddScoped<TypeOfEducationAssambler>();
            services.AddScoped<EducationLevelAssambler>();
        }
    }
}

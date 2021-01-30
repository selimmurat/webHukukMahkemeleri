using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HukukMahkemeleriWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IEmployeeService, EmployeeManager>();
            services.AddSingleton<IEmployeeDAL, EfEmployeeDAL>();
            services.AddSingleton<IAdjectiveService, AdjectiveManager>();
            services.AddSingleton<IAdjectiveDAL, EfAdjectiveDAL>();
            services.AddSingleton<ICityService, CityManager>();
            services.AddSingleton<ICityDAL, EfCityDAL>();
            services.AddSingleton<IUnitTypeService, UnitTypeManager>();
            services.AddSingleton<IUnitTypeDAL, EfUnitTypeDAL>();
            services.AddSingleton<IUnitService, UnitManager>();
            services.AddSingleton<IUnitDAL, EfUnitDAL>();
            services.AddSingleton<IUnitAreaService, UnitAreaManager>();
            services.AddSingleton<IUnitAreaDAL, EfUnitAreaDAL>();
            services.AddSingleton<ICaseTypeService, CaseTypeManager>();
            services.AddSingleton<ICaseTypeDAL, EfCaseTypeDAL>();
            services.AddSingleton<ICompanyService, CompanyManager>();
            services.AddSingleton<ICompanyDAL, EfCompanyDAL>();
            services.AddSingleton<IDecisionTypeService, DecisionTypeManager>();
            services.AddSingleton<IDecisionTypeDAL, EfDecisionTypeDAL>();
            services.AddSingleton<IDistrictService, DistrictManager>();
            services.AddSingleton<IDistrictDAL, EfDistrictDAL>();
            services.AddSingleton<IEmployeeUnitRoleService, EmployeeUnitRoleManager>();
            services.AddSingleton<IEmployeeUnitRoleDAL, EfEmployeeUnitRoleDAL>();
            services.AddSingleton<IFileCaseTypeService, FileCaseTypeManager>();
            services.AddSingleton<IFileCaseTypeDAL, EfFileCaseTypeDAL>();
            services.AddSingleton<IFileRegisterCompanyService, FileRegisterCompanyManager>();
            services.AddSingleton<IFileRegisterCompanyDAL, EfFileRegisterCompanyDAL>();
            services.AddSingleton<IFileRegisterPersonService, FileRegisterPersonManager>();
            services.AddSingleton<IFileRegisterPersonDAL, EfFileRegisterPersonDAL>();
            services.AddSingleton<IFileSafahatStateService, FileSafahatStateManager>();
            services.AddSingleton<IFileSafahatStateDAL, EfFileSafahatStateDAL>();
            services.AddSingleton<IFileStateTypeService, FileStateTypeManager>();
            services.AddSingleton<IFileStateTypeDAL, EfFileStateTypeDAL>();
            services.AddSingleton<IFileTypeService, FileTypeManager>();
            services.AddSingleton<IFileTypeDAL, EfFileTypeDAL>();
            services.AddSingleton<IFileUnderConnectionService, FileUnderConnectionManager>();
            services.AddSingleton<IFileUnderConnectionDAL, EfFileUnderConnectionDAL>();
            services.AddSingleton<ILawWayService, LawWayManager>();
            services.AddSingleton<ILawWayDAL, EfLawWayDAL>();
            services.AddSingleton<ILawyerService, LawyerManager>();
            services.AddSingleton<ILawyerDAL, EfLawyerDAL>();
            services.AddSingleton<IPersonService, PersonManager>();
            services.AddSingleton<IPersonDAL, EfPersonDAL>();
            services.AddSingleton<IRoleService, RoleManager>();
            services.AddSingleton<IRoleDAL, EfRoleDAL>();
            services.AddSingleton<IUnitEndProcessRowNumberService, UnitEndProcessRowNumberManager>();
            services.AddSingleton<IUnitEndProcessRowNumberDAL, EfUnitEndProcessRowNumberDAL>();
            services.AddSingleton<IUnitOpenFileService, UnitOpenFileManager>();
            services.AddSingleton<IUnitOpenFileDAL, EfUnitOpenFileDAL>();
            services.AddSingleton<IUnitOpenFileService, UnitOpenFileManager>();
            services.AddSingleton<IUnitOpenFileDAL, EfUnitOpenFileDAL>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

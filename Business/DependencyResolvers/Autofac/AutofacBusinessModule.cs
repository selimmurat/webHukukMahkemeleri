using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdjectiveManager>().As<IAdjectiveService>().SingleInstance();
            builder.RegisterType<EfAdjectiveDAL>().As<IAdjectiveDAL>().SingleInstance();

            builder.RegisterType<CaseTypeManager>().As<ICaseTypeService>().SingleInstance();
            builder.RegisterType<EfCaseTypeDAL>().As<ICaseTypeDAL>().SingleInstance();

            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDAL>().As<ICityDAL>().SingleInstance();

            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDAL>().As<ICompanyDAL>().SingleInstance();

            builder.RegisterType<DecisionTypeManager>().As<IDecisionTypeService>().SingleInstance();
            builder.RegisterType<EfDecisionTypeDAL>().As<IDecisionTypeDAL>().SingleInstance();

            builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
            builder.RegisterType<EfDistrictDAL>().As<IDistrictDAL>().SingleInstance();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>().SingleInstance();
            builder.RegisterType<EfEmployeeDAL>().As<IEmployeeDAL>().SingleInstance();

            builder.RegisterType<EmployeeUnitRoleManager>().As<IEmployeeUnitRoleService>().SingleInstance();
            builder.RegisterType<EfEmployeeUnitRoleDAL>().As<IEmployeeUnitRoleDAL>().SingleInstance();

            builder.RegisterType<FileCaseTypeManager>().As<IFileCaseTypeService>().SingleInstance();
            builder.RegisterType<EfFileCaseTypeDAL>().As<IFileCaseTypeDAL>().SingleInstance();

            builder.RegisterType<FileRegisterCompanyManager>().As<IFileRegisterCompanyService>().SingleInstance();
            builder.RegisterType<EfFileRegisterCompanyDAL>().As<IFileRegisterCompanyDAL>().SingleInstance();

            builder.RegisterType<FileRegisterPersonManager>().As<IFileRegisterPersonService>().SingleInstance();
            builder.RegisterType<EfFileRegisterPersonDAL>().As<IFileRegisterPersonDAL>().SingleInstance();

            builder.RegisterType<FileSafahatStateManager>().As<IFileSafahatStateService>().SingleInstance();
            builder.RegisterType<EfFileSafahatStateDAL>().As<IFileSafahatStateDAL>().SingleInstance();

            builder.RegisterType<FileStateTypeManager>().As<IFileStateTypeService>().SingleInstance();
            builder.RegisterType<EfFileStateTypeDAL>().As<IFileStateTypeDAL>().SingleInstance();

            builder.RegisterType<FileTypeManager>().As<IFileTypeService>().SingleInstance();
            builder.RegisterType<EfFileTypeDAL>().As<IFileTypeDAL>().SingleInstance();

            builder.RegisterType<FileUnderConnectionManager>().As<IFileUnderConnectionService>().SingleInstance();
            builder.RegisterType<EfFileUnderConnectionDAL>().As<IFileUnderConnectionDAL>().SingleInstance();

            builder.RegisterType<LawWayManager>().As<ILawWayService>().SingleInstance();
            builder.RegisterType<EfLawWayDAL>().As<ILawWayDAL>().SingleInstance();

            builder.RegisterType<LawyerManager>().As<ILawyerService>().SingleInstance();
            builder.RegisterType<EfLawyerDAL>().As<ILawyerDAL>().SingleInstance();

            builder.RegisterType<PersonManager>().As<IPersonService>().SingleInstance();
            builder.RegisterType<EfPersonDAL>().As<IPersonDAL>().SingleInstance();

            builder.RegisterType<RoleManager>().As<IRoleService>().SingleInstance();
            builder.RegisterType<EfRoleDAL>().As<IRoleDAL>();

            builder.RegisterType<UnitAreaManager>().As<IUnitAreaService>().SingleInstance();
            builder.RegisterType<EfUnitAreaDAL>().As<IUnitAreaDAL>().SingleInstance();

            builder.RegisterType<UnitEndProcessRowNumberManager>().As<IUnitEndProcessRowNumberService>().SingleInstance();
            builder.RegisterType<EfUnitEndProcessRowNumberDAL>().As<IUnitEndProcessRowNumberDAL>().SingleInstance();

            builder.RegisterType<UnitManager>().As<IUnitService>().SingleInstance();
            builder.RegisterType<EfUnitDAL>().As<IUnitDAL>().SingleInstance();

            builder.RegisterType<UnitOpenFileManager>().As<IUnitOpenFileService>().SingleInstance();
            builder.RegisterType<EfUnitOpenFileDAL>().As<IUnitOpenFileDAL>().SingleInstance();

            builder.RegisterType<UnitTypeManager>().As<IUnitTypeService>().SingleInstance();
            builder.RegisterType<EfUnitTypeDAL>().As<IUnitTypeDAL>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}

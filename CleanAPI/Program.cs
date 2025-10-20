using CleanBase.Entities;
using CleanBase.Validator;
using CleanBusiness;
using CleanBusiness.Declarations;
using CleanBusiness.Services;
using CleanOperation.DataAccess;
using CleanOperation.Declarations;
using FluentValidation.AspNetCore;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Batch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi.Models;
using Serilog.Ui.Web.Extensions;
using System.Reflection.Emit;
using System.Text.Json.Serialization;
using Serilog;
using Serilog.Ui;
using Serilog.Sinks.MSSqlServer;
using Serilog.Ui.Core.Extensions;
using Serilog.Ui.MsSqlServerProvider.Extensions;
using Serilog.Extensions.Logging;
using Serilog.Events;
using Serilog.Formatting.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Configuration;
using Serilog.Filters;
using Serilog.Ui.Web.Models;
using System;
using CleanAPI.Controllers;
using CleanBase;
using Microsoft.Extensions.FileProviders;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


namespace CleanAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Log.Logger = new LoggerConfiguration()
            //            .MinimumLevel.Override("CleanAPI.Controllers", LogEventLevel.Information) // Log Information for your namespace
            //            .Enrich.FromLogContext()
            //            .MinimumLevel.Warning()
            //            .Filter.ByExcluding(Matching.WithProperty<string>("SensitiveProperty", _ => true))
            //            .WriteTo.Console()
            //            .WriteTo.MSSqlServer(
            //                connectionString: "Server=YTECH19-Server; Database=YaserManufacturing; user ID=ytechadmin; Password=ytech@2022; Connection Timeout=0; MultipleActiveResultSets=True;TrustServerCertificate=True;Multisubnetfailover=True",
            //                tableName: "Logs",
            //                autoCreateSqlTable: true)
            //            .CreateLogger();
            //

            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.
            builder.Services.AddDbContextPool<AppDataContext>(y =>
            {
                y.UseSqlServer(builder.Configuration["ConnectionStrings:InvoiceDb"]);
                //y.UseSqlServer(builder.Configuration.GetSection("")[""]);
                //y.UseInMemoryDatabase("Main");
                y.EnableDetailedErrors();
                /* y.EnableSensitiveDataLogging(); */                                                 ////////////////////////// MUST BE REMOVED ON PUBLISH
                y.ConfigureWarnings(y => y.Ignore(InMemoryEventId.TransactionIgnoredWarning));
            });
            /*builder.Host.ConfigureAppConfiguration((hostingContext, configBuilder) =>
            {
                var config = configBuilder.Build();
                var configSource = new CustomCleanConfigurationSource(opts =>
                    opts.UseSqlServer(builder.Configuration["ConnectionString:DefaultConnection"]));
                configBuilder.Add(configSource);
            });*/

            //builder.Services.AddSerilog();
            //builder.Host.UseSerilog((ctx, lc) => lc
            //    .MinimumLevel.Warning()
            //    .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning)
            //    .WriteTo.EventLog("Logs")
            //    .WriteTo.MSSqlServer(
            //        connectionString: builder.Configuration.GetConnectionString("InvoiceDb"),
            //        tableName: "Logs",
            //        autoCreateSqlTable: true // Set to true if you want Serilog to create the table automatically
            //    ));

            //builder.Services.AddSerilogUi(options => options
            //    .UseSqlServer(opts => opts
            //        .WithConnectionString(builder.Configuration.GetConnectionString("InvoiceDb")) // Correctly fetching connection string
            //        .WithTable("Logs"))); // Specify the log table

            var defaultBatchHandler = new DefaultODataBatchHandler();
            defaultBatchHandler.MessageQuotas.MaxNestingDepth = 3;
            defaultBatchHandler.MessageQuotas.MaxOperationsPerChangeset = 10;
            defaultBatchHandler.MessageQuotas.MaxReceivedMessageSize = 1000;
            builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals;
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            })
            .AddFluentValidation(config =>
            {
                config.RegisterValidatorsFromAssemblyContaining<VouchersTypeValidation>(lifetime: ServiceLifetime.Scoped);
                config.AutomaticValidationEnabled = false;
                config.ImplicitlyValidateChildProperties = false;
            })

            .AddOData(opt => opt.Select().Filter().Expand().Count().SetMaxTop(10).EnableQueryFeatures()
            .AddRouteComponents("odata", GetEdmModel(), defaultBatchHandler));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddFluentValidationRulesToSwagger();
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //builder.Services.AddSerilog(Log.Logger);


            builder.Services.AddScoped<IVouchersTypeService, VouchersTypeService>();
            builder.Services.AddScoped<ICurrencyService, CurrencyService>();
            builder.Services.AddScoped<IProcedureResultDtoService, ProcedureResultDtoService>();
            builder.Services.AddScoped<IProcedureResultListDtoService, ProcedureResultListDtoService>();
            builder.Services.AddScoped<ICostCenterService, CostCenterService>();
            builder.Services.AddScoped<ICostCenterElements, CostCenterElementsService>();
            builder.Services.AddScoped<ICostCenterTypes, CostCenterTypesService>();
            builder.Services.AddScoped<ICostCenterDistribution, CostCenterDistributionService>();
            builder.Services.AddScoped<ICostCenterDistributionDet, CostCenterDistributionDetService>();
            builder.Services.AddScoped<Iv_AcGroups, v_AcGroupsService>();
            builder.Services.AddScoped<IAcGroups, AcGroupsService>();
            builder.Services.AddScoped<IVouchers, VouchersService>();
            builder.Services.AddScoped<ITrans, TransService>();
            builder.Services.AddScoped<IV_Vouchers, V_VouchersService>();
            builder.Services.AddScoped<IV_Trans, V_TransService>();

            builder.Services.AddScoped<IProductLineService, ProductLineService>();
            builder.Services.AddScoped<IV_EmployeeProductionService, V_EmployeeProductionService>();


            builder.Services.AddScoped<IPurchaseOrderMain, PurchaseOrderMainService>();
            builder.Services.AddScoped<IPurchaseOrderDetails, PurchaseOrderDetailsService>();

            builder.Services.AddScoped<IV_FrmPurchaseOrder, V_FrmPurchaseOrderService>();
            builder.Services.AddScoped<IV_FrmPurchaseOrderDet, V_FrmPurchaseOrderDetService>();

            builder.Services.AddScoped<ISalesOrderMain, SalesOrderMainService>();
            builder.Services.AddScoped<ISalesOrderDetails, SalesOrderDetailsService>();

            builder.Services.AddScoped<IV_SalesOrder, V_SalesOrderService>();
            builder.Services.AddScoped<IV_SalesOrderDet, V_SalesOrderDetService>();

            builder.Services.AddScoped<IInvvoucher, InvvoucherService>();
            builder.Services.AddScoped<IMvts, MvtsService>();
            builder.Services.AddScoped<IV_invvoucher, V_invvoucherService>();
            builder.Services.AddScoped<IV_mvts, V_mvtsService>();

            builder.Services.AddScoped<IV_PinvvoucherService, V_PinvvoucherService>();
            builder.Services.AddScoped<IPinvvoucherService, PinvvoucherService>();
            builder.Services.AddScoped<IV_Pinvvoucher_ProductsService, V_Pinvvoucher_ProductsService>();

            builder.Services.AddScoped<IPmvtsService, PmvtsService>();
            builder.Services.AddScoped<IV_PmvtsService, V_PmvtsService>();
            builder.Services.AddScoped<IV_Pmvts_ProductsService, V_Pmvts_ProductsService>();
            builder.Services.AddScoped<IV_PCustomerListService, V_PCustomerListService>();
            builder.Services.AddScoped<ICustomersOrdersService, CustomersOrdersService>();
            builder.Services.AddScoped<IV_CustomersOrdersService, V_CustomersOrdersService>();

            builder.Services.AddScoped<IV_mvts_ProductOrderPackagingService, V_mvts_ProductOrderPackagingService>();


            builder.Services.AddScoped<IReceivingInvvoucher, ReceivingInvvoucherService>();
            builder.Services.AddScoped<IReceivingMvts, ReceivingMvtsService>();
            builder.Services.AddScoped<IV_ReceivingInvvoucher, V_ReceivingInvvoucherService>();
            builder.Services.AddScoped<IV_ReceivingMvts, V_ReceivingMvtsService>();


            builder.Services.AddScoped<IV_StockMvts, V_StockMvtsService>();
            builder.Services.AddScoped<IStores, StoresService>();


            builder.Services.AddScoped<IAccounts, AccountsService>();
            builder.Services.AddScoped<Iv_AcountsLevel, v_AcountsLevelService>();
            builder.Services.AddScoped<IV_Accounts, V_AccountsService>();
            builder.Services.AddScoped<IAccountsStatements, AccountsStatementsService>();


            builder.Services.AddScoped<ISuppliersService, SuppliersService>();
            builder.Services.AddScoped<ITestMethodsService, TestMethodsService>();
            builder.Services.AddScoped<ISpecificationsService, SpecificationsService>();
            builder.Services.AddScoped<IV_SpecificationsService, V_SpecificationsService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
            builder.Services.AddScoped<IV_SubCategoryService, V_SubCategoryService>();
            builder.Services.AddScoped<IColorService, ColorService>();
            builder.Services.AddScoped<IPerfumeService, PerfumeService>();
            builder.Services.AddScoped<IBrandsService, BrandsService>();
            builder.Services.AddScoped<IFactoryService, FactoryService>();
            builder.Services.AddScoped<IUnitsService, UnitsService>();
            builder.Services.AddScoped<ISpecificationLabTestsService, SpecificationLabTestsService>();
            builder.Services.AddScoped<IV_SpecificationLabTestsService, V_SpecificationLabTestsService>();


            //Stock Management 
            builder.Services.AddScoped<IstockService, stockService>();
            builder.Services.AddScoped<IStockSupplierService, StockSupplierService>();
            builder.Services.AddScoped<IStockSpecService, StockSpecService>();
            builder.Services.AddScoped<IStockTestService, StockTestService>();
            builder.Services.AddScoped<IStockPurchaseService, StockPurchaseService>();
            builder.Services.AddScoped<IStockStoreService, StockStoreService>();
            builder.Services.AddScoped<IStockDetailsService, StockDetailsService>();


            builder.Services.AddScoped<IV_stockService, V_stockService>();
            builder.Services.AddScoped<IV_StockSupplierService, V_StockSupplierService>();
            builder.Services.AddScoped<IV_StockSpecService, V_StockSpecService>();
            builder.Services.AddScoped<IV_StockTestService, V_StockTestService>();
            builder.Services.AddScoped<IV_StockPurchaseService, V_StockPurchaseService>();
            builder.Services.AddScoped<IV_StockStoreService, V_StockStoreService>();
            builder.Services.AddScoped<IV_StockDetailsService, V_StockDetailsService>();
            builder.Services.AddScoped<IV_StockBatchesService, V_StockBatchesService>();
            builder.Services.AddScoped<IV_StockDistService, V_StockDistService>();


            builder.Services.AddScoped<IV_ProductsService, V_ProductsService>();
            builder.Services.AddScoped<IV_ProductstestService, V_ProductstestService>();
            builder.Services.AddScoped<IV_ProductSpecsService, V_ProductSpecsService>();
            builder.Services.AddScoped<IV_ProductPackagingService, V_ProductPackagingService>();
            builder.Services.AddScoped<IV_ProductPackagingMaterialService, V_ProductPackagingMaterialService>();
            builder.Services.AddScoped<IV_ProductsRawService, V_ProductsRawService>();
            builder.Services.AddScoped<IV_ProductsStock_RawService, V_ProductsStock_RawService>();
            builder.Services.AddScoped<IV_ProductStock_PackageService, V_ProductStock_PackageService>();
            builder.Services.AddScoped<IV_ProductBatchesService, V_ProductBatchesService>();
            builder.Services.AddScoped<IV_ProductsBarcodesService, V_ProductsBarcodesService>();


            builder.Services.AddScoped<IProductsService, ProductsService>();
            builder.Services.AddScoped<IProductstestService, ProductstestService>();
            builder.Services.AddScoped<IProductSpecsService, ProductSpecsService>();
            builder.Services.AddScoped<IProductPackagingService, ProductPackagingService>();
            builder.Services.AddScoped<IProductPackagingMaterialService, ProductPackagingMaterialService>();
            builder.Services.AddScoped<IProductsRawService, ProductsRawService>();
            builder.Services.AddScoped<IProductsBarcodesService, ProductsBarcodesService>();


            builder.Services.AddScoped<IV_InvStock_RawService, V_InvStock_RawService>();

            builder.Services.AddScoped<IV_SearchProductPackagingService, V_SearchProductPackagingService>();

            //Assets
            builder.Services.AddScoped<ISections, SectionsService>();
            builder.Services.AddScoped<IAssetStore, AssetStoreService>();

            builder.Services.AddScoped<IV_Assets, V_AssetsService>();
            builder.Services.AddScoped<IAssets, AssetsService>();
            builder.Services.AddScoped<IAssetsCat, AssetsCatService>();
            builder.Services.AddScoped<IV_AssetsCat, V_AssetsCatService>();
            builder.Services.AddScoped<IV_AssetsDestruction, V_AssetsDestructionService>();
            builder.Services.AddScoped<IAssetsDestruction, AssetsDestructionService>();

            builder.Services.AddScoped<IV_AssetsTransfer, V_AssetsTransferService>();
            builder.Services.AddScoped<IAssetsTransfer, AssetsTransferService>();

            builder.Services.AddScoped<IV_Asset_Purchase, V_Asset_PurchaseService>();
            builder.Services.AddScoped<IV_Asset_PurchaseDet, V_Asset_PurchaseDetService>();

            builder.Services.AddScoped<IAsset_Purchase, Asset_PurchaseService>();
            builder.Services.AddScoped<IAsset_PurchaseDet, Asset_PurchaseDetService>();

            builder.Services.AddScoped<IV_AssetDepreciation, V_AssetDepreciationService>();
            builder.Services.AddScoped<IV_AssetDepreciationDetails, V_AssetDepreciationDetailsService>();

            builder.Services.AddScoped<IV_FillAssetDep, V_FillAssetDepService>();

            builder.Services.AddScoped<IAssetDepreciation, AssetDepreciationService>();
            builder.Services.AddScoped<IAssetDepreciationDetails, AssetDepreciationDetailsService>();
            builder.Services.AddScoped<IAssetsMethodDep, AssetsMethodDepService>();
            builder.Services.AddScoped<ISubAssets, SubAssetsService>();
            builder.Services.AddScoped<ISubAssetsTestMethodMainService, SubAssetsTestMethodMainService>();
            builder.Services.AddScoped<ISubAssetsTestMethodSubService, SubAssetsTestMethodSubService>();

            builder.Services.AddScoped<IV_SubAssets, V_SubAssetsService>();

            builder.Services.AddScoped<IV_SubAssetsTestMethodMainService, V_SubAssetsTestMethodMainService>();
            builder.Services.AddScoped<IV_SubAssetsTestMethodSubService, V_SubAssetsTestMethodSubService>();

            builder.Services.AddScoped<IV_SubAssets, V_SubAssetsService>();
            builder.Services.AddScoped<IV_ProductLineService, V_ProductLineService>();




            //Hr
            builder.Services.AddScoped<IDept, DeptService>();
            builder.Services.AddScoped<INationality, NationalityService>();
            builder.Services.AddScoped<IJobs, JobsService>();
            builder.Services.AddScoped<IBanks, BanksService>();
            builder.Services.AddScoped<IPayAccounts, PayAccountsService>();
            builder.Services.AddScoped<IAllowance, AllowanceService>();
            builder.Services.AddScoped<IHrSections, HrSectionsService>();
            builder.Services.AddScoped<IQualification, QualificationService>();
            builder.Services.AddScoped<IDiscountType, DiscountTypeService>();
            builder.Services.AddScoped<IAssuranceItem, AssuranceItemService>();
            builder.Services.AddScoped<IHolidayType, HolidayTypeService>();
            builder.Services.AddScoped<IV_EmpAllowance, V_EmpAllowanceService>();
            builder.Services.AddScoped<IEmpAllowance, EmpAllowanceService>();
            builder.Services.AddScoped<IV_Employees, V_EmployeesService>();
            builder.Services.AddScoped<IEmployees, EmployeesService>();
            builder.Services.AddScoped<IPayRollMain, PayRollMainService>();

            builder.Services.AddScoped<IV_OverTimeMain, V_OverTimeMainService>();
            builder.Services.AddScoped<IV_OverTimeDetails, V_OverTimeDetailsService>();

            builder.Services.AddScoped<IOverTimeMain, OverTimeMainService>();
            builder.Services.AddScoped<IOverTimeDetails, OverTimeDetailsService>();

            builder.Services.AddScoped<IV_DiscountMain, V_DiscountMainService>();
            builder.Services.AddScoped<IV_DiscountDetails, V_DiscountDetailsService>();

            builder.Services.AddScoped<IDiscountMain, DiscountMainService>();
            builder.Services.AddScoped<IDiscountDetails, DiscountDetailsService>();

            builder.Services.AddScoped<IHolidayMain, HolidayMainService>();
            builder.Services.AddScoped<IHolidayDetails, HolidayDetailsService>();

            builder.Services.AddScoped<IV_HolidayMain, V_HolidayMainService>();
            builder.Services.AddScoped<IV_HolidayDetails, V_HolidayDetailsService>();

            builder.Services.AddScoped<IV_LeavesMain, V_LeavesMainService>();
            builder.Services.AddScoped<IV_LeavesDetails, V_LeavesDetailsService>();

            builder.Services.AddScoped<ILeavesMain, LeavesMainService>();
            builder.Services.AddScoped<ILeavesDetails, LeavesDetailsService>();

            builder.Services.AddScoped<IEmploans, EmploansService>();

            builder.Services.AddScoped<IV_IncrementMain, V_IncrementMainService>();
            builder.Services.AddScoped<IV_IncrementDetails, V_IncrementDetailsService>();

            builder.Services.AddScoped<IIncrementMain, IncrementMainService>();
            builder.Services.AddScoped<IIncrementDetails, IncrementDetailsService>();

            builder.Services.AddScoped<IEmp_specializations, Emp_specializationsService>();
            builder.Services.AddScoped<IV_PayRollMonthly, V_PayRollMonthlyService>();
            builder.Services.AddScoped<IPayRollMonthly, PayRollMonthlyService>();
            builder.Services.AddScoped<IPayrollmonthlyallowance, PayrollmonthlyallowanceService>();
            builder.Services.AddScoped<IV_Payrollmonthlyallowance, V_PayrollmonthlyallowanceService>();

            builder.Services.AddScoped<IEvaluationElements, EvaluationElementsService>();
            builder.Services.AddScoped<IEvaluationMarks, EvaluationMarksService>();

            builder.Services.AddScoped<IV_LeavesRequest, V_LeavesRequestService>();
            builder.Services.AddScoped<ILeavesRequest, LeavesRequestService>();

            builder.Services.AddScoped<IV_HolidayRequest, V_HolidayRequestService>();
            builder.Services.AddScoped<IHolidayRequest, HolidayRequestService>();

            builder.Services.AddScoped<IV_SalaryIncreaseRequest, V_SalaryIncreaseRequestService>();
            builder.Services.AddScoped<ISalaryIncreaseRequest, SalaryIncreaseRequestService>();

            builder.Services.AddScoped<IV_PerformanceEvaluation, V_PerformanceEvaluationService>();
            builder.Services.AddScoped<IV_PerformanceEvaluationDet, V_PerformanceEvaluationDetService>();

            builder.Services.AddScoped<IPerformanceEvaluation, PerformanceEvaluationService>();
            builder.Services.AddScoped<IPerformanceEvaluationDet, PerformanceEvaluationDetService>();

            builder.Services.AddScoped<IFillEvaluationMarks, FillEvaluationMarksService>();
            builder.Services.AddScoped<IInternalReviewService, InternalReviewService>();



            //Production
            builder.Services.AddScoped<IProductOrderService, ProductOrderService>();
            builder.Services.AddScoped<IProductOrderPackagingService, ProductOrderPackagingService>();
            builder.Services.AddScoped<IProductOrderPackingMaterialService, ProductOrderPackingMaterialService>();
            builder.Services.AddScoped<IProductOrderRawMaterialService, ProductOrderRawMaterialService>();
            builder.Services.AddScoped<IProductOrderWagesService, ProductOrderWagesService>();

            builder.Services.AddScoped<IV_ProductOrderService, V_ProductOrderService>();
            builder.Services.AddScoped<IV_ProductOrderPackagingService, V_ProductOrderPackagingService>();
            builder.Services.AddScoped<IV_ProductOrderPackingMaterialService, V_ProductOrderPackingMaterialService>();
            builder.Services.AddScoped<IV_ProductOrderRawMaterialService, V_ProductOrderRawMaterialService>();
            builder.Services.AddScoped<IV_ProductOrderWagesService, V_ProductOrderWagesService>();


            builder.Services.AddScoped<IV_ProductOrder_InvVoucherService, V_ProductOrder_InvVoucherService>();
            builder.Services.AddScoped<IV_ProductOrder_mvtsService, V_ProductOrder_mvtsService>();

            builder.Services.AddScoped<IProductOrderReport, ProductOrderReportService>();
            builder.Services.AddScoped<IProductOrderReportRaw, ProductOrderReportRawService>();
            builder.Services.AddScoped<IProductOrderReportPackagingService, ProductOrderReportPackagingService>();
            builder.Services.AddScoped<IProductOrderReportWages, ProductOrderReportWagesService>();
            builder.Services.AddScoped<IProductOrderReportConsumablesService, ProductOrderReportConsumablesService>();


            builder.Services.AddScoped<IV_ProductOrderReport, V_ProductOrderReportService>();
            builder.Services.AddScoped<IV_ProductOrderReportRaw, V_ProductOrderReportRawService>();
            builder.Services.AddScoped<IV_ProductOrderReportPackagingService, V_ProductOrderReportPackagingService>();
            builder.Services.AddScoped<IV_ProductOrderReportWages, V_ProductOrderReportWagesService>();
            builder.Services.AddScoped<IV_ProductOrderReportConsumablesService, V_ProductOrderReportConsumablesService>();


            builder.Services.AddScoped<IV_ProductionConsumablesService, V_ProductionConsumablesService>();
            builder.Services.AddScoped<IProductionConsumablesService, ProductionConsumablesService>();
            builder.Services.AddScoped<IConsumableTypeService, ConsumableTypeService>();
            builder.Services.AddScoped<ITrackingBatchesService, TrackingBatchesService>();
            builder.Services.AddScoped<ITrackingBatchesDetailsService, TrackingBatchesDetailsService>();

            builder.Services.AddScoped<IV_TrackingBatchesService, V_TrackingBatchesService>();
            builder.Services.AddScoped<IV_TrackingBatchesDetailsService, V_TrackingBatchesDetailsService>();

            builder.Services.AddScoped<IV_Pmvts_BatchesService, V_Pmvts_BatchesService>();



            builder.Services.AddScoped<ISampletestMain, SampletestMainService>();
            builder.Services.AddScoped<ISampleTestDet, SampleTestDetService>();

            builder.Services.AddScoped<ILabTests, LabTestsService>();
            builder.Services.AddScoped<ILabTestResulte, LabTestResulteService>();

            builder.Services.AddScoped<IStockType, StockTypeService>();
            builder.Services.AddScoped<Iv_FillsampletestProduct, v_FillsampletestProductService>();
            builder.Services.AddScoped<Iv_FillsampletestStock, v_FillsampletestStockService>();

            builder.Services.AddScoped<Iv_sampletestDet, v_sampletestDetService>();
            builder.Services.AddScoped<Iv_sampletestmain, v_sampletestmainService>();



            builder.Services.AddScoped<ISupplierInfo, SupplierInfoService>();
            builder.Services.AddScoped<ISupEvaluationRate, SupEvaluationRateService>();
            builder.Services.AddScoped<ISupContractInfo, SupContractInfoService>();
            builder.Services.AddScoped<ISupContactInfo, SupContactInfoService>();
            builder.Services.AddScoped<ISupComplaintInfo, SupComplaintInfoService>();
            builder.Services.AddScoped<ISupEvaluationInfo, SupEvaluationInfoService>();
            builder.Services.AddScoped<ISuppEvaluation, SuppEvaluationService>();
            builder.Services.AddScoped<IV_SupEvaluationInfo, V_SupEvaluationInfoService>();

            //Maintenance
            builder.Services.AddScoped<IMaintenanceType, MaintenanceTypeService>();
            builder.Services.AddScoped<IMaintenanceTestMethodMain, MaintenanceTestMethodMainService>();
            builder.Services.AddScoped<IV_MaintenanceTestMethodsub, V_MaintenanceTestMethodsubService>();
            builder.Services.AddScoped<IMaintenanceTestMethodsub, MaintenanceTestMethodsubService>();
            builder.Services.AddScoped<IMaintenanceFrequency, MaintenanceFrequencyService>();
            builder.Services.AddScoped<IMaintinancePriorities, MaintinancePrioritiesService>();
            builder.Services.AddScoped<IMaintenanceFaults, MaintenanceFaultsService>();
            builder.Services.AddScoped<IMaintenanceAgencies, MaintenanceAgenciesService>();

            builder.Services.AddScoped<IV_MaintenanceAssetsMain, V_MaintenanceAssetsMainService>();
            builder.Services.AddScoped<IV_MaintenanceAssetsDet, V_MaintenanceAssetsDetService>();

            builder.Services.AddScoped<IMaintenanceAssetsMain, MaintenanceAssetsMainService>();
            builder.Services.AddScoped<IMaintenanceAssetsDet, MaintenanceAssetsDetService>();


            builder.Services.AddScoped<IV_MaintenanceTestsMain, V_MaintenanceTestsMainService>();
            builder.Services.AddScoped<IV_MaintenanceTestsDet, V_MaintenanceTestsDetService>();

            builder.Services.AddScoped<IMaintenanceTestsMain, MaintenanceTestsMainService>();
            builder.Services.AddScoped<IMaintenanceTestsDet, MaintenanceTestsDetService>();
            builder.Services.AddScoped<Iv_FillMaintenanceTestMethod, v_FillMaintenanceTestMethodService>();
            builder.Services.AddScoped<Iv_Maintenance_employees, v_Maintenance_employeesService>();

            builder.Services.AddScoped<IV_MaintenanceRequestMain, V_MaintenanceRequestMainService>();
            builder.Services.AddScoped<IV_MaintenanceRequestDet, V_MaintenanceRequestDetService>();

            builder.Services.AddScoped<IMaintenanceRequestMain, MaintenanceRequestMainService>();
            builder.Services.AddScoped<IMaintenanceRequestDet, MaintenanceRequestDetService>();

            builder.Services.AddScoped<IV_MaintenanceReports, V_MaintenanceReportsService>();
            builder.Services.AddScoped<IMaintenanceReports, MaintenanceReportsService>();


            builder.Services.AddScoped<ICatalyst, CatalystService>();
            builder.Services.AddScoped<IDeviationMain, DeviationMainService>();
            builder.Services.AddScoped<IDeviationDet, DeviationDetService>();


            builder.Services.AddScoped<IV_ProductOrderReportPackagingService, V_ProductOrderReportPackagingService>();

            builder.Services.AddScoped<IProductWithdrawal, ProductWithdrawalService>();

            builder.Services.AddScoped<IQuarantineMain, QuarantineMainService>();
            builder.Services.AddScoped<IV_QuarantineMain, V_QuarantineMainService>();
            builder.Services.AddScoped<IQuarantineDet, QuarantineDetService>();
            builder.Services.AddScoped<IV_QuarantineDet, V_QuarantineDetService>();
            //Safety
            builder.Services.AddScoped<ISafetyDef, SafetyDefService>();
            builder.Services.AddScoped<ISafetyRisk, SafetyRiskService>();
            builder.Services.AddScoped<ISafetyRiskDet, SafetyRiskDetService>();


            builder.Services.AddScoped<ISafetyComposition, SafetyCompositionService>();
            builder.Services.AddScoped<ISafetyCompositionDet, SafetyCompositionDetService>();

            builder.Services.AddScoped<ISafetyAccidental, SafetyAccidentalService>();
            builder.Services.AddScoped<ISafetyAid, SafetyAidService>();
            builder.Services.AddScoped<ISafetyFire, SafetyFireService>();
            builder.Services.AddScoped<ISafetyHandling, SafetyHandlingService>();
            builder.Services.AddScoped<ISafetyHandling, SafetyHandlingService>();
            builder.Services.AddScoped<ISafetyExposure, SafetyExposureService>();
            builder.Services.AddScoped<ISafetyPhysical, SafetyPhysicalService>();
            builder.Services.AddScoped<ISafetyChemical, SafetyChemicalService>();
            builder.Services.AddScoped<ISafetyDisposal, SafetyDisposalService>();
            builder.Services.AddScoped<ISafetyToxicity, SafetyToxicityService>();
            builder.Services.AddScoped<ISafetyTransportation, SafetyTransportationService>();

            builder.Services.AddScoped<IRiskCategory, RiskCategoryService>();
            builder.Services.AddScoped<IRiskGroup, RiskGroupService>();


            builder.Services.AddScoped<ISafetyRegulatoy, SafetyRegulatoyService>();
            builder.Services.AddScoped<ISafetyOther, SafetyOtherService>();

            builder.Services.AddScoped<IV_SupplierInfo, V_SupplierInfoService>();

            builder.Services.AddScoped<IInternalPurchaseOrderMain, InternalPurchaseOrderMainService>();
            builder.Services.AddScoped<IInternalPurchaseOrderDet, InternalPurchaseOrderDetService>();
            builder.Services.AddScoped<ILabs, LabsService>();

            //companyInfo
            builder.Services.AddScoped<ICompanyInfo, CompanyInfoService>();

            //permission

            builder.Services.AddScoped<IWebPagesService, WebPagesService>();
            builder.Services.AddScoped<IWebPagesGroups, WebPagesGroupsService>();

            builder.Services.AddScoped<IwebpagesUsers, webpagesUsersService>();
            builder.Services.AddScoped<IWebPagesOperations, WebPagesOperationsService>();

            builder.Services.AddScoped<IV_webpagesUsers, V_webpagesUsersService>();
            builder.Services.AddScoped<IRepository<V_webpagesUsers>, Repository<V_webpagesUsers>>(); // Ensure Repository is registered


            builder.Services.AddScoped<Iv_WebPagesPermissions, v_WebPagesPermissionsService>();
            builder.Services.AddScoped<IV_WebPagesPermissionsDet, V_WebPagesPermissionsDetService>();

            builder.Services.AddScoped<IWebPagesPermissions, WebPagesPermissionsService>();
            builder.Services.AddScoped<IWebPagesPermissionsDet, WebPagesPermissionsDetService>();

            builder.Services.AddScoped<Iv_FillWebPagesPermissions, v_FillWebPagesPermissionsService>();
            builder.Services.AddScoped<IV_WebpagesSignatures, V_WebpagesSignaturesService>();
            builder.Services.AddScoped<IWebpagesSignatures, WebpagesSignaturesService>();


            builder.Services.AddScoped<IV_NotificationService, V_NotificationService>();
            builder.Services.AddScoped<INotificationService, NotificationService>();

            builder.Services.AddScoped<IV_NotificationLogService, V_NotificationLogService>();
            builder.Services.AddScoped<INotificationLogService, NotificationLogService>();

            builder.Services.AddScoped<IV_WebMenuUserService, V_WebMenuUserService>();


            builder.Services.AddScoped<ISignatures, SignaturesService>();


            //RDM
            builder.Services.AddScoped<IRawMaterialEquationService, RawMaterialEquationService>();
            builder.Services.AddScoped<IStabilityService, StabilityService>();
            builder.Services.AddScoped<IV_RawMaterialEquationService, V_RawMaterialEquationService>();
            builder.Services.AddScoped<IV_StabilityService, V_StabilityService>();


            //CRM
            builder.Services.AddScoped<ICustomerCategory, CustomerCategoryService>();
            builder.Services.AddScoped<Iv_customer, v_customerService>();
            builder.Services.AddScoped<IV_CustomerContactService, V_CustomerContactService>();

            builder.Services.AddScoped<ICustomer, CustomerService>();
            builder.Services.AddScoped<ICustomerContactService, CustomerContactService>();


            //CRM
            builder.Services.AddScoped<IAreaService, AreaService>();
            builder.Services.AddScoped<ICityService, CityService>();
            builder.Services.AddScoped<ICustomerClassificationService, CustomerClassificationService>();
            builder.Services.AddScoped<IPaymentMethodService, PaymentMethodService>();
            builder.Services.AddScoped<IV_Stock_PmvtsService, V_Stock_PmvtsService>();
            builder.Services.AddScoped<IVanInvoiceMainService, VanInvoiceMainService>();
            builder.Services.AddScoped<IV_VanInvoiceMainService, V_VanInvoiceMainService>();
            builder.Services.AddScoped<IVanInvoiceDetailsService, VanInvoiceDetailsService>();
            builder.Services.AddScoped<IV_VanInvoiceDetailsService, V_VanInvoiceDetailsService>();

            builder.Services.AddScoped<IZVanSalesMainService, ZVanSalesMainService>();
            builder.Services.AddScoped<IZVanSalesDetailsService, ZVanSalesDetailsService>();
            builder.Services.AddScoped<IZVanSalesPaymentService, ZVanSalesPaymentService>();
            builder.Services.AddScoped<IZVanSalesChecksService, ZVanSalesChecksService>();
            builder.Services.AddScoped<IZVanSalesOrdersService, ZVanSalesOrdersService>();

            builder.Services.AddScoped<IV_ZVanSalesMainService, V_ZVanSalesMainService>();
            builder.Services.AddScoped<IV_ZVanSalesDetailsService, V_ZVanSalesDetailsService>();
            builder.Services.AddScoped<IV_ZVanSalesPaymentService, V_ZVanSalesPaymentService>();
            builder.Services.AddScoped<IV_ZVanSalesChecksService, V_ZVanSalesChecksService>();
            builder.Services.AddScoped<IV_ZVanSalesOrdersService, V_ZVanSalesOrdersService>();

            builder.Services.AddScoped<IV_ProductBatchDetailsService, V_ProductBatchDetailsService>();
            builder.Services.AddScoped<IV_ProductPackagingReadyService, V_ProductPackagingReadyService>();

            builder.Services.AddScoped<ILabelsService, LabelsService>();

            builder.Services.AddScoped<ILeadDealSourceService, LeadDealSourceService>();

            builder.Services.AddScoped<ILeadsAndDealsService, LeadsAndDealsService>();
            builder.Services.AddScoped<ILeadDealProductsService, LeadDealProductsService>();

            builder.Services.AddScoped<IV_LeadsAndDealsService, V_LeadsAndDealsService>();
            builder.Services.AddScoped<IV_LeadDealProductsService, V_LeadDealProductsService>();

            builder.Services.AddScoped<IV_BarcodeBatches, V_BarcodeBatchesService>();

            //Planning 
            builder.Services.AddScoped<IMasterProductionScheduleService, MasterProductionScheduleService>();
            builder.Services.AddScoped<IMasterProductionScheduleDetService, MasterProductionScheduleDetService>();
            builder.Services.AddScoped<IV_MasterProductionScheduleService, V_MasterProductionScheduleService>();
            builder.Services.AddScoped<IV_MasterProductionScheduleDetService, V_MasterProductionScheduleDetService>();
            builder.Services.AddScoped<IV_MaterialInvoiceService, V_MaterialInvoiceService>();

            builder.Services.AddScoped<IMaterialRequirementsPlanningService, MaterialRequirementsPlanningService>();
            builder.Services.AddScoped<IV_MaterialRequirementsPlanningService, V_MaterialRequirementsPlanningService>();
            builder.Services.AddScoped<IMaterialRequirementsPlanningDetService, MaterialRequirementsPlanningDetService>();
            builder.Services.AddScoped<IV_MaterialRequirementsPlanningDetService, V_MaterialRequirementsPlanningDetService>();

            builder.Services.AddScoped<IWeeklyPlanMainService, WeeklyPlanMainService>();
            builder.Services.AddScoped<IWeeklyPlanDetService, WeeklyPlanDetService>();

            builder.Services.AddScoped<IV_WeeklyPlanMainService, V_WeeklyPlanMainService>();
            builder.Services.AddScoped<IV_WeeklyPlanDetService, V_WeeklyPlanDetService>();
            builder.Services.AddScoped<IV_voucherAccounts, V_voucherAccountsService>();


            //Cash Budget Management
            builder.Services.AddScoped<ICashBalanceService, CashBalanceService>();
            builder.Services.AddScoped<ICashBudgetService, CashBudgetService>();
            builder.Services.AddScoped<ICashBudgetItemsService, CashBudgetItemsService>();
            builder.Services.AddScoped<ICashInflowsService, CashInflowsService>();
            builder.Services.AddScoped<ICashOutflowsService, CashOutflowsService>();

            builder.Services.AddScoped<ILetterOfCredit, LetterOfCreditService>();
            builder.Services.AddScoped<ILcDocs, LcDocsService>();
            builder.Services.AddScoped<IV_LetterOfCredit, V_LetterOfCreditService>();
            builder.Services.AddScoped<IV_LcDocs, V_LcDocsService>();
  

            builder.Services.AddScoped<IStockAssignment, StockAssignmentService>();
            builder.Services.AddScoped<IV_StockAssignment, V_StockAssignmentService>();
            builder.Services.AddScoped<IV_StockAssignmentQty, V_StockAssignmentQtyService>();

            builder.Services.AddScoped<IContractItems, ContractItemsService>();
            builder.Services.AddScoped<IContracts, ContractsService>();

            builder.Services.AddScoped<ILC_Type, LC_TypeService>();
            builder.Services.AddScoped<IlC_STATUS, lC_STATUSService>();


            builder.Services.AddScoped<ICMvts, CMvtsService>();
            builder.Services.AddScoped<IV_Cmvts, V_CmvtsService>();
            builder.Services.AddScoped<ICInvvoucher, CInvvoucherService>();
            builder.Services.AddScoped<IV_Cinvvoucher, V_CinvvoucherService>();
            builder.Services.AddScoped<IPosOperations, PosOperationsService>();
            builder.Services.AddScoped<IPosOperators, PosOperatorsService>();
            builder.Services.AddScoped<IPosOperatorsdet, PosOperatorsdetService>();

            builder.Services.AddScoped<ILoginPos, LoginPosService>();
            builder.Services.AddScoped<ILoginPosDet, LoginPosDetService>();
            builder.Services.AddScoped<IV_CompanyInfo, V_CompanyInfoService>();

            builder.Services.AddScoped<IPosInvoiceMainService,PosInvoiceMainService>();
            builder.Services.AddScoped<IPosInvoiceDetailService,PosInvoiceDetailService>();
            builder.Services.AddScoped<IPosAccountsPaymethodService, PosAccountsPaymethodService>();
            builder.Services.AddScoped<IPosPaidOutService, PosPaidOutService>();
            builder.Services.AddScoped<IPosPaidInService, PosPaidInService>();

            builder.Services.AddScoped<IPosVoucherService, PosVoucherService>();
            builder.Services.AddScoped<IPosVoucherDetailsService, PosVoucherDetailsService>();
            builder.Services.AddScoped<IPosVoidDetailsService, PosVoidDetailsService>();

            builder.Services.AddSingleton<NotificationUserTracker>();




            builder.Services.AddScoped<IV_ProductLineService, V_ProductLineService>();


            // 🔹 Load Allowed Origins from appsettings.json
            var allowedOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>();

            // 🔹 Log Origins to Debug (Check Console Output)
            Console.WriteLine("Allowed Origins: " + (allowedOrigins != null ? string.Join(", ", allowedOrigins) : "NULL"));




            builder.Services.AddAuthorization();

            // ✅ Configure CORS
            var corsPolicyName = "AllowAllOrigins";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(corsPolicyName, policy =>
                {
                    if (allowedOrigins != null && allowedOrigins.Length > 0)
                    {
                        policy.WithOrigins(allowedOrigins) // ✅ Ensure Origins are Loaded
                              .AllowAnyHeader()
                              .AllowAnyMethod()
                              .AllowCredentials();
                    }
                    else
                    {
                        Console.WriteLine("⚠️ No allowed origins found in appsettings.json");
                    }
                });
            });

            // ✅ Add SignalR
            builder.Services.AddSignalR().AddJsonProtocol(options =>
            {
                options.PayloadSerializerOptions.PropertyNamingPolicy = null;
            });

            // ✅ Add Swagger & Security Definitions
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Enter JWT token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
            });




            var app = builder.Build();

            // ✅ Apply Middleware in Correct Order
            app.UseCors(corsPolicyName); // 🔹 CORS must come first

            app.UseWebSockets();
            app.UseRouting();

            app.UseAuthentication(); // 👈 Important: this must come before UseAuthorization
            app.UseAuthorization();
            app.MapControllers();

            // ✅ Map SignalR Hub
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<NotificationHub>("/notificationHub");  // ✅ Ensure this is correct!
            });

            // ✅ Enable Swagger
            app.UseDeveloperExceptionPage(); // أضف هذا السطر
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseStaticFiles();


            var uploadedImagesPath = Path.Combine(Directory.GetCurrentDirectory(), "upload");


            if (Directory.Exists(uploadedImagesPath))
            {
                app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(uploadedImagesPath),
                    RequestPath = "/upload"
                });
            }

            app.UseHttpsRedirection();

            app.Run();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

            builder.EntitySet<VouchersType>("VouchersType");
            builder.EntitySet<ProcedureResultDto>("ProcedureResultDto");
            builder.EntitySet<ProcedureResultListDto>("ProcedureResultListDto");
            builder.EntitySet<v_AcGroups>("v_AcGroups");
            builder.EntitySet<AcGroups>("AcGroups");
            builder.EntitySet<CostCenter>("CostCenter");
            builder.EntitySet<CostCenterElements>("CostCenterElements");
            builder.EntitySet<CostCenterTypes>("CostCenterTypes");
            builder.EntitySet<CostCenterDistribution>("CostCenterDistribution");
            builder.EntitySet<CostCenterDistributionDet>("CostCenterDistributionDet");
            builder.EntitySet<Vouchers>("Vouchers");
            builder.EntitySet<Trans>("Trans");
            builder.EntitySet<V_Vouchers>("V_Vouchers");
            builder.EntitySet<V_Trans>("V_Trans");
            builder.EntitySet<Currency>("Currency");

            builder.EntitySet<PurchaseOrderMain>("PurchaseOrderMain");
            builder.EntitySet<PurchaseOrderDetails>("PurchaseOrderDetails");
            builder.EntitySet<SalesOrderMain>("SalesOrderMain");
            builder.EntitySet<SalesOrderDetails>("SalesOrderDetails");

            builder.EntitySet<V_FrmPurchaseOrder>("V_FrmPurchaseOrder");
            builder.EntitySet<V_FrmPurchaseOrderDet>("V_FrmPurchaseOrderDet");
            builder.EntitySet<V_FrmPurchaseOrder>("V_SalesOrder");
            builder.EntitySet<V_FrmPurchaseOrderDet>("V_SalesOrderDet");

            builder.EntitySet<Invvoucher>("Invvoucher");
            builder.EntitySet<Mvts>("mvts");

            builder.EntitySet<Pinvvoucher>("Pinvvoucher");
            builder.EntitySet<V_Pinvvoucher>("V_Pinvvoucher");
            builder.EntitySet<Pmvts>("Pmvts");
            builder.EntitySet<V_Pmvts>("V_Pmvts");
            builder.EntitySet<V_Pinvvoucher_Products>("V_Pinvvoucher_Products");
            builder.EntitySet<V_Pmvts_Products>("V_Pmvts_Products");
            builder.EntitySet<V_PCustomerList>("V_PCustomerList");
            builder.EntitySet<CustomersOrders>("CustomersOrders");
            builder.EntitySet<V_CustomersOrders>("V_CustomersOrders");


            builder.EntitySet<ReceivingInvvoucher>("ReceivingInvvoucher");
            builder.EntitySet<ReceivingMvts>("ReceivingMvts");

            builder.EntitySet<V_ReceivingInvvoucher>("V_ReceivingInvvoucher");
            builder.EntitySet<V_ReceivingMvts>("V_ReceivingMvts");


            builder.EntitySet<V_StockMvts>("V_StockMvts");
            builder.EntitySet<Stores>("Stores");
            builder.EntitySet<V_invvoucher>("V_invvoucher");
            builder.EntitySet<V_mvts>("V_mvts");

            builder.EntitySet<Accounts>("Accounts");
            builder.EntitySet<v_AcountsLevel>("v_AcountsLevel");
            builder.EntitySet<V_Accounts>("V_Accounts");
            builder.EntitySet<AccountsStatements>("AccountsStatements");


            builder.EntitySet<Specifications>("Specifications");
            builder.EntitySet<V_Specifications>("V_Specifications");
            builder.EntitySet<Suppliers>("Suppliers");
            builder.EntitySet<TestMethods>("TestMethods");
            builder.EntitySet<SubCategory>("SubCategory");
            builder.EntitySet<V_SubCategory>("V_SubCategory");
            builder.EntitySet<Category>("Category");
            builder.EntitySet<Color>("Color");
            builder.EntitySet<Perfume>("Perfume");
            builder.EntitySet<Brands>("Brands");
            builder.EntitySet<Factory>("Factory");
            builder.EntitySet<Units>("Units");
            builder.EntitySet<SpecificationLabTests>("SpecificationLabTests");
            builder.EntitySet<V_SpecificationLabTests>("V_SpecificationLabTests");


            //Stock Management 
            builder.EntitySet<Stock>("stock");
            builder.EntitySet<StockSupplier>("StockSupplier");
            builder.EntitySet<StockSpec>("StockSpec");
            builder.EntitySet<StockTest>("StockTest");
            builder.EntitySet<StockStore>("StockStore");
            builder.EntitySet<StockPurchase>("StockPurchase");
            builder.EntitySet<StockDetails>("StockDetails");


            builder.EntitySet<V_stock>("V_stock");
            builder.EntitySet<V_StockSupplier>("V_StockSupplier");
            builder.EntitySet<V_StockSpec>("V_StockSpec");
            builder.EntitySet<V_StockTest>("V_StockTest");
            builder.EntitySet<V_StockStore>("V_StockStore");
            builder.EntitySet<V_StockPurchase>("V_StockPurchase");
            builder.EntitySet<V_StockDetails>("V_StockDetails");
            builder.EntitySet<V_StockBatches>("V_StockBatches");
            builder.EntitySet<V_StockDist>("V_StockDist");


            builder.EntitySet<V_Products>("V_Products");
            builder.EntitySet<V_Productstest>("V_Productstest");
            builder.EntitySet<V_ProductSpecs>("V_ProductSpecs");
            builder.EntitySet<V_ProductPackaging>("V_ProductPackaging");
            builder.EntitySet<V_ProductPackagingMaterial>("V_ProductPackagingMaterial");
            builder.EntitySet<V_ProductsRaw>("V_ProductsRaw");
            builder.EntitySet<V_ProductsStock_Raw>("V_ProductsStock_Raw");
            builder.EntitySet<V_ProductStock_Package>("V_ProductStock_Package");
            builder.EntitySet<V_ProductBatches>("V_ProductBatches");
            builder.EntitySet<V_ProductsBarcodes>("V_ProductsBarcodes");

            builder.EntitySet<Products>("Products");
            builder.EntitySet<Productstest>("Productstest");
            builder.EntitySet<ProductSpecs>("ProductSpecs");
            builder.EntitySet<ProductPackaging>("ProductPackaging");
            builder.EntitySet<ProductPackagingMaterial>("ProductPackagingMaterial");
            builder.EntitySet<ProductsRaw>("ProductsRaw");
            builder.EntitySet<ProductsBarcodes>("ProductsBarcodes");


            builder.EntitySet<V_InvStock_Raw>("V_InvStock_Raw");
            builder.EntitySet<TrackingBatches>("TrackingBatches");
            builder.EntitySet<TrackingBatchesDetails>("TrackingBatchesDetails");
            builder.EntitySet<V_TrackingBatches>("V_TrackingBatches");
            builder.EntitySet<V_TrackingBatchesDetails>("V_TrackingBatchesDetails");
            builder.EntitySet<V_Pmvts_Batches>("V_Pmvts_Batches");


            builder.EntitySet<V_SearchProductPackaging>("V_SearchProductPackaging");
            builder.EntitySet<V_EmployeeProduction>("V_EmployeeProduction");

            //Assets
            builder.EntitySet<Sections>("Sections");
            builder.EntitySet<AssetStore>("AssetStore");

            builder.EntitySet<V_Assets>("V_Assets");
            builder.EntitySet<Assets>("Assets");
            builder.EntitySet<AssetsCat>("AssetsCat");
            builder.EntitySet<V_AssetsCat>("V_AssetsCat");

            builder.EntitySet<V_AssetsDestruction>("V_AssetsDestruction");
            builder.EntitySet<AssetsDestruction>("AssetsDestruction");

            builder.EntitySet<V_AssetsTransfer>("V_AssetsTransfer");
            builder.EntitySet<AssetsTransfer>("AssetsTransfer");

            builder.EntitySet<V_Asset_Purchase>("V_Asset_Purchase");
            builder.EntitySet<V_Asset_PurchaseDet>("V_Asset_PurchaseDet");

            builder.EntitySet<Asset_Purchase>("Asset_Purchase");
            builder.EntitySet<Asset_PurchaseDet>("Asset_PurchaseDet");

            builder.EntitySet<V_AssetDepreciation>("V_AssetDepreciation");
            builder.EntitySet<V_AssetDepreciationDetails>("V_AssetDepreciationDetails");

            builder.EntitySet<V_FillAssetDep>("V_FillAssetDep");

            builder.EntitySet<AssetDepreciation>("AssetDepreciation");
            builder.EntitySet<AssetDepreciationDetails>("AssetDepreciationDetails");
            builder.EntitySet<AssetsMethodDep>("AssetsMethodDep");
            builder.EntitySet<SubAssets>("SubAssets");
            builder.EntitySet<V_SubAssets>("v_SubAssets");


            builder.EntitySet<SubAssetsTestMethodMain>("SubAssetsTestMethodMain");
            builder.EntitySet<SubAssetsTestMethodSub>("SubAssetsTestMethodSub");

            builder.EntitySet<V_SubAssets>("V_SubAssets");

            builder.EntitySet<V_SubAssetsTestMethodMain>("V_SubAssetsTestMethodMain");
            builder.EntitySet<V_SubAssetsTestMethodSub>("V_SubAssetsTestMethodSub");



            //Hr
            builder.EntitySet<Dept>("Dept");
            builder.EntitySet<Nationality>("Nationality");
            builder.EntitySet<Jobs>("Jobs");
            builder.EntitySet<Banks>("Banks");
            builder.EntitySet<PayAccounts>("PayAccounts");
            builder.EntitySet<Allowance>("Allowance");
            builder.EntitySet<HrSections>("HrSections");
            builder.EntitySet<Qualification>("Qualification");
            builder.EntitySet<DiscountType>("DiscountType");
            builder.EntitySet<AssuranceItem>("AssuranceItem");
            builder.EntitySet<HolidayType>("HolidayType");
            builder.EntitySet<V_EmpAllowance>("V_EmpAllowance");
            builder.EntitySet<EmpAllowance>("EmpAllowance");
            builder.EntitySet<V_Employees>("V_Employees");
            builder.EntitySet<Employees>("Employees");
            builder.EntitySet<PayRollMain>("PayRollMain");

            builder.EntitySet<V_OverTimeMain>("V_OverTimeMain");
            builder.EntitySet<V_OverTimeDetails>("V_OverTimeDetails");

            builder.EntitySet<OverTimeMain>("OverTimeMain");
            builder.EntitySet<OverTimeDetails>("OverTimeDetails");

            builder.EntitySet<V_DiscountMain>("V_DiscountMain");
            builder.EntitySet<V_DiscountDetails>("V_DiscountDetails");

            builder.EntitySet<DiscountMain>("DiscountMain");
            builder.EntitySet<DiscountDetails>("DiscountDetails");

            builder.EntitySet<HolidayMain>("HolidayMain");
            builder.EntitySet<HolidayDetails>("HolidayDetails");

            builder.EntitySet<V_HolidayMain>("V_HolidayMain");
            builder.EntitySet<V_HolidayDetails>("V_HolidayDetails");

            builder.EntitySet<V_LeavesMain>("V_LeavesMain");
            builder.EntitySet<V_LeavesDetails>("V_LeavesDetails");

            builder.EntitySet<LeavesMain>("LeavesMain");
            builder.EntitySet<LeavesDetails>("LeavesDetails");

            builder.EntitySet<Emploans>("Emploans");

            builder.EntitySet<V_IncrementMain>("V_IncrementMain");
            builder.EntitySet<V_IncrementDetails>("V_IncrementDetails");

            builder.EntitySet<IncrementMain>("IncrementMain");
            builder.EntitySet<IncrementDetails>("IncrementDetails");

            builder.EntitySet<Emp_specializations>("Emp_specializations");
            builder.EntitySet<V_PayRollMonthly>("V_PayRollMonthly");
            builder.EntitySet<PayRollMonthly>("PayRollMonthly");

            builder.EntitySet<EvaluationElements>("EvaluationElements");
            builder.EntitySet<EvaluationMarks>("EvaluationMarks");

            builder.EntitySet<V_LeavesRequest>("V_LeavesRequest");
            builder.EntitySet<LeavesRequest>("LeavesRequest");

            builder.EntitySet<V_HolidayRequest>("V_HolidayRequest");
            builder.EntitySet<HolidayRequest>("HolidayRequest");

            builder.EntitySet<V_SalaryIncreaseRequest>("V_SalaryIncreaseRequest");
            builder.EntitySet<SalaryIncreaseRequest>("SalaryIncreaseRequest");

            builder.EntitySet<V_PerformanceEvaluation>("V_PerformanceEvaluation");
            builder.EntitySet<V_PerformanceEvaluationDet>("V_PerformanceEvaluationDet");

            builder.EntitySet<PerformanceEvaluation>("PerformanceEvaluation");
            builder.EntitySet<PerformanceEvaluationDet>("PerformanceEvaluationDet");
            builder.EntitySet<FillEvaluationMarks>("Fill_Evaluation_Marks");



            //Production
            builder.EntitySet<ProductOrder>("ProductOrder");
            builder.EntitySet<ProductOrderPackaging>("ProductOrderPackaging");
            builder.EntitySet<ProductOrderPackingMaterial>("ProductOrderPackingMaterial");
            builder.EntitySet<ProductOrderRawMaterial>("ProductOrderRawMaterial");
            builder.EntitySet<ProductOrderWages>("ProductOrderWages");

            builder.EntitySet<V_ProductOrder>("V_ProductOrder");
            builder.EntitySet<V_ProductOrderPackaging>("V_ProductOrderPackaging");
            builder.EntitySet<V_ProductOrderPackingMaterial>("V_ProductOrderPackingMaterial");
            builder.EntitySet<V_ProductOrderRawMaterial>("V_ProductOrderRawMaterial");
            builder.EntitySet<V_ProductOrderWages>("V_ProductOrderWages");


            builder.EntitySet<V_ProductOrder_InvVoucher>("V_ProductOrder_InvVoucher");
            builder.EntitySet<V_ProductOrder_mvts>("V_ProductOrder_mvts");
            builder.EntitySet<V_mvts_ProductOrderPackaging>("V_mvts_ProductOrderPackaging");

            builder.EntitySet<ProductOrderReport>("ProductOrderReporV_Stock_Pmvtst");
            builder.EntitySet<ProductOrderReportRaw>("ProductOrderReportRaw");
            builder.EntitySet<ProductOrderReportPackaging>("ProductOrderReportPackaging");
            builder.EntitySet<ProductOrderReportWages>("ProductOrderReportWages");
            builder.EntitySet<ProductOrderReportConsumables>("ProductOrderReportConsumables");


            builder.EntitySet<V_ProductOrderReport>("V_ProductOrderReport");
            builder.EntitySet<V_ProductOrderReportRaw>("V_ProductOrderReportRaw");
            builder.EntitySet<V_ProductOrderReportPackaging>("V_ProductOrderReportPackaging");
            builder.EntitySet<V_ProductOrderReportWages>("V_ProductOrderReportWages");
            builder.EntitySet<V_ProductOrderReportConsumables>("V_ProductOrderReportConsumables");


            builder.EntitySet<V_ProductionConsumables>("V_ProductionConsumables");
            builder.EntitySet<ProductionConsumables>("ProductionConsumables");
            builder.EntitySet<ConsumableType>("ConsumableType");


            builder.EntitySet<ProductLine>("ProductLine");


            builder.EntitySet<SampletestMain>("SampletestMain");
            builder.EntitySet<SampleTestDet>("SampleTestDet");


            builder.EntitySet<StockType>("StockType");
            builder.EntitySet<LabTests>("LabTests");
            builder.EntitySet<LabTestResulte>("LabTestResulte");
            builder.EntitySet<v_FillsampletestProduct>("v_FillsampletestProduct");
            builder.EntitySet<v_FillsampletestStock>("v_FillsampletestStock");
            builder.EntitySet<v_sampletestDet>("v_sampletestDet");
            builder.EntitySet<v_sampletestmain>("v_sampletestmain");


            builder.EntitySet<SupplierInfo>("SupplierInfo");
            builder.EntitySet<SupEvaluationRate>("SupEvaluationRate");
            builder.EntitySet<SupContractInfo>("SupContractInfo");
            builder.EntitySet<SupContactInfo>("SupContactInfo");
            builder.EntitySet<SupComplaintInfo>("SupComplaintInfo");
            builder.EntitySet<SupEvaluationInfo>("SupEvaluationInfo");
            builder.EntitySet<SuppEvaluation>("SuppEvaluation");

            builder.EntitySet<V_SupEvaluationInfo>("V_SupEvaluationInfo");


            //Maintenance
            builder.EntitySet<MaintenanceType>("MaintenanceType");
            builder.EntitySet<MaintenanceTestMethodMain>("MaintenanceTestMethodMain");
            builder.EntitySet<V_MaintenanceTestMethodsub>("V_MaintenanceTestMethodsub");
            builder.EntitySet<MaintenanceTestMethodsub>("MaintenanceTestMethodsub");
            builder.EntitySet<MaintenanceFrequency>("MaintenanceFrequency");
            builder.EntitySet<MaintinancePriorities>("MaintinancePriorities");
            builder.EntitySet<MaintenanceFaults>("MaintenanceFaults");
            builder.EntitySet<MaintenanceAgencies>("MaintenanceAgencies");

            builder.EntitySet<V_MaintenanceAssetsMain>("V_MaintenanceAssetsMain");
            builder.EntitySet<V_MaintenanceAssetsDet>("V_MaintenanceAssetsDet");

            builder.EntitySet<MaintenanceAssetsMain>("MaintenanceAssetsMain");
            builder.EntitySet<MaintenanceAssetsDet>("MaintenanceAssetsDet");

            builder.EntitySet<V_MaintenanceTestsMain>("V_MaintenanceTestsMain");
            builder.EntitySet<V_MaintenanceTestsDet>("V_MaintenanceTestsDet");

            builder.EntitySet<MaintenanceTestsMain>("MaintenanceTestsMain");
            builder.EntitySet<MaintenanceTestsDet>("MaintenanceTestsDet");

            builder.EntitySet<v_FillMaintenanceTestMethod>("v_FillMaintenanceTestMethod");
            builder.EntitySet<v_Maintenance_employees>("v_Maintenance_ev_FillMaintenanceTestMethodmployees");

            builder.EntitySet<V_MaintenanceRequestMain>("V_MaintenanceRequestMain");
            builder.EntitySet<V_MaintenanceRequestDet>("V_MaintenanceRequestDet");

            builder.EntitySet<MaintenanceRequestMain>("MaintenanceRequestMain");
            builder.EntitySet<MaintenanceRequestDet>("MaintenanceRequestDet");

            builder.EntitySet<V_MaintenanceReports>("V_MaintenanceReports");
            builder.EntitySet<MaintenanceReports>("MaintenanceReports");


            builder.EntitySet<InternalReview>("InternalReview");


            builder.EntitySet<Catalyst>("Catalyst");
            builder.EntitySet<DeviationDet>("DeviationDet");
            builder.EntitySet<DeviationMain>("DeviationMain");
            builder.EntitySet<ProductWithdrawal>("ProductWithdrawal");

            builder.EntitySet<V_ProductOrderReportPackaging>("V_ProductOrderReportPackaging");


            builder.EntitySet<QuarantineMain>("QuarantineMain");
            builder.EntitySet<V_QuarantineMain>("V_QuarantineMain");
            builder.EntitySet<QuarantineDet>("QuarantineDet");
            builder.EntitySet<V_QuarantineDet>("V_QuarantineDet");

            builder.EntitySet<SafetyDef>("SafetyDef");
            builder.EntitySet<SafetyRisk>("SafetyRisk");
            builder.EntitySet<SafetyRiskDet>("SafetyRiskDet");
            builder.EntitySet<SafetyComposition>("SafetyComposition");
            builder.EntitySet<SafetyCompositionDet>("SafetyCompositionDet");

            builder.EntitySet<SafetyAccidental>("SafetyAccidental");
            builder.EntitySet<SafetyAid>("SafetyAid");
            builder.EntitySet<SafetyFire>("SafetyFire");
            builder.EntitySet<SafetyHandling>("SafetyHandling");
            builder.EntitySet<SafetyExposure>("SafetyExposure");
            builder.EntitySet<SafetyPhysical>("SafetyPhysical");
            builder.EntitySet<SafetyChemical>("SafetyChemical");
            builder.EntitySet<SafetyDisposal>("SafetyDisposal");
            builder.EntitySet<SafetyToxicity>("SafetyToxicity");
            builder.EntitySet<SafetyTransportation>("SafetyTransportation");

            builder.EntitySet<SafetyRegulatoy>("SafetyRegulatoy");
            builder.EntitySet<SafetyOther>("SafetyOther");
            builder.EntitySet<RiskGroup>("RiskGroup");
            builder.EntitySet<RiskCategory>("RiskCategory");

            builder.EntitySet<V_SupplierInfo>("V_SupplierInfo");

            builder.EntitySet<InternalPurchaseOrderMain>("InternalPurchaseOrderMain");
            builder.EntitySet<InternalPurchaseOrderDet>("InternalPurchaseOrderDet");
            builder.EntitySet<Labs>("Labs");

            //companyInfo
            builder.EntitySet<CompanyInfo>("CompanyInfo");


            //permission
            builder.EntitySet<WebPages>("WebPages");

            builder.EntitySet<WebPagesGroups>("WebPagesGroups");
            builder.EntitySet<webpagesUsers>("webpagesUsers");
            builder.EntitySet<V_webpagesUsers>("V_webpagesUsers");
            builder.EntitySet<WebPagesOperations>("WebPagesOperations");

            builder.EntitySet<v_WebPagesPermissions>("v_WebPagesPermissions");
            builder.EntitySet<V_WebPagesPermissionsDet>("V_WebPagesPermissionsDet");

            builder.EntitySet<WebPagesPermissions>("WebPagesPermissions");
            builder.EntitySet<WebPagesPermissionsDet>("WebPagesPermissionsDet");

            builder.EntitySet<v_FillWebPagesPermissions>("v_FillWebPagesPermissions");
            builder.EntitySet<V_WebpagesSignatures>("V_WebpagesSignatures");
            builder.EntitySet<WebpagesSignatures>("WebpagesSignatures");

            builder.EntitySet<V_Notification>("V_Notification");
            builder.EntitySet<Notification>("Notification");
            builder.EntitySet<V_NotificationLog>("V_NotificationLog");
            builder.EntitySet<NotificationLog>("NotificationLog");
            builder.EntitySet<V_WebMenuUser>("V_WebMenuUser");



            builder.EntitySet<Signatures>("Signatures");



            //RDM
            builder.EntitySet<RawMaterialEquation>("RawMaterialEquation");
            builder.EntitySet<Stability>("Stability");

            builder.EntitySet<V_RawMaterialEquation>("V_RawMaterialEquation");
            builder.EntitySet<V_Stability>("V_Stability");


            //CRM
            builder.EntitySet<V_ProductPackagingReady>("V_ProductPackagingReady");
            builder.EntitySet<CustomerCategory>("CustomerCategory");
            builder.EntitySet<Area>("Area");
            builder.EntitySet<City>("City");
            builder.EntitySet<CustomerClassification>("CustomerClassification");
            builder.EntitySet<PaymentMethod>("PaymentMethod");
            builder.EntitySet<V_Stock_Pmvts>("V_Stock_Pmvts");
            builder.EntitySet<V_VanInvoiceMain>("V_VanInvoiceMain");
            builder.EntitySet<V_VanInvoiceDetails>("V_VanInvoiceDetails");
            builder.EntitySet<VanInvoiceMain>("VanInvoiceMain");
            builder.EntitySet<VanInvoiceDetails>("VanInvoiceDetails");

            builder.EntitySet<Customer>("Customer");
            builder.EntitySet<CustomerContact>("CustomerContact");

            builder.EntitySet<v_customer>("v_customer");
            builder.EntitySet<V_CustomerContact>("V_CustomerContact");


            builder.EntitySet<Labels>("Labels");
            builder.EntitySet<LeadDealSource>("LeadDealSource");

            builder.EntitySet<LeadsAndDeals>("LeadsAndDeals");
            builder.EntitySet<LeadDealProducts>("LeadDealProducts");

            builder.EntitySet<V_LeadsAndDeals>("V_LeadsAndDeals");
            builder.EntitySet<V_LeadDealProducts>("V_LeadDealProducts");

            builder.EntitySet<ZVanSalesMain>("ZVanSalesMain");
            builder.EntitySet<ZVanSalesDetails>("ZVanSalesDetails");
            builder.EntitySet<ZVanSalesPayment>("ZVanSalesPayment");
            builder.EntitySet<ZVanSalesChecks>("ZVanSalesChecks");
            builder.EntitySet<ZVanSalesOrders>("ZVanSalesOrders");

            builder.EntitySet<V_ZVanSalesMain>("V_ZVanSalesMain");
            builder.EntitySet<V_ZVanSalesDetails>("V_ZVanSalesDetails");
            builder.EntitySet<V_ZVanSalesPayment>("V_ZVanSalesPayment");
            builder.EntitySet<V_ZVanSalesChecks>("V_ZVanSalesChecks");
            builder.EntitySet<V_ZVanSalesOrders>("V_ZVanSalesOrders");

            builder.EntitySet<V_ProductBatchDetails>("V_ProductBatchDetails");

            builder.EntitySet<V_BarcodeBatches>("V_BarcodeBatches");

            //Planning
            builder.EntitySet<MasterProductionSchedule>("MasterProductionSchedule");
            builder.EntitySet<MasterProductionScheduleDet>("MasterProductionScheduleDet");
            builder.EntitySet<V_MasterProductionSchedule>("V_MasterProductionSchedule");
            builder.EntitySet<V_MasterProductionScheduleDet>("V_MasterProductionScheduleDet");
            builder.EntitySet<V_MaterialInvoice>("V_MaterialInvoice");

            builder.EntitySet<MaterialRequirementsPlanning>("MaterialRequirementsPlanning");
            builder.EntitySet<V_MaterialRequirementsPlanning>("V_MaterialRequirementsPlanning");
            builder.EntitySet<MaterialRequirementsPlanningDet>("MaterialRequirementsPlanningDet");
            builder.EntitySet<V_MaterialRequirementsPlanningDet>("V_MaterialRequirementsPlanningDet");

            builder.EntitySet<WeeklyPlanMain>("WeeklyPlanMain");
            builder.EntitySet<WeeklyPlanDet>("WeeklyPlanDet");

            builder.EntitySet<V_WeeklyPlanMain>("V_WeeklyPlanMain");
            builder.EntitySet<V_WeeklyPlanDet>("V_WeeklyPlanDet");
            builder.EntitySet<V_voucherAccounts>("V_voucherAccounts");


            builder.EntitySet<LetterOfCredit>("LetterOfCredit");
            builder.EntitySet<LcDocs>("LcDocs");
            builder.EntitySet<V_LetterOfCredit>("V_LetterOfCredit");
            builder.EntitySet<V_LcDocs>("V_LcDocs");

            builder.EntitySet<StockAssignment>("StockAssignment");
            builder.EntitySet<V_StockAssignment>("V_StockAssignment");
            builder.EntitySet<V_StockAssignmentQty>("V_StockAssignmentQty");

            builder.EntitySet<CashBalance>("CashBalance");
            builder.EntitySet<CashBudget>("CashBudget");
            builder.EntitySet<CashBudgetItems>("CashBudgetItems");
            builder.EntitySet<CashInflows>("CashInflows");
            builder.EntitySet<CashOutflows>("CashOutflows");

            builder.EntitySet<Contracts>("Contracts");
            builder.EntitySet<ContractItems>("ContractItems");

            builder.EntitySet<LC_Type>("LC_Type");
            builder.EntitySet<lC_STATUS>("lC_STATUS");

            builder.EntitySet<CMvts>("CMvts");
            builder.EntitySet<CInvvoucher>("CInvvoucher");
            builder.EntitySet<V_Cmvts>("V_Cmvts");
            builder.EntitySet<V_Cinvvoucher>("V_Cinvvoucher");
            builder.EntitySet<PosOperations>("PosOperations");
            builder.EntitySet<PosOperators>("PosOperators");
            builder.EntitySet<PosOperatorsdet>("PosOperatorsdet");
            builder.EntitySet<LoginPos>("LoginPos");
            builder.EntitySet<LoginPosDet>("LoginPosDet");
            builder.EntitySet<V_CompanyInfo>("V_CompanyInfo");

            builder.EntitySet<PosAccountsPaymethod>("PosAccountsPaymethod");
            builder.EntitySet<PosInvoiceDetail>("PosInvoiceDetail");
            builder.EntitySet<PosInvoiceMain>("PosInvoiceMain");

            builder.EntitySet<PosPaidOut>("PosPaidOut");
            builder.EntitySet<PosPaidIn>("PosPaidIn");

            builder.EntitySet<PosVoucher>("PosVoucher");
            builder.EntitySet<PosVoucherDetails>("PosVoucherDetails");
            builder.EntitySet<PosVoidDetails>("PosVoidDetails");
            builder.EntitySet<V_ProductLine>("V_ProductLine");

            builder.EntitySet<V_ProductLine>("V_ProductLine");

            return builder.GetEdmModel();
        }
    }


}
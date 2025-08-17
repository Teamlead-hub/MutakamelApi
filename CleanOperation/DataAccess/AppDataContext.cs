using CleanBase;
using CleanBase.Entities;
using CleanOperation.Declarations;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Xml;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CleanOperation.DataAccess
{
    public class AppDataContext : DbContext
    {
        
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CleanConfiguration>().ToTable("CleanConfigurations");
            modelBuilder.Entity<CleanConfigurationItem>().ToTable("CleanConfigurationItems");


            modelBuilder.Entity<VouchersType>().ToTable("VouchersType");
            modelBuilder.Entity<InternalReview>().ToTable("InternalReview");

            modelBuilder.Entity<CostCenter>().ToTable("CostCenter");
            modelBuilder.Entity<v_AcGroups>().ToView("v_AcGroups");
            modelBuilder.Entity<AcGroups>().ToTable("AcGroups");
            modelBuilder.Entity<V_mvts_ProductOrderPackaging>().ToView("V_mvts_ProductOrderPackaging");


            modelBuilder.Entity<Vouchers>().ToTable("Vouchers");
            modelBuilder.Entity<Trans>().ToTable("Trans");
            modelBuilder.Entity<Trans>().HasOne(r => r.Vouchers).WithMany(t=>t.Trans).HasForeignKey(t => t.VouchersId).OnDelete(DeleteBehavior.Cascade);
           

            modelBuilder.Entity<V_Vouchers>().ToView("V_Vouchers");
            modelBuilder.Entity<V_Trans>().ToView("V_Trans");
            modelBuilder.Entity<V_Trans>().HasOne(r => r.Vouchers);

            modelBuilder.Entity<Currency>().ToTable("Currency");

            modelBuilder.Entity<PurchaseOrderMain>().ToTable("PurchaseOrderMain");


            modelBuilder.Entity<Invvoucher>().ToTable("INVVOUCHER");
            modelBuilder.Entity<Mvts>().ToTable("mvts");
            modelBuilder.Entity<Mvts>().HasOne(r=>r.InvVoucher).WithMany(i => i.Mvts).HasForeignKey(t => t.InvVoucherId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_invvoucher>().ToView("V_invvoucher");
            modelBuilder.Entity<V_mvts>().ToView("V_mvts");
            modelBuilder.Entity<V_mvts>().HasOne(r => r.InvVoucher);


            modelBuilder.Entity<Pinvvoucher>().ToTable("PINVVOUCHER");
            modelBuilder.Entity<Pmvts>().ToTable("Pmvts");
            modelBuilder.Entity<Pmvts>().HasOne(r => r.InvVoucher).WithMany(i => i.Mvts).HasForeignKey(t => t.InvVoucherId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_Pinvvoucher>().ToView("V_Pinvvoucher");
            modelBuilder.Entity<V_Pmvts>().ToView("V_Pmvts");
            modelBuilder.Entity<V_Pmvts>().HasOne(r => r.InvVoucher);

            modelBuilder.Entity<V_Pinvvoucher_Products>().ToView("V_Pinvvoucher_Products");
            modelBuilder.Entity<V_Pmvts_Products>().ToView("V_Pmvts_Products");
            modelBuilder.Entity<V_Pmvts_Products>().HasOne(r => r.InvVoucher);

            modelBuilder.Entity<V_PCustomerList>().ToView("V_PCustomerList");
            modelBuilder.Entity<V_PCustomerList>().HasOne(r => r.InvVoucher);

            modelBuilder.Entity<V_CustomersOrders>().ToView("CustomersOrders");
            modelBuilder.Entity<V_CustomersOrders>().HasOne(r => r.InvVoucher);

            modelBuilder.Entity<CustomersOrders>().ToTable("CustomersOrders");
            modelBuilder.Entity<CustomersOrders>().HasOne(r => r.InvVoucher).WithMany(i => i.CustomersOrders).HasForeignKey(t => t.InvVoucherId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ReceivingInvvoucher>().ToTable("ReceivingInvvoucher");
            modelBuilder.Entity<ReceivingMvts>().ToTable("ReceivingMvts");
            modelBuilder.Entity<ReceivingMvts>().HasOne(r => r.ReceivingInvvoucher).WithMany(i => i.Mvts).HasForeignKey(t => t.ReceivingInvvoucherId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_ReceivingInvvoucher>().ToView("V_ReceivingInvvoucher");
            modelBuilder.Entity<V_ReceivingMvts>().ToView("V_ReceivingMvts");
            modelBuilder.Entity<V_ReceivingMvts>().HasOne(r => r.ReceivingInvvoucher);

            modelBuilder.Entity<TrackingBatches>().ToTable("TrackingBatches");
            modelBuilder.Entity<TrackingBatchesDetails>().ToTable("TrackingBatchesDetails");
            modelBuilder.Entity<TrackingBatchesDetails>().HasOne(r => r.TrackingBatches).WithMany(i => i.TrackingBatchesDetails).HasForeignKey(t => t.TrackingBatchesId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<V_TrackingBatches>().ToView("V_TrackingBatches");
            modelBuilder.Entity<V_TrackingBatchesDetails>().ToView("V_TrackingBatchesDetails");
            modelBuilder.Entity<V_TrackingBatchesDetails>().HasOne(r => r.TrackingBatches);

            modelBuilder.Entity<V_Pmvts_Batches>().ToView("V_Pmvts_Batches");


            modelBuilder.Entity<V_StockMvts>().ToView("V_StockMvts");

            modelBuilder.Entity<Accounts>().ToTable("Accounts");
            modelBuilder.Entity<v_AcountsLevel>().ToView("v_AcountsLevel");
            modelBuilder.Entity<V_Accounts>().ToView("V_Accounts");

            modelBuilder.Entity<AccountsStatements>().ToTable("AccountsStatements");


            modelBuilder.Entity<ProcedureResultDto>().HasNoKey();
            modelBuilder.Entity<ProcedureResultListDto>().HasNoKey();

            modelBuilder.Entity<Stores>().ToTable("Stores");

            modelBuilder.Entity<V_SearchProductPackaging>().ToView("V_SearchProductPackaging");

            modelBuilder.Entity<PurchaseOrderMain>().ToTable("PurchaseOrderMain");
            modelBuilder.Entity<PurchaseOrderDetails>().ToTable("PurchaseOrderDetails");
            modelBuilder.Entity<PurchaseOrderDetails>().HasOne(r => r.PurchaseOrderMain).WithMany(i => i.PurchaseOrderDetails).HasForeignKey(t => t.PurchaseOrderMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_FrmPurchaseOrder>().ToView("V_FrmPurchaseOrder");
            modelBuilder.Entity<V_FrmPurchaseOrderDet>().ToView("V_FrmPurchaseOrderDet");
            modelBuilder.Entity<V_FrmPurchaseOrderDet>().HasOne(r => r.PurchaseOrderMain);

            modelBuilder.Entity<SalesOrderMain>().ToTable("SalesOrderMain");
            modelBuilder.Entity<SalesOrderDetails>().ToTable("SalesOrderDetails");
            modelBuilder.Entity<SalesOrderDetails>().HasOne(r => r.SalesOrderMain).WithMany(i => i.SalesOrderDetails).HasForeignKey(t => t.SalesOrderMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_SalesOrder>().ToView("V_SalesOrder");
            modelBuilder.Entity<V_SalesOrderDet>().ToView("V_SalesOrderDet");
            modelBuilder.Entity<V_SalesOrderDet>().HasOne(r => r.SalesOrderMain);
            //For Stored Procedure that will have only one column one row output

            ///Quality
            modelBuilder.Entity<SampletestMain>().ToTable("SampletestMain");
            modelBuilder.Entity<SampleTestDet>().ToTable("SampleTestDet");
            modelBuilder.Entity<SampleTestDet>().HasOne(r=>r.SampletestMain).WithMany(i => i.SampleTestDet).HasForeignKey(t => t.SampletestMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StockType>().ToTable("StockType");

            modelBuilder.Entity<LabTests>().ToTable("LabTests");
            modelBuilder.Entity<SpecificationLabTests>().ToTable("SpecificationLabTests");
            modelBuilder.Entity<SpecificationLabTests>().HasOne(r => r.Specifications).WithMany(i => i.SpecificationLabTests).HasForeignKey(t => t.SpecificationsId).OnDelete(DeleteBehavior.Cascade);
           
            modelBuilder.Entity<V_SpecificationLabTests>().ToView("V_SpecificationLabTests");
            modelBuilder.Entity<V_SpecificationLabTests>().HasOne(r => r.Specifications).WithMany(i => i.SpecificationLabTests).HasForeignKey(t => t.SpecificationsId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<LabTestResulte>().ToTable("LabTestResulte");

            modelBuilder.Entity<v_FillsampletestStock>().ToView("v_FillsampletestStock");
            modelBuilder.Entity<v_FillsampletestProduct>().ToView("v_FillsampletestProduct");

            modelBuilder.Entity<v_sampletestDet>().ToView("v_sampletestDet");
            modelBuilder.Entity<v_sampletestmain>().ToView("v_sampletestmain");
            modelBuilder.Entity<v_sampletestDet>().HasOne(r => r.SampletestMain);

            ///Quality

            modelBuilder.Entity<TestMethods>().ToTable("TestMethods");
            modelBuilder.Entity<Specifications>().ToTable("Specifications");
            modelBuilder.Entity<V_Specifications>().ToView("V_Specifications");
            modelBuilder.Entity<Suppliers>().ToTable("Suppliers");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<SubCategory>().ToTable("Subcategory");
            modelBuilder.Entity<V_SubCategory>().ToView("V_Subcategory");
            modelBuilder.Entity<Color>().ToTable("Color");
            modelBuilder.Entity<Perfume>().ToTable("Perfume");
            modelBuilder.Entity<Brands>().ToTable("Brands");
            modelBuilder.Entity<Factory>().ToTable("Factory");
            modelBuilder.Entity<Units>().ToTable("Units");
            modelBuilder.Entity<V_EmployeeProduction>().ToView("V_EmployeeProduction");
            modelBuilder.Entity<ProductLine>().ToTable("ProductLine");

            //Stock  

            //Tables
            //To Save, Update and Delete on the tables
            modelBuilder.Entity<Stock>().ToTable("stock");

            modelBuilder.Entity<StockSupplier>().ToTable("StockSupplier");
            modelBuilder.Entity<StockSupplier>().HasOne(r => r.Stock).WithMany(p => p.StockSupplier).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<StockSpec>().ToTable("StockSpec");
            modelBuilder.Entity<StockSpec>().HasOne(r => r.Stock).WithMany(p => p.StockSpec).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StockTest>().ToTable("StockTest");
            modelBuilder.Entity<StockTest>().HasOne(r => r.StockSpec).WithMany(p => p.StockTest).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StockDetails>().ToTable("StockDetails");



            //Views
            //To Get All from the views
            modelBuilder.Entity<V_stock>().ToView("V_stock");

            modelBuilder.Entity<V_StockSupplier>().ToView("V_StockSupplier");
            modelBuilder.Entity<V_StockSupplier>().HasOne(r => r.Stock);

            modelBuilder.Entity<V_StockSpec>().ToView("V_StockSpec");
            modelBuilder.Entity<V_StockSpec>().HasOne(r => r.Stock);

            modelBuilder.Entity<V_StockTest>().ToView("V_StockTest");
            modelBuilder.Entity<V_StockTest>().HasOne(r => r.StockSpec);

            modelBuilder.Entity<V_StockPurchase>().ToView("V_StockPurchase");
            modelBuilder.Entity<V_StockPurchase>().HasOne(r => r.Stock);

            modelBuilder.Entity<V_StockStore>().ToView("V_StockStore");
            modelBuilder.Entity<V_StockStore>().HasOne(r => r.Stock);

            modelBuilder.Entity<V_StockDetails>().ToView("V_StockDetails");

            modelBuilder.Entity<V_StockBatches>().ToView("V_StockBatches");
            modelBuilder.Entity<V_StockBatches>().HasOne(r => r.Stock);

            modelBuilder.Entity<V_StockDist>().ToView("V_StockDist");
            modelBuilder.Entity<V_StockDist>().HasOne(r => r.Stock);
            //Products 

            //Table
            //To Save, Update and Delete on the tables
            modelBuilder.Entity<Products>().ToTable("Products");

            modelBuilder.Entity<Productstest>().ToTable("Productstest");
            modelBuilder.Entity<Productstest>().HasOne(r => r.ProductSpecs).WithMany(p => p.Productstest).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductPackaging>().ToTable("ProductPackaging");
            modelBuilder.Entity<ProductPackaging>().HasOne(r => r.Product).WithMany(p => p.ProductPackaging).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductPackagingMaterial>().ToTable("ProductPackagingMaterial");
            modelBuilder.Entity<ProductPackagingMaterial>().HasOne(r => r.ProductPackaging).WithMany(p => p.ProductPackagingMaterial).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductSpecs>().ToTable("ProductSpecs");
            modelBuilder.Entity<ProductSpecs>().HasOne(r => r.Product).WithMany(p => p.ProductSpecs).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductsRaw>().ToTable("ProductsRaw");
            modelBuilder.Entity<ProductsRaw>().HasOne(r => r.Product).WithMany(p => p.ProductsRaw).OnDelete(DeleteBehavior.Cascade);

            //Views
            //To Get All from the views
            modelBuilder.Entity<V_Products>().ToView("V_Products");

            modelBuilder.Entity<V_Productstest>().ToView("V_Productstest");
            modelBuilder.Entity<V_Productstest>().HasOne(r => r.ProductSpecs);

            modelBuilder.Entity<V_ProductPackaging>().ToView("V_ProductPackaging");
            modelBuilder.Entity<V_ProductPackaging>().HasOne(r => r.Product);

            modelBuilder.Entity<V_ProductPackagingMaterial>().ToView("V_ProductPackagingMaterial");
            modelBuilder.Entity<V_ProductPackagingMaterial>().HasOne(r => r.ProductPackaging).WithMany(p => p.ProductPackagingMaterial).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_ProductSpecs>().ToView("V_ProductSpecs");
            modelBuilder.Entity<V_ProductSpecs>().HasOne(r => r.Product);
            
            modelBuilder.Entity<V_ProductsRaw>().ToView("V_ProductsRaw");
            modelBuilder.Entity<V_ProductsRaw>().HasOne(r => r.Product);

            modelBuilder.Entity<V_ProductBatches>().ToView("V_ProductBatches");
            modelBuilder.Entity<V_ProductBatches>().HasOne(r => r.Product);

            modelBuilder.Entity<V_ProductsStock_Raw>().ToView("V_ProductsStock_Raw");
            modelBuilder.Entity<V_ProductStock_Package>().ToView("V_ProductStock_Package");



            //Distributing Raw Materials To The Factory
            modelBuilder.Entity<V_InvStock_Raw>().ToView("V_InvStock_Raw");

            //Assets
            modelBuilder.Entity<Sections>().ToTable("Sections");
            modelBuilder.Entity<AssetStore>().ToTable("AssetStore");

            modelBuilder.Entity<V_Assets>().ToView("V_Assets");
            modelBuilder.Entity<Assets>().ToTable("Assets");
            modelBuilder.Entity<Assets>().Property(e => e.Id).HasDefaultValueSql("CONVERT( , abs(checksum(newid())))");

            modelBuilder.Entity<AssetsCat>().ToTable("AssetsCat");
            modelBuilder.Entity<V_AssetsDestruction>().ToView("V_AssetsDestruction");
            modelBuilder.Entity<AssetsDestruction>().ToTable("AssetsDestruction");
            modelBuilder.Entity<SubAssets>().ToTable("SubAssets");


            modelBuilder.Entity<V_SubAssets>().ToView("v_SubAssets");


            modelBuilder.Entity<SubAssetsTestMethodMain>().ToTable("SubAssetsTestMethodMain");
            modelBuilder.Entity<SubAssetsTestMethodMain>().HasOne(r => r.SubAssets).WithMany(t => t.SubAssetsTestMethodMain).HasForeignKey(t => t.SubAssetsId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<SubAssetsTestMethodSub>().ToTable("SubAssetsTestMethodSub");
            modelBuilder.Entity<SubAssetsTestMethodSub>().HasOne(r => r.SubAssetsTestMethodMain).WithMany(t => t.SubAssetsTestMethodSub).HasForeignKey(t => t.SubAssetsTestMethodMainId).OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<V_SubAssets>().ToView("V_SubAssets");

            modelBuilder.Entity<V_SubAssetsTestMethodMain>().ToView("V_SubAssetsTestMethodMain");
            modelBuilder.Entity<V_SubAssetsTestMethodSub>().ToView("V_SubAssetsTestMethodSub");



            modelBuilder.Entity<V_AssetsTransfer>().ToView("V_AssetsTransfer");
            modelBuilder.Entity<AssetsTransfer>().ToTable("AssetsTransfer");

            modelBuilder.Entity<V_Asset_Purchase>().ToView("V_Asset_Purchase");
            modelBuilder.Entity<V_Asset_PurchaseDet>().ToView("V_Asset_PurchaseDet");
            modelBuilder.Entity<V_Asset_PurchaseDet>().HasOne(r => r.Asset_Purchase);

            modelBuilder.Entity<Asset_Purchase>().ToTable("Asset_Purchase");
            modelBuilder.Entity<Asset_PurchaseDet>().ToTable("Asset_PurchaseDet");
            modelBuilder.Entity<Asset_PurchaseDet>().HasOne(r => r.Asset_Purchase);
            modelBuilder.Entity<Asset_PurchaseDet>().HasOne(r => r.Asset_Purchase).WithMany(t => t.PurchaseDet).HasForeignKey(t => t.Asset_PurchaseId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AssetDepreciation>().ToTable("V_AssetDepreciation");
            modelBuilder.Entity<V_AssetDepreciationDetails>().ToView("V_AssetDepreciationDetails");
            modelBuilder.Entity<V_AssetDepreciationDetails>().HasOne(r => r.AssetDepreciation).WithMany(t => t.Det).HasForeignKey(t => t.AssetDepreciationId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_FillAssetDep>().ToView("V_FillAssetDep");

            modelBuilder.Entity<AssetDepreciation>().ToTable("AssetDepreciation");
            modelBuilder.Entity<AssetDepreciationDetails>().ToTable("AssetDepreciationDetails");
            modelBuilder.Entity<AssetDepreciationDetails>().HasOne(r => r.AssetDepreciation).WithMany(t => t.Det).HasForeignKey(t => t.AssetDepreciationId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AssetsMethodDep>().ToTable("AssetsMethodDep");


            //Hr
            modelBuilder.Entity<Dept>().ToTable("Dept");
            modelBuilder.Entity<Nationality>().ToTable("Nationality");
            modelBuilder.Entity<Jobs>().ToTable("Jobs");
            modelBuilder.Entity<Banks>().ToTable("Banks");
            modelBuilder.Entity<PayAccounts>().ToTable("PayAccounts");
            modelBuilder.Entity<Allowance>().ToTable("Allowance");
            modelBuilder.Entity<HrSections>().ToTable("HrSections");
            modelBuilder.Entity<Qualification>().ToTable("Qualification");
            modelBuilder.Entity<DiscountType>().ToTable("DiscountType");
            modelBuilder.Entity<AssuranceItem>().ToTable("AssuranceItem");
            modelBuilder.Entity<HolidayType>().ToTable("HolidayType");
            modelBuilder.Entity<V_EmpAllowance>().ToView("V_EmpAllowance");
            modelBuilder.Entity<EmpAllowance>().ToTable("EmpAllowance");
            modelBuilder.Entity<V_Employees>().ToView("V_Employees");
            modelBuilder.Entity<V_EmpAllowance>().HasOne(r => r.Employees).WithMany(t => t.Allowance).HasForeignKey(t => t.EmployeeId);


            modelBuilder.Entity<Employees>().ToTable("Employees");
            modelBuilder.Entity<EmpAllowance>().HasOne(r => r.Employees).WithMany(t => t.Allowance).HasForeignKey(t => t.EmployeeId);


            modelBuilder.Entity<PayRollMain>().ToTable("PayRollMain");


            modelBuilder.Entity<V_OverTimeMain>().ToView("V_OverTimeMain");
            modelBuilder.Entity<V_OverTimeDetails>().ToView("V_OverTimeDetails");
            modelBuilder.Entity<V_OverTimeDetails>().HasOne(r => r.OvertimeMain).WithMany(m => m.Det);

            modelBuilder.Entity<OverTimeMain>().ToTable("OverTimeMain"); 
            modelBuilder.Entity<OverTimeDetails>().ToTable("OverTimeDetails");
            modelBuilder.Entity<OverTimeDetails>().HasOne(r => r.OvertimeMain).WithMany(m => m.Det).HasForeignKey(t => t.OvertimeMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_DiscountMain>().ToView("V_DiscountMain");
            modelBuilder.Entity<V_DiscountDetails>().ToView("V_DiscountDetails");
            modelBuilder.Entity<V_DiscountDetails>().HasOne(r => r.DiscountMain).WithMany(m => m.Det);

            modelBuilder.Entity<DiscountMain>().ToTable("DiscountMain");
            modelBuilder.Entity<DiscountDetails>().ToTable("DiscountDetails");
            modelBuilder.Entity<DiscountDetails>().HasOne(r => r.DiscountMain).WithMany(m => m.Det).HasForeignKey(t => t.DiscountMainId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<V_HolidayMain>().ToView("V_HolidayMain");
            modelBuilder.Entity<V_HolidayDetails>().ToView("V_HolidayDetails");
            modelBuilder.Entity<V_HolidayDetails>().HasOne(r => r.HolidayMain).WithMany(m => m.Det);

            modelBuilder.Entity<HolidayMain>().ToTable("HolidayMain");
            modelBuilder.Entity<HolidayDetails>().ToTable("HolidayDetails");
            modelBuilder.Entity<HolidayDetails>().HasOne(r => r.HolidayMain).WithMany(m => m.Det).HasForeignKey(t => t.HolidayMainId).OnDelete(DeleteBehavior.Cascade); 
            

            modelBuilder.Entity<V_LeavesMain>().ToView("V_LeavesMain");
            modelBuilder.Entity<V_LeavesDetails>().ToView("V_LeavesDetails");
            modelBuilder.Entity<V_LeavesDetails>().HasOne(r => r.LeavesMain).WithMany(m => m.Det);

            modelBuilder.Entity<LeavesMain>().ToTable("LeavesMain");
            modelBuilder.Entity<LeavesDetails>().ToTable("LeavesDetails");
            modelBuilder.Entity<LeavesDetails>().HasOne(r => r.LeavesMain).WithMany(m => m.Det).HasForeignKey(t => t.LeavesMainId).OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Emploans>().ToTable("Emploans");
   
            modelBuilder.Entity<V_IncrementMain>().ToView("V_IncrementMain");
            modelBuilder.Entity<V_IncrementDetails>().ToView("V_IncrementDetails");
            modelBuilder.Entity<V_IncrementDetails>().HasOne(r => r.IncrementMain).WithMany(m => m.Det);

            modelBuilder.Entity<IncrementMain>().ToTable("IncrementMain");
            modelBuilder.Entity<IncrementDetails>().ToTable("IncrementDetails");
            modelBuilder.Entity<IncrementDetails>().HasOne(r => r.IncrementMain).WithMany(m => m.Det).HasForeignKey(t => t.IncrementMainId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Emp_specializations>().ToTable("Emp_specializations");

            modelBuilder.Entity<V_PayRollMonthly>().ToView("V_PayRollMonthly");
            modelBuilder.Entity<PayRollMonthly>().ToTable("PayRollMonthly");
            modelBuilder.Entity<Payrollmonthlyallowance>().ToTable("Payrollmonthlyallowance");
            modelBuilder.Entity<V_Payrollmonthlyallowance>().ToView("V_Payrollmonthlyallowance");



            modelBuilder.Entity<EvaluationElements>().ToTable("EvaluationElements");
            modelBuilder.Entity<EvaluationMarks>().ToTable("EvaluationMarks");
            
            modelBuilder.Entity<V_LeavesRequest>().ToView("V_LeavesRequest");
            modelBuilder.Entity<LeavesRequest>().ToTable("LeavesRequest");
            modelBuilder.Entity<V_HolidayRequest>().ToView("V_HolidayRequest");
            modelBuilder.Entity<HolidayRequest>().ToTable("HolidayRequest");
            modelBuilder.Entity<V_SalaryIncreaseRequest>().ToView("V_SalaryIncreaseRequest");
            modelBuilder.Entity<SalaryIncreaseRequest>().ToTable("SalaryIncreaseRequest");

            modelBuilder.Entity<V_PerformanceEvaluation>().ToView("V_PerformanceEvaluation");
            modelBuilder.Entity<V_PerformanceEvaluationDet>().ToView("V_PerformanceEvaluationDet");
            modelBuilder.Entity<V_PerformanceEvaluationDet>().HasOne(r => r.PerformanceEvaluation).WithMany(m => m.Det);


            modelBuilder.Entity<PerformanceEvaluation>().ToTable("PerformanceEvaluation");
            modelBuilder.Entity<PerformanceEvaluationDet>().ToTable("PerformanceEvaluationDet");
            modelBuilder.Entity<PerformanceEvaluationDet>().HasOne(r => r.PerformanceEvaluation).WithMany(m => m.Det).HasForeignKey(t => t.PerformanceEvaluationId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FillEvaluationMarks>().ToView("Fill_Evaluation_Marks");
            

            //Production 
            modelBuilder.Entity<ProductOrder>().ToTable("ProductOrder");
            modelBuilder.Entity<ProductOrder>().ToTable("ProductOrder");

            modelBuilder.Entity<ProductOrderPackaging>().ToTable("ProductOrderPackaging");
            modelBuilder.Entity<ProductOrderPackaging>().HasOne(r => r.ProductOrder).WithMany(t => t.ProductOrderPackaging).HasForeignKey(t => t.ProductOrderId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductOrderPackingMaterial>().ToTable("ProductOrderPackingMaterial");
            modelBuilder.Entity<ProductOrderPackingMaterial>().HasOne(r => r.ProductOrderPackaging).WithMany(t => t.ProductOrderPackingMaterial).HasForeignKey(t => t.ProductOrderPackagingId).OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<ProductOrderRawMaterial>().ToTable("ProductOrderRawMaterial");
            modelBuilder.Entity<ProductOrderRawMaterial>().HasOne(r => r.ProductOrder).WithMany(t => t.ProductOrderRawMaterial).HasForeignKey(t => t.ProductOrderId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductOrderWages>().ToTable("ProductOrderWages");
            modelBuilder.Entity<ProductOrderWages>().HasOne(r => r.ProductOrder).WithMany(t => t.ProductOrderWages).HasForeignKey(t => t.ProductOrderId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<V_ProductOrder>().ToView("V_ProductOrder");


            modelBuilder.Entity<V_ProductOrderPackaging>().ToView("V_ProductOrderPackaging");
            modelBuilder.Entity<V_ProductOrderPackaging>().HasOne(r => r.ProductOrder).WithMany(t => t.ProductOrderPackaging).HasForeignKey(t => t.ProductOrderId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_ProductOrderPackingMaterial>().ToView("V_ProductOrderPackingMaterial");
            modelBuilder.Entity<V_ProductOrderPackingMaterial>().HasOne(r => r.ProductOrderPackaging).WithMany(p => p.ProductOrderPackingMaterial).HasForeignKey(t => t.ProductOrderPackagingId);

            modelBuilder.Entity<V_ProductOrderRawMaterial>().ToView("V_ProductOrderRawMaterial");
            modelBuilder.Entity<V_ProductOrderRawMaterial>().HasOne(r => r.ProductOrder);

            modelBuilder.Entity<V_ProductOrderWages>().ToView("V_ProductOrderWages");
            modelBuilder.Entity<V_ProductOrderWages>().HasOne(r => r.ProductOrder);


            
            modelBuilder.Entity<V_ProductOrder_InvVoucher>().ToView("V_ProductOrder_InvVoucher");
            modelBuilder.Entity<V_ProductOrder_mvts>().ToView("V_ProductOrder_mvts");
            modelBuilder.Entity<V_ProductOrder_mvts>().HasOne(r => r.InvVoucher);



            modelBuilder.Entity<V_ProductionConsumables>().ToView("V_ProductionConsumables");
            modelBuilder.Entity<ProductionConsumables>().ToTable("ProductionConsumables");


            modelBuilder.Entity<ProductOrderReport>().ToTable("ProductOrderReport"); 

            modelBuilder.Entity<ProductOrderReportRaw>().ToTable("ProductOrderReportRaw");
            modelBuilder.Entity<ProductOrderReportRaw>().HasOne(r => r.ProductOrderReport).WithMany(t => t.ProductOrderReportRaw).HasForeignKey(t => t.ProductOrderReportId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductOrderReportWages>().ToTable("ProductOrderReportWages");
            modelBuilder.Entity<ProductOrderReportWages>().HasOne(r => r.ProductOrderReport).WithMany(t => t.ProductOrderReportWages).HasForeignKey(t => t.ProductOrderReportId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductOrderReportPackaging>().ToTable("ProductOrderReportPackaging");
            modelBuilder.Entity<ProductOrderReportPackaging>().HasOne(r => r.ProductOrderReport).WithMany(t => t.ProductOrderReportPackaging).HasForeignKey(t => t.ProductOrderReportId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProductOrderReportConsumables>().ToTable("ProductOrderReportConsumables");
             modelBuilder.Entity<ProductOrderReportConsumables>().HasOne(r => r.ProductOrderReport).WithMany(t => t.ProductOrderReportConsumables).HasForeignKey(t => t.ProductOrderReportId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<ConsumableType>().ToTable("ConsumableType");



            modelBuilder.Entity<V_ProductOrderReport>().ToView("V_ProductOrderReport");

            modelBuilder.Entity<V_ProductOrderReportRaw>().ToView("V_ProductOrderReportRaw");
            modelBuilder.Entity<V_ProductOrderReportRaw>().HasOne(r => r.ProductOrderReport);

            modelBuilder.Entity<V_ProductOrderReportPackaging>().ToTable("V_ProductOrderReportPackaging");
            modelBuilder.Entity<V_ProductOrderReportPackaging>().HasOne(r => r.ProductOrderReport);

            modelBuilder.Entity<V_ProductOrderReportWages>().ToView("V_ProductOrderReportWages");
            modelBuilder.Entity<V_ProductOrderReportWages>().HasOne(r => r.ProductOrderReport);

            modelBuilder.Entity<V_ProductOrderReportConsumables>().ToView("V_ProductOrderReportConsumables");
            modelBuilder.Entity<V_ProductOrderReportConsumables>().HasOne(r => r.ProductOrderReport);





            modelBuilder.Entity<SupplierInfo>().ToTable("SupplierInfo");
            modelBuilder.Entity<SupContractInfo>().ToTable("SupContractInfo").HasOne(c => c.SupplierInfo).WithMany(c => c.SupContractInfo).HasForeignKey(c => c.SupplierInfoId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<SupContactInfo>().ToTable("SupContactInfo").HasOne(c => c.SupplierInfo).WithMany(c => c.SupContactInfo).HasForeignKey(c => c.SupplierInfoId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<SupComplaintInfo>().ToTable("SupComplaintInfo");

            modelBuilder.Entity<SupEvaluationInfo>().ToTable("SupEvaluationInfo").HasOne(e => e.SupplierInfo).WithMany(s => s.SupEvaluationInfo).HasForeignKey(e => e.SupplierInfoId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_ProductOrderReportPackaging>().ToView("V_ProductOrderReportPackaging");
            modelBuilder.Entity<V_ProductOrderReportPackaging>().HasOne(r => r.ProductOrderReport);



            //Maintenance
            modelBuilder.Entity<MaintenanceType>().ToTable("MaintenanceType");
            modelBuilder.Entity<MaintenanceTestMethodMain>().ToTable("MaintenanceTestMethodMain");
            modelBuilder.Entity<V_MaintenanceTestMethodsub>().ToView("V_MaintenanceTestMethodsub");
            modelBuilder.Entity<MaintenanceTestMethodsub>().ToTable("MaintenanceTestMethodsub");
            modelBuilder.Entity<MaintenanceTestMethodsub>().HasOne(r => r.MaintenanceTestMethodMain).WithMany(m => m.MaintenanceTestMethodSub).HasForeignKey(t => t.MaintenanceTestMethodMainId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<MaintenanceFrequency>().ToTable("MaintenanceFrequency");
            modelBuilder.Entity<MaintinancePriorities>().ToTable("MaintinancePriorities");
            modelBuilder.Entity<MaintenanceFaults>().ToTable("MaintenanceFaults");
            modelBuilder.Entity<MaintenanceAgencies>().ToTable("MaintenanceAgencies");

            modelBuilder.Entity<V_MaintenanceAssetsMain>().ToView("V_MaintenanceAssetsMain");
            modelBuilder.Entity<V_MaintenanceAssetsDet>().ToView("V_MaintenanceAssetsDet");
            modelBuilder.Entity<V_MaintenanceAssetsDet>().HasOne(r => r.MaintenanceAssetsMain);

            modelBuilder.Entity<MaintenanceAssetsMain>().ToTable("MaintenanceAssetsMain");
            modelBuilder.Entity<MaintenanceAssetsDet>().ToTable("MaintenanceAssetsDet");
            modelBuilder.Entity<MaintenanceAssetsDet>().HasOne(r => r.MaintenanceAssetsMain).WithMany(m => m.Det).HasForeignKey(t => t.MaintenanceAssetsMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_MaintenanceTestsMain>().ToView("V_MaintenanceTestsMain");
            modelBuilder.Entity<V_MaintenanceTestsDet>().ToView("V_MaintenanceTestsDet");
            modelBuilder.Entity<V_MaintenanceTestsDet>().HasOne(r => r.MaintenanceTestsMain);

            modelBuilder.Entity<MaintenanceTestsMain>().ToTable("MaintenanceTestsMain");
            modelBuilder.Entity<MaintenanceTestsDet>().ToTable("MaintenanceTestsDet");
            modelBuilder.Entity<MaintenanceTestsDet>().HasOne(r => r.MaintenanceTestsMain).WithMany(m => m.Det).HasForeignKey(t => t.MaintenanceTestsMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<v_FillMaintenanceTestMethod>().ToView("v_FillMaintenanceTestMethod");
            modelBuilder.Entity<v_Maintenance_employees>().ToView("v_Maintenance_employees");

            modelBuilder.Entity<V_MaintenanceRequestMain>().ToView("V_MaintenanceRequestMain");
            modelBuilder.Entity<V_MaintenanceRequestDet>().ToView("V_MaintenanceRequestDet");
            modelBuilder.Entity<V_MaintenanceRequestDet>().HasOne(r => r.MaintenanceRequestMain);

            modelBuilder.Entity<MaintenanceRequestMain>().ToTable("MaintenanceRequestMain");
            modelBuilder.Entity<MaintenanceRequestDet>().ToTable("MaintenanceRequestDet");
            modelBuilder.Entity<MaintenanceRequestDet>().HasOne(r => r.MaintenanceRequestMain).WithMany(m => m.Det).HasForeignKey(t => t.MaintenanceRequestMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_MaintenanceReports>().ToView("V_MaintenanceReports");
            modelBuilder.Entity<MaintenanceReports>().ToTable("MaintenanceReports");

         

            modelBuilder.Entity<DeviationMain>().ToTable("DeviationMain");
            modelBuilder.Entity<DeviationDet>().ToTable("DeviationDet");

            modelBuilder.Entity<Catalyst>().ToTable("Catalyst");
            modelBuilder.Entity<ProductWithdrawal>().ToTable("ProductWithdrawal");


            modelBuilder.Entity<QuarantineMain>().ToTable("QuarantineMain");
            modelBuilder.Entity<QuarantineDet>().ToTable("QuarantineDet");
            modelBuilder.Entity<QuarantineDet>().HasOne(r => r.QuarantineMain).WithMany(i => i.QuarantineDet).HasForeignKey(t => t.QuarantineMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_QuarantineMain>().ToView("V_QuarantineMain");
            modelBuilder.Entity<V_QuarantineDet>().ToView("V_QuarantineDet");
            modelBuilder.Entity<V_QuarantineDet>().HasOne(r => r.QuarantineMain);


            //safety
            modelBuilder.Entity<SafetyDef>().ToTable("SafetyDef");
            modelBuilder.Entity<SafetyRisk>().ToTable("SafetyRisk");
            modelBuilder.Entity<SafetyRiskDet>().ToTable("SafetyRiskDet");
            modelBuilder.Entity<SafetyRiskDet>().HasOne(r => r.SafetyRisk).WithMany(i => i.SafetyRiskDet).HasForeignKey(t => t.SafetyRiskId).OnDelete(DeleteBehavior.Cascade);
           
            modelBuilder.Entity<SafetyComposition>().ToTable("SafetyComposition");
            modelBuilder.Entity<SafetyCompositionDet>().ToTable("SafetyCompositionDet");
            modelBuilder.Entity<SafetyCompositionDet>().HasOne(r => r.SafetyComposition).WithMany(i => i.SafetyCompositionDet).HasForeignKey(t => t.SafetyCompositionId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SafetyAid>().ToTable("SafetyAid");
            modelBuilder.Entity<SafetyFire>().ToTable("SafetyFire");
            modelBuilder.Entity<SafetyAccidental>().ToTable("SafetyAccidental");
            modelBuilder.Entity<SafetyHandling>().ToTable("SafetyHandling");
            modelBuilder.Entity<SafetyExposure>().ToTable("SafetyExposure");
            modelBuilder.Entity<SafetyPhysical>().ToTable("SafetyPhysical");
            modelBuilder.Entity<SafetyChemical>().ToTable("SafetyChemical");
            modelBuilder.Entity<SafetyDisposal>().ToTable("SafetyDisposal");
            modelBuilder.Entity<SafetyTransportation>().ToTable("SafetyTransportation");
            modelBuilder.Entity<SafetyRegulatoy>().ToTable("SafetyRegulatoy");
            modelBuilder.Entity<SafetyOther>().ToTable("SafetyOther");
            modelBuilder.Entity<SafetyToxicity>().ToTable("SafetyToxicity");
            modelBuilder.Entity<V_SupplierInfo>().ToView("V_SupplierInfo");

            modelBuilder.Entity<InternalPurchaseOrderMain>().ToTable("InternalPurchaseOrderMain");
            modelBuilder.Entity<InternalPurchaseOrderDet>().ToTable("InternalPurchaseOrderDet");
            modelBuilder.Entity<InternalPurchaseOrderDet>().HasOne(r => r.InternalPurchaseOrderMain).WithMany(i => i.InternalPurchaseOrderDet).HasForeignKey(t => t.InternalPurchaseOrderMainId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Labs>().ToTable("Labs");


            modelBuilder.Entity<RiskGroup>().ToTable("RiskGroup");
            modelBuilder.Entity<RiskCategory>().ToTable("RiskCategory");
            modelBuilder.Entity<RiskCategory>().HasOne(r => r.RiskGroup).WithMany(i => i.RiskCategory).HasForeignKey(t => t.RiskGroupId).OnDelete(DeleteBehavior.Cascade);


            //CompanyInfo
            modelBuilder.Entity<CompanyInfo>().ToTable("CompanyInfo");


            //permission
            modelBuilder.Entity<WebPages>().ToTable("WebPages");

            modelBuilder.Entity<WebPagesGroups>().ToTable("WebPagesGroups");
            modelBuilder.Entity<webpagesUsers>().ToTable("webpagesUsers");
            modelBuilder.Entity<V_webpagesUsers>().ToTable("V_webpagesUsers");
            modelBuilder.Entity<WebPagesOperations>().ToTable("WebPagesOperations");

            modelBuilder.Entity<v_WebPagesPermissions>().ToView("v_WebPagesPermissions");
            modelBuilder.Entity<V_WebPagesPermissionsDet>().ToView("V_WebPagesPermissionsDet");
            modelBuilder.Entity<V_WebPagesPermissionsDet>().HasOne(r => r.WebPagesPermissions);

            modelBuilder.Entity<WebPagesPermissions>().ToTable("WebPagesPermissions");
            modelBuilder.Entity<WebPagesPermissionsDet>().ToTable("WebPagesPermissionsDet");
            modelBuilder.Entity<WebPagesPermissionsDet>().HasOne(r => r.WebPagesPermissions).WithMany(t => t.Det).HasForeignKey(t => t.WebPagesPermissionsId).OnDelete(DeleteBehavior.Cascade);

         
            modelBuilder.Entity<v_FillWebPagesPermissions>().ToView("v_FillWebPagesPermissions");

            modelBuilder.Entity<V_Notification>().ToView("V_Notification");
            modelBuilder.Entity<Notification>().ToTable("Notification");

            modelBuilder.Entity<V_NotificationLog>().ToView("V_NotificationLog");
            modelBuilder.Entity<NotificationLog>().ToTable("NotificationLog");

            modelBuilder.Entity<V_WebMenuUser>().ToView("V_WebMenuUser");



            modelBuilder.Entity<V_WebpagesSignatures>().ToView("V_WebpagesSignatures");
            modelBuilder.Entity<V_WebpagesSignatures>().HasOne(r => r.WebPagesPermissions);

            modelBuilder.Entity<WebpagesSignatures>().ToTable("WebpagesSignatures");
            modelBuilder.Entity<WebpagesSignatures>().HasOne(r => r.WebPagesPermissions).WithMany(t => t.Sig).HasForeignKey(t => t.WebPagesPermissionsId).OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Signatures>().ToTable("Signatures");


            //RDM
            modelBuilder.Entity<RawMaterialEquation>().ToTable("RawMaterialEquation");
            modelBuilder.Entity<Stability>().ToTable("Stability");

            modelBuilder.Entity<V_RawMaterialEquation>().ToView("V_RawMaterialEquation");
            modelBuilder.Entity<V_Stability>().ToView("V_Stability");



            //CRM
            
            modelBuilder.Entity<V_ProductPackagingReady>().ToView("V_ProductPackagingReady");
            modelBuilder.Entity<CustomerCategory>().ToTable("CustomerCategory");

            modelBuilder.Entity<CustomerCategory>().Property(e => e.Id).HasDefaultValueSql("CONVERT( , abs(checksum(newid())))");

            modelBuilder.Entity<Area>().ToTable("Area");

            modelBuilder.Entity<Area>().Property(e => e.Id).HasDefaultValueSql("CONVERT( , abs(checksum(newid())))");

            modelBuilder.Entity<City>().ToTable("City");

            modelBuilder.Entity<City>().Property(e => e.Id).HasDefaultValueSql("CONVERT( , abs(checksum(newid())))");

            modelBuilder.Entity<CustomerClassification>().ToTable("CustomerClassification");

            modelBuilder.Entity<CustomerClassification>().Property(e => e.Id).HasDefaultValueSql("CONVERT( , abs(checksum(newid())))");

            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");

            modelBuilder.Entity<PaymentMethod>().Property(e => e.Id).HasDefaultValueSql("CONVERT( , abs(checksum(newid())))");

            modelBuilder.Entity<V_Stock_Pmvts>().ToView("V_Stock_Pmvts");

            modelBuilder.Entity<V_VanInvoiceMain>().ToView("V_VanInvoiceMain");
            modelBuilder.Entity<V_VanInvoiceDetails>().ToView("V_VanInvoiceDetails");


            modelBuilder.Entity<VanInvoiceMain>().ToTable("VanInvoiceMain");
            modelBuilder.Entity<VanInvoiceDetails>().ToTable("VanInvoiceDetails");
            modelBuilder.Entity<VanInvoiceDetails>().HasOne(r => r.VanInvoiceMain).WithMany(t => t.VanInvoiceDetails).HasForeignKey(t => t.VanInvoiceMainId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Labels>().ToTable("Labels");
            modelBuilder.Entity<LeadDealSource>().ToTable("LeadDealSource");


            modelBuilder.Entity<LeadsAndDeals>().ToTable("LeadsAndDeals");
            modelBuilder.Entity<LeadDealProducts>().ToTable("LeadDealProducts");
            modelBuilder.Entity<LeadDealProducts>().HasOne(t=>t.LeadsAndDeals).WithMany(t => t.LeadDealProducts).HasForeignKey(t=>t.LeadsAndDealsId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_LeadsAndDeals>().ToView("V_LeadsAndDeals");
            modelBuilder.Entity<V_LeadDealProducts>().ToView("V_LeadDealProducts");


            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>().Property(e => e.Id).HasDefaultValueSql("CONVERT( , abs(checksum(newid())))");

            modelBuilder.Entity<CustomerContact>().ToTable("CustomerContact");
            modelBuilder.Entity<CustomerContact>().HasOne(r=>r.Customer).WithMany(t=>t.CustomerContact).HasForeignKey(t=> t.CustomerId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<v_customer>().ToView("v_customer");
            modelBuilder.Entity<V_CustomerContact>().ToView("V_CustomerContact");
            modelBuilder.Entity<V_CustomerContact>().HasOne(r => r.Customer).WithMany(t => t.CustomerContact).HasForeignKey(t => t.CustomerId).OnDelete(DeleteBehavior.Cascade);

           


            modelBuilder.Entity<ZVanSalesMain>().ToTable("ZVanSalesMain");
            modelBuilder.Entity<ZVanSalesDetails>().ToTable("ZVanSalesDetails");
            modelBuilder.Entity<ZVanSalesDetails>().HasOne(r => r.ZVanSalesMain).WithMany(t => t.ItemsDetails).HasForeignKey(t => t.ZVanSalesMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ZVanSalesPayment>().ToTable("ZVanSalesPayment");
            modelBuilder.Entity<ZVanSalesPayment>().HasOne(r => r.ZVanSalesMain).WithMany(t => t.Payments).HasForeignKey(t => t.ZVanSalesMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ZVanSalesChecks>().ToTable("ZVanSalesChecks");
            modelBuilder.Entity<ZVanSalesChecks>().HasOne(r => r.ZVanSalesPayment).WithMany(t => t.Checks).HasForeignKey(t => t.ZVanSalesPaymentId).OnDelete(DeleteBehavior.Cascade);
           
            modelBuilder.Entity<ZVanSalesOrders>().ToTable("ZVanSalesOrders");
            modelBuilder.Entity<ZVanSalesOrders>().HasOne(r => r.ZVanSalesMain).WithMany(t => t.SalesOrders).HasForeignKey(t => t.ZVanSalesMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_ZVanSalesMain>().ToView("V_ZVanSalesMain");
            modelBuilder.Entity<V_ZVanSalesDetails>().ToView("V_ZVanSalesDetails");
            modelBuilder.Entity<V_ZVanSalesPayment>().ToView("V_ZVanSalesPayment");
            modelBuilder.Entity<V_ZVanSalesChecks>().ToView("V_ZVanSalesChecks");
            modelBuilder.Entity<V_ZVanSalesOrders>().ToView("V_ZVanSalesOrders");

            modelBuilder.Entity<V_BarcodeBatches>().ToView("V_BarcodeBatches");

            modelBuilder.Entity<V_ProductBatchDetails>().ToView("V_ProductBatchDetails");



            //Planning 

            modelBuilder.Entity<MasterProductionSchedule>().ToTable("MasterProductionSchedule");
            modelBuilder.Entity<MasterProductionScheduleDet>().ToTable("MasterProductionScheduleDet");
            modelBuilder.Entity<MasterProductionScheduleDet>().HasOne(r => r.MasterProductionSchedule).WithMany(t => t.MasterProductionScheduleDet).HasForeignKey(t => t.MasterProductionScheduleId).OnDelete(DeleteBehavior.Cascade);
           
            modelBuilder.Entity<V_MasterProductionSchedule>().ToView("V_MasterProductionSchedule");
            modelBuilder.Entity<V_MasterProductionScheduleDet>().ToView("V_MasterProductionScheduleDet");
            modelBuilder.Entity<V_MasterProductionScheduleDet>().HasOne(r => r.MasterProductionSchedule).WithMany(t => t.MasterProductionScheduleDet).HasForeignKey(t => t.MasterProductionScheduleId).OnDelete(DeleteBehavior.Cascade);
         
            modelBuilder.Entity<V_MaterialInvoice>().ToView("V_MaterialInvoice");

            modelBuilder.Entity<MaterialRequirementsPlanning>().ToTable("MaterialRequirementsPlanning");
            modelBuilder.Entity<MaterialRequirementsPlanningDet>().ToTable("MaterialRequirementsPlanningDet");
            modelBuilder.Entity<MaterialRequirementsPlanningDet>().HasOne(r => r.MaterialRequirementsPlanning).WithMany(t => t.MaterialRequirementsPlanningDet).HasForeignKey(t => t.MaterialRequirementsPlanningId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_MaterialRequirementsPlanning>().ToView("V_MaterialRequirementsPlanning");
            modelBuilder.Entity<V_MaterialRequirementsPlanningDet>().ToView("V_MaterialRequirementsPlanningDet");
            modelBuilder.Entity<V_MaterialRequirementsPlanningDet>().HasOne(r => r.MaterialRequirementsPlanning).WithMany(t => t.MaterialRequirementsPlanningDet).HasForeignKey(t => t.MaterialRequirementsPlanningId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<WeeklyPlanMain>().ToTable("WeeklyPlanMain");
            modelBuilder.Entity<WeeklyPlanDet>().ToTable("WeeklyPlanDet");
            modelBuilder.Entity<WeeklyPlanDet>().HasOne(r => r.WeeklyPlanMain).WithMany(t => t.WeeklyPlanDet).HasForeignKey(t => t.WeeklyPlanMainId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<V_WeeklyPlanMain>().ToView("V_WeeklyPlanMain");
            modelBuilder.Entity<V_WeeklyPlanDet>().ToView("V_WeeklyPlanDet");
            modelBuilder.Entity<V_WeeklyPlanDet>().HasOne(r => r.WeeklyPlanMain).WithMany(t => t.WeeklyPlanDet).HasForeignKey(t => t.WeeklyPlanMainId).OnDelete(DeleteBehavior.Cascade);


            EntityPropertyMapper(modelBuilder);

        }
     
        private void EntityPropertyMapper(ModelBuilder modelBuilder)
        {

            IEnumerable<string> entityProperties = typeof(EntityRoot).GetProperties().Select(propInfo => propInfo.Name);

            IEnumerable<IMutableEntityType> mappedEntities = modelBuilder.Model.GetEntityTypes().Where(y => y.ClrType.BaseType.Name.Contains(nameof(EntityRoot))).ToList();


            foreach (IMutableEntityType entity in mappedEntities)
            {
                EntityTypeBuilder entityTypeBuilder = modelBuilder.Entity(entity.ClrType);
                entityTypeBuilder.Property(nameof(EntityRoot.Id)).ValueGeneratedOnAdd();
                entityTypeBuilder.Property(nameof(EntityRoot.Rowversion)).IsConcurrencyToken();
                entityTypeBuilder.Property(nameof(EntityRoot.Rowversion)).ValueGeneratedOnAddOrUpdate();
            }
        }
   
    }
}

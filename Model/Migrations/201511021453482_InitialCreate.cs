namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.T_Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        SenderName = c.String(),
                        SenderTel = c.String(),
                        CustomerName = c.String(),
                        Tel = c.String(),
                        Address = c.String(),
                        TransID = c.Int(nullable: false),
                        TransName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.T_Goods",
                c => new
                    {
                        BillID = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        SenderName = c.String(),
                        SenderTel = c.String(),
                        ReceiverName = c.String(),
                        ReceiverTel = c.String(),
                        ReceiverAddress = c.String(),
                        GoodsType = c.Int(),
                        Measure = c.Single(),
                        Amount = c.Int(),
                        PackingType = c.Int(),
                        Price = c.Int(),
                        ChinaPrice = c.Int(),
                        PackingPrice = c.Int(),
                        InsurancePrice = c.Int(),
                        SumPrice = c.Int(),
                        RecorderID = c.Int(),
                        RecordTime = c.DateTime(),
                        TransCompID = c.Int(),
                        TransCompName = c.String(),
                        TransBill = c.String(),
                        TransTime = c.DateTime(),
                        TransRecoderID = c.Int(),
                        ModifyTime = c.DateTime(),
                        StoreID = c.Int(),
                        PriceType = c.Int(),
                        Status = c.String(),
                        PayType = c.Int(nullable: false),
                        Remark = c.String(),
                        GoodsName = c.String(),
                        BillFee = c.Int()
                    })
                .PrimaryKey(t => t.BillID);
            
            CreateTable(
                "dbo.T_GoodsTrans",
                c => new
                    {
                        BillID = c.String(nullable: false, maxLength: 128),
                        RecorderID = c.Int(),
                        RecordTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.BillID);
            
            CreateTable(
                "dbo.T_GoodsTransDetail",
                c => new
                    {
                        BillID = c.String(nullable: false, maxLength: 128),
                        GoodsID = c.String(nullable: false, maxLength: 128),
                        GoodsStatu = c.String(),
                        ReceiverID = c.Int(),
                        ReceiveTime = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.BillID, t.GoodsID });
            
            CreateTable(
                "dbo.T_GoodsType",
                c => new
                    {
                        GoodsTypeID = c.Int(nullable: false, identity: true),
                        GoodsTypeName = c.String(),
                    })
                .PrimaryKey(t => t.GoodsTypeID);
            
            CreateTable(
                "dbo.T_Log",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OperID = c.Int(nullable: false),
                        OperTime = c.DateTime(nullable: false),
                        Operation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.T_PackingType",
                c => new
                    {
                        PackingTypeID = c.Int(nullable: false, identity: true),
                        PackingTypeName = c.String(),
                    })
                .PrimaryKey(t => t.PackingTypeID);
            
            CreateTable(
                "dbo.T_PayType",
                c => new
                    {
                        PayID = c.Int(nullable: false, identity: true),
                        PayName = c.String(),
                    })
                .PrimaryKey(t => t.PayID);
            
            CreateTable(
                "dbo.T_PriceInfo",
                c => new
                    {
                        PriceID = c.Int(nullable: false, identity: true),
                        PriceName = c.String(),
                        UnitPrice = c.Int(),
                    })
                .PrimaryKey(t => t.PriceID);
            
            CreateTable(
                "dbo.T_Role",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.T_Status",
                c => new
                    {
                        StatusID = c.String(nullable: false, maxLength: 128),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.T_Store",
                c => new
                    {
                        StoreID = c.Int(nullable: false, identity: true),
                        StoreName = c.String(),
                    })
                .PrimaryKey(t => t.StoreID);
            
            CreateTable(
                "dbo.T_TransCompany",
                c => new
                    {
                        TransCompanyID = c.Int(nullable: false, identity: true),
                        TransCompanyName = c.String(),
                        TransCompanyCode = c.String(),
                        BillLength = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransCompanyID);
            
            CreateTable(
                "dbo.T_TransToKM",
                c => new
                    {
                        BillID = c.String(nullable: false, maxLength: 128),
                        RecorderID = c.Int(),
                        RecordTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.BillID);
            
            CreateTable(
                "dbo.T_TransToKMDetail",
                c => new
                    {
                        BillID = c.String(nullable: false, maxLength: 128),
                        GoodsID = c.String(nullable: false, maxLength: 128),
                        GoodsStatu = c.String(),
                        ReceiverID = c.Int(),
                        ReceiveTime = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.BillID, t.GoodsID });

            CreateTable(
                "dbo.T_Users",
                c => new
                {
                    UserID = c.Int(nullable: false, identity: true),
                    UserName = c.String(),
                    LoginName = c.String(),
                    Password = c.String(),
                    Status = c.String(),
                    RoleID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.UserID);

            CreateTable(
                "dbo.T_TransRecord",
                c => new
                {
                    BillID = c.String(),
                    Seq = c.Int(),
                    OperTime = c.DateTime(),
                    OperAction = c.String(),
                })
                .PrimaryKey(t => new
                {
                    t.Seq
                });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.T_Users");
            DropTable("dbo.T_TransToKMDetail");
            DropTable("dbo.T_TransToKM");
            DropTable("dbo.T_TransCompany");
            DropTable("dbo.T_Store");
            DropTable("dbo.T_Status");
            DropTable("dbo.T_Role");
            DropTable("dbo.T_PriceInfo");
            DropTable("dbo.T_PayType");
            DropTable("dbo.T_PackingType");
            DropTable("dbo.T_Log");
            DropTable("dbo.T_GoodsType");
            DropTable("dbo.T_GoodsTransDetail");
            DropTable("dbo.T_GoodsTrans");
            DropTable("dbo.T_Goods");
            DropTable("dbo.T_Customer");
            DropTable("dbo.T_TransRecord");
        }
    }
}

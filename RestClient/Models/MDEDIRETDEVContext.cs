using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestApiClient.Models
{
    public partial class MDEDIRETDEVContext : DbContext
    {
        public virtual DbSet<CusttypeXref> CusttypeXref { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderHeader> OrderHeader { get; set; }
        public virtual DbSet<OrderLineNotes> OrderLineNotes { get; set; }
        public virtual DbSet<OrderNotes> OrderNotes { get; set; }
        public virtual DbSet<ShiploadDetail> ShiploadDetail { get; set; }
        public virtual DbSet<ShiploadMove> ShiploadMove { get; set; }
        public virtual DbSet<ShiploadOrd> ShiploadOrd { get; set; }
        public virtual DbSet<ShiploadOrdlin> ShiploadOrdlin { get; set; }
        public virtual DbSet<ShiploadParcel> ShiploadParcel { get; set; }
        public virtual DbSet<ShiploadSerial> ShiploadSerial { get; set; }
        public virtual DbSet<ShiploadShipment> ShiploadShipment { get; set; }
        public virtual DbSet<ShiploadStop> ShiploadStop { get; set; }
        public virtual DbSet<TocustXref> TocustXref { get; set; }

        // Unable to generate entity type for table 'dbo.Client_ID_XREF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ESCALADE_CSV_ORDER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CARCOD_XREF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ClientList_XREF'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ErrorTable'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=mdlsql02;Database=MDEDIRETDEV;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CusttypeXref>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.SoldtoCustno });

                entity.ToTable("CUSTTYPE_XREF");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.SoldtoCustno)
                    .HasColumnName("SOLDTO_CUSTNO")
                    .HasMaxLength(30);

                entity.Property(e => e.Btcust)
                    .HasColumnName("BTCUST")
                    .HasMaxLength(25);

                entity.Property(e => e.Carrier)
                    .HasColumnName("CARRIER")
                    .HasMaxLength(25);

                entity.Property(e => e.CarrierWb)
                    .HasColumnName("CARRIER_WB")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasColumnName("CREATE_BY")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_name())");

                entity.Property(e => e.CreateDte)
                    .HasColumnName("CREATE_DTE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Custtype)
                    .IsRequired()
                    .HasColumnName("CUSTTYPE")
                    .HasMaxLength(25);

                entity.Property(e => e.DaysToAdd)
                    .HasColumnName("DAYS_TO_ADD")
                    .HasColumnType("numeric(15, 5)");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("MODIFY_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDte)
                    .HasColumnName("MODIFY_DTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrdType)
                    .HasColumnName("ORD_TYPE")
                    .HasMaxLength(25);

                entity.Property(e => e.Payterm)
                    .HasColumnName("PAYTERM")
                    .HasMaxLength(25);

                entity.Property(e => e.PaytermWb)
                    .HasColumnName("PAYTERM_WB")
                    .HasMaxLength(25);

                entity.Property(e => e.RpCustype)
                    .IsRequired()
                    .HasColumnName("RP_CUSTYPE")
                    .HasMaxLength(25);

                entity.Property(e => e.Srvlvl)
                    .HasColumnName("SRVLVL")
                    .HasMaxLength(25);

                entity.Property(e => e.SrvlvlWb)
                    .HasColumnName("SRVLVL_WB")
                    .HasMaxLength(25);

                entity.Property(e => e.WaveFlg)
                    .HasColumnName("WAVE_FLG")
                    .HasMaxLength(1);

                entity.Property(e => e.WeightBreak)
                    .HasColumnName("WEIGHT_BREAK")
                    .HasColumnType("numeric(15, 5)");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Ordnum, e.Ordlin });

                entity.ToTable("ORDER_DETAIL");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ORDNUM")
                    .HasMaxLength(35);

                entity.Property(e => e.Ordlin).HasColumnName("ORDLIN");

                entity.Property(e => e.BinLoc)
                    .HasColumnName("BIN_LOC")
                    .HasMaxLength(25);

                entity.Property(e => e.BulkLoc)
                    .HasColumnName("BULK_LOC")
                    .HasMaxLength(25);

                entity.Property(e => e.Carcod)
                    .HasColumnName("CARCOD")
                    .HasMaxLength(10);

                entity.Property(e => e.CaseCount).HasColumnName("CASE_COUNT");

                entity.Property(e => e.CreateDte)
                    .HasColumnName("CREATE_DTE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustLinenum)
                    .HasColumnName("CUST_LINENUM")
                    .HasMaxLength(25);

                entity.Property(e => e.DpciNum)
                    .HasColumnName("DPCI_NUM")
                    .HasMaxLength(50);

                entity.Property(e => e.FreightClassCode)
                    .HasColumnName("FREIGHT_CLASS_CODE")
                    .HasMaxLength(5);

                entity.Property(e => e.ItemDesc)
                    .HasColumnName("ITEM_DESC")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderPrice).HasColumnName("ORDER_PRICE");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.RetailItemCode)
                    .HasColumnName("RETAIL_ITEM_CODE")
                    .HasMaxLength(48);

                entity.Property(e => e.SalesPrice).HasColumnName("SALES_PRICE");

                entity.Property(e => e.ServOpt)
                    .HasColumnName("SERV_OPT")
                    .HasMaxLength(25);

                entity.Property(e => e.ShippingCost).HasColumnName("SHIPPING_COST");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(48);

                entity.Property(e => e.Tax).HasColumnName("TAX");

                entity.Property(e => e.TcNum)
                    .HasColumnName("TC_NUM")
                    .HasMaxLength(25);

                entity.Property(e => e.TotalPrice).HasColumnName("TOTAL_PRICE");

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(2);

                entity.Property(e => e.UpcCasecode)
                    .HasColumnName("UPC_CASECODE")
                    .HasMaxLength(12);

                entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Ordnum });

                entity.ToTable("ORDER_HEADER");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ORDNUM")
                    .HasMaxLength(35);

                entity.Property(e => e.AclxDcnum)
                    .HasColumnName("ACLX_DCNUM")
                    .HasMaxLength(40);

                entity.Property(e => e.BAddr1)
                    .HasColumnName("B_ADDR1")
                    .HasMaxLength(55);

                entity.Property(e => e.BAddr2)
                    .HasColumnName("B_ADDR2")
                    .HasMaxLength(55);

                entity.Property(e => e.BCity)
                    .HasColumnName("B_CITY")
                    .HasMaxLength(30);

                entity.Property(e => e.BCountry)
                    .HasColumnName("B_COUNTRY")
                    .HasMaxLength(3);

                entity.Property(e => e.BName)
                    .HasColumnName("B_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.BState)
                    .HasColumnName("B_STATE")
                    .HasMaxLength(2);

                entity.Property(e => e.BZip)
                    .HasColumnName("B_ZIP")
                    .HasMaxLength(15);

                entity.Property(e => e.ContTel)
                    .HasColumnName("CONT_TEL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("CREATE_DTE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeptNo)
                    .HasColumnName("DEPT_NO")
                    .HasMaxLength(25);

                entity.Property(e => e.OrderType)
                    .HasColumnName("ORDER_TYPE")
                    .HasMaxLength(25);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("PAYMENT_TYPE")
                    .HasMaxLength(80);

                entity.Property(e => e.PoNum)
                    .HasColumnName("PO_NUM")
                    .HasMaxLength(30);

                entity.Property(e => e.ReadyForRp).HasColumnName("READY_FOR_RP");

                entity.Property(e => e.RequestShipDate)
                    .HasColumnName("REQUEST_SHIP_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnName("REQUESTED_DELIVERY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Rsaflag).HasColumnName("RSAFLAG");

                entity.Property(e => e.RushFlg).HasColumnName("RUSH_FLG");

                entity.Property(e => e.SAddr1)
                    .HasColumnName("S_ADDR1")
                    .HasMaxLength(55);

                entity.Property(e => e.SAddr2)
                    .HasColumnName("S_ADDR2")
                    .HasMaxLength(55);

                entity.Property(e => e.SCity)
                    .HasColumnName("S_CITY")
                    .HasMaxLength(30);

                entity.Property(e => e.SCountry)
                    .HasColumnName("S_COUNTRY")
                    .HasMaxLength(3);

                entity.Property(e => e.SName)
                    .HasColumnName("S_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.SState)
                    .HasColumnName("S_STATE")
                    .HasMaxLength(2);

                entity.Property(e => e.SZip)
                    .HasColumnName("S_ZIP")
                    .HasMaxLength(15);

                entity.Property(e => e.SalesOrdnum)
                    .HasColumnName("SALES_ORDNUM")
                    .HasMaxLength(50);

                entity.Property(e => e.SentToRp).HasColumnName("SENT_TO_RP");

                entity.Property(e => e.ServiceLvl)
                    .HasColumnName("SERVICE_LVL")
                    .HasMaxLength(25);

                entity.Property(e => e.ShiptoCustno)
                    .HasColumnName("SHIPTO_CUSTNO")
                    .HasMaxLength(30);

                entity.Property(e => e.SoldtoCustno)
                    .HasColumnName("SOLDTO_CUSTNO")
                    .HasMaxLength(30);

                entity.Property(e => e.StoreName)
                    .HasColumnName("STORE_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.StoreNum)
                    .HasColumnName("STORE_NUM")
                    .HasMaxLength(25);

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("TOTAL_PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.TransBillMethod)
                    .HasColumnName("TRANS_BILL_METHOD")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OrderLineNotes>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Ordnum, e.Ordlin, e.Nottyp, e.Notlin });

                entity.ToTable("ORDER_LINE_NOTES");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ORDNUM")
                    .HasMaxLength(35);

                entity.Property(e => e.Ordlin).HasColumnName("ORDLIN");

                entity.Property(e => e.Nottyp)
                    .HasColumnName("NOTTYP")
                    .HasMaxLength(3);

                entity.Property(e => e.Notlin)
                    .HasColumnName("NOTLIN")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("CREATE_DTE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nottxt)
                    .HasColumnName("NOTTXT")
                    .HasMaxLength(160);
            });

            modelBuilder.Entity<OrderNotes>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Ordnum, e.Nottyp, e.Notlin });

                entity.ToTable("ORDER_NOTES");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ORDNUM")
                    .HasMaxLength(35);

                entity.Property(e => e.Nottyp)
                    .HasColumnName("NOTTYP")
                    .HasMaxLength(3);

                entity.Property(e => e.Notlin)
                    .HasColumnName("NOTLIN")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("CREATE_DTE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nottxt)
                    .HasColumnName("NOTTXT")
                    .HasMaxLength(160);
            });

            modelBuilder.Entity<ShiploadDetail>(entity =>
            {
                entity.HasKey(e => e.Dtlnum);

                entity.ToTable("SHIPLOAD_DETAIL");

                entity.Property(e => e.Dtlnum)
                    .HasColumnName("DTLNUM")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssetTyp)
                    .HasColumnName("ASSET_TYP")
                    .HasMaxLength(30);

                entity.Property(e => e.CatchQty).HasColumnName("CATCH_QTY");

                entity.Property(e => e.CatchUnttyp)
                    .HasColumnName("CATCH_UNTTYP")
                    .HasMaxLength(30);

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("create_dte")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DistroId)
                    .HasColumnName("DISTRO_ID")
                    .HasMaxLength(35);

                entity.Property(e => e.HostClientId)
                    .HasColumnName("HOST_CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.HostShipId)
                    .HasColumnName("HOST_SHIP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.Hstacc)
                    .HasColumnName("HSTACC")
                    .HasMaxLength(30);

                entity.Property(e => e.Invsts)
                    .HasColumnName("INVSTS")
                    .HasMaxLength(4);

                entity.Property(e => e.Lodnum)
                    .HasColumnName("LODNUM")
                    .HasMaxLength(30);

                entity.Property(e => e.Lodtag)
                    .HasColumnName("LODTAG")
                    .HasMaxLength(40);

                entity.Property(e => e.Loducc)
                    .HasColumnName("LODUCC")
                    .HasMaxLength(20);

                entity.Property(e => e.Lodurn)
                    .HasColumnName("LODURN")
                    .HasMaxLength(60);

                entity.Property(e => e.Lotnum)
                    .HasColumnName("LOTNUM")
                    .HasMaxLength(25);

                entity.Property(e => e.Ordlin)
                    .HasColumnName("ORDLIN")
                    .HasMaxLength(4);

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ORDNUM")
                    .HasMaxLength(35);

                entity.Property(e => e.Ordsln)
                    .HasColumnName("ORDSLN")
                    .HasMaxLength(4);

                entity.Property(e => e.Orgcod)
                    .HasColumnName("ORGCOD")
                    .HasMaxLength(25);

                entity.Property(e => e.PrtClientId)
                    .IsRequired()
                    .HasColumnName("PRT_CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Prtnum)
                    .IsRequired()
                    .HasColumnName("PRTNUM")
                    .HasMaxLength(30);

                entity.Property(e => e.Revlvl)
                    .HasColumnName("REVLVL")
                    .HasMaxLength(25);

                entity.Property(e => e.ShipId)
                    .IsRequired()
                    .HasColumnName("SHIP_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.SourceDistroId)
                    .HasColumnName("SOURCE_DISTRO_ID")
                    .HasMaxLength(35);

                entity.Property(e => e.SubAssetTyp)
                    .HasColumnName("SUB_ASSET_TYP")
                    .HasMaxLength(30);

                entity.Property(e => e.Subnum)
                    .HasColumnName("SUBNUM")
                    .HasMaxLength(30);

                entity.Property(e => e.Subtag)
                    .HasColumnName("SUBTAG")
                    .HasMaxLength(40);

                entity.Property(e => e.Subucc)
                    .HasColumnName("SUBUCC")
                    .HasMaxLength(20);

                entity.Property(e => e.Suburn)
                    .HasColumnName("SUBURN")
                    .HasMaxLength(60);

                entity.Property(e => e.Supnum)
                    .HasColumnName("SUPNUM")
                    .HasMaxLength(32);

                entity.Property(e => e.Untcas).HasColumnName("UNTCAS");

                entity.Property(e => e.Untpak).HasColumnName("UNTPAK");

                entity.Property(e => e.Untqty).HasColumnName("UNTQTY");

                entity.Property(e => e.VcExpdat)
                    .HasColumnName("VC_EXPDAT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VcGrossWgt).HasColumnName("VC_GROSS_WGT");

                entity.Property(e => e.VcMfgDt)
                    .HasColumnName("VC_MFG_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VcNetWgt).HasColumnName("VC_NET_WGT");
            });

            modelBuilder.Entity<ShiploadMove>(entity =>
            {
                entity.HasKey(e => e.CarMoveId);

                entity.ToTable("SHIPLOAD_MOVE");

                entity.Property(e => e.CarMoveId)
                    .HasColumnName("CAR_MOVE_ID")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Carcod)
                    .HasColumnName("CARCOD")
                    .HasMaxLength(10);

                entity.Property(e => e.Carnam)
                    .HasColumnName("CARNAM")
                    .HasMaxLength(30);

                entity.Property(e => e.CloseDte)
                    .HasColumnName("CLOSE_DTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateDte)
                    .HasColumnName("create_dte")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DispatchDte)
                    .HasColumnName("DISPATCH_DTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DriveLic)
                    .HasColumnName("DRIVE_LIC")
                    .HasMaxLength(40);

                entity.Property(e => e.DriveName)
                    .HasColumnName("DRIVE_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.HostClientId)
                    .HasColumnName("HOST_CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.HostMoveId)
                    .HasColumnName("HOST_MOVE_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.MoveDocnum)
                    .HasColumnName("MOVE_DOCNUM")
                    .HasMaxLength(20);

                entity.Property(e => e.MoveTrackNum)
                    .HasColumnName("MOVE_TRACK_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.PendDte)
                    .HasColumnName("PEND_DTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Scac)
                    .HasColumnName("SCAC")
                    .HasMaxLength(10);

                entity.Property(e => e.Sitcod)
                    .HasColumnName("SITCOD")
                    .HasMaxLength(4);

                entity.Property(e => e.TrlrBroker)
                    .HasColumnName("TRLR_BROKER")
                    .HasMaxLength(20);

                entity.Property(e => e.TrlrId)
                    .HasColumnName("TRLR_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.TrlrNum)
                    .HasColumnName("TRLR_NUM")
                    .HasMaxLength(10);

                entity.Property(e => e.TrlrSeal1)
                    .HasColumnName("TRLR_SEAL1")
                    .HasMaxLength(20);

                entity.Property(e => e.TrlrSeal2)
                    .HasColumnName("TRLR_SEAL2")
                    .HasMaxLength(20);

                entity.Property(e => e.TrlrSeal3)
                    .HasColumnName("TRLR_SEAL3")
                    .HasMaxLength(20);

                entity.Property(e => e.TrlrSeal4)
                    .HasColumnName("TRLR_SEAL4")
                    .HasMaxLength(20);

                entity.Property(e => e.TrlrSize)
                    .HasColumnName("TRLR_SIZE")
                    .HasMaxLength(20);

                entity.Property(e => e.TrlrTyp)
                    .HasColumnName("TRLR_TYP")
                    .HasMaxLength(4);

                entity.Property(e => e.Trndte)
                    .HasColumnName("TRNDTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Trnnum)
                    .HasColumnName("TRNNUM")
                    .HasMaxLength(20);

                entity.Property(e => e.VcWhName)
                    .HasColumnName("VC_WH_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.WhId)
                    .HasColumnName("WH_ID")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ShiploadOrd>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Ordnum, e.ShipId });

                entity.ToTable("SHIPLOAD_ORD");

                entity.HasIndex(e => new { e.ClientId, e.Ordnum, e.SendShipConfirm, e.ShipConfirmSent })
                    .HasName("IX_shipload_ord_flag");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ORDNUM")
                    .HasMaxLength(35);

                entity.Property(e => e.ShipId)
                    .HasColumnName("SHIP_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.AclxBolNum)
                    .HasColumnName("ACLX_BOL_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.AclxDcnum)
                    .HasColumnName("ACLX_DCNUM")
                    .HasMaxLength(40);

                entity.Property(e => e.AclxFrtrte).HasColumnName("ACLX_FRTRTE");

                entity.Property(e => e.AclxMstBolNum)
                    .HasColumnName("ACLX_MST_BOL_NUM")
                    .HasMaxLength(25);

                entity.Property(e => e.AclxOrdConsId)
                    .HasColumnName("ACLX_ORD_CONS_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.AclxStore)
                    .HasColumnName("ACLX_STORE")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Asnsent).HasColumnName("ASNSent");

                entity.Property(e => e.Btcust)
                    .HasColumnName("BTCUST")
                    .HasMaxLength(20);

                entity.Property(e => e.Cponum)
                    .HasColumnName("CPONUM")
                    .HasMaxLength(30);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("create_dte")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Entdte)
                    .HasColumnName("ENTDTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.HostApptNum)
                    .HasColumnName("HOST_APPT_NUM")
                    .HasMaxLength(40);

                entity.Property(e => e.HostShipId)
                    .HasColumnName("HOST_SHIP_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.Ordtyp)
                    .HasColumnName("ORDTYP")
                    .HasMaxLength(4);

                entity.Property(e => e.Reffld1)
                    .HasColumnName("REFFLD_1")
                    .HasMaxLength(40);

                entity.Property(e => e.Reffld2)
                    .HasColumnName("REFFLD_2")
                    .HasMaxLength(40);

                entity.Property(e => e.Reffld3)
                    .HasColumnName("REFFLD_3")
                    .HasMaxLength(40);

                entity.Property(e => e.Reffld4)
                    .HasColumnName("REFFLD_4")
                    .HasMaxLength(40);

                entity.Property(e => e.Reffld5)
                    .HasColumnName("REFFLD_5")
                    .HasMaxLength(40);

                entity.Property(e => e.Rtcust)
                    .HasColumnName("RTCUST")
                    .HasMaxLength(20);

                entity.Property(e => e.SendAsn).HasColumnName("SendASN");

                entity.Property(e => e.Stcust)
                    .HasColumnName("STCUST")
                    .HasMaxLength(20);

                entity.Property(e => e.UcCarMoveId)
                    .HasColumnName("UC_CAR_MOVE_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.UcOrdNetWgt)
                    .HasColumnName("UC_ORD_NET_WGT")
                    .HasMaxLength(25);

                entity.Property(e => e.VcAdrcty)
                    .HasColumnName("VC_ADRCTY")
                    .HasMaxLength(30);

                entity.Property(e => e.VcAdrpsz)
                    .HasColumnName("VC_ADRPSZ")
                    .HasMaxLength(20);

                entity.Property(e => e.VcAdrstc)
                    .HasColumnName("VC_ADRSTC")
                    .HasMaxLength(40);

                entity.Property(e => e.VcChepQty).HasColumnName("VC_CHEP_QTY");

                entity.Property(e => e.VcCtryName)
                    .HasColumnName("VC_CTRY_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.VcFld1)
                    .HasColumnName("VC_FLD1")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld10)
                    .HasColumnName("VC_FLD10")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld11)
                    .HasColumnName("VC_FLD11")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld12)
                    .HasColumnName("VC_FLD12")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld13)
                    .HasColumnName("VC_FLD13")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld14)
                    .HasColumnName("VC_FLD14")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld15)
                    .HasColumnName("VC_FLD15")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld2)
                    .HasColumnName("VC_FLD2")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld3)
                    .HasColumnName("VC_FLD3")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld4)
                    .HasColumnName("VC_FLD4")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld5)
                    .HasColumnName("VC_FLD5")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld6)
                    .HasColumnName("VC_FLD6")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld7)
                    .HasColumnName("VC_FLD7")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld8)
                    .HasColumnName("VC_FLD8")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld9)
                    .HasColumnName("VC_FLD9")
                    .HasMaxLength(60);

                entity.Property(e => e.VcNonChepQty).HasColumnName("VC_NON_CHEP_QTY");

                entity.Property(e => e.VcOrdPackCnt).HasColumnName("VC_ORD_PACK_CNT");

                entity.Property(e => e.VcShipToAddr1)
                    .HasColumnName("VC_SHIP_TO_ADDR1")
                    .HasMaxLength(40);

                entity.Property(e => e.VcShipToAddr2)
                    .HasColumnName("VC_SHIP_TO_ADDR2")
                    .HasMaxLength(40);

                entity.Property(e => e.VcShipToName)
                    .HasColumnName("VC_SHIP_TO_NAME")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<ShiploadOrdlin>(entity =>
            {
                entity.HasKey(e => new { e.OrdClientId, e.Ordlin, e.Ordnum, e.ShipId, e.ShipLineId, e.Ordsln });

                entity.ToTable("SHIPLOAD_ORDLIN");

                entity.Property(e => e.OrdClientId)
                    .HasColumnName("ORD_CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Ordlin)
                    .HasColumnName("ORDLIN")
                    .HasMaxLength(4);

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ORDNUM")
                    .HasMaxLength(35);

                entity.Property(e => e.ShipId)
                    .HasColumnName("SHIP_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipLineId)
                    .HasColumnName("SHIP_LINE_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.Ordsln)
                    .HasColumnName("ORDSLN")
                    .HasMaxLength(4);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("create_dte")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deptno)
                    .HasColumnName("DEPTNO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DistroId)
                    .HasColumnName("DISTRO_ID")
                    .HasMaxLength(35);

                entity.Property(e => e.HostOrdqty).HasColumnName("HOST_ORDQTY");

                entity.Property(e => e.Hstacc)
                    .HasColumnName("HSTACC")
                    .HasMaxLength(30);

                entity.Property(e => e.Invsts)
                    .HasColumnName("INVSTS")
                    .HasMaxLength(4);

                entity.Property(e => e.InvstsPrg)
                    .HasColumnName("INVSTS_PRG")
                    .HasMaxLength(4);

                entity.Property(e => e.NonAlcFlg)
                    .HasColumnName("NON_ALC_FLG")
                    .HasMaxLength(1);

                entity.Property(e => e.OrderedLineQty).HasColumnName("ORDERED_LINE_QTY");

                entity.Property(e => e.PartNum)
                    .HasColumnName("PART_NUM")
                    .HasMaxLength(30);

                entity.Property(e => e.Paytrm)
                    .HasColumnName("PAYTRM")
                    .HasMaxLength(30);

                entity.Property(e => e.Reffld1)
                    .HasColumnName("REFFLD_1")
                    .HasMaxLength(40);

                entity.Property(e => e.Reffld2)
                    .HasColumnName("REFFLD_2")
                    .HasMaxLength(40);

                entity.Property(e => e.Reffld3)
                    .HasColumnName("REFFLD_3")
                    .HasMaxLength(40);

                entity.Property(e => e.Reffld4)
                    .HasColumnName("REFFLD_4")
                    .HasMaxLength(40);

                entity.Property(e => e.Reffld5)
                    .HasColumnName("REFFLD_5")
                    .HasMaxLength(40);

                entity.Property(e => e.RequestedSupnum)
                    .HasColumnName("REQUESTED_SUPNUM")
                    .HasMaxLength(32);

                entity.Property(e => e.SalesOrdNum)
                    .HasColumnName("SALES_ORD_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesOrdlin)
                    .HasColumnName("SALES_ORDLIN")
                    .HasMaxLength(4);

                entity.Property(e => e.ShipmentLineQty).HasColumnName("SHIPMENT_LINE_QTY");

                entity.Property(e => e.ShpQty).HasColumnName("SHP_QTY");

                entity.Property(e => e.SourceDistroId)
                    .HasColumnName("SOURCE_DISTRO_ID")
                    .HasMaxLength(35);

                entity.Property(e => e.Stkuom)
                    .HasColumnName("STKUOM")
                    .HasMaxLength(2);

                entity.Property(e => e.UcUpcCs)
                    .HasColumnName("UC_UPC_CS")
                    .HasMaxLength(50);

                entity.Property(e => e.UcUpcEa)
                    .HasColumnName("UC_UPC_EA")
                    .HasMaxLength(50);

                entity.Property(e => e.VcFld1)
                    .HasColumnName("VC_FLD1")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld10)
                    .HasColumnName("VC_FLD10")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld11)
                    .HasColumnName("VC_FLD11")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld12)
                    .HasColumnName("VC_FLD12")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld13)
                    .HasColumnName("VC_FLD13")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld14)
                    .HasColumnName("VC_FLD14")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld15)
                    .HasColumnName("VC_FLD15")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld2)
                    .HasColumnName("VC_FLD2")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld3)
                    .HasColumnName("VC_FLD3")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld4)
                    .HasColumnName("VC_FLD4")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld5)
                    .HasColumnName("VC_FLD5")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld6)
                    .HasColumnName("VC_FLD6")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld7)
                    .HasColumnName("VC_FLD7")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld8)
                    .HasColumnName("VC_FLD8")
                    .HasMaxLength(60);

                entity.Property(e => e.VcFld9)
                    .HasColumnName("VC_FLD9")
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<ShiploadParcel>(entity =>
            {
                entity.HasKey(e => new { e.Crtnid, e.Ordnum, e.Subnum });

                entity.ToTable("SHIPLOAD_PARCEL");

                entity.Property(e => e.Crtnid)
                    .HasColumnName("CRTNID")
                    .HasMaxLength(30);

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ORDNUM")
                    .HasMaxLength(35);

                entity.Property(e => e.Subnum)
                    .HasColumnName("SUBNUM")
                    .HasMaxLength(30);

                entity.Property(e => e.Carcod)
                    .HasColumnName("CARCOD")
                    .HasMaxLength(10);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("create_dte")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dstnam)
                    .HasColumnName("DSTNAM")
                    .HasMaxLength(30);

                entity.Property(e => e.Frtrte)
                    .HasColumnName("FRTRTE")
                    .HasMaxLength(19);

                entity.Property(e => e.Lodnum)
                    .HasColumnName("LODNUM")
                    .HasMaxLength(30);

                entity.Property(e => e.Mfstid)
                    .HasColumnName("MFSTID")
                    .HasMaxLength(20);

                entity.Property(e => e.Mstdte)
                    .HasColumnName("MSTDTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrtClientId)
                    .HasColumnName("PRT_CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Prtnum)
                    .HasColumnName("PRTNUM")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipId)
                    .IsRequired()
                    .HasColumnName("SHIP_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.Srvlvl)
                    .HasColumnName("SRVLVL")
                    .HasMaxLength(10);

                entity.Property(e => e.Traknm)
                    .HasColumnName("TRAKNM")
                    .HasMaxLength(30);

                entity.Property(e => e.UcSapmaterial)
                    .HasColumnName("uc_sapmaterial")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Usrfld1)
                    .HasColumnName("USRFLD1")
                    .HasMaxLength(250);

                entity.Property(e => e.Usrfld2)
                    .HasColumnName("USRFLD2")
                    .HasMaxLength(250);

                entity.Property(e => e.Usrfld3)
                    .HasColumnName("USRFLD3")
                    .HasMaxLength(250);

                entity.Property(e => e.Usrfld4)
                    .HasColumnName("USRFLD4")
                    .HasMaxLength(250);

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasMaxLength(19);
            });

            modelBuilder.Entity<ShiploadSerial>(entity =>
            {
                entity.HasKey(e => new { e.SerNum, e.SerNumTypId, e.Invtid });

                entity.ToTable("SHIPLOAD_SERIAL");

                entity.Property(e => e.SerNum)
                    .HasColumnName("SER_NUM")
                    .HasMaxLength(40);

                entity.Property(e => e.SerNumTypId)
                    .HasColumnName("SER_NUM_TYP_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.Invtid)
                    .HasColumnName("INVTID")
                    .HasMaxLength(30);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(35);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("create_dte")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ordnum)
                    .HasColumnName("ordnum")
                    .HasMaxLength(35);

                entity.Property(e => e.PrtClientId)
                    .HasColumnName("PRT_CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Prtnum)
                    .HasColumnName("PRTNUM")
                    .HasMaxLength(30);

                entity.Property(e => e.SerLvl)
                    .HasColumnName("SER_LVL")
                    .HasMaxLength(1);

                entity.Property(e => e.ShipId)
                    .HasColumnName("SHIP_ID")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ShiploadShipment>(entity =>
            {
                entity.HasKey(e => e.ShipId);

                entity.ToTable("SHIPLOAD_SHIPMENT");

                entity.Property(e => e.ShipId)
                    .HasColumnName("SHIP_ID")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.AesAcptDte)
                    .HasColumnName("AES_ACPT_DTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.AesTyp)
                    .HasColumnName("AES_TYP")
                    .HasMaxLength(10);

                entity.Property(e => e.Aesitn)
                    .HasColumnName("AESITN")
                    .HasMaxLength(40);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("create_dte")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EarlyDevDt)
                    .HasColumnName("EARLY_DEV_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.EarlyShpDt)
                    .HasColumnName("EARLY_SHP_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrghtChrg)
                    .HasColumnName("FRGHT_CHRG")
                    .HasMaxLength(1);

                entity.Property(e => e.FrghtRate)
                    .HasColumnName("FRGHT_RATE")
                    .HasMaxLength(19);

                entity.Property(e => e.Frtcod)
                    .HasColumnName("FRTCOD")
                    .HasMaxLength(6);

                entity.Property(e => e.Ftsrnum)
                    .HasColumnName("FTSRNUM")
                    .HasMaxLength(40);

                entity.Property(e => e.HostShipId)
                    .HasColumnName("HOST_SHIP_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.LateDevDt)
                    .HasColumnName("LATE_DEV_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.LateShpDt)
                    .HasColumnName("LATE_SHP_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipClientId)
                    .HasColumnName("SHIP_CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.ShipDocNum)
                    .HasColumnName("SHIP_DOC_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipTrackNum)
                    .HasColumnName("SHIP_TRACK_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.SrcHost)
                    .HasColumnName("SRC_HOST")
                    .HasMaxLength(100);

                entity.Property(e => e.SrcPort)
                    .HasColumnName("SRC_PORT")
                    .HasMaxLength(10);

                entity.Property(e => e.Srvlvl)
                    .HasColumnName("SRVLVL")
                    .HasMaxLength(10);

                entity.Property(e => e.UcStopId)
                    .HasColumnName("UC_STOP_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.WhId)
                    .HasColumnName("WH_ID")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ShiploadStop>(entity =>
            {
                entity.HasKey(e => e.StopId);

                entity.ToTable("SHIPLOAD_STOP");

                entity.Property(e => e.StopId)
                    .HasColumnName("STOP_ID")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AdressId)
                    .HasColumnName("ADRESS_ID")
                    .HasMaxLength(20);

                entity.Property(e => e.CarMoveId)
                    .HasColumnName("CAR_MOVE_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.CreateDte)
                    .HasColumnName("create_dte")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Docnum)
                    .HasColumnName("DOCNUM")
                    .HasMaxLength(20);

                entity.Property(e => e.HostAdrId)
                    .HasColumnName("HOST_ADR_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.StopSeq).HasColumnName("STOP_SEQ");

                entity.Property(e => e.TrackNum)
                    .HasColumnName("TRACK_NUM")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TocustXref>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.Carcod, e.Custtype });

                entity.ToTable("TOCUST_XREF");

                entity.Property(e => e.ClientId)
                    .HasColumnName("CLIENT_ID")
                    .HasMaxLength(32);

                entity.Property(e => e.Carcod)
                    .HasColumnName("CARCOD")
                    .HasMaxLength(25);

                entity.Property(e => e.Custtype)
                    .HasColumnName("CUSTTYPE")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasColumnName("CREATE_BY")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(suser_name())");

                entity.Property(e => e.CreateDte)
                    .HasColumnName("CREATE_DTE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("MODIFY_BY")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyDte)
                    .HasColumnName("MODIFY_DTE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tocust)
                    .HasColumnName("TOCUST")
                    .HasMaxLength(25);
            });
        }
    }
}

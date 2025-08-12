using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hrportalNew.Models;

public partial class PortalContext : DbContext
{
    public PortalContext()
    {
    }

    public PortalContext(DbContextOptions<PortalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }

    public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }

    public virtual DbSet<AspnetPath> AspnetPaths { get; set; }

    public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }

    public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }

    public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }

    public virtual DbSet<AspnetRole> AspnetRoles { get; set; }

    public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }

    public virtual DbSet<AspnetUser> AspnetUsers { get; set; }

    public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }

    public virtual DbSet<Complaint> Complaints { get; set; }

    public virtual DbSet<ComplaintMaster> ComplaintMasters { get; set; }

    public virtual DbSet<Deduction> Deductions { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EventMaster> EventMasters { get; set; }

    public virtual DbSet<Increase> Increases { get; set; }

    public virtual DbSet<Leaf> Leaves { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestMaster> RequestMasters { get; set; }

    public virtual DbSet<TblAttendance> TblAttendances { get; set; }

    public virtual DbSet<TblCareer> TblCareers { get; set; }

    public virtual DbSet<TblDeduction> TblDeductions { get; set; }

    public virtual DbSet<TblEarning> TblEarnings { get; set; }

    public virtual DbSet<TblEmpAttend> TblEmpAttends { get; set; }

    public virtual DbSet<TblEvent> TblEvents { get; set; }

    public virtual DbSet<TblEventImage> TblEventImages { get; set; }

    public virtual DbSet<TblFaq> TblFaqs { get; set; }

    public virtual DbSet<TblGallery> TblGalleries { get; set; }

    public virtual DbSet<TblGalleryMainCat> TblGalleryMainCats { get; set; }

    public virtual DbSet<TblHeartectionSubFoldr> TblHeartectionSubFoldrs { get; set; }

    public virtual DbSet<TblHeartictionPoint> TblHeartictionPoints { get; set; }

    public virtual DbSet<TblLandD> TblLandDs { get; set; }

    public virtual DbSet<TblLdmainTyp> TblLdmainTyps { get; set; }

    public virtual DbSet<TblLdtypsSubFolder> TblLdtypsSubFolders { get; set; }

    public virtual DbSet<TblLeaf> TblLeaves { get; set; }

    public virtual DbSet<TblNews> TblNews { get; set; }

    public virtual DbSet<TblOffer> TblOffers { get; set; }

    public virtual DbSet<TblPopUpVideo> TblPopUpVideos { get; set; }

    public virtual DbSet<TblReport> TblReports { get; set; }

    public virtual DbSet<TblSubGelleryCat> TblSubGelleryCats { get; set; }

    public virtual DbSet<TblTod> TblTods { get; set; }

    public virtual DbSet<TblTopmng> TblTopmngs { get; set; }

    public virtual DbSet<TblUserEvent> TblUserEvents { get; set; }

    public virtual DbSet<TblUserProfile> TblUserProfiles { get; set; }

    public virtual DbSet<TblVquotum> TblVquota { get; set; }

    public virtual DbSet<TblWageTypesMaster> TblWageTypesMasters { get; set; }

    public virtual DbSet<Vac> Vacs { get; set; }

    public virtual DbSet<VacOld> VacOlds { get; set; }

    public virtual DbSet<Vquotum> Vquota { get; set; }

    public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }

    public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }

    public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }

    public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }

    public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }

    public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }

    public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }

    public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }

    public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-KT81PQCH\\SQLEXPRESS;DataBase=Portal;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_100_CI_AS");

        modelBuilder.Entity<AspnetApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK__aspnet_A__C93A4C9870A8B9AE")
                .IsClustered(false);

            entity.ToTable("aspnet_Applications");

            entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE46DCC4D03").IsUnique();

            entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__309103316AEFE058").IsUnique();

            entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspnetMembership>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_M__1788CC4D74794A92")
                .IsClustered(false);

            entity.ToTable("aspnet_Membership");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetMemberships)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__Appli__40C49C62");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetMembership)
                .HasForeignKey<AspnetMembership>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__UserI__41B8C09B");
        });

        modelBuilder.Entity<AspnetPath>(entity =>
        {
            entity.HasKey(e => e.PathId)
                .HasName("PK__aspnet_P__CD67DC587849DB76")
                .IsClustered(false);

            entity.ToTable("aspnet_Paths");

            entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LoweredPath).HasMaxLength(256);
            entity.Property(e => e.Path).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetPaths)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pa__Appli__42ACE4D4");
        });

        modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
        {
            entity.HasKey(e => e.PathId).HasName("PK__aspnet_P__CD67DC597C1A6C5A");

            entity.ToTable("aspnet_PersonalizationAllUsers");

            entity.Property(e => e.PathId).ValueGeneratedNever();
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PageSettings).HasColumnType("image");

            entity.HasOne(d => d.Path).WithOne(p => p.AspnetPersonalizationAllUser)
                .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pe__PathI__43A1090D");
        });

        modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__aspnet_P__3214EC067FEAFD3E")
                .IsClustered(false);

            entity.ToTable("aspnet_PersonalizationPerUser");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PageSettings).HasColumnType("image");

            entity.HasOne(d => d.Path).WithMany(p => p.AspnetPersonalizationPerUsers)
                .HasForeignKey(d => d.PathId)
                .HasConstraintName("FK__aspnet_Pe__PathI__44952D46");

            entity.HasOne(d => d.User).WithMany(p => p.AspnetPersonalizationPerUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__aspnet_Pe__UserI__4589517F");
        });

        modelBuilder.Entity<AspnetProfile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__aspnet_P__1788CC4C03BB8E22");

            entity.ToTable("aspnet_Profile");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PropertyNames).HasColumnType("ntext");
            entity.Property(e => e.PropertyValuesBinary).HasColumnType("image");
            entity.Property(e => e.PropertyValuesString).HasColumnType("ntext");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetProfile)
                .HasForeignKey<AspnetProfile>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pr__UserI__467D75B8");
        });

        modelBuilder.Entity<AspnetRole>(entity =>
        {
            entity.HasKey(e => e.RoleId)
                .HasName("PK__aspnet_R__8AFACE1B078C1F06")
                .IsClustered(false);

            entity.ToTable("aspnet_Roles");

            entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredRoleName).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetRoles)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Ro__Appli__477199F1");
        });

        modelBuilder.Entity<AspnetSchemaVersion>(entity =>
        {
            entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion }).HasName("PK__aspnet_S__5A1E6BC10B5CAFEA");

            entity.ToTable("aspnet_SchemaVersions");

            entity.Property(e => e.Feature).HasMaxLength(128);
            entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
        });

        modelBuilder.Entity<AspnetUser>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_U__1788CC4D0F2D40CE")
                .IsClustered(false);

            entity.ToTable("aspnet_Users");

            entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ChangePassword).HasDefaultValue(1);
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredUserName).HasMaxLength(256);
            entity.Property(e => e.MobileAlias)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetUsers)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Us__Appli__4865BE2A");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspnetUsersInRole",
                    r => r.HasOne<AspnetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__RoleI__4959E263"),
                    l => l.HasOne<AspnetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__UserI__4A4E069C"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD12FDD1B2");
                        j.ToTable("aspnet_UsersInRoles");
                    });
        });

        modelBuilder.Entity<AspnetWebEventEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__aspnet_W__7944C81016CE6296");

            entity.ToTable("aspnet_WebEvent_Events");

            entity.Property(e => e.EventId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ApplicationPath).HasMaxLength(256);
            entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);
            entity.Property(e => e.Details).HasColumnType("ntext");
            entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.EventType).HasMaxLength(256);
            entity.Property(e => e.ExceptionType).HasMaxLength(256);
            entity.Property(e => e.MachineName).HasMaxLength(256);
            entity.Property(e => e.Message).HasMaxLength(1024);
            entity.Property(e => e.RequestUrl).HasMaxLength(1024);
        });

        modelBuilder.Entity<Complaint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb => tb.HasTrigger("Tr_Add_Comp"));

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Emp).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("IP");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.NotesHr)
                .HasMaxLength(500)
                .HasColumnName("notes_hr");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Pending")
                .HasColumnName("status");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type)
                .HasMaxLength(225)
                .HasColumnName("type");
            entity.Property(e => e.Uip)
                .HasMaxLength(50)
                .HasColumnName("UIP");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updatedtime)
                .HasColumnType("datetime")
                .HasColumnName("updatedtime");
        });

        modelBuilder.Entity<ComplaintMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ComplaintMaster");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mail).HasMaxLength(255);
            entity.Property(e => e.ReqNameAr)
                .HasMaxLength(255)
                .HasColumnName("ReqName_ar");
            entity.Property(e => e.ReqNameEn)
                .HasMaxLength(255)
                .HasColumnName("ReqName_en");
        });

        modelBuilder.Entity<Deduction>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Amount).HasMaxLength(50);
            entity.Property(e => e.Days).HasMaxLength(50);
            entity.Property(e => e.Ddate)
                .HasColumnType("datetime")
                .HasColumnName("DDate");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EmpID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.WageType).HasMaxLength(255);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressAr)
                .HasMaxLength(255)
                .HasColumnName("AddressAR");
            entity.Property(e => e.AddressEn)
                .HasMaxLength(255)
                .HasColumnName("AddressEN");
            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .HasComment("('')")
                .HasColumnName("e-mail");
            entity.Property(e => e.EmpFullName).HasMaxLength(255);
            entity.Property(e => e.EmpFullNameAr)
                .HasMaxLength(300)
                .HasColumnName("EmpFullNameAR");
            entity.Property(e => e.EmpGroup).HasMaxLength(50);
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EmpID");
            entity.Property(e => e.EmpName).HasMaxLength(50);
            entity.Property(e => e.GradDate)
                .HasMaxLength(50)
                .HasColumnName("Grad_date");
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.InstBranch).HasMaxLength(255);
            entity.Property(e => e.InstDegree).HasMaxLength(255);
            entity.Property(e => e.Institute).HasMaxLength(255);
            entity.Property(e => e.Job).HasMaxLength(255);
            entity.Property(e => e.JobAr)
                .HasMaxLength(255)
                .HasColumnName("JobAR");
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Mrn)
                .HasMaxLength(255)
                .HasColumnName("MRN");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.NationalityAr)
                .HasMaxLength(100)
                .HasColumnName("nationalityAR");
            entity.Property(e => e.OrgUnit).HasMaxLength(255);
            entity.Property(e => e.OrgUnitAr)
                .HasMaxLength(255)
                .HasColumnName("OrgUnitAR");
            entity.Property(e => e.OtherDegDte)
                .HasMaxLength(250)
                .HasColumnName("other_deg_dte");
            entity.Property(e => e.OtherDegree)
                .HasMaxLength(250)
                .HasColumnName("other_degree");
            entity.Property(e => e.Pernr)
                .HasMaxLength(200)
                .HasColumnName("pernr");
            entity.Property(e => e.Position).HasMaxLength(255);
            entity.Property(e => e.PositionAr)
                .HasMaxLength(255)
                .HasColumnName("PositionAR");
            entity.Property(e => e.Sino)
                .HasMaxLength(200)
                .HasColumnName("SINo");
            entity.Property(e => e.SubArea).HasMaxLength(50);
            entity.Property(e => e.SubGroup).HasMaxLength(50);
        });

        modelBuilder.Entity<EventMaster>(entity =>
        {
            entity.ToTable("EventMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EvntTypAr)
                .HasMaxLength(300)
                .HasColumnName("evnt_typ_ar");
            entity.Property(e => e.EvntTypEn)
                .HasMaxLength(300)
                .HasColumnName("evnt_typ_en");
        });

        modelBuilder.Entity<Increase>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Increase1)
                .HasMaxLength(50)
                .HasColumnName("Increase");
        });

        modelBuilder.Entity<Leaf>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.EmpId, "IX_Leaves");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EmpID");
            entity.Property(e => e.EndD).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Ltype)
                .HasMaxLength(50)
                .HasColumnName("LType");
            entity.Property(e => e.StartD).HasColumnType("datetime");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("Tr_Add_Req"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Emp).HasMaxLength(50);
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .HasColumnName("IP");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .HasColumnName("notes");
            entity.Property(e => e.NotesHr)
                .HasMaxLength(500)
                .HasColumnName("notes_hr");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Pending")
                .HasColumnName("status");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type)
                .HasMaxLength(225)
                .HasColumnName("type");
            entity.Property(e => e.Uip)
                .HasMaxLength(50)
                .HasColumnName("UIP");
            entity.Property(e => e.Updatedby)
                .HasMaxLength(50)
                .HasColumnName("updatedby");
            entity.Property(e => e.Updatedtime)
                .HasColumnType("datetime")
                .HasColumnName("updatedtime");
        });

        modelBuilder.Entity<RequestMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RequestMaster");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mail).HasMaxLength(255);
            entity.Property(e => e.ReqNameAr)
                .HasMaxLength(255)
                .HasColumnName("ReqName_ar");
            entity.Property(e => e.ReqNameEn)
                .HasMaxLength(255)
                .HasColumnName("ReqName_en");
        });

        modelBuilder.Entity<TblAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAttendance");

            entity.Property(e => e.ActualDays)
                .HasMaxLength(100)
                .HasColumnName("actualDays");
            entity.Property(e => e.ActualWorkHours)
                .HasMaxLength(100)
                .HasColumnName("actualWorkHours");
            entity.Property(e => e.AttAbs)
                .HasMaxLength(250)
                .HasColumnName("Att_Abs");
            entity.Property(e => e.Average)
                .HasMaxLength(100)
                .HasColumnName("average");
            entity.Property(e => e.CheckIn)
                .HasColumnType("datetime")
                .HasColumnName("checkIn");
            entity.Property(e => e.CheckOut)
                .HasColumnType("datetime")
                .HasColumnName("checkOut");
            entity.Property(e => e.Date)
                .HasMaxLength(150)
                .HasColumnName("date");
            entity.Property(e => e.Department)
                .HasMaxLength(150)
                .HasColumnName("department");
            entity.Property(e => e.Dws)
                .HasMaxLength(150)
                .HasColumnName("DWS");
            entity.Property(e => e.EarlyOut)
                .HasMaxLength(50)
                .HasColumnName("earlyOut");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.LateIn)
                .HasMaxLength(100)
                .HasColumnName("lateIn");
            entity.Property(e => e.Leaves)
                .HasMaxLength(100)
                .HasColumnName("leaves");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.OverTime)
                .HasMaxLength(100)
                .HasColumnName("overTime");
            entity.Property(e => e.Pernr)
                .HasMaxLength(150)
                .HasColumnName("pernr");
            entity.Property(e => e.PlanWorkHours)
                .HasMaxLength(100)
                .HasColumnName("planWorkHours");
            entity.Property(e => e.PlannedDays)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("plannedDays");
            entity.Property(e => e.Position)
                .HasMaxLength(150)
                .HasColumnName("position");
            entity.Property(e => e.TotEarlyOut)
                .HasMaxLength(100)
                .HasColumnName("totEarlyOut");
            entity.Property(e => e.TotLateIn)
                .HasMaxLength(100)
                .HasColumnName("totLateIn");
            entity.Property(e => e.TotWorkHours)
                .HasMaxLength(100)
                .HasColumnName("totWorkHours");
            entity.Property(e => e.WorkingHours)
                .HasMaxLength(100)
                .HasColumnName("workingHours");
        });

        modelBuilder.Entity<TblCareer>(entity =>
        {
            entity.ToTable("tblCareers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentAr)
                .HasMaxLength(300)
                .HasColumnName("Department_ar");
            entity.Property(e => e.DepartmentEn)
                .HasMaxLength(300)
                .HasColumnName("Department_en");
            entity.Property(e => e.DivisionAr)
                .HasMaxLength(250)
                .HasColumnName("Division_ar");
            entity.Property(e => e.DivisionEn)
                .HasMaxLength(250)
                .HasColumnName("Division_en");
            entity.Property(e => e.EducationAr)
                .HasColumnType("ntext")
                .HasColumnName("Education_ar");
            entity.Property(e => e.EducationEn)
                .HasColumnType("ntext")
                .HasColumnName("Education_en");
            entity.Property(e => e.ExperienceAr)
                .HasColumnType("ntext")
                .HasColumnName("Experience_ar");
            entity.Property(e => e.ExperienceEn)
                .HasColumnType("ntext")
                .HasColumnName("Experience_en");
            entity.Property(e => e.JobBranchAr)
                .HasMaxLength(150)
                .HasColumnName("job_branch_ar");
            entity.Property(e => e.JobBranchEn)
                .HasMaxLength(150)
                .HasColumnName("job_branch_en");
            entity.Property(e => e.JobDeadline)
                .HasColumnType("datetime")
                .HasColumnName("job_deadline");
            entity.Property(e => e.PositionAr)
                .HasMaxLength(500)
                .HasColumnName("Position_ar");
            entity.Property(e => e.PositionEn)
                .HasMaxLength(500)
                .HasColumnName("Position_en");
            entity.Property(e => e.TitleAr)
                .HasMaxLength(300)
                .HasColumnName("Title_ar");
            entity.Property(e => e.TitleEn)
                .HasMaxLength(300)
                .HasColumnName("Title_en");
        });

        modelBuilder.Entity<TblDeduction>(entity =>
        {
            entity.ToTable("tblDeductions");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount)
                .HasMaxLength(100)
                .HasColumnName("amount");
            entity.Property(e => e.Ddate)
                .HasColumnType("datetime")
                .HasColumnName("DDate");
            entity.Property(e => e.EmpId)
                .HasMaxLength(100)
                .HasColumnName("EmpID");
            entity.Property(e => e.TotalDeduction)
                .HasMaxLength(150)
                .HasColumnName("total_deduction");
            entity.Property(e => e.WageCode)
                .HasMaxLength(100)
                .HasColumnName("wageCode");
        });

        modelBuilder.Entity<TblEarning>(entity =>
        {
            entity.ToTable("tblEarning");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount)
                .HasMaxLength(100)
                .HasColumnName("amount");
            entity.Property(e => e.Bank)
                .HasMaxLength(200)
                .HasColumnName("bank");
            entity.Property(e => e.Edate)
                .HasColumnType("datetime")
                .HasColumnName("EDate");
            entity.Property(e => e.EmpId)
                .HasMaxLength(100)
                .HasColumnName("EmpID");
            entity.Property(e => e.TotalEarninig)
                .HasMaxLength(200)
                .HasColumnName("total_earninig");
            entity.Property(e => e.WageCode)
                .HasMaxLength(100)
                .HasColumnName("wageCode");
        });

        modelBuilder.Entity<TblEmpAttend>(entity =>
        {
            entity.ToTable("tblEmpAttend");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActualDays)
                .HasMaxLength(100)
                .HasColumnName("actualDays");
            entity.Property(e => e.ActualWorkHours)
                .HasMaxLength(100)
                .HasColumnName("actualWorkHours");
            entity.Property(e => e.AttAbs)
                .HasMaxLength(250)
                .HasColumnName("Att_Abs");
            entity.Property(e => e.Average)
                .HasMaxLength(100)
                .HasColumnName("average");
            entity.Property(e => e.CheckIn)
                .HasColumnType("datetime")
                .HasColumnName("checkIn");
            entity.Property(e => e.CheckOut)
                .HasColumnType("datetime")
                .HasColumnName("checkOut");
            entity.Property(e => e.Date)
                .HasMaxLength(150)
                .HasColumnName("date");
            entity.Property(e => e.Department)
                .HasMaxLength(150)
                .HasColumnName("department");
            entity.Property(e => e.Dws)
                .HasMaxLength(150)
                .HasColumnName("DWS");
            entity.Property(e => e.EarlyOut)
                .HasMaxLength(50)
                .HasColumnName("earlyOut");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.LateIn)
                .HasMaxLength(100)
                .HasColumnName("lateIn");
            entity.Property(e => e.Leaves)
                .HasMaxLength(100)
                .HasColumnName("leaves");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.OverTime)
                .HasMaxLength(100)
                .HasColumnName("overTime");
            entity.Property(e => e.Pernr)
                .HasMaxLength(150)
                .HasColumnName("pernr");
            entity.Property(e => e.PlanWorkHours)
                .HasMaxLength(100)
                .HasColumnName("planWorkHours");
            entity.Property(e => e.PlannedDays)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("plannedDays");
            entity.Property(e => e.Position)
                .HasMaxLength(150)
                .HasColumnName("position");
            entity.Property(e => e.TotEarlyOut)
                .HasMaxLength(100)
                .HasColumnName("totEarlyOut");
            entity.Property(e => e.TotLateIn)
                .HasMaxLength(100)
                .HasColumnName("totLateIn");
            entity.Property(e => e.TotWorkHours)
                .HasMaxLength(100)
                .HasColumnName("totWorkHours");
            entity.Property(e => e.WorkingHours)
                .HasMaxLength(100)
                .HasColumnName("workingHours");
        });

        modelBuilder.Entity<TblEvent>(entity =>
        {
            entity.ToTable("tblEvent");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsAr)
                .HasColumnType("ntext")
                .HasColumnName("details_ar");
            entity.Property(e => e.DetaisEn)
                .HasColumnType("ntext")
                .HasColumnName("detais_en");
            entity.Property(e => e.EventOrder).HasColumnName("event_order");
            entity.Property(e => e.EventTypeAr)
                .HasMaxLength(500)
                .HasColumnName("event_type_ar");
            entity.Property(e => e.EventTypeEn)
                .HasMaxLength(500)
                .HasColumnName("event_type_en");
            entity.Property(e => e.HeaderAr)
                .HasMaxLength(500)
                .HasColumnName("header_ar");
            entity.Property(e => e.HeaderEn)
                .HasMaxLength(500)
                .HasColumnName("header_en");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(500)
                .HasColumnName("imgPath");
            entity.Property(e => e.LDId)
                .HasDefaultValue(0)
                .HasColumnName("l_d_ID");
            entity.Property(e => e.Order).HasColumnName("order");
        });

        modelBuilder.Entity<TblEventImage>(entity =>
        {
            entity.ToTable("tblEventImages");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.EventId).HasColumnName("eventID");
            entity.Property(e => e.EvntImg).HasColumnName("evnt_img");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(500)
                .HasColumnName("imgPath");
        });

        modelBuilder.Entity<TblFaq>(entity =>
        {
            entity.ToTable("tblFAQ");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnswerAr)
                .HasColumnType("ntext")
                .HasColumnName("answer_ar");
            entity.Property(e => e.AnswerEn)
                .HasColumnType("ntext")
                .HasColumnName("answer_en");
            entity.Property(e => e.QuestionAr)
                .HasColumnType("ntext")
                .HasColumnName("question_ar");
            entity.Property(e => e.QuestionEn)
                .HasColumnType("ntext")
                .HasColumnName("question_en");
        });

        modelBuilder.Entity<TblGallery>(entity =>
        {
            entity.ToTable("tblGallery");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllowPopUp)
                .HasMaxLength(10)
                .HasColumnName("allowPopUp");
            entity.Property(e => e.Current).HasColumnName("current");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.HeaderAr)
                .HasMaxLength(250)
                .HasColumnName("header_ar");
            entity.Property(e => e.HeaderEn)
                .HasMaxLength(250)
                .HasColumnName("header_en");
            entity.Property(e => e.HeartSubFolderId).HasColumnName("heart_sub_folder_id");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(250)
                .HasColumnName("imgPath");
            entity.Property(e => e.MainCatId).HasColumnName("main_cat_id");
            entity.Property(e => e.SubCatId).HasColumnName("sub_cat_id");
        });

        modelBuilder.Entity<TblGalleryMainCat>(entity =>
        {
            entity.ToTable("tblGalleryMainCat");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MainCategoryAr)
                .HasMaxLength(250)
                .HasColumnName("main_category_AR");
            entity.Property(e => e.MainCategoryEn)
                .HasMaxLength(250)
                .HasColumnName("main_category_EN");
        });

        modelBuilder.Entity<TblHeartectionSubFoldr>(entity =>
        {
            entity.ToTable("tblHeartectionSubFoldrs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MainCatId)
                .HasDefaultValue(3)
                .HasColumnName("main_cat_id");
            entity.Property(e => e.SubCategoryId).HasColumnName("sub_category_id");
            entity.Property(e => e.SubFolderAr)
                .HasMaxLength(250)
                .HasColumnName("sub_folder_AR");
            entity.Property(e => e.SubFolderEn)
                .HasMaxLength(250)
                .HasColumnName("sub_folder_EN");
        });

        modelBuilder.Entity<TblHeartictionPoint>(entity =>
        {
            entity.ToTable("tblHeartictionPoints");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("EmpID");
            entity.Property(e => e.Points).HasColumnName("points");
        });

        modelBuilder.Entity<TblLandD>(entity =>
        {
            entity.ToTable("tblLandD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsAr)
                .HasColumnType("ntext")
                .HasColumnName("details_ar");
            entity.Property(e => e.DetaisEn)
                .HasColumnType("ntext")
                .HasColumnName("detais_en");
            entity.Property(e => e.EventOrder).HasColumnName("event_order");
            entity.Property(e => e.HeaderAr)
                .HasMaxLength(500)
                .HasColumnName("header_ar");
            entity.Property(e => e.HeaderEn)
                .HasMaxLength(500)
                .HasColumnName("header_en");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(500)
                .HasColumnName("imgPath");
            entity.Property(e => e.LDType)
                .HasDefaultValue(0)
                .HasColumnName("L_D_type");
            entity.Property(e => e.MainCatId)
                .HasDefaultValue(0)
                .HasColumnName("main_cat_id");
            entity.Property(e => e.SubFolderId)
                .HasDefaultValue(0)
                .HasColumnName("sub_folder_id");
        });

        modelBuilder.Entity<TblLdmainTyp>(entity =>
        {
            entity.ToTable("tblLDMainTyps");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LdTypeAr)
                .HasMaxLength(250)
                .HasColumnName("LD_type_AR");
            entity.Property(e => e.LdTypeEn)
                .HasMaxLength(250)
                .HasColumnName("LD_type_EN");
        });

        modelBuilder.Entity<TblLdtypsSubFolder>(entity =>
        {
            entity.ToTable("tblLDTypsSubFolders");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MainTypId).HasColumnName("main_typ_id");
            entity.Property(e => e.SubFolderAr)
                .HasMaxLength(250)
                .HasColumnName("sub_folder_AR");
            entity.Property(e => e.SubFolderEn)
                .HasMaxLength(250)
                .HasColumnName("sub_folder_EN");
        });

        modelBuilder.Entity<TblLeaf>(entity =>
        {
            entity.ToTable("tblLeaves");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EmpID");
            entity.Property(e => e.EndD).HasColumnType("datetime");
            entity.Property(e => e.StartD).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblNews>(entity =>
        {
            entity.ToTable("tblNews");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsAr)
                .HasColumnType("ntext")
                .HasColumnName("details_ar");
            entity.Property(e => e.DetailsEn)
                .HasColumnType("ntext")
                .HasColumnName("details_en");
            entity.Property(e => e.HeaderAr)
                .HasMaxLength(500)
                .HasColumnName("header_ar");
            entity.Property(e => e.HeaderEn)
                .HasMaxLength(500)
                .HasColumnName("header_en");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(500)
                .HasColumnName("imgPath");
            entity.Property(e => e.Type)
                .HasMaxLength(150)
                .HasColumnName("type");
        });

        modelBuilder.Entity<TblOffer>(entity =>
        {
            entity.ToTable("tblOffer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DetailsAr)
                .HasMaxLength(500)
                .HasColumnName("details_ar");
            entity.Property(e => e.DetailsEn)
                .HasMaxLength(500)
                .HasColumnName("details_en");
            entity.Property(e => e.HeaderAr)
                .HasMaxLength(150)
                .HasColumnName("header_ar");
            entity.Property(e => e.HeaderEn)
                .HasMaxLength(150)
                .HasColumnName("header_en");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(150)
                .HasColumnName("img_path");
            entity.Property(e => e.LDId)
                .HasDefaultValue(0)
                .HasColumnName("l_d_ID");
            entity.Property(e => e.OfferOrder).HasColumnName("offer_order");
            entity.Property(e => e.PopUp).HasColumnName("pop_up");
        });

        modelBuilder.Entity<TblPopUpVideo>(entity =>
        {
            entity.ToTable("tblPopUpVideos");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllowPopUp)
                .HasMaxLength(10)
                .HasColumnName("allowPopUp");
            entity.Property(e => e.VideoName)
                .HasMaxLength(200)
                .HasColumnName("videoName");
            entity.Property(e => e.VideoPath)
                .HasMaxLength(200)
                .HasColumnName("videoPath");
        });

        modelBuilder.Entity<TblReport>(entity =>
        {
            entity.ToTable("tblReports");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.FilePath)
                .HasMaxLength(500)
                .HasColumnName("filePath");
            entity.Property(e => e.NameAr)
                .HasMaxLength(250)
                .HasColumnName("name_ar");
            entity.Property(e => e.NameEn)
                .HasMaxLength(250)
                .HasColumnName("name_en");
        });

        modelBuilder.Entity<TblSubGelleryCat>(entity =>
        {
            entity.ToTable("tblSubGelleryCat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MainCatId).HasColumnName("main_cat_id");
            entity.Property(e => e.Order)
                .HasDefaultValue(50)
                .HasColumnName("order");
            entity.Property(e => e.SubCategoryAr)
                .HasMaxLength(250)
                .HasColumnName("sub_category_AR");
            entity.Property(e => e.SubCategoryEn)
                .HasMaxLength(250)
                .HasColumnName("sub_category_EN");
        });

        modelBuilder.Entity<TblTod>(entity =>
        {
            entity.ToTable("tblTOD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsAr)
                .HasColumnType("ntext")
                .HasColumnName("details_ar");
            entity.Property(e => e.DetailsEn)
                .HasColumnType("ntext")
                .HasColumnName("details_en");
            entity.Property(e => e.First).HasColumnName("first");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(500)
                .HasColumnName("imgPath");
        });

        modelBuilder.Entity<TblTopmng>(entity =>
        {
            entity.ToTable("tblTopmngs");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.DetailsAr)
                .HasColumnType("ntext")
                .HasColumnName("details_ar");
            entity.Property(e => e.DetailsEn)
                .HasColumnType("ntext")
                .HasColumnName("details_en");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(250)
                .HasColumnName("imgPath");
            entity.Property(e => e.Na).HasColumnName("na");
            entity.Property(e => e.NameAr)
                .HasMaxLength(250)
                .HasColumnName("name_ar");
            entity.Property(e => e.NameEn)
                .HasMaxLength(250)
                .HasColumnName("name_en");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.PositionAr)
                .HasMaxLength(250)
                .HasColumnName("position_ar");
            entity.Property(e => e.PositionEn)
                .HasMaxLength(250)
                .HasColumnName("position_en");
        });

        modelBuilder.Entity<TblUserEvent>(entity =>
        {
            entity.ToTable("tblUserEvent");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Details)
                .HasColumnType("ntext")
                .HasColumnName("details");
            entity.Property(e => e.EmpId).HasColumnName("empID");
            entity.Property(e => e.EvntType)
                .HasMaxLength(300)
                .HasColumnName("evnt_type");
            entity.Property(e => e.Header)
                .HasMaxLength(500)
                .HasColumnName("header");
        });

        modelBuilder.Entity<TblUserProfile>(entity =>
        {
            entity.ToTable("tblUserProfile");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImgPath)
                .HasMaxLength(500)
                .HasColumnName("img_path");
        });

        modelBuilder.Entity<TblVquotum>(entity =>
        {
            entity.ToTable("tblVQuota");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EmpID");
            entity.Property(e => e.Qdate)
                .HasColumnType("datetime")
                .HasColumnName("QDate");
        });

        modelBuilder.Entity<TblWageTypesMaster>(entity =>
        {
            entity.ToTable("tblWageTypesMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(150);
            entity.Property(e => e.WageType)
                .HasMaxLength(250)
                .HasColumnName("wage_type");
        });

        modelBuilder.Entity<Vac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Vac");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(255);
            entity.Property(e => e.Division).HasMaxLength(255);
            entity.Property(e => e.Education).HasMaxLength(500);
            entity.Property(e => e.Experience).HasMaxLength(500);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Position).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<VacOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Vac_old");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Department).HasMaxLength(255);
            entity.Property(e => e.Division).HasMaxLength(255);
            entity.Property(e => e.Education).HasMaxLength(500);
            entity.Property(e => e.Experience).HasMaxLength(500);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Position).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<Vquotum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VQuota");

            entity.HasIndex(e => e.EmpId, "IX_VQuota");

            entity.Property(e => e.EmpId)
                .HasMaxLength(50)
                .HasColumnName("EmpID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Qdate)
                .HasColumnType("datetime")
                .HasColumnName("QDate");
            entity.Property(e => e.Qtype)
                .HasMaxLength(100)
                .HasColumnName("QType");
        });

        modelBuilder.Entity<VwAspnetApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Applications");

            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_MembershipUsers");

            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobileAlias).HasMaxLength(16);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Profiles");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAspnetRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Roles");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredRoleName).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Users");

            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredUserName).HasMaxLength(256);
            entity.Property(e => e.MobileAlias).HasMaxLength(16);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_UsersInRoles");
        });

        modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_Paths");

            entity.Property(e => e.LoweredPath).HasMaxLength(256);
            entity.Property(e => e.Path).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_Shared");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_User");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

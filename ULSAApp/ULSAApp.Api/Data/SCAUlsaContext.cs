using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ULSAApp.Api.Data.Entities
{
    public partial class SCAUlsaContext : DbContext
    {
        public SCAUlsaContext()
        {
        }

        public SCAUlsaContext(DbContextOptions<SCAUlsaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Scai0imp> Scai0imps { get; set; }
        public virtual DbSet<Scalumno> Scalumnos { get; set; }
        public virtual DbSet<Scanegociacione> Scanegociaciones { get; set; }
        public virtual DbSet<Scar0rut> Scar0ruts { get; set; }
        public virtual DbSet<ScatiposCpp> ScatiposCpps { get; set; }
        public virtual DbSet<ScbanAluConv> ScbanAluConvs { get; set; }
        public virtual DbSet<ScbanCat> ScbanCats { get; set; }
        public virtual DbSet<ScbanCtum> ScbanCta { get; set; }
        public virtual DbSet<ScbanMovCar> ScbanMovCars { get; set; }
        public virtual DbSet<ScbanMovto> ScbanMovtos { get; set; }
        public virtual DbSet<ScbanPar> ScbanPars { get; set; }
        public virtual DbSet<Scbeca> Scbecas { get; set; }
        public virtual DbSet<Sccalend> Sccalends { get; set; }
        public virtual DbSet<SccartasPf> SccartasPfs { get; set; }
        public virtual DbSet<SccompDet> SccompDets { get; set; }
        public virtual DbSet<Sccomprom> Sccomproms { get; set; }
        public virtual DbSet<Scconcep> Scconceps { get; set; }
        public virtual DbSet<ScdatCli> ScdatClis { get; set; }
        public virtual DbSet<ScdatIn> ScdatIns { get; set; }
        public virtual DbSet<ScdisEfectivo> ScdisEfectivos { get; set; }
        public virtual DbSet<Scescuela> Scescuelas { get; set; }
        public virtual DbSet<Scfacele> Scfaceles { get; set; }
        public virtual DbSet<ScfaceleAnt> ScfaceleAnts { get; set; }
        public virtual DbSet<ScforDet> ScforDets { get; set; }
        public virtual DbSet<ScforPagoSat> ScforPagoSats { get; set; }
        public virtual DbSet<Scformato> Scformatos { get; set; }
        public virtual DbSet<ScgpoCar> ScgpoCars { get; set; }
        public virtual DbSet<Schmovimi> Schmovimis { get; set; }
        public virtual DbSet<Scimpre> Scimpres { get; set; }
        public virtual DbSet<ScimpuestosSat> ScimpuestosSats { get; set; }
        public virtual DbSet<Scisaldo> Scisaldos { get; set; }
        public virtual DbSet<ScjsalHi> ScjsalHis { get; set; }
        public virtual DbSet<ScmetPago> ScmetPagos { get; set; }
        public virtual DbSet<ScmetPagoSat> ScmetPagoSats { get; set; }
        public virtual DbSet<ScnivAcad> ScnivAcads { get; set; }
        public virtual DbSet<ScproSerSat> ScproSerSats { get; set; }
        public virtual DbSet<Scprospec> Scprospecs { get; set; }
        public virtual DbSet<Screferen> Screferens { get; set; }
        public virtual DbSet<ScregSat> ScregSats { get; set; }
        public virtual DbSet<Scstatus> Scstatuses { get; set; }
        public virtual DbSet<SctasaCpp> SctasaCpps { get; set; }
        public virtual DbSet<SctipCompSat> SctipCompSats { get; set; }
        public virtual DbSet<ScuniMedSat> ScuniMedSats { get; set; }
        public virtual DbSet<ScusoSat> ScusoSats { get; set; }
        public virtual DbSet<Scusuario> Scusuarios { get; set; }
        public virtual DbSet<SdealumnosDer> SdealumnosDers { get; set; }
        public virtual DbSet<SdecalPag> SdecalPags { get; set; }
        public virtual DbSet<Sdeparame> Sdeparames { get; set; }
        public virtual DbSet<SpbalumnosCon> SpbalumnosCons { get; set; }
        public virtual DbSet<SpbmovCar> SpbmovCars { get; set; }
        public virtual DbSet<Spbmovto> Spbmovtos { get; set; }
        public virtual DbSet<Spbparametro> Spbparametros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=JAAM-LAP;Database=SCAUlsa;user=sa;password=red11red");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Scai0imp>(entity =>
            {
                entity.HasKey(e => new { e.I0usuimp, e.I0numimp });

                entity.ToTable("SCAI0IMP");

                entity.Property(e => e.I0usuimp)
                    .HasMaxLength(6)
                    .HasColumnName("I0USUIMP");

                entity.Property(e => e.I0numimp).HasColumnName("I0NUMIMP");

                entity.Property(e => e.I0actimp)
                    .HasMaxLength(1)
                    .HasColumnName("I0ACTIMP");

                entity.Property(e => e.I0ch1imp).HasColumnName("I0CH1IMP");

                entity.Property(e => e.I0ch2imp).HasColumnName("I0CH2IMP");

                entity.Property(e => e.I0ch3imp).HasColumnName("I0CH3IMP");

                entity.Property(e => e.I0ch4imp).HasColumnName("I0CH4IMP");

                entity.Property(e => e.I0ch5imp).HasColumnName("I0CH5IMP");

                entity.Property(e => e.I0ch6imp).HasColumnName("I0CH6IMP");

                entity.Property(e => e.I0disimp)
                    .HasMaxLength(40)
                    .HasColumnName("I0DISIMP");

                entity.Property(e => e.I0hojimp).HasColumnName("I0HOJIMP");

                entity.Property(e => e.I0ideimp)
                    .HasMaxLength(30)
                    .HasColumnName("I0IDEIMP");
            });

            modelBuilder.Entity<Scalumno>(entity =>
            {
                entity.HasKey(e => e.G0nummat)
                    .HasName("PK_SCAGALU");

                entity.ToTable("SCAlumnos");

                entity.Property(e => e.G0nummat)
                    .ValueGeneratedNever()
                    .HasColumnName("G0NUMMAT");

                entity.Property(e => e.G0alsexo)
                    .HasMaxLength(1)
                    .HasColumnName("G0ALSEXO");

                entity.Property(e => e.G0apmalu)
                    .HasMaxLength(20)
                    .HasColumnName("G0APMALU");

                entity.Property(e => e.G0appalu)
                    .HasMaxLength(20)
                    .HasColumnName("G0APPALU");

                entity.Property(e => e.G0banAlu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("G0BanAlu")
                    .IsFixedLength(true);

                entity.Property(e => e.G0bonbec)
                    .HasMaxLength(1)
                    .HasColumnName("G0BONBEC");

                entity.Property(e => e.G0calmor)
                    .HasMaxLength(1)
                    .HasColumnName("G0CALMOR");

                entity.Property(e => e.G0cbaAlu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G0CBaAlu")
                    .IsFixedLength(true);

                entity.Property(e => e.G0celAlu)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("G0CElAlu")
                    .IsFixedLength(true);

                entity.Property(e => e.G0ciudad)
                    .HasMaxLength(20)
                    .HasColumnName("G0CIUDAD");

                entity.Property(e => e.G0ciurec)
                    .HasMaxLength(20)
                    .HasColumnName("G0CIUREC");

                entity.Property(e => e.G0cpoAlu).HasColumnName("G0CPoAlu");

                entity.Property(e => e.G0cpoRec).HasColumnName("G0CPoRec");

                entity.Property(e => e.G0ctacor)
                    .HasMaxLength(40)
                    .HasColumnName("G0CTACOR");

                entity.Property(e => e.G0curAlu)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("G0CurAlu")
                    .IsFixedLength(true);

                entity.Property(e => e.G0dadpag).HasColumnName("G0DADPAG");

                entity.Property(e => e.G0domic1)
                    .HasMaxLength(150)
                    .HasColumnName("G0DOMIC1");

                entity.Property(e => e.G0domic2)
                    .HasMaxLength(150)
                    .HasColumnName("G0DOMIC2");

                entity.Property(e => e.G0domre1)
                    .HasMaxLength(35)
                    .HasColumnName("G0DOMRE1");

                entity.Property(e => e.G0domre2)
                    .HasMaxLength(35)
                    .HasColumnName("G0DOMRE2");

                entity.Property(e => e.G0edoAlu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G0EdoAlu")
                    .IsFixedLength(true);

                entity.Property(e => e.G0edoRec)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G0EdoRec")
                    .IsFixedLength(true);

                entity.Property(e => e.G0fecbaj)
                    .HasColumnType("datetime")
                    .HasColumnName("G0FECBAJ");

                entity.Property(e => e.G0fecgra)
                    .HasColumnType("datetime")
                    .HasColumnName("G0FECGRA");

                entity.Property(e => e.G0fecing)
                    .HasColumnType("datetime")
                    .HasColumnName("G0FECING");

                entity.Property(e => e.G0fecnac)
                    .HasColumnType("datetime")
                    .HasColumnName("G0FECNAC");

                entity.Property(e => e.G0folneg).HasColumnName("G0FOLNEG");

                entity.Property(e => e.G0fpaAlu)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("G0FPaAlu")
                    .IsFixedLength(true);

                entity.Property(e => e.G0matri1).HasColumnName("G0MATRI1");

                entity.Property(e => e.G0matri2).HasColumnName("G0MATRI2");

                entity.Property(e => e.G0matri3).HasColumnName("G0MATRI3");

                entity.Property(e => e.G0mpaAlu).HasColumnName("G0MPaAlu");

                entity.Property(e => e.G0munAlu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G0MunAlu")
                    .IsFixedLength(true);

                entity.Property(e => e.G0munRec)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("G0MunRec")
                    .IsFixedLength(true);

                entity.Property(e => e.G0nomalu)
                    .HasMaxLength(60)
                    .HasColumnName("G0NOMALU");

                entity.Property(e => e.G0nomrec)
                    .HasMaxLength(60)
                    .HasColumnName("G0NOMREC");

                entity.Property(e => e.G0nosalu)
                    .HasMaxLength(20)
                    .HasColumnName("G0NOSALU");

                entity.Property(e => e.G0numgpo).HasColumnName("G0NUMGPO");

                entity.Property(e => e.G0numniv).HasColumnName("G0NUMNIV");

                entity.Property(e => e.G0numsem).HasColumnName("G0NUMSEM");

                entity.Property(e => e.G0paiAlu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("G0PaiAlu")
                    .IsFixedLength(true);

                entity.Property(e => e.G0paiRec)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("G0PaiRec")
                    .IsFixedLength(true);

                entity.Property(e => e.G0passApp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("G0PassApp");

                entity.Property(e => e.G0peddat)
                    .HasMaxLength(1)
                    .HasColumnName("G0PEDDAT");

                entity.Property(e => e.G0portra).HasColumnName("G0PORTRA");

                entity.Property(e => e.G0recesp)
                    .HasMaxLength(1)
                    .HasColumnName("G0RECESP");

                entity.Property(e => e.G0rfcalu)
                    .HasMaxLength(15)
                    .HasColumnName("G0RFCALU");

                entity.Property(e => e.G0rfcrec)
                    .HasMaxLength(15)
                    .HasColumnName("G0RFCREC");

                entity.Property(e => e.G0seguro)
                    .HasMaxLength(1)
                    .HasColumnName("G0SEGURO");

                entity.Property(e => e.G0sengra)
                    .HasMaxLength(1)
                    .HasColumnName("G0SENGRA");

                entity.Property(e => e.G0situac)
                    .HasMaxLength(15)
                    .HasColumnName("G0SITUAC");

                entity.Property(e => e.G0status)
                    .HasMaxLength(2)
                    .HasColumnName("G0STATUS");

                entity.Property(e => e.G0telefo)
                    .HasMaxLength(20)
                    .HasColumnName("G0TELEFO");

                entity.Property(e => e.G0telrec)
                    .HasMaxLength(20)
                    .HasColumnName("G0TELREC");

                entity.Property(e => e.G0tipbec)
                    .HasMaxLength(1)
                    .HasColumnName("G0TIPBEC");

                entity.Property(e => e.G0tiptra).HasColumnName("G0TIPTRA");

                entity.HasOne(d => d.G0numgpoNavigation)
                    .WithMany(p => p.Scalumnos)
                    .HasForeignKey(d => d.G0numgpo)
                    .HasConstraintName("FK_SCAlumnos_SCGpoCar");
            });

            modelBuilder.Entity<Scanegociacione>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCANegociaciones");

                entity.Property(e => e.N0codtcp).HasColumnName("N0CODTCP");

                entity.Property(e => e.N0concar).HasColumnName("N0CONCAR");

                entity.Property(e => e.N0congto).HasColumnName("N0CONGTO");

                entity.Property(e => e.N0conint).HasColumnName("N0CONINT");

                entity.Property(e => e.N0de1neg)
                    .HasMaxLength(75)
                    .HasColumnName("N0DE1NEG");

                entity.Property(e => e.N0de2neg)
                    .HasMaxLength(75)
                    .HasColumnName("N0DE2NEG");

                entity.Property(e => e.N0fecneg)
                    .HasColumnType("datetime")
                    .HasColumnName("N0FECNEG");

                entity.Property(e => e.N0folneg).HasColumnName("N0FOLNEG");

                entity.Property(e => e.N0impgto)
                    .HasColumnType("money")
                    .HasColumnName("N0IMPGTO");

                entity.Property(e => e.N0impint)
                    .HasColumnType("money")
                    .HasColumnName("N0IMPINT");

                entity.Property(e => e.N0matneg).HasColumnName("N0MATNEG");

                entity.Property(e => e.N0nebneg)
                    .HasColumnType("datetime")
                    .HasColumnName("N0NEBNEG");

                entity.Property(e => e.N0stsneg)
                    .HasMaxLength(1)
                    .HasColumnName("N0STSNEG");
            });

            modelBuilder.Entity<Scar0rut>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCAR0RUT");

                entity.Property(e => e.R0codrut)
                    .HasMaxLength(1)
                    .HasColumnName("R0CODRUT");

                entity.Property(e => e.R0ruta)
                    .HasMaxLength(40)
                    .HasColumnName("R0RUTA");
            });

            modelBuilder.Entity<ScatiposCpp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCATiposCPP");

                entity.Property(e => e.V0codtcp).HasColumnName("V0CODTCP");

                entity.Property(e => e.V0destcp)
                    .HasMaxLength(20)
                    .HasColumnName("V0DESTCP");

                entity.Property(e => e.V0puntcp)
                    .HasColumnType("money")
                    .HasColumnName("V0PUNTCP");
            });

            modelBuilder.Entity<ScbanAluConv>(entity =>
            {
                entity.HasKey(e => e.B0nummat);

                entity.ToTable("SCBanAluConv");

                entity.Property(e => e.B0nummat)
                    .ValueGeneratedNever()
                    .HasColumnName("B0NUMMAT");

                entity.Property(e => e.B0permar).HasColumnName("B0PERMAR");
            });

            modelBuilder.Entity<ScbanCat>(entity =>
            {
                entity.HasKey(e => e.B0BanCod);

                entity.ToTable("SCBanCat");

                entity.Property(e => e.B0BanCod)
                    .ValueGeneratedNever()
                    .HasColumnName("b0BanCod");

                entity.Property(e => e.B0BanNoC)
                    .HasMaxLength(10)
                    .HasColumnName("b0BanNoC")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.B0BanNom)
                    .HasMaxLength(30)
                    .HasColumnName("b0BanNom")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.B0BanRut)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("b0BanRut")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ScbanCtum>(entity =>
            {
                entity.HasKey(e => e.C0CtaCod);

                entity.ToTable("SCBanCta");

                entity.Property(e => e.C0CtaCod)
                    .ValueGeneratedNever()
                    .HasColumnName("c0CtaCod");

                entity.Property(e => e.C0BanCod).HasColumnName("c0BanCod");

                entity.Property(e => e.C0CtaCct).HasColumnName("c0CtaCCt");

                entity.Property(e => e.C0CtaCie).HasColumnName("c0CtaCIE");

                entity.Property(e => e.C0CtaDes)
                    .HasMaxLength(20)
                    .HasColumnName("c0CtaDes")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.C0CtaMay).HasColumnName("c0CtaMay");

                entity.Property(e => e.C0CtaSsb).HasColumnName("c0CtaSSb");

                entity.Property(e => e.C0CtaSss).HasColumnName("c0CtaSSS");

                entity.Property(e => e.C0CtaSub).HasColumnName("c0CtaSub");
            });

            modelBuilder.Entity<ScbanMovCar>(entity =>
            {
                entity.HasKey(e => new { e.D0ctaMov, e.D0fecmov, e.D0renmov, e.D0tipmov, e.D0nummat, e.D0conmov, e.D0refmov, e.D0impmov });

                entity.ToTable("SCBanMovCar");

                entity.Property(e => e.D0ctaMov).HasColumnName("D0CtaMov");

                entity.Property(e => e.D0fecmov)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("D0FECMOV");

                entity.Property(e => e.D0renmov).HasColumnName("D0RENMOV");

                entity.Property(e => e.D0tipmov).HasColumnName("D0TIPMOV");

                entity.Property(e => e.D0nummat).HasColumnName("D0NUMMAT");

                entity.Property(e => e.D0conmov).HasColumnName("D0CONMOV");

                entity.Property(e => e.D0refmov).HasColumnName("D0REFMOV");

                entity.Property(e => e.D0impmov)
                    .HasColumnType("money")
                    .HasColumnName("D0IMPMOV");

                entity.Property(e => e.D0FpaMov)
                    .HasMaxLength(10)
                    .HasColumnName("d0FPaMov")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.D0bonmov)
                    .HasColumnType("money")
                    .HasColumnName("D0BONMOV");

                entity.Property(e => e.D0folrec).HasColumnName("D0FOLREC");

                entity.Property(e => e.D0sacmov)
                    .HasMaxLength(1)
                    .HasColumnName("D0SACMOV")
                    .UseCollation("Traditional_Spanish_BIN");

                entity.Property(e => e.D0seamov)
                    .HasMaxLength(1)
                    .HasColumnName("D0SEAMOV")
                    .UseCollation("Traditional_Spanish_BIN");
            });

            modelBuilder.Entity<ScbanMovto>(entity =>
            {
                entity.HasKey(e => new { e.C0ctaMov, e.C0fecmov, e.C0renmov, e.C0tipmov, e.C0numcon, e.C0nummat, e.C0numref });

                entity.ToTable("SCBanMovtos");

                entity.Property(e => e.C0ctaMov).HasColumnName("C0CtaMov");

                entity.Property(e => e.C0fecmov)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("C0FECMOV");

                entity.Property(e => e.C0renmov).HasColumnName("C0RENMOV");

                entity.Property(e => e.C0tipmov).HasColumnName("C0TIPMOV");

                entity.Property(e => e.C0numcon).HasColumnName("C0NUMCON");

                entity.Property(e => e.C0nummat).HasColumnName("C0NUMMAT");

                entity.Property(e => e.C0numref).HasColumnName("C0NUMREF");

                entity.Property(e => e.C0forpag)
                    .HasMaxLength(10)
                    .HasColumnName("C0FORPAG")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.C0idemov)
                    .HasMaxLength(1)
                    .HasColumnName("C0IDEMOV")
                    .UseCollation("Traditional_Spanish_BIN");

                entity.Property(e => e.C0impmov)
                    .HasColumnType("money")
                    .HasColumnName("C0IMPMOV");

                entity.Property(e => e.C0impnet)
                    .HasColumnType("money")
                    .HasColumnName("C0IMPNET");

                entity.Property(e => e.C0imprec)
                    .HasColumnType("money")
                    .HasColumnName("C0IMPREC");

                entity.Property(e => e.C0nombre)
                    .HasMaxLength(100)
                    .HasColumnName("C0Nombre")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.C0nompza)
                    .HasMaxLength(20)
                    .HasColumnName("C0NOMPZA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.C0numpza).HasColumnName("C0NUMPZA");

                entity.Property(e => e.C0numsuc).HasColumnName("C0NUMSUC");

                entity.Property(e => e.C0sacmov)
                    .HasMaxLength(1)
                    .HasColumnName("C0SACMOV")
                    .UseCollation("Traditional_Spanish_BIN");
            });

            modelBuilder.Entity<ScbanPar>(entity =>
            {
                entity.HasKey(e => e.A0Dato);

                entity.ToTable("SCBanPar");

                entity.Property(e => e.A0Dato)
                    .HasMaxLength(15)
                    .HasColumnName("a0Dato")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.A0Valor)
                    .HasMaxLength(20)
                    .HasColumnName("a0Valor")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Scbeca>(entity =>
            {
                entity.HasKey(e => e.E0tipbec)
                    .HasName("PK_SCAEBEC");

                entity.ToTable("SCBecas");

                entity.Property(e => e.E0tipbec)
                    .HasMaxLength(1)
                    .HasColumnName("E0TIPBEC");

                entity.Property(e => e.E0bascre)
                    .HasMaxLength(7)
                    .HasColumnName("E0BASCRE");

                entity.Property(e => e.E0feclim)
                    .HasColumnType("datetime")
                    .HasColumnName("E0FECLIM");

                entity.Property(e => e.E0nombec)
                    .HasMaxLength(20)
                    .HasColumnName("E0NOMBEC");

                entity.Property(e => e.E0numhrs).HasColumnName("E0NUMHRS");

                entity.Property(e => e.E0porbec).HasColumnName("E0PORBEC");

                entity.Property(e => e.E0porcre).HasColumnName("E0PORCRE");
            });

            modelBuilder.Entity<Sccalend>(entity =>
            {
                entity.HasKey(e => new { e.F0numniv, e.F0aciclo })
                    .HasName("PK_SCAFCAL");

                entity.ToTable("SCCalend");

                entity.Property(e => e.F0numniv).HasColumnName("F0NUMNIV");

                entity.Property(e => e.F0aciclo).HasColumnName("F0ACICLO");

                entity.Property(e => e.F0nump10).HasColumnName("F0NUMP10");

                entity.Property(e => e.F0nump11).HasColumnName("F0NUMP11");

                entity.Property(e => e.F0nump12).HasColumnName("F0NUMP12");

                entity.Property(e => e.F0numpe1).HasColumnName("F0NUMPE1");

                entity.Property(e => e.F0numpe2).HasColumnName("F0NUMPE2");

                entity.Property(e => e.F0numpe3).HasColumnName("F0NUMPE3");

                entity.Property(e => e.F0numpe4).HasColumnName("F0NUMPE4");

                entity.Property(e => e.F0numpe5).HasColumnName("F0NUMPE5");

                entity.Property(e => e.F0numpe6).HasColumnName("F0NUMPE6");

                entity.Property(e => e.F0numpe7).HasColumnName("F0NUMPE7");

                entity.Property(e => e.F0numpe8).HasColumnName("F0NUMPE8");

                entity.Property(e => e.F0numpe9).HasColumnName("F0NUMPE9");

                entity.HasOne(d => d.F0numnivNavigation)
                    .WithMany(p => p.Sccalends)
                    .HasForeignKey(d => d.F0numniv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCCalend_SCNivAcad");
            });

            modelBuilder.Entity<SccartasPf>(entity =>
            {
                entity.HasKey(e => new { e.C0numniv, e.C0numgpo, e.C0nummat });

                entity.ToTable("SCCartasPF");

                entity.Property(e => e.C0numniv).HasColumnName("C0NUMNIV");

                entity.Property(e => e.C0numgpo).HasColumnName("C0NUMGPO");

                entity.Property(e => e.C0nummat).HasColumnName("C0NUMMAT");

                entity.Property(e => e.C0senimp).HasColumnName("C0SENIMP");
            });

            modelBuilder.Entity<SccompDet>(entity =>
            {
                entity.HasKey(e => new { e.K1folio, e.K1pagNum });

                entity.ToTable("SCCompDet");

                entity.Property(e => e.K1folio).HasColumnName("K1Folio");

                entity.Property(e => e.K1pagNum).HasColumnName("K1PagNum");

                entity.Property(e => e.K1pagFec)
                    .HasColumnType("datetime")
                    .HasColumnName("K1PagFec");

                entity.Property(e => e.K1pagImp)
                    .HasColumnType("money")
                    .HasColumnName("K1PagImp");
            });

            modelBuilder.Entity<Sccomprom>(entity =>
            {
                entity.HasKey(e => new { e.K0folio, e.K0nummat, e.K0feccom })
                    .HasName("PK_SCAKAGE");

                entity.ToTable("SCComprom");

                entity.Property(e => e.K0folio)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("K0Folio");

                entity.Property(e => e.K0nummat).HasColumnName("K0NUMMAT");

                entity.Property(e => e.K0feccom)
                    .HasColumnType("datetime")
                    .HasColumnName("K0FECCOM");

                entity.Property(e => e.K0comen1)
                    .HasMaxLength(60)
                    .HasColumnName("K0COMEN1");

                entity.Property(e => e.K0comen2)
                    .HasMaxLength(60)
                    .HasColumnName("K0COMEN2");

                entity.Property(e => e.K0comen3)
                    .HasMaxLength(60)
                    .HasColumnName("K0COMEN3");

                entity.Property(e => e.K0fecdia)
                    .HasColumnType("datetime")
                    .HasColumnName("K0FECDIA");

                entity.Property(e => e.K0import).HasColumnName("K0IMPORT");

                entity.Property(e => e.K0nomalu)
                    .HasMaxLength(35)
                    .HasColumnName("K0NOMALU");
            });

            modelBuilder.Entity<Scconcep>(entity =>
            {
                entity.HasKey(e => e.C0numcon)
                    .HasName("PK_SCACCON");

                entity.ToTable("SCConcep");

                entity.Property(e => e.C0numcon).HasColumnName("C0NUMCON");

                entity.Property(e => e.C0carrec)
                    .HasMaxLength(1)
                    .HasColumnName("C0CARREC");

                entity.Property(e => e.C0codrec).HasColumnName("C0CODREC");

                entity.Property(e => e.C0mansal)
                    .HasMaxLength(1)
                    .HasColumnName("C0MANSAL");

                entity.Property(e => e.C0nomcon)
                    .HasMaxLength(20)
                    .HasColumnName("C0NOMCON");

                entity.Property(e => e.C0numccs).HasColumnName("C0NUMCCS");

                entity.Property(e => e.C0numcta).HasColumnName("C0NUMCTA");

                entity.Property(e => e.C0numsct).HasColumnName("C0NUMSCT");

                entity.Property(e => e.C0numssc).HasColumnName("C0NUMSSC");

                entity.Property(e => e.C0numsss).HasColumnName("C0NUMSSS");

                entity.Property(e => e.C0sencop)
                    .HasMaxLength(1)
                    .HasColumnName("C0SENCOP");

                entity.Property(e => e.C0senfre)
                    .HasMaxLength(1)
                    .HasColumnName("C0SENFRE");

                entity.Property(e => e.C0senrec)
                    .HasMaxLength(1)
                    .HasColumnName("C0SENREC");

                entity.Property(e => e.C0tasiva).HasColumnName("C0TASIVA");

                entity.Property(e => e.C0tipref).HasColumnName("C0TIPREF");

                entity.Property(e => e.C0topmax).HasColumnName("C0TOPMAX");

                entity.Property(e => e.C0valcop).HasColumnName("C0VALCOP");
            });

            modelBuilder.Entity<ScdatCli>(entity =>
            {
                entity.HasKey(e => new { e.H1folRec, e.H1tipIng })
                    .HasName("PK_SCDatCli_1");

                entity.ToTable("SCDatCli");

                entity.Property(e => e.H1folRec).HasColumnName("H1FolRec");

                entity.Property(e => e.H1tipIng)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("H1TipIng")
                    .IsFixedLength(true);

                entity.Property(e => e.H1celCli)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("H1CElCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1ciuCli)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("H1CiuCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1codPro).HasColumnName("H1CodPro");

                entity.Property(e => e.H1colCli)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("H1ColCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1cpoCli).HasColumnName("H1CPoCli");

                entity.Property(e => e.H1curCli)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("H1CurCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1domCli)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("H1DomCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1edoCli)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("H1EdoCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1munCli)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("H1MunCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1nomCli)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("H1NomCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1paiCli)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("H1PaiCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1rfccli)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("H1RFCCli")
                    .IsFixedLength(true);

                entity.Property(e => e.H1telCli)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("H1TelCli")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ScdatIn>(entity =>
            {
                entity.HasKey(e => e.A0nomemp)
                    .HasName("PK_SCAACIA");

                entity.ToTable("SCDatIns");

                entity.Property(e => e.A0nomemp)
                    .HasMaxLength(60)
                    .HasColumnName("A0NOMEMP");

                entity.Property(e => e.A0AutMail).HasColumnName("a0AutMail");

                entity.Property(e => e.A0Cfdicer)
                    .HasMaxLength(200)
                    .HasColumnName("a0CFDICer")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Cfdiimg)
                    .HasMaxLength(200)
                    .HasColumnName("a0CFDIImg")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Cfdikey)
                    .HasMaxLength(200)
                    .HasColumnName("a0CFDIKey")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Cfdipas)
                    .HasMaxLength(20)
                    .HasColumnName("a0CFDIPas")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Cfdipcp)
                    .HasMaxLength(100)
                    .HasColumnName("a0CFDIPCP")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Cfdirap)
                    .HasMaxLength(200)
                    .HasColumnName("a0CFDIRAP")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Cfdirax)
                    .HasMaxLength(200)
                    .HasColumnName("a0CFDIRAX")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Cfdiucp)
                    .HasMaxLength(20)
                    .HasColumnName("a0CFDIUCP")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Cfdixcp)
                    .HasMaxLength(200)
                    .HasColumnName("a0CFDIXCP")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Colonia)
                    .HasMaxLength(40)
                    .HasColumnName("a0Colonia")
                    .IsFixedLength(true);

                entity.Property(e => e.A0CtaMail)
                    .HasMaxLength(70)
                    .HasColumnName("a0CtaMail")
                    .IsFixedLength(true);

                entity.Property(e => e.A0CvePro)
                    .HasMaxLength(8)
                    .HasColumnName("a0CvePro")
                    .IsFixedLength(true);

                entity.Property(e => e.A0CveReg)
                    .HasMaxLength(3)
                    .HasColumnName("a0CveReg")
                    .IsFixedLength(true);

                entity.Property(e => e.A0CveUnM)
                    .HasMaxLength(3)
                    .HasColumnName("a0CveUnM")
                    .IsFixedLength(true);

                entity.Property(e => e.A0CveUso)
                    .HasMaxLength(3)
                    .HasColumnName("a0CveUso")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Estado)
                    .HasMaxLength(30)
                    .HasColumnName("a0Estado")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Municipio)
                    .HasMaxLength(40)
                    .HasColumnName("a0Municipio")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Pacact).HasColumnName("a0PACAct");

                entity.Property(e => e.A0PasMail)
                    .HasMaxLength(20)
                    .HasColumnName("a0PasMail")
                    .IsFixedLength(true);

                entity.Property(e => e.A0PrvPdf).HasColumnName("a0PrvPDF");

                entity.Property(e => e.A0PrvTimb).HasColumnName("a0PrvTimb");

                entity.Property(e => e.A0PtoMail).HasColumnName("a0PtoMail");

                entity.Property(e => e.A0SerMail)
                    .HasMaxLength(70)
                    .HasColumnName("a0SerMail")
                    .IsFixedLength(true);

                entity.Property(e => e.A0Sslmail).HasColumnName("a0SSLMail");

                entity.Property(e => e.A0Vpactest).HasColumnName("a0VPACTest");

                entity.Property(e => e.A0carErr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("A0CarErr")
                    .IsFixedLength(true);

                entity.Property(e => e.A0carIn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("A0CarIN")
                    .IsFixedLength(true);

                entity.Property(e => e.A0carOut)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("A0CarOut")
                    .IsFixedLength(true);

                entity.Property(e => e.A0cierre)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0CIERRE");

                entity.Property(e => e.A0codpos).HasColumnName("A0CODPOS");

                entity.Property(e => e.A0conbec).HasColumnName("A0CONBEC");

                entity.Property(e => e.A0concre).HasColumnName("A0CONCRE");

                entity.Property(e => e.A0diasr1).HasColumnName("A0DIASR1");

                entity.Property(e => e.A0diasr2).HasColumnName("A0DIASR2");

                entity.Property(e => e.A0diasre).HasColumnName("A0DIASRE");

                entity.Property(e => e.A0direcc)
                    .HasMaxLength(40)
                    .HasColumnName("A0DIRECC");

                entity.Property(e => e.A0ejeFis).HasColumnName("A0EjeFis");

                entity.Property(e => e.A0fecpro)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0FECPRO");

                entity.Property(e => e.A0firpar)
                    .HasMaxLength(50)
                    .HasColumnName("A0FIRPAR");

                entity.Property(e => e.A0folRvoe)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("A0FolRVOE")
                    .IsFixedLength(true);

                entity.Property(e => e.A0frmpag)
                    .HasMaxLength(1)
                    .HasColumnName("A0FRMPAG");

                entity.Property(e => e.A0licemp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("A0LICEMP")
                    .IsFixedLength(true);

                entity.Property(e => e.A0manBco)
                    .HasMaxLength(1)
                    .HasColumnName("A0ManBco")
                    .IsFixedLength(true);

                entity.Property(e => e.A0mancre)
                    .HasMaxLength(1)
                    .HasColumnName("A0MANCRE");

                entity.Property(e => e.A0mataut)
                    .HasMaxLength(1)
                    .HasColumnName("A0MATAUT");

                entity.Property(e => e.A0menCic)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("A0MenCic");

                entity.Property(e => e.A0menec1)
                    .HasMaxLength(70)
                    .HasColumnName("A0MENEC1");

                entity.Property(e => e.A0menec2)
                    .HasMaxLength(70)
                    .HasColumnName("A0MENEC2");

                entity.Property(e => e.A0menec3)
                    .HasMaxLength(70)
                    .HasColumnName("A0MENEC3");

                entity.Property(e => e.A0menec4)
                    .HasMaxLength(70)
                    .HasColumnName("A0MENEC4");

                entity.Property(e => e.A0menec5)
                    .HasMaxLength(70)
                    .HasColumnName("A0MENEC5");

                entity.Property(e => e.A0mensaj)
                    .HasMaxLength(56)
                    .HasColumnName("A0MENSAJ");

                entity.Property(e => e.A0perarr)
                    .HasMaxLength(1)
                    .HasColumnName("A0PERARR");

                entity.Property(e => e.A0poblac)
                    .HasMaxLength(20)
                    .HasColumnName("A0POBLAC");

                entity.Property(e => e.A0prgimp).HasColumnName("A0PRGIMP");

                entity.Property(e => e.A0ptopar)
                    .HasMaxLength(30)
                    .HasColumnName("A0PTOPAR");

                entity.Property(e => e.A0pueleg)
                    .HasMaxLength(15)
                    .HasColumnName("A0PUELEG");

                entity.Property(e => e.A0reccia)
                    .HasMaxLength(20)
                    .HasColumnName("A0RECCIA");

                entity.Property(e => e.A0regFis)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("A0RegFis")
                    .IsFixedLength(true);

                entity.Property(e => e.A0regfed)
                    .HasMaxLength(20)
                    .HasColumnName("A0REGFED");

                entity.Property(e => e.A0repleg)
                    .HasMaxLength(40)
                    .HasColumnName("A0REPLEG");

                entity.Property(e => e.A0rfcleg)
                    .HasMaxLength(20)
                    .HasColumnName("A0RFCLEG");

                entity.Property(e => e.A0rutscb)
                    .HasMaxLength(50)
                    .HasColumnName("A0RUTSCB");

                entity.Property(e => e.A0senfac)
                    .HasMaxLength(1)
                    .HasColumnName("A0SENFAC");

                entity.Property(e => e.A0tasiva).HasColumnName("A0TASIVA");

                entity.Property(e => e.A0telefo)
                    .HasMaxLength(15)
                    .HasColumnName("A0TELEFO");

                entity.Property(e => e.A0ultfol).HasColumnName("A0ULTFOL");

                entity.Property(e => e.A0ultfre)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0ULTFRE");

                entity.Property(e => e.A0ultmat).HasColumnName("A0ULTMAT");

                entity.Property(e => e.A0ultmov).HasColumnName("A0ULTMOV");

                entity.Property(e => e.A0ultneg).HasColumnName("A0ULTNEG");

                entity.Property(e => e.A0ulttra).HasColumnName("A0ULTTRA");
            });

            modelBuilder.Entity<ScdisEfectivo>(entity =>
            {
                entity.HasKey(e => e.M0numtra);

                entity.ToTable("SCDisEfectivo");

                entity.Property(e => e.M0numtra)
                    .ValueGeneratedNever()
                    .HasColumnName("M0NUMTRA");

                entity.Property(e => e.M0adeudo).HasColumnName("M0ADEUDO");

                entity.Property(e => e.M0cambio).HasColumnName("M0CAMBIO");

                entity.Property(e => e.M0desch1)
                    .HasMaxLength(30)
                    .HasColumnName("M0DESCH1");

                entity.Property(e => e.M0desch2)
                    .HasMaxLength(30)
                    .HasColumnName("M0DESCH2");

                entity.Property(e => e.M0destc1)
                    .HasMaxLength(30)
                    .HasColumnName("M0DESTC1");

                entity.Property(e => e.M0destc2)
                    .HasMaxLength(30)
                    .HasColumnName("M0DESTC2");

                entity.Property(e => e.M0fectra)
                    .HasColumnType("datetime")
                    .HasColumnName("M0FECTRA");

                entity.Property(e => e.M0folrec).HasColumnName("M0FOLREC");

                entity.Property(e => e.M0impch1).HasColumnName("M0IMPCH1");

                entity.Property(e => e.M0impch2).HasColumnName("M0IMPCH2");

                entity.Property(e => e.M0impefe).HasColumnName("M0IMPEFE");

                entity.Property(e => e.M0imprec).HasColumnName("M0IMPREC");

                entity.Property(e => e.M0imptc1).HasColumnName("M0IMPTC1");

                entity.Property(e => e.M0imptc2).HasColumnName("M0IMPTC2");

                entity.Property(e => e.M0recant).HasColumnName("M0RECANT");

                entity.Property(e => e.M0totpag).HasColumnName("M0TOTPAG");
            });

            modelBuilder.Entity<Scescuela>(entity =>
            {
                entity.HasKey(e => e.Q0codesc)
                    .HasName("PK_SCAQ0ESC");

                entity.ToTable("SCEscuelas");

                entity.Property(e => e.Q0codesc)
                    .ValueGeneratedNever()
                    .HasColumnName("Q0CODESC");

                entity.Property(e => e.Q0nomesc)
                    .HasMaxLength(40)
                    .HasColumnName("Q0NOMESC");
            });

            modelBuilder.Entity<Scfacele>(entity =>
            {
                entity.HasKey(e => new { e.FenumNiv, e.Fenumgpo, e.Fenummat, e.Fefecrec, e.FeserRec, e.Fefolrec, e.FetipDoc })
                    .HasName("PK__SCFACELE_New__5AEE82B9");

                entity.ToTable("SCFACELE");

                entity.Property(e => e.FenumNiv).HasColumnName("FENumNiv");

                entity.Property(e => e.Fenumgpo).HasColumnName("FENUMGPO");

                entity.Property(e => e.Fenummat).HasColumnName("FENUMMAT");

                entity.Property(e => e.Fefecrec)
                    .HasColumnType("datetime")
                    .HasColumnName("FEFECREC");

                entity.Property(e => e.FeserRec)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FESerRec")
                    .IsFixedLength(true);

                entity.Property(e => e.Fefolrec).HasColumnName("FEFOLREC");

                entity.Property(e => e.FetipDoc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FETipDoc")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacArc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FEFacArc")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacCfdi)
                    .HasColumnType("text")
                    .HasColumnName("FEFacCFDI");

                entity.Property(e => e.FefacEnv).HasColumnName("FEFacEnv");

                entity.Property(e => e.FefacErr)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FEFacErr")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacFeT)
                    .HasColumnType("datetime")
                    .HasColumnName("FEFacFeT");

                entity.Property(e => e.FefacRfce)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FEFacRFCE")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacRfcr)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FEFacRFCR")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacSat)
                    .HasColumnType("text")
                    .HasColumnName("FEFacSAT");

                entity.Property(e => e.FefacSer)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FEFacSer")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacSts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FEFacSts")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacUuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FEFacUUID")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacXml)
                    .HasColumnType("xml")
                    .HasColumnName("FEFacXml");

                entity.Property(e => e.FefecCan)
                    .HasColumnType("datetime")
                    .HasColumnName("FEFecCan");

                entity.Property(e => e.Feobserv)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FEObserv")
                    .IsFixedLength(true);

                entity.Property(e => e.FetipIng)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FETipIng")
                    .IsFixedLength(true);

                entity.Property(e => e.FetipPac).HasColumnName("FETipPAC");

                entity.Property(e => e.Fetotrec)
                    .HasColumnType("money")
                    .HasColumnName("FETOTREC");

                entity.Property(e => e.Feusuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FEUsuario")
                    .IsFixedLength(true);

                entity.Property(e => e.Feuuidref)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("FEUUIDRef")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ScfaceleAnt>(entity =>
            {
                entity.HasKey(e => new { e.FenumNiv, e.Fenumgpo, e.Fenummat, e.Fefecrec, e.FeserRec, e.Fefolrec })
                    .HasName("PK_SCFACELE_1");

                entity.ToTable("SCFACELE_ANT");

                entity.Property(e => e.FenumNiv).HasColumnName("FENumNiv");

                entity.Property(e => e.Fenumgpo).HasColumnName("FENUMGPO");

                entity.Property(e => e.Fenummat).HasColumnName("FENUMMAT");

                entity.Property(e => e.Fefecrec)
                    .HasColumnType("datetime")
                    .HasColumnName("FEFECREC");

                entity.Property(e => e.FeserRec)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FESerRec")
                    .IsFixedLength(true);

                entity.Property(e => e.Fefolrec).HasColumnName("FEFOLREC");

                entity.Property(e => e.FefacArc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FEFacArc")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacCfdi)
                    .HasColumnType("text")
                    .HasColumnName("FEFacCFDI");

                entity.Property(e => e.FefacErr)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FEFacErr")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacFeT)
                    .HasColumnType("datetime")
                    .HasColumnName("FEFacFeT");

                entity.Property(e => e.FefacRfce)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FEFacRFCE")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacRfcr)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("FEFacRFCR")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacSat)
                    .HasColumnType("text")
                    .HasColumnName("FEFacSAT");

                entity.Property(e => e.FefacSer)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FEFacSer")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacSts)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FEFacSts")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacUuid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("FEFacUUID")
                    .IsFixedLength(true);

                entity.Property(e => e.FefacXml)
                    .HasColumnType("xml")
                    .HasColumnName("FEFacXml");

                entity.Property(e => e.FetipDoc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FETipDoc")
                    .IsFixedLength(true);

                entity.Property(e => e.FetipIng)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("FETipIng")
                    .IsFixedLength(true);

                entity.Property(e => e.Fetotrec)
                    .HasColumnType("money")
                    .HasColumnName("FETOTREC");
            });

            modelBuilder.Entity<ScforDet>(entity =>
            {
                entity.HasKey(e => new { e.G04nomfrm, e.G04rowpos, e.G04colpos });

                entity.ToTable("SCForDet");

                entity.Property(e => e.G04nomfrm)
                    .HasMaxLength(6)
                    .HasColumnName("G04NOMFRM");

                entity.Property(e => e.G04rowpos).HasColumnName("G04ROWPOS");

                entity.Property(e => e.G04colpos).HasColumnName("G04COLPOS");

                entity.Property(e => e.G04campo)
                    .HasMaxLength(10)
                    .HasColumnName("G04CAMPO");

                entity.Property(e => e.G04const)
                    .HasMaxLength(135)
                    .HasColumnName("G04CONST");

                entity.Property(e => e.G04descrp)
                    .HasMaxLength(50)
                    .HasColumnName("G04DESCRP");

                entity.Property(e => e.G04lindat).HasColumnName("G04LINDAT");

                entity.Property(e => e.G04longit).HasColumnName("G04LONGIT");

                entity.Property(e => e.G04pictur)
                    .HasMaxLength(1)
                    .HasColumnName("G04PICTUR");

                entity.HasOne(d => d.G04nomfrmNavigation)
                    .WithMany(p => p.ScforDets)
                    .HasForeignKey(d => d.G04nomfrm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCForDet_SCFormatos");
            });

            modelBuilder.Entity<ScforPagoSat>(entity =>
            {
                entity.HasKey(e => e.FeCveFpa)
                    .HasName("PK_SCForPagSAT");

                entity.ToTable("SCForPagoSAT");

                entity.Property(e => e.FeCveFpa)
                    .HasMaxLength(2)
                    .HasColumnName("feCveFPa")
                    .IsFixedLength(true);

                entity.Property(e => e.FeBanFpa)
                    .HasMaxLength(1)
                    .HasColumnName("feBanFPa")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FeDesFpa)
                    .HasMaxLength(100)
                    .HasColumnName("feDesFPa")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Scformato>(entity =>
            {
                entity.HasKey(e => e.H0nomfrm);

                entity.ToTable("SCFormatos");

                entity.Property(e => e.H0nomfrm)
                    .HasMaxLength(6)
                    .HasColumnName("H0NOMFRM");

                entity.Property(e => e.H0desfrm)
                    .HasMaxLength(40)
                    .HasColumnName("H0DESFRM");

                entity.Property(e => e.H0idedoc)
                    .HasMaxLength(3)
                    .HasColumnName("H0IDEDOC");

                entity.Property(e => e.H0lastfr)
                    .HasMaxLength(6)
                    .HasColumnName("H0LASTFR");

                entity.Property(e => e.H0modulo)
                    .HasMaxLength(3)
                    .HasColumnName("H0MODULO");

                entity.Property(e => e.H0tipfor)
                    .HasMaxLength(1)
                    .HasColumnName("H0TIPFOR");

                entity.Property(e => e.H0tipimp)
                    .HasMaxLength(1)
                    .HasColumnName("H0TIPIMP");

                entity.Property(e => e.H0tiplet)
                    .HasMaxLength(1)
                    .HasColumnName("H0TIPLET");
            });

            modelBuilder.Entity<ScgpoCar>(entity =>
            {
                entity.HasKey(e => e.D0numgpo)
                    .HasName("PK_SCADGPO");

                entity.ToTable("SCGpoCar");

                entity.Property(e => e.D0numgpo)
                    .ValueGeneratedNever()
                    .HasColumnName("D0NUMGPO");

                entity.Property(e => e.D0codadm).HasColumnName("D0CODADM");

                entity.Property(e => e.D0codcol).HasColumnName("D0CODCOL");

                entity.Property(e => e.D0codins).HasColumnName("D0CODINS");

                entity.Property(e => e.D0codlib).HasColumnName("D0CODLIB");

                entity.Property(e => e.D0codmat).HasColumnName("D0CODMAT");

                entity.Property(e => e.D0codot1).HasColumnName("D0CODOT1");

                entity.Property(e => e.D0codot2).HasColumnName("D0CODOT2");

                entity.Property(e => e.D0codseg).HasColumnName("D0CODSEG");

                entity.Property(e => e.D0codtra).HasColumnName("D0CODTRA");

                entity.Property(e => e.D0dialim).HasColumnName("D0DIALIM");

                entity.Property(e => e.D0dialr1).HasColumnName("D0DIALR1");

                entity.Property(e => e.D0dialr2).HasColumnName("D0DIALR2");

                entity.Property(e => e.D0impadm).HasColumnName("D0IMPADM");

                entity.Property(e => e.D0impcol).HasColumnName("D0IMPCOL");

                entity.Property(e => e.D0impins).HasColumnName("D0IMPINS");

                entity.Property(e => e.D0implib).HasColumnName("D0IMPLIB");

                entity.Property(e => e.D0impmat).HasColumnName("D0IMPMAT");

                entity.Property(e => e.D0impot1).HasColumnName("D0IMPOT1");

                entity.Property(e => e.D0impot2).HasColumnName("D0IMPOT2");

                entity.Property(e => e.D0impseg).HasColumnName("D0IMPSEG");

                entity.Property(e => e.D0imptra).HasColumnName("D0IMPTRA");

                entity.Property(e => e.D0nomcor)
                    .HasMaxLength(5)
                    .HasColumnName("D0NOMCOR");

                entity.Property(e => e.D0nomgpo)
                    .HasMaxLength(40)
                    .HasColumnName("D0NOMGPO");

                entity.Property(e => e.D0numniv).HasColumnName("D0NUMNIV");

                entity.Property(e => e.D0numsem).HasColumnName("D0NUMSEM");

                entity.Property(e => e.D0rvoegpo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("D0RVOEGpo")
                    .IsFixedLength(true);

                entity.Property(e => e.D0senadm)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENADM");

                entity.Property(e => e.D0sencol)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENCOL");

                entity.Property(e => e.D0senins)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENINS");

                entity.Property(e => e.D0senlib)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENLIB");

                entity.Property(e => e.D0senmat)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENMAT");

                entity.Property(e => e.D0senot1)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENOT1");

                entity.Property(e => e.D0senot2)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENOT2");

                entity.Property(e => e.D0senseg)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENSEG");

                entity.Property(e => e.D0sentra)
                    .HasMaxLength(1)
                    .HasColumnName("D0SENTRA");

                entity.Property(e => e.D0valadm).HasColumnName("D0VALADM");

                entity.Property(e => e.D0valcol).HasColumnName("D0VALCOL");

                entity.Property(e => e.D0valins).HasColumnName("D0VALINS");

                entity.Property(e => e.D0vallib).HasColumnName("D0VALLIB");

                entity.Property(e => e.D0valmat).HasColumnName("D0VALMAT");

                entity.Property(e => e.D0valot1).HasColumnName("D0VALOT1");

                entity.Property(e => e.D0valot2).HasColumnName("D0VALOT2");

                entity.Property(e => e.D0valseg).HasColumnName("D0VALSEG");

                entity.Property(e => e.D0valtra).HasColumnName("D0VALTRA");

                entity.HasOne(d => d.D0numnivNavigation)
                    .WithMany(p => p.ScgpoCars)
                    .HasForeignKey(d => d.D0numniv)
                    .HasConstraintName("FK_SCGpoCar_SCNivAcad");
            });

            modelBuilder.Entity<Schmovimi>(entity =>
            {
                entity.HasKey(e => new { e.H0consec, e.H0consec2, e.H0numniv, e.H0numgpo, e.H0nummat })
                    .HasName("PK_SCAHMOV");

                entity.ToTable("SCHMovimi");

                entity.Property(e => e.H0consec).HasColumnName("H0CONSEC");

                entity.Property(e => e.H0consec2).HasColumnName("H0Consec2");

                entity.Property(e => e.H0numniv).HasColumnName("H0NUMNIV");

                entity.Property(e => e.H0numgpo).HasColumnName("H0NUMGPO");

                entity.Property(e => e.H0nummat).HasColumnName("H0NUMMAT");

                entity.Property(e => e.H0autori)
                    .HasMaxLength(6)
                    .HasColumnName("H0AUTORI");

                entity.Property(e => e.H0cajUsu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("H0CajUsu")
                    .IsFixedLength(true);

                entity.Property(e => e.H0cbaMov)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("H0CBaMov")
                    .IsFixedLength(true);

                entity.Property(e => e.H0codpro).HasColumnName("H0CODPRO");

                entity.Property(e => e.H0cpaMov)
                    .HasMaxLength(10)
                    .HasColumnName("H0CPaMov")
                    .IsFixedLength(true);

                entity.Property(e => e.H0ctaCod).HasColumnName("H0CtaCod");

                entity.Property(e => e.H0descri)
                    .HasMaxLength(40)
                    .HasColumnName("H0DESCRI");

                entity.Property(e => e.H0fecmov)
                    .HasColumnType("datetime")
                    .HasColumnName("H0FECMOV");

                entity.Property(e => e.H0folneg).HasColumnName("H0FOLNEG");

                entity.Property(e => e.H0folrec).HasColumnName("H0FOLREC");

                entity.Property(e => e.H0fpaMov)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("H0FPaMov")
                    .IsFixedLength(true);

                entity.Property(e => e.H0fpaMov33)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("H0FPaMov33")
                    .IsFixedLength(true);

                entity.Property(e => e.H0impbon).HasColumnName("H0IMPBON");

                entity.Property(e => e.H0import).HasColumnName("H0IMPORT");

                entity.Property(e => e.H0menCic)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("H0MenCic");

                entity.Property(e => e.H0mensaj)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("H0Mensaj");

                entity.Property(e => e.H0mpaMov).HasColumnName("H0MPaMov");

                entity.Property(e => e.H0mpaMov33)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("H0MPaMov33")
                    .IsFixedLength(true);

                entity.Property(e => e.H0numcon).HasColumnName("H0NUMCON");

                entity.Property(e => e.H0numref).HasColumnName("H0NUMREF");

                entity.Property(e => e.H0numtra).HasColumnName("H0NUMTRA");

                entity.Property(e => e.H0numusu).HasColumnName("H0NUMUSU");

                entity.Property(e => e.H0observ)
                    .HasMaxLength(80)
                    .HasColumnName("H0OBSERV");

                entity.Property(e => e.H0pagCie).HasColumnName("H0PagCIE");

                entity.Property(e => e.H0porbec).HasColumnName("H0PORBEC");

                entity.Property(e => e.H0senenl)
                    .HasMaxLength(1)
                    .HasColumnName("H0SENENL");

                entity.Property(e => e.H0senfac)
                    .HasMaxLength(1)
                    .HasColumnName("H0SENFAC");

                entity.Property(e => e.H0tascpp).HasColumnName("H0TASCPP");

                entity.Property(e => e.H0tipDoc)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("H0TipDoc")
                    .IsFixedLength(true);

                entity.Property(e => e.H0tipIng)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("H0TipIng")
                    .IsFixedLength(true);

                entity.Property(e => e.H0tipbec)
                    .HasMaxLength(1)
                    .HasColumnName("H0TIPBEC");

                entity.Property(e => e.H0tipmov).HasColumnName("H0TIPMOV");
            });

            modelBuilder.Entity<Scimpre>(entity =>
            {
                entity.HasKey(e => new { e.I0usuimp, e.I0desimp });

                entity.ToTable("SCImpres");

                entity.Property(e => e.I0usuimp)
                    .HasMaxLength(6)
                    .HasColumnName("I0USUIMP");

                entity.Property(e => e.I0desimp)
                    .HasMaxLength(60)
                    .HasColumnName("I0DESIMP");

                entity.Property(e => e.I0actimp)
                    .HasMaxLength(1)
                    .HasColumnName("I0ACTIMP");

                entity.Property(e => e.I0ch1imp).HasColumnName("I0CH1IMP");

                entity.Property(e => e.I0ch2imp).HasColumnName("I0CH2IMP");

                entity.Property(e => e.I0ch3imp).HasColumnName("I0CH3IMP");

                entity.Property(e => e.I0ch4imp).HasColumnName("I0CH4IMP");

                entity.Property(e => e.I0ch5imp).HasColumnName("I0CH5IMP");

                entity.Property(e => e.I0ch6imp).HasColumnName("I0CH6IMP");

                entity.Property(e => e.I0disimp)
                    .HasMaxLength(40)
                    .HasColumnName("I0DISIMP");

                entity.Property(e => e.I0hojimp).HasColumnName("I0HOJIMP");

                entity.Property(e => e.I0imptex).HasColumnName("I0IMPTEX");
            });

            modelBuilder.Entity<ScimpuestosSat>(entity =>
            {
                entity.HasKey(e => e.FeCveImp)
                    .HasName("PK_SCImpSAT");

                entity.ToTable("SCImpuestosSAT");

                entity.Property(e => e.FeCveImp)
                    .HasMaxLength(3)
                    .HasColumnName("feCveImp")
                    .IsFixedLength(true);

                entity.Property(e => e.FeDesImp)
                    .HasMaxLength(30)
                    .HasColumnName("feDesImp")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FeRetImp)
                    .HasMaxLength(1)
                    .HasColumnName("feRetImp")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FeTipImp)
                    .HasMaxLength(1)
                    .HasColumnName("feTipImp")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FeTraImp)
                    .HasMaxLength(1)
                    .HasColumnName("feTraImp")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Scisaldo>(entity =>
            {
                entity.HasKey(e => new { e.I0numniv, e.I0numgpo, e.I0nummat, e.I0numcon, e.I0numref, e.I0consec })
                    .HasName("PK_SCAICAR");

                entity.ToTable("SCISaldos");

                entity.Property(e => e.I0numniv).HasColumnName("I0NUMNIV");

                entity.Property(e => e.I0numgpo).HasColumnName("I0NUMGPO");

                entity.Property(e => e.I0nummat).HasColumnName("I0NUMMAT");

                entity.Property(e => e.I0numcon).HasColumnName("I0NUMCON");

                entity.Property(e => e.I0numref).HasColumnName("I0NUMREF");

                entity.Property(e => e.I0consec).HasColumnName("I0Consec");

                entity.Property(e => e.I0codtcp).HasColumnName("I0CODTCP");

                entity.Property(e => e.I0fecope)
                    .HasColumnType("datetime")
                    .HasColumnName("I0FECOPE");

                entity.Property(e => e.I0fecpag)
                    .HasColumnType("datetime")
                    .HasColumnName("I0FECPAG");

                entity.Property(e => e.I0fecuci)
                    .HasColumnType("datetime")
                    .HasColumnName("I0FECUCI");

                entity.Property(e => e.I0fecven)
                    .HasColumnType("datetime")
                    .HasColumnName("I0FECVEN");

                entity.Property(e => e.I0import).HasColumnName("I0IMPORT");

                entity.Property(e => e.I0imppag).HasColumnName("I0IMPPAG");

                entity.Property(e => e.I0ncontr).HasColumnName("I0NCONTR");

                entity.Property(e => e.I0nomalu)
                    .HasMaxLength(40)
                    .HasColumnName("I0NOMALU");

                entity.Property(e => e.I0refcar).HasColumnName("I0REFCAR");

                entity.Property(e => e.I0salact).HasColumnName("I0SALACT");

                entity.Property(e => e.I0salrec).HasColumnName("I0SALREC");

                entity.Property(e => e.I0senaux)
                    .HasMaxLength(1)
                    .HasColumnName("I0SENAUX");

                entity.Property(e => e.I0senrec)
                    .HasMaxLength(1)
                    .HasColumnName("I0SENREC");

                entity.Property(e => e.I0tascpp).HasColumnName("I0TASCPP");

                entity.Property(e => e.I0ultrec)
                    .HasColumnType("datetime")
                    .HasColumnName("I0ULTREC");
            });

            modelBuilder.Entity<ScjsalHi>(entity =>
            {
                entity.HasKey(e => new { e.J0numniv, e.J0numgpo, e.J0nummat, e.J0anohis })
                    .HasName("PK_SCAJSAL");

                entity.ToTable("SCJSalHis");

                entity.Property(e => e.J0numniv).HasColumnName("J0NUMNIV");

                entity.Property(e => e.J0numgpo).HasColumnName("J0NUMGPO");

                entity.Property(e => e.J0nummat).HasColumnName("J0NUMMAT");

                entity.Property(e => e.J0anohis).HasColumnName("J0ANOHIS");

                entity.Property(e => e.J0abon01).HasColumnName("J0ABON01");

                entity.Property(e => e.J0abon02).HasColumnName("J0ABON02");

                entity.Property(e => e.J0abon03).HasColumnName("J0ABON03");

                entity.Property(e => e.J0abon04).HasColumnName("J0ABON04");

                entity.Property(e => e.J0abon05).HasColumnName("J0ABON05");

                entity.Property(e => e.J0abon06).HasColumnName("J0ABON06");

                entity.Property(e => e.J0abon07).HasColumnName("J0ABON07");

                entity.Property(e => e.J0abon08).HasColumnName("J0ABON08");

                entity.Property(e => e.J0abon09).HasColumnName("J0ABON09");

                entity.Property(e => e.J0abon10).HasColumnName("J0ABON10");

                entity.Property(e => e.J0abon11).HasColumnName("J0ABON11");

                entity.Property(e => e.J0abon12).HasColumnName("J0ABON12");

                entity.Property(e => e.J0carg01).HasColumnName("J0CARG01");

                entity.Property(e => e.J0carg02).HasColumnName("J0CARG02");

                entity.Property(e => e.J0carg03).HasColumnName("J0CARG03");

                entity.Property(e => e.J0carg04).HasColumnName("J0CARG04");

                entity.Property(e => e.J0carg05).HasColumnName("J0CARG05");

                entity.Property(e => e.J0carg06).HasColumnName("J0CARG06");

                entity.Property(e => e.J0carg07).HasColumnName("J0CARG07");

                entity.Property(e => e.J0carg08).HasColumnName("J0CARG08");

                entity.Property(e => e.J0carg09).HasColumnName("J0CARG09");

                entity.Property(e => e.J0carg10).HasColumnName("J0CARG10");

                entity.Property(e => e.J0carg11).HasColumnName("J0CARG11");

                entity.Property(e => e.J0carg12).HasColumnName("J0CARG12");

                entity.Property(e => e.J0salini).HasColumnName("J0SALINI");
            });

            modelBuilder.Entity<ScmetPago>(entity =>
            {
                entity.HasKey(e => e.Z0CveMpa)
                    .HasName("PK_SCMetPagos");

                entity.ToTable("SCMetPago");

                entity.Property(e => e.Z0CveMpa)
                    .ValueGeneratedNever()
                    .HasColumnName("z0CveMPa");

                entity.Property(e => e.Z0DesMpa)
                    .HasMaxLength(40)
                    .HasColumnName("z0DesMPa")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ScmetPagoSat>(entity =>
            {
                entity.HasKey(e => e.FeCveMpa)
                    .HasName("PK_SCMetPagSAT");

                entity.ToTable("SCMetPagoSAT");

                entity.Property(e => e.FeCveMpa)
                    .HasMaxLength(3)
                    .HasColumnName("feCveMPa")
                    .IsFixedLength(true);

                entity.Property(e => e.FeDesMpa)
                    .HasMaxLength(100)
                    .HasColumnName("feDesMPa")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ScnivAcad>(entity =>
            {
                entity.HasKey(e => e.B0numniv)
                    .HasName("PK_SCABNIV");

                entity.ToTable("SCNivAcad");

                entity.Property(e => e.B0numniv).HasColumnName("B0NUMNIV");

                entity.Property(e => e.B0aciclo).HasColumnName("B0ACICLO");

                entity.Property(e => e.B0nomniv)
                    .HasMaxLength(20)
                    .HasColumnName("B0NOMNIV");
            });

            modelBuilder.Entity<ScproSerSat>(entity =>
            {
                entity.HasKey(e => e.FeCvePro);

                entity.ToTable("SCProSerSAT");

                entity.Property(e => e.FeCvePro)
                    .HasMaxLength(8)
                    .HasColumnName("feCvePro")
                    .IsFixedLength(true);

                entity.Property(e => e.FeDesPro)
                    .HasMaxLength(150)
                    .HasColumnName("feDesPro")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Scprospec>(entity =>
            {
                entity.HasKey(e => e.P0codpro)
                    .HasName("PK_SCAP0PRO");

                entity.ToTable("SCProspec");

                entity.Property(e => e.P0codpro)
                    .ValueGeneratedNever()
                    .HasColumnName("P0CODPRO");

                entity.Property(e => e.P0CelPro)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("p0CElPro")
                    .IsFixedLength(true);

                entity.Property(e => e.P0ColPro)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("p0ColPro")
                    .IsFixedLength(true);

                entity.Property(e => e.P0CpoPro).HasColumnName("p0CPoPro");

                entity.Property(e => e.P0CurPro)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("p0CurPro")
                    .IsFixedLength(true);

                entity.Property(e => e.P0EdoPro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("p0EdoPro")
                    .IsFixedLength(true);

                entity.Property(e => e.P0MunPro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("p0MunPro")
                    .IsFixedLength(true);

                entity.Property(e => e.P0PaiPro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("p0PaiPro")
                    .IsFixedLength(true);

                entity.Property(e => e.P0TelPro)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("p0TelPro")
                    .IsFixedLength(true);

                entity.Property(e => e.P0apmpro)
                    .HasMaxLength(20)
                    .HasColumnName("P0APMPRO");

                entity.Property(e => e.P0apppro)
                    .HasMaxLength(20)
                    .HasColumnName("P0APPPRO");

                entity.Property(e => e.P0ciupro)
                    .HasMaxLength(20)
                    .HasColumnName("P0CIUPRO");

                entity.Property(e => e.P0codcar).HasColumnName("P0CODCAR");

                entity.Property(e => e.P0codesc).HasColumnName("P0CODESC");

                entity.Property(e => e.P0dompro)
                    .HasMaxLength(50)
                    .HasColumnName("P0DOMPRO");

                entity.Property(e => e.P0nompro)
                    .HasMaxLength(60)
                    .HasColumnName("P0NOMPRO");

                entity.Property(e => e.P0nospro)
                    .HasMaxLength(20)
                    .HasColumnName("P0NOSPRO");

                entity.Property(e => e.P0nummat).HasColumnName("P0NUMMAT");

                entity.Property(e => e.P0numsem).HasColumnName("P0NUMSEM");

                entity.Property(e => e.P0rfcpro)
                    .HasMaxLength(15)
                    .HasColumnName("P0RFCPRO");

                entity.HasOne(d => d.P0codcarNavigation)
                    .WithMany(p => p.Scprospecs)
                    .HasForeignKey(d => d.P0codcar)
                    .HasConstraintName("FK_SCProspec_SCGpoCar");

                entity.HasOne(d => d.P0codescNavigation)
                    .WithMany(p => p.Scprospecs)
                    .HasForeignKey(d => d.P0codesc)
                    .HasConstraintName("FK_SCProspec_SCEscuelas");
            });

            modelBuilder.Entity<Screferen>(entity =>
            {
                entity.HasKey(e => e.N0numref)
                    .HasName("PK_SCANREF");

                entity.ToTable("SCReferen");

                entity.Property(e => e.N0numref)
                    .ValueGeneratedNever()
                    .HasColumnName("N0NUMREF");

                entity.Property(e => e.N0nomref)
                    .HasMaxLength(25)
                    .HasColumnName("N0NOMREF");
            });

            modelBuilder.Entity<ScregSat>(entity =>
            {
                entity.HasKey(e => e.FeCveReg);

                entity.ToTable("SCRegSAT");

                entity.Property(e => e.FeCveReg)
                    .HasMaxLength(3)
                    .HasColumnName("feCveReg")
                    .IsFixedLength(true);

                entity.Property(e => e.FeDesReg)
                    .HasMaxLength(100)
                    .HasColumnName("feDesReg")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FePfmreg)
                    .HasMaxLength(1)
                    .HasColumnName("fePFMReg")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Scstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SCStatus");

                entity.Property(e => e.U0codsta)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("U0CODSTA");

                entity.Property(e => e.U0dessta)
                    .HasMaxLength(30)
                    .HasColumnName("U0DESSTA");
            });

            modelBuilder.Entity<SctasaCpp>(entity =>
            {
                entity.HasKey(e => e.T0anocpp);

                entity.ToTable("SCTasaCPP");

                entity.Property(e => e.T0anocpp)
                    .HasMaxLength(4)
                    .HasColumnName("T0ANOCPP");

                entity.Property(e => e.T0m01cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M01CPP");

                entity.Property(e => e.T0m02cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M02CPP");

                entity.Property(e => e.T0m03cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M03CPP");

                entity.Property(e => e.T0m04cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M04CPP");

                entity.Property(e => e.T0m05cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M05CPP");

                entity.Property(e => e.T0m06cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M06CPP");

                entity.Property(e => e.T0m07cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M07CPP");

                entity.Property(e => e.T0m08cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M08CPP");

                entity.Property(e => e.T0m09cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M09CPP");

                entity.Property(e => e.T0m10cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M10CPP");

                entity.Property(e => e.T0m11cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M11CPP");

                entity.Property(e => e.T0m12cpp)
                    .HasColumnType("money")
                    .HasColumnName("T0M12CPP");
            });

            modelBuilder.Entity<SctipCompSat>(entity =>
            {
                entity.HasKey(e => e.FeCveTco);

                entity.ToTable("SCTipCompSAT");

                entity.Property(e => e.FeCveTco)
                    .HasMaxLength(1)
                    .HasColumnName("feCveTCo")
                    .IsFixedLength(true);

                entity.Property(e => e.FeDesTco)
                    .HasMaxLength(30)
                    .HasColumnName("feDesTCo")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ScuniMedSat>(entity =>
            {
                entity.HasKey(e => e.FeCveUnM);

                entity.ToTable("SCUniMedSAT");

                entity.Property(e => e.FeCveUnM)
                    .HasMaxLength(4)
                    .HasColumnName("feCveUnM")
                    .IsFixedLength(true);

                entity.Property(e => e.FeDesUnM)
                    .HasMaxLength(150)
                    .HasColumnName("feDesUnM")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ScusoSat>(entity =>
            {
                entity.HasKey(e => e.FeCveUso);

                entity.ToTable("SCUsoSAT");

                entity.Property(e => e.FeCveUso)
                    .HasMaxLength(3)
                    .HasColumnName("feCveUso")
                    .IsFixedLength(true);

                entity.Property(e => e.FeDesUso)
                    .HasMaxLength(100)
                    .HasColumnName("feDesUso")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FePfmuso)
                    .HasMaxLength(1)
                    .HasColumnName("fePFMUso")
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Scusuario>(entity =>
            {
                entity.HasKey(e => e.Usnumusu)
                    .HasName("PK_SCAUSUAR");

                entity.ToTable("SCUsuarios");

                entity.Property(e => e.Usnumusu).HasColumnName("USNUMUSU");

                entity.Property(e => e.UscajUsu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USCajUsu")
                    .IsFixedLength(true);

                entity.Property(e => e.Uscodusu)
                    .HasMaxLength(6)
                    .HasColumnName("USCODUSU");

                entity.Property(e => e.Usmodulo)
                    .HasMaxLength(10)
                    .HasColumnName("USMODULO");

                entity.Property(e => e.Usnomusu)
                    .HasMaxLength(45)
                    .HasColumnName("USNOMUSU");
            });

            modelBuilder.Entity<SdealumnosDer>(entity =>
            {
                entity.HasKey(e => new { e.B0codcar, e.B0numsem, e.B0nummat });

                entity.ToTable("SDEAlumnosDer");

                entity.Property(e => e.B0codcar)
                    .HasMaxLength(6)
                    .HasColumnName("B0CODCAR");

                entity.Property(e => e.B0numsem).HasColumnName("B0NUMSEM");

                entity.Property(e => e.B0nummat).HasColumnName("B0NUMMAT");

                entity.Property(e => e.B0nomalu)
                    .HasMaxLength(60)
                    .HasColumnName("B0NOMALU");

                entity.Property(e => e.B0numpar)
                    .HasMaxLength(15)
                    .HasColumnName("B0NUMPAR");

                entity.Property(e => e.B0salalu).HasColumnName("B0SALALU");

                entity.Property(e => e.B0seialu)
                    .HasMaxLength(1)
                    .HasColumnName("B0SEIALU");

                entity.Property(e => e.B0sender)
                    .HasMaxLength(1)
                    .HasColumnName("B0SENDER");

                entity.Property(e => e.B0senman)
                    .HasMaxLength(1)
                    .HasColumnName("B0SENMAN");
            });

            modelBuilder.Entity<SdecalPag>(entity =>
            {
                entity.HasKey(e => e.P0CicDat);

                entity.ToTable("SDECalPag");

                entity.Property(e => e.P0CicDat)
                    .ValueGeneratedNever()
                    .HasColumnName("p0CicDat");

                entity.Property(e => e.P0Ba1Dat)
                    .HasMaxLength(20)
                    .HasColumnName("p0Ba1Dat")
                    .IsFixedLength(true);

                entity.Property(e => e.P0Ba2Dat)
                    .HasMaxLength(20)
                    .HasColumnName("p0Ba2Dat")
                    .IsFixedLength(true);

                entity.Property(e => e.P0Ba3Dat)
                    .HasMaxLength(20)
                    .HasColumnName("p0Ba3Dat")
                    .IsFixedLength(true);

                entity.Property(e => e.P0Co1Dat)
                    .HasMaxLength(20)
                    .HasColumnName("p0Co1Dat")
                    .IsFixedLength(true);

                entity.Property(e => e.P0Co2Dat)
                    .HasMaxLength(20)
                    .HasColumnName("p0Co2Dat")
                    .IsFixedLength(true);

                entity.Property(e => e.P0Co3Dat)
                    .HasMaxLength(20)
                    .HasColumnName("p0Co3Dat")
                    .IsFixedLength(true);

                entity.Property(e => e.P0DesDat)
                    .HasMaxLength(20)
                    .HasColumnName("p0DesDat")
                    .IsFixedLength(true);

                entity.Property(e => e.P0ExaFin)
                    .HasMaxLength(45)
                    .HasColumnName("p0ExaFin")
                    .IsFixedLength(true);

                entity.Property(e => e.P0ImpRec)
                    .HasColumnType("money")
                    .HasColumnName("p0ImpRec");

                entity.Property(e => e.P0PriPar)
                    .HasMaxLength(45)
                    .HasColumnName("p0PriPar")
                    .IsFixedLength(true);

                entity.Property(e => e.P0TasRec)
                    .HasColumnType("money")
                    .HasColumnName("p0TasRec");

                entity.Property(e => e.P0Ve1Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("p0Ve1Dat");

                entity.Property(e => e.P0Ve2Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("p0Ve2Dat");

                entity.Property(e => e.P0Ve3Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("p0Ve3Dat");

                entity.Property(e => e.P0Ve4Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("p0Ve4Dat");

                entity.Property(e => e.P0Ve5Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("p0Ve5Dat");

                entity.Property(e => e.P0Ve6Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("p0Ve6Dat");

                entity.Property(e => e.P0VeIdat)
                    .HasColumnType("datetime")
                    .HasColumnName("p0VeIDat");
            });

            modelBuilder.Entity<Sdeparame>(entity =>
            {
                entity.HasKey(e => e.A0numpar);

                entity.ToTable("SDEParame");

                entity.Property(e => e.A0numpar)
                    .HasMaxLength(15)
                    .HasColumnName("A0NUMPAR");

                entity.Property(e => e.A0perpar)
                    .HasMaxLength(50)
                    .HasColumnName("A0PERPAR");

                entity.Property(e => e.A0refpar).HasColumnName("A0REFPAR");
            });

            modelBuilder.Entity<SpbalumnosCon>(entity =>
            {
                entity.HasKey(e => e.B0nummat);

                entity.ToTable("SPBAlumnosCon");

                entity.Property(e => e.B0nummat)
                    .ValueGeneratedNever()
                    .HasColumnName("B0NUMMAT");

                entity.Property(e => e.B0permar).HasColumnName("B0PERMAR");
            });

            modelBuilder.Entity<SpbmovCar>(entity =>
            {
                entity.HasKey(e => new { e.D0fecmov, e.D0renmov, e.D0tipmov, e.D0nummat, e.D0conmov, e.D0refmov, e.D0impmov });

                entity.ToTable("SPBMovCar");

                entity.Property(e => e.D0fecmov)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("D0FECMOV");

                entity.Property(e => e.D0renmov).HasColumnName("D0RENMOV");

                entity.Property(e => e.D0tipmov).HasColumnName("D0TIPMOV");

                entity.Property(e => e.D0nummat).HasColumnName("D0NUMMAT");

                entity.Property(e => e.D0conmov).HasColumnName("D0CONMOV");

                entity.Property(e => e.D0refmov).HasColumnName("D0REFMOV");

                entity.Property(e => e.D0impmov)
                    .HasColumnType("money")
                    .HasColumnName("D0IMPMOV");

                entity.Property(e => e.D0bonmov)
                    .HasColumnType("money")
                    .HasColumnName("D0BONMOV");

                entity.Property(e => e.D0sacmov)
                    .HasMaxLength(1)
                    .HasColumnName("D0SACMOV");

                entity.Property(e => e.D0seamov)
                    .HasMaxLength(1)
                    .HasColumnName("D0SEAMOV");
            });

            modelBuilder.Entity<Spbmovto>(entity =>
            {
                entity.HasKey(e => new { e.C0fecmov, e.C0renmov, e.C0tipmov, e.C0nummat, e.C0rebmov });

                entity.ToTable("SPBMovtos");

                entity.Property(e => e.C0fecmov)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("C0FECMOV");

                entity.Property(e => e.C0renmov).HasColumnName("C0RENMOV");

                entity.Property(e => e.C0tipmov).HasColumnName("C0TIPMOV");

                entity.Property(e => e.C0nummat).HasColumnName("C0NUMMAT");

                entity.Property(e => e.C0rebmov).HasColumnName("C0REBMOV");

                entity.Property(e => e.C0idemov)
                    .HasMaxLength(1)
                    .HasColumnName("C0IDEMOV");

                entity.Property(e => e.C0impmov)
                    .HasColumnType("money")
                    .HasColumnName("C0IMPMOV");

                entity.Property(e => e.C0sacmov)
                    .HasMaxLength(1)
                    .HasColumnName("C0SACMOV");
            });

            modelBuilder.Entity<Spbparametro>(entity =>
            {
                entity.HasKey(e => e.A0ctapar);

                entity.ToTable("SPBParametros");

                entity.Property(e => e.A0ctapar)
                    .HasMaxLength(5)
                    .HasColumnName("A0CTAPAR");

                entity.Property(e => e.A0b01par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B01PAR");

                entity.Property(e => e.A0b02par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B02PAR");

                entity.Property(e => e.A0b03par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B03PAR");

                entity.Property(e => e.A0b04par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B04PAR");

                entity.Property(e => e.A0b05par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B05PAR");

                entity.Property(e => e.A0b06par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B06PAR");

                entity.Property(e => e.A0b07par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B07PAR");

                entity.Property(e => e.A0b08par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B08PAR");

                entity.Property(e => e.A0b09par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B09PAR");

                entity.Property(e => e.A0b10par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B10PAR");

                entity.Property(e => e.A0b11par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B11PAR");

                entity.Property(e => e.A0b12par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0B12PAR");

                entity.Property(e => e.A0bonpar)
                    .HasColumnType("money")
                    .HasColumnName("A0BONPAR");

                entity.Property(e => e.A0cexpar)
                    .HasColumnType("money")
                    .HasColumnName("A0CEXPAR");

                entity.Property(e => e.A0p01par).HasColumnName("A0P01PAR");

                entity.Property(e => e.A0p02par).HasColumnName("A0P02PAR");

                entity.Property(e => e.A0p03par).HasColumnName("A0P03PAR");

                entity.Property(e => e.A0p04par).HasColumnName("A0P04PAR");

                entity.Property(e => e.A0p05par).HasColumnName("A0P05PAR");

                entity.Property(e => e.A0p06par).HasColumnName("A0P06PAR");

                entity.Property(e => e.A0p07par).HasColumnName("A0P07PAR");

                entity.Property(e => e.A0p08par).HasColumnName("A0P08PAR");

                entity.Property(e => e.A0p09par).HasColumnName("A0P09PAR");

                entity.Property(e => e.A0p10par).HasColumnName("A0P10PAR");

                entity.Property(e => e.A0p11par).HasColumnName("A0P11PAR");

                entity.Property(e => e.A0p12par).HasColumnName("A0P12PAR");

                entity.Property(e => e.A0r01par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R01PAR");

                entity.Property(e => e.A0r02par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R02PAR");

                entity.Property(e => e.A0r03par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R03PAR");

                entity.Property(e => e.A0r04par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R04PAR");

                entity.Property(e => e.A0r05par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R05PAR");

                entity.Property(e => e.A0r06par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R06PAR");

                entity.Property(e => e.A0r07par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R07PAR");

                entity.Property(e => e.A0r08par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R08PAR");

                entity.Property(e => e.A0r09par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R09PAR");

                entity.Property(e => e.A0r10par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R10PAR");

                entity.Property(e => e.A0r11par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R11PAR");

                entity.Property(e => e.A0r12par)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("A0R12PAR");

                entity.Property(e => e.A0salmay).HasColumnName("A0SALMAY");

                entity.Property(e => e.A0tipref).HasColumnName("A0TIPREF");

                entity.Property(e => e.A0tp1par).HasColumnName("A0TP1PAR");

                entity.Property(e => e.A0tp2par).HasColumnName("A0TP2PAR");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

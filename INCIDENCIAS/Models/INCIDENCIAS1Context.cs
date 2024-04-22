using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace INCiDENCIAS.Models
{
    public partial class INCIDENCIAS1Context : DbContext
    {
        public INCIDENCIAS1Context()
        {
        }

        public INCIDENCIAS1Context(DbContextOptions<INCIDENCIAS1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AsignacionHorariosEmpleado> AsignacionHorariosEmpleados { get; set; } = null!;
        public virtual DbSet<AsignacionTiposEmpleado> AsignacionTiposEmpleados { get; set; } = null!;
        public virtual DbSet<CatalogoClasificacionContrato> CatalogoClasificacionContratos { get; set; } = null!;
        public virtual DbSet<CatalogoDia> CatalogoDias { get; set; } = null!;
        public virtual DbSet<CatalogoDiasFeriadosOficiale> CatalogoDiasFeriadosOficiales { get; set; } = null!;
        public virtual DbSet<CatalogoHora> CatalogoHoras { get; set; } = null!;
        public virtual DbSet<CatalogoHorario> CatalogoHorarios { get; set; } = null!;
        public virtual DbSet<CatalogoIncidenciasColore> CatalogoIncidenciasColores { get; set; } = null!;
        public virtual DbSet<CatalogoJornada> CatalogoJornadas { get; set; } = null!;
        public virtual DbSet<CatalogoTipoEmpleado> CatalogoTipoEmpleados { get; set; } = null!;
        public virtual DbSet<CatalogoTiposDeContrato> CatalogoTiposDeContratos { get; set; } = null!;
        public virtual DbSet<Checada> Checadas { get; set; } = null!;
        public virtual DbSet<Checador> Checadors { get; set; } = null!;
        public virtual DbSet<ComisionesDocumento> ComisionesDocumentos { get; set; } = null!;
        public virtual DbSet<ConfiguracionTipoEmpleado> ConfiguracionTipoEmpleados { get; set; } = null!;
        public virtual DbSet<ContratosDocumento> ContratosDocumentos { get; set; } = null!;
        public virtual DbSet<ContratosEmpleado> ContratosEmpleados { get; set; } = null!;
        public virtual DbSet<DiasDocumento> DiasDocumentos { get; set; } = null!;
        public virtual DbSet<DiasEstimuloDocumento> DiasEstimuloDocumentos { get; set; } = null!;
        public virtual DbSet<DiasFeriadoDocumento> DiasFeriadoDocumentos { get; set; } = null!;
        public virtual DbSet<Documento> Documentos { get; set; } = null!;
        public virtual DbSet<DocumentosDetalle> DocumentosDetalles { get; set; } = null!;
        public virtual DbSet<Estatus> Estatuses { get; set; } = null!;
        public virtual DbSet<EstimuloDocumento> EstimuloDocumentos { get; set; } = null!;
        public virtual DbSet<EstimuloHorasExtra> EstimuloHorasExtras { get; set; } = null!;
        public virtual DbSet<GuardiaDocumento> GuardiaDocumentos { get; set; } = null!;
        public virtual DbSet<Horario> Horarios { get; set; } = null!;
        public virtual DbSet<IncapacidadesDocumento> IncapacidadesDocumentos { get; set; } = null!;
        public virtual DbSet<Incidencia> Incidencias { get; set; } = null!;
        public virtual DbSet<Jornada> Jornadas { get; set; } = null!;
        public virtual DbSet<JustificacionDocumento> JustificacionDocumentos { get; set; } = null!;
        public virtual DbSet<Justificacione> Justificaciones { get; set; } = null!;
        public virtual DbSet<LicenciasDocumento> LicenciasDocumentos { get; set; } = null!;
        public virtual DbSet<Medico> Medicos { get; set; } = null!;
        public virtual DbSet<RetardoDocumento> RetardoDocumentos { get; set; } = null!;
        public virtual DbSet<Unidade> Unidades { get; set; } = null!;
        public virtual DbSet<VacacionesDocumento> VacacionesDocumentos { get; set; } = null!;
        public virtual DbSet<VistaAsignacionHorariosEmpleadosConDatosGenerale> VistaAsignacionHorariosEmpleadosConDatosGenerales { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=INCIDENCIAS1;Trusted_Connection=True;Encrypt=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AsignacionHorariosEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion)
                    .HasName("PK__Asignaci__A7235DFF6F8CE4C2");

                entity.Property(e => e.IdAsignacion).ValueGeneratedNever();

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");

                entity.Property(e => e.IdHorario).HasColumnName("Id_Horario");

                entity.Property(e => e.IdTipoEmpleado).HasColumnName("Id_Tipo_Empleado");

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.AsignacionHorariosEmpleados)
                    .HasForeignKey(d => d.IdHorario)
                    .HasConstraintName("FK__Asignacio__Id_Ho__6B24EA82");
            });

            modelBuilder.Entity<AsignacionTiposEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdTipoEmpleado)
                    .HasName("PK_Tipos_Empleados");

                entity.ToTable("Asignacion_Tipos_Empleados");

                entity.Property(e => e.IdTipoEmpleado).HasColumnName("Id_Tipo_Empleado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCatalogotipodeEmpleado).HasColumnName("Id_catalogotipodeEmpleado");

                entity.Property(e => e.IdConfTipoEmpleado).HasColumnName("Id_Conf_Tipo_Empleado");

                entity.Property(e => e.IdDocumento).HasColumnName("Id_documento");

                entity.Property(e => e.IdDocumentos).HasColumnName("Id_Documentos");

                entity.Property(e => e.NucEmpleados).HasColumnName("NUC_Empleados");

                entity.HasOne(d => d.IdCatalogotipodeEmpleadoNavigation)
                    .WithMany(p => p.AsignacionTiposEmpleados)
                    .HasForeignKey(d => d.IdCatalogotipodeEmpleado)
                    .HasConstraintName("FK_Tipos_Empleados_Catalogo_Tipo_Empleado");

                entity.HasOne(d => d.IdConfTipoEmpleadoNavigation)
                    .WithMany(p => p.AsignacionTiposEmpleados)
                    .HasForeignKey(d => d.IdConfTipoEmpleado)
                    .HasConstraintName("FK_Tipos_Empleados_Configuracion_Tipo_Empleado");
            });

            modelBuilder.Entity<CatalogoClasificacionContrato>(entity =>
            {
                entity.HasKey(e => e.IdClasificacionContrato);

                entity.ToTable("Catalogo_Clasificacion_Contratos");

                entity.Property(e => e.IdClasificacionContrato).HasColumnName("IdClasificacion_Contrato");

                entity.Property(e => e.ClasificacionContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Clasificacion_Contrato");

                entity.Property(e => e.IdEstatus).HasColumnName("Id_Estatus");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.CatalogoClasificacionContratos)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_Catalogo_Clasificacion_Contratos_Estatus");
            });

            modelBuilder.Entity<CatalogoDia>(entity =>
            {
                entity.HasKey(e => e.IdCatalogodias)
                    .HasName("PK__Catalogo__0AFFF186EC74BBAA");

                entity.ToTable("Catalogo_Dias");

                entity.Property(e => e.IdCatalogodias).HasColumnName("Id_catalogodias");

                entity.Property(e => e.Dato)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraUltimaModificacion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.NombreDia)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogoDiasFeriadosOficiale>(entity =>
            {
                entity.HasKey(e => e.IdDiaFeriado)
                    .HasName("PK__Catalogo__53AB3979BDB712E9");

                entity.ToTable("Catalogo_DiasFeriadosOficiales");

                entity.Property(e => e.IdDiaFeriado)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_DiaFeriado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaHoraUltimaModificacion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CatalogoHora>(entity =>
            {
                entity.HasKey(e => e.IdHora)
                    .HasName("PK__Catalogo__426A893BFCAEF929");

                entity.ToTable("Catalogo_Horas");

                entity.Property(e => e.IdHora).HasColumnName("Id_hora");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraUltimaModificacion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CatalogoHorario>(entity =>
            {
                entity.HasKey(e => e.IdCatalogoHorario);

                entity.ToTable("Catalogo_Horarios");

                entity.Property(e => e.IdCatalogoHorario).HasColumnName("Id_Catalogo_Horario");

                entity.Property(e => e.DescripcionHorario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Descripcion_Horario")
                    .HasDefaultValueSql("('NO ESPECIFICADO')");

                entity.Property(e => e.DiasLaborables)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Dias_Laborables")
                    .HasDefaultValueSql("('LMRJVSD')");

                entity.Property(e => e.FechaHoraUltimaModificacion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Horario1)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Horario_1")
                    .HasDefaultValueSql("('00:00-00:00')");

                entity.Property(e => e.Horario2)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Horario_2")
                    .HasDefaultValueSql("('00:00-00:00')");

                entity.Property(e => e.IdEstatus).HasColumnName("Id_Estatus");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.CatalogoHorarios)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_CatalogoHorarios_Estatus");
            });

            modelBuilder.Entity<CatalogoIncidenciasColore>(entity =>
            {
                entity.HasKey(e => e.IdIncidenciasColores)
                    .HasName("PK__Catalogo__4E264D9A7F6876A6");

                entity.ToTable("Catalogo_IncidenciasColores");

                entity.Property(e => e.IdIncidenciasColores).HasColumnName("Id_IncidenciasColores");

                entity.Property(e => e.Color)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Dato)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraUltimaModificacion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CatalogoJornada>(entity =>
            {
                entity.HasKey(e => e.IdCatalogosjornadas)
                    .HasName("PK__Catalogo__C57F7C648DA28935");

                entity.ToTable("Catalogo_Jornadas");

                entity.Property(e => e.IdCatalogosjornadas).HasColumnName("Id_catalogosjornadas");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstatus).HasColumnName("Id_Estatus");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.CatalogoJornada)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_CatalogoJornadas_Estatus");
            });

            modelBuilder.Entity<CatalogoTipoEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdCatalogotipodeempleado)
                    .HasName("PK__Catalogo__49A8FE049EA0D59A");

                entity.ToTable("Catalogo_Tipo_Empleado");

                entity.Property(e => e.IdCatalogotipodeempleado).HasColumnName("Id_catalogotipodeempleado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraUltimaModificacion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogoTiposDeContrato>(entity =>
            {
                entity.HasKey(e => e.IdTipoContrato);

                entity.ToTable("Catalogo_Tipos_de_Contrato");

                entity.Property(e => e.IdTipoContrato).HasColumnName("idTipo_Contrato");

                entity.Property(e => e.DbLegado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DB_Legado");

                entity.Property(e => e.DescripcionTipoContrato)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Descripcion_Tipo_Contrato");

                entity.Property(e => e.FuenteFinanciamiento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fuente_Financiamiento");

                entity.Property(e => e.IdEstatus).HasColumnName("Id_Estatus");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.CatalogoTiposDeContratos)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_Catalogo_Tipos_de_Contrato_Estatus");
            });

            modelBuilder.Entity<Checada>(entity =>
            {
                entity.HasKey(e => e.IdChecadas)
                    .HasName("PK__Checadas__861C18FACD83A72F");

                entity.Property(e => e.IdChecadas).HasColumnName("Id_checadas");

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdChecador).HasColumnName("Id_Checador");

                entity.Property(e => e.NucEmpleado).HasColumnName("NUC_Empleado");

                entity.HasOne(d => d.IdChecadorNavigation)
                    .WithMany(p => p.Checada)
                    .HasForeignKey(d => d.IdChecador)
                    .HasConstraintName("FK_Checadas_Checador");
            });

            modelBuilder.Entity<Checador>(entity =>
            {
                entity.HasKey(e => e.IdChecador)
                    .HasName("PK__Checador__861D96ABF492ED26");

                entity.ToTable("Checador");

                entity.Property(e => e.IdChecador).HasColumnName("Id_checador");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstatus).HasColumnName("Id_Estatus");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NucEmpleados).HasColumnName("NUC_Empleados");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.Checadors)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_Checador_Estatus");
            });

            modelBuilder.Entity<ComisionesDocumento>(entity =>
            {
                entity.HasKey(e => e.IdComisiones)
                    .HasName("PK__Comision__5B0789DDBB2BD8F0");

                entity.ToTable("Comisiones_Documentos");

                entity.Property(e => e.IdComisiones).HasColumnName("Id_Comisiones");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.TipoComision)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Comision");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.ComisionesDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Comisiones_Documentos_Documentos_Detalles");
            });

            modelBuilder.Entity<ConfiguracionTipoEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdConfTipoEmpleado)
                    .HasName("PK_Tipos_De_Empleados");

                entity.ToTable("Configuracion_Tipo_Empleado");

                entity.Property(e => e.IdConfTipoEmpleado).HasColumnName("Id_Conf_Tipo_Empleado");

                entity.Property(e => e.Dato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraUltimaModificacion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.NucEmpleado).HasColumnName("NUC_Empleado");
            });

            modelBuilder.Entity<ContratosDocumento>(entity =>
            {
                entity.HasKey(e => new { e.IdTipoContrato, e.IdDocumento })
                    .HasName("PK__Contrato__576B854283E0317F");

                entity.ToTable("Contratos_Documentos");

                entity.Property(e => e.IdTipoContrato)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IdTipo_Contrato");

                entity.Property(e => e.IdDocumento).HasColumnName("ID_Documento");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.ContratosDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Contratos_Documentos_Documentos_Detalles");

                entity.HasOne(d => d.IdDocumentoNavigation)
                    .WithMany(p => p.ContratosDocumentos)
                    .HasForeignKey(d => d.IdDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contratos_Documentos_Documentos");

                entity.HasOne(d => d.IdTipoContratoNavigation)
                    .WithMany(p => p.ContratosDocumentos)
                    .HasForeignKey(d => d.IdTipoContrato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Contratos__IdTip__2BC97F7C");
            });

            modelBuilder.Entity<ContratosEmpleado>(entity =>
            {
                entity.HasKey(e => e.FolioContrato);

                entity.ToTable("Contratos_empleados");

                entity.Property(e => e.FolioContrato)
                    .ValueGeneratedNever()
                    .HasColumnName("Folio_Contrato");

                entity.Property(e => e.AcuerdoCon)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("acuerdo_con");

                entity.Property(e => e.CapturadoPor).HasColumnName("Capturado_por");

                entity.Property(e => e.CccPara)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCC_para");

                entity.Property(e => e.ClaveCatalogoContratoEmpleado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("clave_catalogo_contrato_empleado");

                entity.Property(e => e.ClaveClasificacionContrato).HasColumnName("Clave_Clasificacion_Contrato");

                entity.Property(e => e.ClaveTipoContrato).HasColumnName("Clave_Tipo_Contrato");

                entity.Property(e => e.CveCtroAdscripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cve_ctro_adscripcion");

                entity.Property(e => e.CveCtroDistribucion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cve_ctro_distribucion");

                entity.Property(e => e.CveFuenteFinanciamiento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cve_fuente_financiamiento");

                entity.Property(e => e.DescripcionContratoEmpleado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_contrato_empleado");

                entity.Property(e => e.EstatusContrato)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Estatus_Contrato");

                entity.Property(e => e.FechaContrato)
                    .HasColumnType("date")
                    .HasColumnName("fecha_contrato");

                entity.Property(e => e.FechaEfectoFin)
                    .HasColumnType("date")
                    .HasColumnName("fecha_efecto_fin");

                entity.Property(e => e.FechaEfectoInicio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_efecto_inicio");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_modificacion");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_registro");

                entity.Property(e => e.FuncionesAcuerdo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("funciones_acuerdo");

                entity.Property(e => e.IdCatalogoPuesto).HasColumnName("ID_Catalogo_Puesto");

                entity.Property(e => e.IdCodigoPuesto)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("ID_Codigo_Puesto");

                entity.Property(e => e.IdHorario).HasColumnName("ID_Horario");

                entity.Property(e => e.IdJornada).HasColumnName("ID_Jornada");

                entity.Property(e => e.JornadaEnHoras).HasColumnName("Jornada_en_horas");

                entity.Property(e => e.ModificadoPor).HasColumnName("Modificado_por");

                entity.Property(e => e.NoEmpleadoAutoriza1).HasColumnName("No_Empleado_Autoriza1");

                entity.Property(e => e.NoEmpleadoAutoriza2).HasColumnName("No_Empleado_Autoriza2");

                entity.Property(e => e.NoEmpleadoVoBo).HasColumnName("No_Empleado_VoBo");

                entity.Property(e => e.NucEmpleado)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NUC_Empleado");

                entity.Property(e => e.SueldoBruto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("sueldo_bruto");

                entity.HasOne(d => d.ClaveClasificacionContratoNavigation)
                    .WithMany(p => p.ContratosEmpleados)
                    .HasForeignKey(d => d.ClaveClasificacionContrato)
                    .HasConstraintName("FK_Contratos_empleados_Catalogo_Clasificacion_Contratos");

                entity.HasOne(d => d.ClaveTipoContratoNavigation)
                    .WithMany(p => p.ContratosEmpleados)
                    .HasForeignKey(d => d.ClaveTipoContrato)
                    .HasConstraintName("FK_Contratos_empleados_Catalogo_Tipos_de_Contrato");

                entity.HasOne(d => d.IdHorarioNavigation)
                    .WithMany(p => p.ContratosEmpleados)
                    .HasForeignKey(d => d.IdHorario)
                    .HasConstraintName("FK_Contratos_empleados_Horarios");

                entity.HasOne(d => d.IdJornadaNavigation)
                    .WithMany(p => p.ContratosEmpleados)
                    .HasForeignKey(d => d.IdJornada)
                    .HasConstraintName("FK_Contratos_empleados_Jornadas");
            });

            modelBuilder.Entity<DiasDocumento>(entity =>
            {
                entity.HasKey(e => e.IdDiaDocumento)
                    .HasName("PK__Dias_Doc__D9B4A0320A1F0AED");

                entity.ToTable("Dias_Documentos");

                entity.Property(e => e.IdDiaDocumento).HasColumnName("Id_Dia_Documento");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IndicadorDia).HasColumnName("Indicador_Dia");

                entity.Property(e => e.TipoDia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Dia");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.DiasDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Dias_Documentos_Documentos_Detalles");
            });

            modelBuilder.Entity<DiasEstimuloDocumento>(entity =>
            {
                entity.HasKey(e => e.IdDiaEstimuloDocumento)
                    .HasName("PK__DiasEsti__BCE3E7E6B623922F");

                entity.ToTable("DiasEstimuloDocumento");

                entity.Property(e => e.IdDiaEstimuloDocumento).ValueGeneratedNever();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.NoRelojChecador).IsUnicode(false);

                entity.Property(e => e.TipoDia).IsUnicode(false);

                entity.Property(e => e.TipoPeriodo).IsUnicode(false);

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.DiasEstimuloDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_DiasEstimuloDocumento_Documentos_Detalles");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.DiasEstimuloDocumentos)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_DiasEstimuloDocumento_Unidades");
            });

            modelBuilder.Entity<DiasFeriadoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdDiaFeriado)
                    .HasName("PK__DiaFeria__53AB39796B8461C2");

                entity.ToTable("DiasFeriado_Documentos");

                entity.Property(e => e.IdDiaFeriado).HasColumnName("Id_DiaFeriado");

                entity.Property(e => e.FAutoriza)
                    .HasColumnType("date")
                    .HasColumnName("F_autoriza");

                entity.Property(e => e.FTrabaja)
                    .HasColumnType("date")
                    .HasColumnName("F_trabaja");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoRelojChecador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NucEmpleado).HasColumnName("Nuc_Empleado");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdDocumento)
                    .HasName("PK__Document__995E1613816843D2");

                entity.Property(e => e.IdDocumento).HasColumnName("Id_Documento");

                entity.Property(e => e.AutorizacionTrabajar).HasColumnName("Autorizacion_Trabajar");

                entity.Property(e => e.DetalleDocuemnto)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Detalle_docuemnto");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.HoraFin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HoraInicio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HorasConcedidasMasiva).HasColumnName("Horas_Concedidas_Masiva");

                entity.Property(e => e.IdComisiones).HasColumnName("Id_Comisiones");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IdDiaFeriado).HasColumnName("Id_DiaFeriado");

                entity.Property(e => e.IdDiasDocumentos).HasColumnName("Id_Dias_Documentos");

                entity.Property(e => e.IdEstimulo).HasColumnName("Id_Estimulo");

                entity.Property(e => e.IdGuardia).HasColumnName("Id_Guardia");

                entity.Property(e => e.IdIncapacidades).HasColumnName("Id_Incapacidades");

                entity.Property(e => e.IdJustificacion).HasColumnName("Id_Justificacion");

                entity.Property(e => e.IdLicencias).HasColumnName("Id_Licencias");

                entity.Property(e => e.IdRetardo).HasColumnName("Id_Retardo");

                entity.Property(e => e.IdVacaciones).HasColumnName("Id_Vacaciones");

                entity.Property(e => e.NombreDocumento)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Documento");

                entity.Property(e => e.NucEmpleado).HasColumnName("NUC_Empleado");

                entity.Property(e => e.PaseSalida).HasColumnName("Pase_Salida");

                entity.Property(e => e.SancionesAdministrativas).HasColumnName("Sanciones_Administrativas");

                entity.Property(e => e.SolicitudHorasExtras).HasColumnName("Solicitud_Horas_Extras");

                entity.Property(e => e.ToleranciaEntrada).HasColumnName("Tolerancia_Entrada");

                entity.HasOne(d => d.IdComisionesNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdComisiones)
                    .HasConstraintName("FK_Documentos_Comisiones_Documentos");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Documentos_Documentos_Detalles");

                entity.HasOne(d => d.IdDiasDocumentosNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdDiasDocumentos)
                    .HasConstraintName("FK_Documentos_Dias_Documentos");

                entity.HasOne(d => d.IdEstimuloNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdEstimulo)
                    .HasConstraintName("FK_Documentos_Estimulo_Documentos");

                entity.HasOne(d => d.IdGuardiaNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdGuardia)
                    .HasConstraintName("FK_Documentos_Guardia_Documentos");

                entity.HasOne(d => d.IdIncapacidadesNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdIncapacidades)
                    .HasConstraintName("FK_Documentos_Incapacidades_Documentos");

                entity.HasOne(d => d.IdJustificacionNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdJustificacion)
                    .HasConstraintName("FK_Documentos_Justificacion_Documentos");

                entity.HasOne(d => d.IdLicenciasNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdLicencias)
                    .HasConstraintName("FK_Documentos_Licencias_Documentos");

                entity.HasOne(d => d.IdRetardoNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdRetardo)
                    .HasConstraintName("FK_Documentos_Retardo_Documentos");

                entity.HasOne(d => d.IdVacacionesNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.IdVacaciones)
                    .HasConstraintName("FK_Documentos_Vacaciones_Documentos");
            });

            modelBuilder.Entity<DocumentosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdDocumentosDetalle)
                    .HasName("PK__Document__7C939A13712C51EC");

                entity.ToTable("Documentos_Detalles");

                entity.Property(e => e.IdDocumentosDetalle).HasColumnName("Id_Documentos_Detalle");

                entity.Property(e => e.Detalles)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdDetalle).HasColumnName("ID_Detalle");
            });

            modelBuilder.Entity<Estatus>(entity =>
            {
                entity.HasKey(e => e.IdEstatus)
                    .HasName("PK__Estatus__A114FD1B85A84961");

                entity.ToTable("Estatus");

                entity.Property(e => e.IdEstatus).HasColumnName("Id_Estatus");

                entity.Property(e => e.NombreEstado)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstimuloDocumento>(entity =>
            {
                entity.HasKey(e => e.IdEstimulo)
                    .HasName("PK__Estimulo__246DC0C06C938949");

                entity.ToTable("Estimulo_Documentos");

                entity.Property(e => e.IdEstimulo).HasColumnName("Id_Estimulo");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IndicadorEstimulo).HasColumnName("Indicador_Estimulo");

                entity.Property(e => e.TipoEstimulo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Estimulo");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.EstimuloDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Estimulo_Documentos_Documentos_Detalles");
            });

            modelBuilder.Entity<EstimuloHorasExtra>(entity =>
            {
                entity.HasKey(e => e.IdEstimuloHorasEx)
                    .HasName("PK__Estimulo__D74F634AE519122E");

                entity.ToTable("Estimulo_HorasExtra");

                entity.Property(e => e.IdEstimuloHorasEx).HasColumnName("IdEstimulo_HorasEx");

                entity.Property(e => e.FFin)
                    .HasColumnType("date")
                    .HasColumnName("F_fin");

                entity.Property(e => e.FInicicio)
                    .HasColumnType("date")
                    .HasColumnName("F_inicicio");

                entity.Property(e => e.IdDetalle).HasColumnName("Id_Detalle");

                entity.Property(e => e.IdUnidad).HasColumnName("Id_Unidad");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_pago");

                entity.HasOne(d => d.IdDetalleNavigation)
                    .WithMany(p => p.EstimuloHorasExtras)
                    .HasForeignKey(d => d.IdDetalle)
                    .HasConstraintName("FK_Estimulo_HorasExtra_Documentos_Detalles");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.EstimuloHorasExtras)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_Estimulo_HorasExtra_Unidades");
            });

            modelBuilder.Entity<GuardiaDocumento>(entity =>
            {
                entity.HasKey(e => e.IdGuardia)
                    .HasName("PK__Guardia___2AE48954491E0CF4");

                entity.ToTable("Guardia_Documentos");

                entity.Property(e => e.IdGuardia).HasColumnName("Id_Guardia");

                entity.Property(e => e.EmpleadoAcubrirId).HasColumnName("EmpleadoACubrirId");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IndicadorGuardia).HasColumnName("Indicador_Guardia");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoRelojChecador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoGuardia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Guardia");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.GuardiaDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Guardia_Documentos_Documentos_Detalles");
            });

            modelBuilder.Entity<Horario>(entity =>
            {
                entity.HasKey(e => e.IdHorario)
                    .HasName("PK__Horarios__3214EC2735C49285");

                entity.Property(e => e.IdHorario).HasColumnName("Id_Horario");

                entity.Property(e => e.FechaFin)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Fin");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Inicio");

                entity.Property(e => e.IdCatalogoHorario).HasColumnName("Id_Catalogo_Horario");

                entity.Property(e => e.IdEstatus).HasColumnName("Id_Estatus");

                entity.Property(e => e.IdHora).HasColumnName("Id_Hora");

                entity.Property(e => e.NucEmpleados).HasColumnName("NUC_Empleados");

                entity.HasOne(d => d.IdCatalogoHorarioNavigation)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.IdCatalogoHorario)
                    .HasConstraintName("FK_Horarios_CatalogoHorarios");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_Horarios_Estatus");

                entity.HasOne(d => d.IdHoraNavigation)
                    .WithMany(p => p.Horarios)
                    .HasForeignKey(d => d.IdHora)
                    .HasConstraintName("FK_Horarios_CatalogoHoras");
            });

            modelBuilder.Entity<IncapacidadesDocumento>(entity =>
            {
                entity.HasKey(e => e.IdIncapacidades)
                    .HasName("PK__Incapaci__CDB327AF5B66BB9D");

                entity.ToTable("Incapacidades_Documentos");

                entity.Property(e => e.IdIncapacidades).HasColumnName("Id_Incapacidades");

                entity.Property(e => e.Diagnosticos)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FFinal)
                    .HasColumnType("date")
                    .HasColumnName("F_final");

                entity.Property(e => e.FInicio)
                    .HasColumnType("date")
                    .HasColumnName("F_inicio");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IdMedicos).HasColumnName("Id_medicos");

                entity.Property(e => e.IdUnidad).HasColumnName("Id_unidad");

                entity.Property(e => e.IndicadorIncapacidad).HasColumnName("Indicador_Incapacidad");

                entity.Property(e => e.TipoIncapacidad)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Incapacidad");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.IncapacidadesDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Incapacidades_Documentos_Documentos_Detalles");

                entity.HasOne(d => d.IdMedicosNavigation)
                    .WithMany(p => p.IncapacidadesDocumentos)
                    .HasForeignKey(d => d.IdMedicos)
                    .HasConstraintName("FK_Incapacidades_Documentos_Medicos");
            });

            modelBuilder.Entity<Incidencia>(entity =>
            {
                entity.HasKey(e => e.IdIncidencias)
                    .HasName("PK__Incidenc__C49A168826F152DC");

                entity.Property(e => e.IdIncidencias).HasColumnName("Id_incidencias");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdChecadas).HasColumnName("Id_Checadas");

                entity.Property(e => e.IdTipoEmpleado).HasColumnName("Id_Tipo_Empleado");

                entity.Property(e => e.NucEmpleados).HasColumnName("NUC_Empleados");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdChecadasNavigation)
                    .WithMany(p => p.Incidencia)
                    .HasForeignKey(d => d.IdChecadas)
                    .HasConstraintName("FK_Incidencias_Checadas");

                entity.HasOne(d => d.IdTipoEmpleadoNavigation)
                    .WithMany(p => p.Incidencia)
                    .HasForeignKey(d => d.IdTipoEmpleado)
                    .HasConstraintName("FK_Incidencias_Tipos_Empleados");
            });

            modelBuilder.Entity<Jornada>(entity =>
            {
                entity.HasKey(e => e.IdJornada)
                    .HasName("PK__Jornadas__A8E3CC86649D73F1");

                entity.Property(e => e.IdJornada).HasColumnName("Id_Jornada");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCatalogosjornadas).HasColumnName("Id_catalogosjornadas");

                entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");

                entity.Property(e => e.IdHorarios).HasColumnName("Id_Horarios");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NucEmpleados).HasColumnName("NUC_Empleados");

                entity.HasOne(d => d.IdCatalogosjornadasNavigation)
                    .WithMany(p => p.Jornada)
                    .HasForeignKey(d => d.IdCatalogosjornadas)
                    .HasConstraintName("FK__Jornadas__Descri__1AD3FDA4");

                entity.HasOne(d => d.IdHorariosNavigation)
                    .WithMany(p => p.Jornada)
                    .HasForeignKey(d => d.IdHorarios)
                    .HasConstraintName("FK_Jornadas_Horarios");
            });

            modelBuilder.Entity<JustificacionDocumento>(entity =>
            {
                entity.HasKey(e => e.IdJustificacion)
                    .HasName("PK__Justific__3A1BCA31833A7EB9");

                entity.ToTable("Justificacion_Documentos");

                entity.Property(e => e.IdJustificacion).HasColumnName("Id_Justificacion");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IndicadorJustificacion).HasColumnName("Indicador_Justificacion");

                entity.Property(e => e.TipoJustificacion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Justificacion");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.JustificacionDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Justificacion_Documentos_Documentos_Detalles");
            });

            modelBuilder.Entity<Justificacione>(entity =>
            {
                entity.HasKey(e => e.IdJustificaciones)
                    .HasName("PK__Justific__01BF9B1AB0DEE53F");

                entity.Property(e => e.IdJustificaciones).HasColumnName("Id_justificaciones");

                entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NucEmpleado).HasColumnName("NUC_Empleado");
            });

            modelBuilder.Entity<LicenciasDocumento>(entity =>
            {
                entity.HasKey(e => e.IdLicencia)
                    .HasName("PK__Licencia__DEC92166FEA2271F");

                entity.ToTable("Licencias_Documentos");

                entity.Property(e => e.IdLicencia).HasColumnName("Id_Licencia");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IndicadorLicencia).HasColumnName("Indicador_Licencia");

                entity.Property(e => e.NucEmpleado).HasColumnName("Nuc_Empleado");

                entity.Property(e => e.TipoLicencia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Licencia");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.LicenciasDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Licencias_Documentos_Documentos_Detalles");

                entity.HasOne(d => d.IdUnidadNavigation)
                    .WithMany(p => p.LicenciasDocumentos)
                    .HasForeignKey(d => d.IdUnidad)
                    .HasConstraintName("FK_Licencias_Documentos_Unidades");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasKey(e => e.IdMedicos)
                    .HasName("PK__Medicos__BBB8F651E09F2461");

                entity.Property(e => e.IdMedicos).HasColumnName("Id_medicos");

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RetardoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdRetardo)
                    .HasName("PK__Retardo___1157D17825D08188");

                entity.ToTable("Retardo_Documentos");

                entity.Property(e => e.IdRetardo).HasColumnName("Id_Retardo");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IndicadorRetardo).HasColumnName("Indicador_Retardo");

                entity.Property(e => e.TipoRetardo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Retardo");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.RetardoDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Retardo_Documentos_Documentos_Detalles");
            });

            modelBuilder.Entity<Unidade>(entity =>
            {
                entity.HasKey(e => e.IdUnidad)
                    .HasName("PK__Unidades__A6F89A0BF9DCB52F");

                entity.Property(e => e.IdUnidad).HasColumnName("Id_unidad");

                entity.Property(e => e.ClaveCentro)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Clues)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CLUES");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUnidad)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_unidad");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<VacacionesDocumento>(entity =>
            {
                entity.HasKey(e => e.IdVacaciones)
                    .HasName("PK__Vacacion__3C7A995E8395EC04");

                entity.ToTable("Vacaciones_Documentos");

                entity.Property(e => e.IdVacaciones).HasColumnName("Id_Vacaciones");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.IdDetalles).HasColumnName("Id_detalles");

                entity.Property(e => e.IdEmpleados).HasColumnName("Id_Empleados");

                entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");

                entity.Property(e => e.IndicadorVacaciones).HasColumnName("Indicador_Vacaciones");

                entity.Property(e => e.NumeroChecador)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVacaciones)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Vacaciones");

                entity.HasOne(d => d.IdDetallesNavigation)
                    .WithMany(p => p.VacacionesDocumentos)
                    .HasForeignKey(d => d.IdDetalles)
                    .HasConstraintName("FK_Vacaciones_Documentos_Documentos_Detalles");
            });

            modelBuilder.Entity<VistaAsignacionHorariosEmpleadosConDatosGenerale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VistaAsignacionHorariosEmpleadosConDatosGenerales");

                entity.Property(e => e.ApellidoMaternoEmpleado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Apellido_Materno_Empleado");

                entity.Property(e => e.ApellidoPaternoEmpleado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Apellido_Paterno_Empleado");

                entity.Property(e => e.FechaFin).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");

                entity.Property(e => e.IdHorario).HasColumnName("Id_Horario");

                entity.Property(e => e.NombresEmpleado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nombres_Empleado");

                entity.Property(e => e.NucEmpleado).HasColumnName("NUC_Empleado");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

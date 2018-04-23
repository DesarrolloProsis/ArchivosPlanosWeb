namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbFirstTlalpanLab : DbContext
    {
        public DbFirstTlalpanLab()
            : base("name=DbFirstTlalpanLab")
        {
        }

        public virtual DbSet<ACCES_ECRAN_APPLIS> ACCES_ECRAN_APPLIS { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<NUM_PERSONAL> NUM_PERSONAL { get; set; }
        public virtual DbSet<TABLE_COMM> TABLE_COMM { get; set; }
        public virtual DbSet<TBL_USUARIOS> TBL_USUARIOS { get; set; }
        public virtual DbSet<CLOSED_LANE_REPORT> CLOSED_LANE_REPORT { get; set; }
        public virtual DbSet<COMPTAGE_HORAIRE> COMPTAGE_HORAIRE { get; set; }
        public virtual DbSet<CORRECTED_TRANSACTION> CORRECTED_TRANSACTION { get; set; }
        public virtual DbSet<ETAT_LOGICIEL> ETAT_LOGICIEL { get; set; }
        public virtual DbSet<EVENEMENT> EVENEMENT { get; set; }
        public virtual DbSet<EVENEMENT_CRITERE> EVENEMENT_CRITERE { get; set; }
        public virtual DbSet<FIN_POSTE> FIN_POSTE { get; set; }
        public virtual DbSet<FIN_POSTE_RECETTE_PAIEMENT> FIN_POSTE_RECETTE_PAIEMENT { get; set; }
        public virtual DbSet<FIN_POSTE_TRAFIC> FIN_POSTE_TRAFIC { get; set; }
        public virtual DbSet<GPOS_CUSTOMER> GPOS_CUSTOMER { get; set; }
        public virtual DbSet<GPOS_CUSTOMER_LOCK> GPOS_CUSTOMER_LOCK { get; set; }
        public virtual DbSet<GPOS_EOJ> GPOS_EOJ { get; set; }
        public virtual DbSet<GPOS_EOJ_MEDIA> GPOS_EOJ_MEDIA { get; set; }
        public virtual DbSet<GPOS_EOJ_PAYMENT> GPOS_EOJ_PAYMENT { get; set; }
        public virtual DbSet<GPOS_EOJ_PRODUCT> GPOS_EOJ_PRODUCT { get; set; }
        public virtual DbSet<GPOS_MEDIA> GPOS_MEDIA { get; set; }
        public virtual DbSet<GPOS_PRODUCT> GPOS_PRODUCT { get; set; }
        public virtual DbSet<GPOS_SUBSCRIPTION> GPOS_SUBSCRIPTION { get; set; }
        public virtual DbSet<GPOS_SUBSCRIPTION_LOCK> GPOS_SUBSCRIPTION_LOCK { get; set; }
        public virtual DbSet<GPOS_SUBSCRIPTION_MEDIA> GPOS_SUBSCRIPTION_MEDIA { get; set; }
        public virtual DbSet<GPOS_TRANSACTION> GPOS_TRANSACTION { get; set; }
        public virtual DbSet<GPOS_TRANSACTION_PAYMENT> GPOS_TRANSACTION_PAYMENT { get; set; }
        public virtual DbSet<GPOS_TRANSACTION_POS> GPOS_TRANSACTION_POS { get; set; }
        public virtual DbSet<GPOS_TYPE_OBS_MOP> GPOS_TYPE_OBS_MOP { get; set; }
        public virtual DbSet<GPOS_TYPE_OBS_SEQUENCE> GPOS_TYPE_OBS_SEQUENCE { get; set; }
        public virtual DbSet<HOURLY_REVENUE_MOP> HOURLY_REVENUE_MOP { get; set; }
        public virtual DbSet<HOURLY_TRAFFIC_MOP> HOURLY_TRAFFIC_MOP { get; set; }
        public virtual DbSet<IMG_VIDEO_IMAGE> IMG_VIDEO_IMAGE { get; set; }
        public virtual DbSet<LANE_ASSIGN> LANE_ASSIGN { get; set; }
        public virtual DbSet<PTM_CONSTANT_A> PTM_CONSTANT_A { get; set; }
        public virtual DbSet<PTM_CONSTANT_B> PTM_CONSTANT_B { get; set; }
        public virtual DbSet<PTM_DEFMEDIA> PTM_DEFMEDIA { get; set; }
        public virtual DbSet<PTM_FARE> PTM_FARE { get; set; }
        public virtual DbSet<PTM_LASS> PTM_LASS { get; set; }
        public virtual DbSet<PTM_LSTABONN> PTM_LSTABONN { get; set; }
        public virtual DbSet<PTM_LSTDEVIS> PTM_LSTDEVIS { get; set; }
        public virtual DbSet<PTM_LSTMEDIA> PTM_LSTMEDIA { get; set; }
        public virtual DbSet<PTM_LSTORANG> PTM_LSTORANG { get; set; }
        public virtual DbSet<PTM_LSTPERSO> PTM_LSTPERSO { get; set; }
        public virtual DbSet<PTM_LSTPRODS> PTM_LSTPRODS { get; set; }
        public virtual DbSet<PTM_LSTRELOD> PTM_LSTRELOD { get; set; }
        public virtual DbSet<PTM_LSTRELOD_P> PTM_LSTRELOD_P { get; set; }
        public virtual DbSet<PTM_OPPABONN> PTM_OPPABONN { get; set; }
        public virtual DbSet<PTM_OPPCARTE> PTM_OPPCARTE { get; set; }
        public virtual DbSet<PTM_TABLE_ENTETE> PTM_TABLE_ENTETE { get; set; }
        public virtual DbSet<REDDITION> REDDITION { get; set; }
        public virtual DbSet<REDDITION_DEVISE> REDDITION_DEVISE { get; set; }
        public virtual DbSet<REDDITION_PIECE> REDDITION_PIECE { get; set; }
        public virtual DbSet<SEQ_VOIE_TOD> SEQ_VOIE_TOD { get; set; }
        public virtual DbSet<SITE_GARE> SITE_GARE { get; set; }
        public virtual DbSet<SIX_MIN_TRAFFIC> SIX_MIN_TRAFFIC { get; set; }
        public virtual DbSet<STAT_GPOS_EOJ> STAT_GPOS_EOJ { get; set; }
        public virtual DbSet<STAT_GPOS_EOJ_MEDIA> STAT_GPOS_EOJ_MEDIA { get; set; }
        public virtual DbSet<STAT_GPOS_EOJ_PAYMENT> STAT_GPOS_EOJ_PAYMENT { get; set; }
        public virtual DbSet<STAT_GPOS_EOJ_PRODUCT> STAT_GPOS_EOJ_PRODUCT { get; set; }
        public virtual DbSet<TABLE_AEXEMPTS> TABLE_AEXEMPTS { get; set; }
        public virtual DbSet<TABLE_AEXEMPTS_ENTETE> TABLE_AEXEMPTS_ENTETE { get; set; }
        public virtual DbSet<TABLE_BADGE_BALANCE> TABLE_BADGE_BALANCE { get; set; }
        public virtual DbSet<TABLE_BADGE_BALANCE_ENTETE> TABLE_BADGE_BALANCE_ENTETE { get; set; }
        public virtual DbSet<TABLE_BADGE_CONSIGNE> TABLE_BADGE_CONSIGNE { get; set; }
        public virtual DbSet<TABLE_BADGE_CONSIGNE_ENTETE> TABLE_BADGE_CONSIGNE_ENTETE { get; set; }
        public virtual DbSet<TABLE_CHQ_FIXE> TABLE_CHQ_FIXE { get; set; }
        public virtual DbSet<TABLE_CHQ_FIXE_ENTETE> TABLE_CHQ_FIXE_ENTETE { get; set; }
        public virtual DbSet<TABLE_CLEARING> TABLE_CLEARING { get; set; }
        public virtual DbSet<TABLE_CLEARING_ENTETE> TABLE_CLEARING_ENTETE { get; set; }
        public virtual DbSet<TABLE_CONSTANTE> TABLE_CONSTANTE { get; set; }
        public virtual DbSet<TABLE_CONSTANTE_ENTETE> TABLE_CONSTANTE_ENTETE { get; set; }
        public virtual DbSet<TABLE_CONTROLE_TRAJET> TABLE_CONTROLE_TRAJET { get; set; }
        public virtual DbSet<TABLE_CONTROLE_TRAJET_ENTETE> TABLE_CONTROLE_TRAJET_ENTETE { get; set; }
        public virtual DbSet<TABLE_DECOPASS> TABLE_DECOPASS { get; set; }
        public virtual DbSet<TABLE_DECOPASS_ENTETE> TABLE_DECOPASS_ENTETE { get; set; }
        public virtual DbSet<TABLE_DEVISE> TABLE_DEVISE { get; set; }
        public virtual DbSet<TABLE_DEVISE_ENTETE> TABLE_DEVISE_ENTETE { get; set; }
        public virtual DbSet<TABLE_DISCOUNT> TABLE_DISCOUNT { get; set; }
        public virtual DbSet<TABLE_DISCOUNT_ENTETE> TABLE_DISCOUNT_ENTETE { get; set; }
        public virtual DbSet<TABLE_FUFARE> TABLE_FUFARE { get; set; }
        public virtual DbSet<TABLE_LSTPRINT> TABLE_LSTPRINT { get; set; }
        public virtual DbSet<TABLE_LSTPRINT_ENTETE> TABLE_LSTPRINT_ENTETE { get; set; }
        public virtual DbSet<TABLE_MAGNETIQUE> TABLE_MAGNETIQUE { get; set; }
        public virtual DbSet<TABLE_MAGNETIQUE_ENTETE> TABLE_MAGNETIQUE_ENTETE { get; set; }
        public virtual DbSet<TABLE_MODULATION> TABLE_MODULATION { get; set; }
        public virtual DbSet<TABLE_MODULATION_ENTETE> TABLE_MODULATION_ENTETE { get; set; }
        public virtual DbSet<TABLE_PARAMETRE> TABLE_PARAMETRE { get; set; }
        public virtual DbSet<TABLE_PARAMETRE_ENTETE> TABLE_PARAMETRE_ENTETE { get; set; }
        public virtual DbSet<TABLE_PERIODE_TARIF> TABLE_PERIODE_TARIF { get; set; }
        public virtual DbSet<TABLE_PERIODE_TARIF_ENTETE> TABLE_PERIODE_TARIF_ENTETE { get; set; }
        public virtual DbSet<TABLE_PERSONNEL> TABLE_PERSONNEL { get; set; }
        public virtual DbSet<TABLE_PERSONNEL_ENTETE> TABLE_PERSONNEL_ENTETE { get; set; }
        public virtual DbSet<TABLE_TARIF> TABLE_TARIF { get; set; }
        public virtual DbSet<TABLE_TARIF_ENTETE> TABLE_TARIF_ENTETE { get; set; }
        public virtual DbSet<TABLE_TRAJET> TABLE_TRAJET { get; set; }
        public virtual DbSet<TABLE_TRAJET_ENTETE> TABLE_TRAJET_ENTETE { get; set; }
        public virtual DbSet<TRANSACTION> TRANSACTION { get; set; }
        public virtual DbSet<TRANSFERT_BANQUE> TRANSFERT_BANQUE { get; set; }
        public virtual DbSet<TYPE_ACQUISITION> TYPE_ACQUISITION { get; set; }
        public virtual DbSet<TYPE_CLASSE> TYPE_CLASSE { get; set; }
        public virtual DbSet<TYPE_EQUIPEMENT> TYPE_EQUIPEMENT { get; set; }
        public virtual DbSet<TYPE_ETAT_TELEPEAGE> TYPE_ETAT_TELEPEAGE { get; set; }
        public virtual DbSet<TYPE_FONCTION> TYPE_FONCTION { get; set; }
        public virtual DbSet<TYPE_GARE> TYPE_GARE { get; set; }
        public virtual DbSet<TYPE_LIBELLE_EVENEMENT> TYPE_LIBELLE_EVENEMENT { get; set; }
        public virtual DbSet<TYPE_MODE_VOIE> TYPE_MODE_VOIE { get; set; }
        public virtual DbSet<TYPE_MONNAIE> TYPE_MONNAIE { get; set; }
        public virtual DbSet<TYPE_NATIONALITE> TYPE_NATIONALITE { get; set; }
        public virtual DbSet<TYPE_OBS_MP> TYPE_OBS_MP { get; set; }
        public virtual DbSet<TYPE_OBS_PASSAGE> TYPE_OBS_PASSAGE { get; set; }
        public virtual DbSet<TYPE_OBS_PASSAGE_BE> TYPE_OBS_PASSAGE_BE { get; set; }
        public virtual DbSet<TYPE_OBS_SEQUENCE> TYPE_OBS_SEQUENCE { get; set; }
        public virtual DbSet<TYPE_OBS_SEQUENCE_BE> TYPE_OBS_SEQUENCE_BE { get; set; }
        public virtual DbSet<TYPE_OBS_TT> TYPE_OBS_TT { get; set; }
        public virtual DbSet<TYPE_OBS_TT_BE> TYPE_OBS_TT_BE { get; set; }
        public virtual DbSet<TYPE_PAIEMENT> TYPE_PAIEMENT { get; set; }
        public virtual DbSet<TYPE_PROBLEME> TYPE_PROBLEME { get; set; }
        public virtual DbSet<TYPE_PROBLEME_BE> TYPE_PROBLEME_BE { get; set; }
        public virtual DbSet<TYPE_RESEAU> TYPE_RESEAU { get; set; }
        public virtual DbSet<TYPE_SITE> TYPE_SITE { get; set; }
        public virtual DbSet<TYPE_TRANSACTION> TYPE_TRANSACTION { get; set; }
        public virtual DbSet<TYPE_VOIE> TYPE_VOIE { get; set; }
        public virtual DbSet<VOIE_PHYSIQUE> VOIE_PHYSIQUE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.ID_APPLICATION)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.CODE_ECRAN)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.ORDRE_AFFICHAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.LIBELLE_MENU)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.LIBELLE_MENU_L2)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.TYPE_CODE_ECRAN)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I0)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I1)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I2)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I3)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I4)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I5)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I6)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I7)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I8)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.I9)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M0)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M1)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M2)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M3)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M4)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M5)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M6)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M7)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M8)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.M9)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V0)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V1)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V2)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V3)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V4)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V5)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V6)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V7)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V8)
                .IsUnicode(false);

            modelBuilder.Entity<ACCES_ECRAN_APPLIS>()
                .Property(e => e.V9)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles", "GEADBA").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<NUM_PERSONAL>()
                .Property(e => e.ID_NUM_PERSONAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<NUM_PERSONAL>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<NUM_PERSONAL>()
                .Property(e => e.NUM_CAPUFE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_COMM>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_COMM>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_COMM>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_COMM>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_USUARIOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TBL_USUARIOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_USUARIOS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_USUARIOS>()
                .Property(e => e.NIVEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CLOSED_LANE_REPORT>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<CLOSED_LANE_REPORT>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<CLOSED_LANE_REPORT>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<CLOSED_LANE_REPORT>()
                .Property(e => e.LANE)
                .IsUnicode(false);

            modelBuilder.Entity<CLOSED_LANE_REPORT>()
                .Property(e => e.BAG_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<CLOSED_LANE_REPORT>()
                .Property(e => e.REPORT_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.ID_NATIONALITE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TRAFIC_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.COMPTAGE_CPT1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.COMPTAGE_CPT2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.COMPTAGE_CPT3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.COMPTAGE_CPT4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.COMPTAGE_CPT5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.PASSAGE_FORCE_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.PASSAGE_FORCE_HP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.PASSAGE_LIBRE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<COMPTAGE_HORAIRE>()
                .Property(e => e.TEMPS_OUVERTURE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_ETC_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.TRX_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.TRX_NUMBER_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_TAB_CLASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_TAB_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_TT_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_TT_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_TT_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.TT_DHM)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_TT_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.TT_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_OBS_TT)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_OBS_MOP)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_OBS_PASSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.FARE_MODULATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.FARE_TABLE_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.TOLL_FARE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.AMOUNT_PAID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.MOP_LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ISO_MOP_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_MOP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_AVC_CLASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_CORRECTED_CLASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_CORRECTED_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_CORRECTED_MOP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_CORRECTED_TOLL_FARE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_CORRECTOR_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_TYPE_CORRECTION)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.RECEIPT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.MODULATION_VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_TAB_AXLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_AVC_AXLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.ID_CORRECTED_AXLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CORRECTED_TRANSACTION>()
                .Property(e => e.EVENT_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.VERSION_LOGICIEL)
                .IsUnicode(false);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TARIF_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TARIF_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TRAJET_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TRAJET_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.MODULA_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.MODULA_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.DEVISE_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.DEVISE_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.ACCMPM_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.ACCMPM_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.CHQFIX_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.CHQFIX_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.AGENTS_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.AGENTS_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.OPPOS1_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.OPPOS1_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.OPPOS2_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.OPPOS2_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.OPPTLP_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.OPPTLP_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TCONST_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TCONST_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TMOTIF_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TMOTIF_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE1_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE1_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE2_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE2_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE3_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE3_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE4_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE4_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE5_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE5_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE6_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE6_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE7_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE7_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE8_EC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ETAT_LOGICIEL>()
                .Property(e => e.TABLE8_FU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.ID_EVENEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.ID_ETAT_TELEPEAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.ID_MODE_VOIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.NUMERO_POSTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.STATUS_EVENEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EVENEMENT>()
                .Property(e => e.DETAIL_EVENEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT_CRITERE>()
                .Property(e => e.ID_LIBELLE_EVENEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EVENEMENT_CRITERE>()
                .Property(e => e.ID_EVENEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT_CRITERE>()
                .Property(e => e.ID_EQUIPEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EVENEMENT_CRITERE>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<EVENEMENT_CRITERE>()
                .Property(e => e.STATUS_EVENEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EVENEMENT_CRITERE>()
                .Property(e => e.SELECTION)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.ID_ETAT_TELEPEAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.ID_MODE_VOIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.NUMERO_POSTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.VERSION_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.ID_DPT)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.RED_MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.SAC)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.TRAFIC_TOTAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.RECETTE_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.RECETTE_MONNAIE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.RECETTE_MONNAIE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.RECETTE_MONNAIE4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.DISCORDANCE_DAC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.PASSAGE_FORCE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.PASSAGE_FORCE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.PASSAGE_FORCE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.PASSAGE_FORCE4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.PASSAGE_FORCE5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.MP_OPPOSITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.MP_DEPASSEE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.TT_DEPASSEE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.VIOLATION_FERME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT21)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT22)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT23)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT24)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT25)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT26)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT27)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT28)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT29)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT30)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT31)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT32)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT33)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT34)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FIN_POSTE_CPT35)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.OPERATING_SHIFT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.VALIDATION_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FOLIO_NUMBER_OPEN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FOLIO_NUMBER_CLOSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.INITIAL_EVENT_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FINAL_EVENT_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FOLIO2_NUMBER_INITIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FOLIO2_NUMBER_FINAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FOLIO3_NUMBER_INITIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FOLIO3_NUMBER_FINAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FOLIO_ECT_NUMBER_INITIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE>()
                .Property(e => e.FOLIO_ECT_NUMBER_FINAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_CLASSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_PAIEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_NATIONALITE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_ETAT_TELEPEAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_MODE_VOIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.NUMERO_POSTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.ID_DPT)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.NB_PAIEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.RECETTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.OPERATING_SHIFT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_RECETTE_PAIEMENT>()
                .Property(e => e.VALIDATION_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.ID_ETAT_TELEPEAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.ID_MODE_VOIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.NUMERO_POSTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.TRAFIC_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.OPERATING_SHIFT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<FIN_POSTE_TRAFIC>()
                .Property(e => e.VALIDATION_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.ID_CUSTOMER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.FIRST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.CONTACT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.ADDRESS_L1)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.ADDRESS_L2)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.ADDRESS_L3)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.POSTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.TOWN)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.PHONE_NUMBER1)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.PHONE_NUMBER2)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.FAX_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_ADDRESS_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_ADDRESS_L1)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_ADDRESS_L2)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_ADDRESS_L3)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_POSTCODE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_TOWN)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.BANK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.BANK_ACCOUNT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.CREDIT_CARD_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.CREDIT_CARD_EXPIRY)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.INVOICING_LOCK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_CUSTOMER>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_CUSTOMER_LOCK>()
                .Property(e => e.ID_CUSTOMER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_CUSTOMER_LOCK>()
                .Property(e => e.ID_LOCK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.CURRENCY_VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.BAG_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.CREATED_CUSTOMER_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.MODIFIED_CUSTOMER_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.CLOSED_CUSTOMER_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.REPLACED_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.BLACKLIST_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.UNBLACKLIST_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.INVALIDATED_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.VALIDATION_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.BAG_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_MEDIA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.ADDED_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.AMOUNT_ADDED_MEDIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.VAT_DEPOSIT_AMOUNT_RECEIVED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.RETURNED_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.AMOUNT_RETURNED_MEDIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.VAT_DEPOSIT_AMOUNT_RETURNED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.RETURN_MEDIA_DEPOSIT_KEPT_CT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.LOST_MEDIA_DEPOSIT_KEPT_CT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.DEPOSIT_AMOUNT_KEPT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_MEDIA>()
                .Property(e => e.VAT_DEPOSIT_AMOUNT_KEPT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.BAG_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_MOP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.MOP_LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.PAYMENT_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.VAT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PAYMENT>()
                .Property(e => e.VALIDATION_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.BAG_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.SALE_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT_SALE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.REFUND_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT_REFUND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.RELOAD_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT_RELOAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.VAT_AMOUNT_SALE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.VAT_AMOUNT_REFUND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_EOJ_PRODUCT>()
                .Property(e => e.VAT_AMOUNT_RELOAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_MEDIA>()
                .Property(e => e.ID_MEDIA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_MEDIA>()
                .Property(e => e.MEDIA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_MEDIA>()
                .Property(e => e.VERSION_MEDIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_PRODUCT>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_PRODUCT>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_PRODUCT>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_PRODUCT>()
                .Property(e => e.VERSION_PRODUCT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.ID_SUBSCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.ID_CUSTOMER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.ID_CLASS)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.BALANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.BALANCE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.BALANCE_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.TOTAL_BALANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.TOTAL_BALANCE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.RELOAD_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.RELOAD_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.VAT_AMOUNT_RP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.VAT_RATE_RP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.THRESHOLD_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.CREDIT_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.ID_MEDIA_TYPE_LIST)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.OWNER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.RELOADING_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.DEPOSIT_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.LAST_RELOAD_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.LAST_RELOAD_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.VAT_AMOUNT_LRP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.VAT_RATE_LRP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.LAST_BALANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.REFUND_CALC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.VAT_AMOUNT_RC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.NEXT_ACKNOWLEDGE_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.PASSAGE_COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.PASSAGE_COUNT1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.INVOICING_LOCK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.REFUND_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.ID_VALIDITY_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.VALIDITY_LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.SELLING_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.VAT_AMOUNT_SP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.VAT_RATE_SP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION>()
                .Property(e => e.GROUP_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_LOCK>()
                .Property(e => e.ID_SUBSCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_LOCK>()
                .Property(e => e.ID_LOCK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.ID_SUBSCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.ID_MEDIA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.ID_MEDIA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.MEDIA_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.OWNER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.OWNER_INFORMATION)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.MEDIA_DEPOSIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.VAT_AMOUNT_MD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.VAT_RATE_MD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.MEDIA_DEPOSIT_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.ID_MEDIA_TECHNOLOGY)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.MANAGEMENT_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.TEMPLATE_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.TEMPLATE_1)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_SUBSCRIPTION_MEDIA>()
                .Property(e => e.TEMPLATE_2)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.PLAZA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.BOJ_DHM)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.TRX_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.TRX_NUMBER_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_TRX)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_CUSTOMER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_SUBSCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_CLASS)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_MEDIA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.VAT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.VAT_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.DEPOSIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.VAT_AMOUNT_D)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.VAT_RATE_D)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_OBS_TRX)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.PLAZA_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.BOJ_DHM)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.TRX_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.TRX_NUMBER_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_TRX)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_CUSTOMER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.VAT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.VAT_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.PARTIAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.VAT_AMOUNT_P)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.VAT_RATE_P)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.MOP_LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ISO_MOP_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_MOP_ACQ_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_OBS_MOP)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_MOP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.FLAG_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_PAYMENT>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.MSG_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.TRX_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.TRX_NUMBER_INDEX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_TRX)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_CUSTOMER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_SUBSCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_CLASS)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.MEDIA_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_MEDIA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_MEDIA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_OLD_MEDIA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_OLD_MEDIA)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.VAT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.VAT_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.PARTIAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.VAT_AMOUNT_D)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.VAT_RATE_D)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.MOP_LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ISO_MOP_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_MOP_ACQ_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_OBS_MOP)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_MOP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.ID_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.FLAG_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPOS_TRANSACTION_POS>()
                .Property(e => e.VALIDATION_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TYPE_OBS_MOP>()
                .Property(e => e.ID_OBS_MOP)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TYPE_OBS_MOP>()
                .Property(e => e.SEL_OBS_MOP)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TYPE_OBS_MOP>()
                .Property(e => e.LABEL_OBS_MOP)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TYPE_OBS_MOP>()
                .Property(e => e.LABEL_OBS_MOP_L2)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TYPE_OBS_SEQUENCE>()
                .Property(e => e.ID_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TYPE_OBS_SEQUENCE>()
                .Property(e => e.SEL_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TYPE_OBS_SEQUENCE>()
                .Property(e => e.LABEL_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<GPOS_TYPE_OBS_SEQUENCE>()
                .Property(e => e.LABEL_OBS_SEQUENCE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.BILLING_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.ID_NATIONALITY)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.REVENUE_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_REVENUE_MOP>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.BILLING_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.TRAFFIC_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOURLY_TRAFFIC_MOP>()
                .Property(e => e.ID_LANE_MODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.ID_VOIE_ACQUIS)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.CHEMIN_FICHIER)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MATRICULE_OPE1)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MATRICULE_OPE2)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.PLAQUE_IMMATRIC1)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.PLAQUE_IMMATRIC2)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.PBS_AUTORISE)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.NUMERO_CARTE)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.INFORMATION)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.LITIGATION)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.SAC)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.OBSERVATION_TT)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.OBSERVATION_MP)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.OBSERVATION_SEQ)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.OBSERVATION_PAS)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_1)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_2)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_3)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_4)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_5)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_6)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_7)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_8)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_9)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_10)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_11)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_12)
                .IsUnicode(false);

            modelBuilder.Entity<IMG_VIDEO_IMAGE>()
                .Property(e => e.MAINTENANCE_13)
                .IsUnicode(false);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.SHIFT_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.OPERATION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.STAFF_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.JOB_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.IN_CHARGE_SHIFT_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.DELEGATION)
                .IsUnicode(false);

            modelBuilder.Entity<LANE_ASSIGN>()
                .Property(e => e.MAT_ADMIN)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.VERSION_CONSTANT_A)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.HEURE_DEBUT_PEAGE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.TOLERANCE_HEURE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ECART_OK_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.IMPR_AUTO_CP_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.IMPR_AUTO_CP_MONNAIE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.IMPR_AUTO_CP_DEVISES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.IMPR_AUTO_CP_VIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.IMPR_AUTO_CP_VSC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.IMPR_AUTO_CP_IAVE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.IMPR_AUTO_CP_RPI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.MAX_NATIONALITES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.MAX_CLASSES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.VAT_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ECART_OK_JETON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ECART_OK_RPI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ECART_OK_VSC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ECART_OK_VIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ECART_OK_MNT_RPI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ECART_OK_MNT_VSC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_A>()
                .Property(e => e.ECART_OK_MNT_VIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_B>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_B>()
                .Property(e => e.VERSION_CONSTANT_B)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_B>()
                .Property(e => e.ID_GARE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_CONSTANT_B>()
                .Property(e => e.LIBELLE_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.ID_NETWORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.VERSION_DEFMEDIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.ID_MEDIA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.MEDIA_TYPE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.ISSUER_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.VALIDITY_LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.DEPOSIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.DEPOSIT_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.MANAGEMENT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.ENCODER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.SELLING_PRICE_VAT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_DEFMEDIA>()
                .Property(e => e.VAT_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.ID_MOP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.VERSION_TARIF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.ID_NATIONALITE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.ID_GARE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL01)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL02)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL03)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL04)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL05)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL06)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL07)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL08)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL09)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.PRIX_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL01)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL02)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL03)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL04)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL05)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL06)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL07)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL08)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL09)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TVA_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL01)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL02)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL03)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL04)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL05)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL06)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL07)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL08)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL09)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_FARE>()
                .Property(e => e.TAX_FREE_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.VERSION_LASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.DELEGATION)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.ID_GARE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.ID_SHIFT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.MAT_PEAGER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.MAT_SUPER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.OBSERVATION)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LASS>()
                .Property(e => e.MAT_ADMIN)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.VERSION_LSTABONN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.NUMERO_CARTE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.CODE_CONTROLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.CLASSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.NO_ABONNEMENT_CARTE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.ID_TYPE_CARTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.CODE_MODELE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.ID_MONNAIE_UTILISEE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.NUM_CARTE_BANCAIRE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTABONN>()
                .Property(e => e.DATE_EXPIRE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.VERSION_LSTDEVIS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.CODE_DEVISE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.LIBELLE_DEVISE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.TAUX_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.COUPURE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.COUPURE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.COUPURE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.COUPURE4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.COUPURE5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTDEVIS>()
                .Property(e => e.ORDRE_DEV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTMEDIA>()
                .Property(e => e.VERSION_LSTMEDIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTMEDIA>()
                .Property(e => e.ID_NETWORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTMEDIA>()
                .Property(e => e.ID_MEDIA_TYPE_LIST)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTMEDIA>()
                .Property(e => e.MEDIA_TYPE_LIST_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTMEDIA>()
                .Property(e => e.MEDIA_TYPE_LIST_COUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTMEDIA>()
                .Property(e => e.MEDIA_TYPE_LIST)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTORANG>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTORANG>()
                .Property(e => e.VERSION_LSTORANG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTORANG>()
                .Property(e => e.NUMERO_CARTE_ORANGE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTORANG>()
                .Property(e => e.CONFISCATION_CARTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.VERSION_LSTPERSO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.ID_FONCTION)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.CLE_LUHN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.NOM_PERSONNEL)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.PRENOM_PERSONNEL)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.ID_SITE_AUTORISE1)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.ID_SITE_AUTORISE2)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.ID_SITE_AUTORISE3)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.ID_SITE_AUTORISE4)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.ID_SITE_AUTORISE5)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.CODE_ACCESS)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.ID_USER)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.TEMPLATE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPERSO>()
                .Property(e => e.NUMERO_CAPUFE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.VERSION_LSTPRODS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.ID_NETWORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.ID_CLASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.PRODUCT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.RELOADING_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.INITIAL_BALANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.INITIAL_BALANCE_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.SELLING_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.SELLING_PRICE_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.SELLING_PRICE_VAT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.VAT_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.ID_VALIDITY_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.VALIDITY_LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.DEPOSIT_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.ID_MEDIA_TYPE_LIST)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.EQUIP_RESTRICT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.PLAZA_RESTRICT_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.LEVEL_RESTRICT_CODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.OWNER_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.THRESHOLD_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.CREDIT_LIMIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTPRODS>()
                .Property(e => e.MULTI_CLASS)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.VERSION_LSTRELOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.ID_NETWORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.ID_CLASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.RELOADING_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.RELOADING_VALUE_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.RELOADING_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.RELOADING_PRICE_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.SELLING_PRICE_VAT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD>()
                .Property(e => e.VAT_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.VERSION_LSTRELOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.ID_NETWORK)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.ID_CLASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.ID_VALIDITY_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.VALIDITY_LENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.RELOADING_PRICE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.RELOADING_PRICE_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.VAT_RATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_LSTRELOD_P>()
                .Property(e => e.SELLING_PRICE_VAT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_OPPABONN>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_OPPABONN>()
                .Property(e => e.VERSION_OPPABONN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_OPPABONN>()
                .Property(e => e.NUMERO_ABONNEMENT_OPP)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_OPPABONN>()
                .Property(e => e.CONFISCATION_CARTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_OPPABONN>()
                .Property(e => e.SUBSCRIPTION_STATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_OPPCARTE>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_OPPCARTE>()
                .Property(e => e.VERSION_OPPCARTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_OPPCARTE>()
                .Property(e => e.NUMERO_CARTE_OPP)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_OPPCARTE>()
                .Property(e => e.CONFISCATION_CARTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_TABLE_ENTETE>()
                .Property(e => e.ID_TABLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_TABLE_ENTETE>()
                .Property(e => e.ID_RESEAU_SORTIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_TABLE_ENTETE>()
                .Property(e => e.ID_GARE_SORTIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_TABLE_ENTETE>()
                .Property(e => e.VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_TABLE_ENTETE>()
                .Property(e => e.NB_ENREGS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PTM_TABLE_ENTETE>()
                .Property(e => e.ETAT_TABLE)
                .IsUnicode(false);

            modelBuilder.Entity<PTM_TABLE_ENTETE>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.SAC)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.VERSION_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_POS_RCT_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_POS_RCT_MONNAIE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_POS_RCT_MONNAIE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_POS_RCT_MONNAIE4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_POS_RMB_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_POS_RCT_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_POS_RCT_CHQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_RCT_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_RCT_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_RCT_MONNAIE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_RCT_MONNAIE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_RCT_MONNAIE4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_JETON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_RDD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_GRATUIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_RCT_CHQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RCT_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RCT_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RCT_MONNAIE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RCT_MONNAIE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RCT_MONNAIE4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_JETON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RDD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_GRATUIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RCT_CHQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_NB_CHQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.ETAT_REDDITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.ID_MONNAIE_REF)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.TRAFIC_TOTAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.NB_POSTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.NB_POSTE_POS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.NB_POSTE_CLAIM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.LISTE_MONNAIE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.MATRICULE_COMMENTAIRE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.COMMENTAIRE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.BANK_SLIP_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.BANK_SLIP_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.FOND_CAISSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.FOND_CAISSE_MONNAIE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RCT_TOT_INI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT21)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT22)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT23)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT24)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_CPT25)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_TXT1)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_TXT2)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_TXT3)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_TXT4)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.CORRECTION_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.OPERATING_SHIFT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.RED_RCT_RDD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_RCT_RDD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_CLAIM_RCT_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_CLAIM_RCT_MONNAIE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_CLAIM_RCT_MONNAIE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_CLAIM_RCT_MONNAIE4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_CLAIM_RCT_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.POSTE_CLAIM_RCT_CHQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.VALIDATION_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION>()
                .Property(e => e.ID_SHIFT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.ID_DEVISE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.SAC)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.MONTANT_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.MONTANT_MONNAIE_REF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.LIBELLE_DEVISE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.SAC_PARTIELLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.CONSOLIDATION_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.BANK_SLIP_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_DEVISE>()
                .Property(e => e.CORRECTION_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.ID_MONNAIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.SAC)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.LIBELLE_PIECE)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.MONTANT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.NBR_PIECE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.SAC_PARTIELLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.CONSOLIDATION_FLAG)
                .IsUnicode(false);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.SOUS_TYPE_MP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<REDDITION_PIECE>()
                .Property(e => e.BANK_SLIP_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SEQ_VOIE_TOD>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<SEQ_VOIE_TOD>()
                .Property(e => e.NUM_SEQUENCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SITE_GARE>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<SITE_GARE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<SITE_GARE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<SIX_MIN_TRAFFIC>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<SIX_MIN_TRAFFIC>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<SIX_MIN_TRAFFIC>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SIX_MIN_TRAFFIC>()
                .Property(e => e.ID_LANE)
                .IsUnicode(false);

            modelBuilder.Entity<SIX_MIN_TRAFFIC>()
                .Property(e => e.TRAFFIC_CL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.CREATED_CUSTOMER_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.MODIFIED_CUSTOMER_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.CLOSED_CUSTOMER_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.REPLACED_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.BLACKLIST_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.UNBLACKLIST_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.INVALIDATED_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ>()
                .Property(e => e.EOJ_COUNTER20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.ID_MEDIA_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.ADDED_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.AMOUNT_ADDED_MEDIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.VAT_DEPOSIT_AMOUNT_RECEIVED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.RETURNED_MEDIA_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.AMOUNT_RETURNED_MEDIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.VAT_DEPOSIT_AMOUNT_RETURNED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.RETURN_MEDIA_DEPOSIT_KEPT_CT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.LOST_MEDIA_DEPOSIT_KEPT_CT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.DEPOSIT_AMOUNT_KEPT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_MEDIA>()
                .Property(e => e.VAT_DEPOSIT_AMOUNT_KEPT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.ID_MOP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.MOP_LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.PAYMENT_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.TOTAL_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PAYMENT>()
                .Property(e => e.VAT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_LANE_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_PRODUCT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.SALE_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT_SALE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.REFUND_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT_REFUND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.RELOAD_COUNTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.TOTAL_AMOUNT_RELOAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.VAT_AMOUNT_SALE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.VAT_AMOUNT_REFUND)
                .HasPrecision(38, 0);

            modelBuilder.Entity<STAT_GPOS_EOJ_PRODUCT>()
                .Property(e => e.VAT_AMOUNT_RELOAD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.VERSION_AEXEMPTS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.ID_VEHICULE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.ID_CLASSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.IMMATRICULATION)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.PROPRIETAIRE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.NUM_PATRIMOINE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.MARQUE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.MODELE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.COULEUR)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.PREFIXE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.MUNICIPALITE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.ETAT)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_AEXEMPTS_ENTETE>()
                .Property(e => e.VERSION_AEXEMPTS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_AEXEMPTS_ENTETE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_BADGE_BALANCE>()
                .Property(e => e.VERSION_BADGE_BALANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_BALANCE>()
                .Property(e => e.TYPE_BALANCE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_BADGE_BALANCE>()
                .Property(e => e.VALEUR_BALANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_BALANCE>()
                .Property(e => e.VALEUR_PRIX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_BALANCE_ENTETE>()
                .Property(e => e.VERSION_BADGE_BALANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_CONSIGNE>()
                .Property(e => e.VERSION_BADGE_CONSIGNE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_CONSIGNE>()
                .Property(e => e.ID_CLASSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_CONSIGNE>()
                .Property(e => e.CAUTION_TAG_PARTICULIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_CONSIGNE>()
                .Property(e => e.CAUTION_CSC_PARTICULIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_CONSIGNE>()
                .Property(e => e.CAUTION_TAG_SOCIETE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_CONSIGNE>()
                .Property(e => e.CAUTION_CSC_SOCIETE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_CONSIGNE_ENTETE>()
                .Property(e => e.VERSION_BADGE_CONSIGNE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_BADGE_CONSIGNE_ENTETE>()
                .Property(e => e.MIN_RCHG_ENTREPRISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CHQ_FIXE>()
                .Property(e => e.VERSION_CHQ_FIXE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CHQ_FIXE>()
                .Property(e => e.LIBELLE_CHQ_FIXE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CHQ_FIXE>()
                .Property(e => e.MONTANT_CHQ_FIXE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CHQ_FIXE_ENTETE>()
                .Property(e => e.VERSION_CHQ_FIXE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.VERSION_CLEARING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.ID_BANK)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.ID_CLEARING)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_POST_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_TOWN)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_TEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.ID_TRANSMITTER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.TYPE_PAYMENT_OR_SITE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.TRANSMISSION_MODE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_ACCOUNT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_ACCOUNT_NUMBER_C1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.BANK_ACCOUNT_NUMBER_C2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.CURRENCY_UNIT)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.DELAY_FROM_BANK_RESPONSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM3)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM4)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM5)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING>()
                .Property(e => e.PARAM10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CLEARING_ENTETE>()
                .Property(e => e.VERSION_CLEARING)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CONSTANTE>()
                .Property(e => e.VERSION_CONSTANTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CONSTANTE>()
                .Property(e => e.ID_RESEAU)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CONSTANTE>()
                .Property(e => e.ID_GARE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CONSTANTE>()
                .Property(e => e.LIBELLE_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONSTANTE_ENTETE>()
                .Property(e => e.VERSION_CONSTANTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.VERSION_CONTROLE_TRAJET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.CODE_TRAJET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_3)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_4)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_5)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_6)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_7)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_8)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_9)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_10)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_11)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_12)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_13)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_14)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_15)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_16)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_17)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_18)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_19)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET>()
                .Property(e => e.ID_RESEAU_GARE_20)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_CONTROLE_TRAJET_ENTETE>()
                .Property(e => e.VERSION_CONTROLE_TRAJET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.VERSION_DECOPASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.CODE_TRAJET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.ID_CLASSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.NOM_TRAJET)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.NB_PASSAGE_1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PRIX_NB_PASSAGE_1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.NB_PASSAGE_2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PRIX_NB_PASSAGE_2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.NB_PASSAGE_3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PRIX_NB_PASSAGE_3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.NB_PASSAGE_4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PRIX_NB_PASSAGE_4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.NB_PASSAGE_5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PRIX_NB_PASSAGE_5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.DUREE_VAL_1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.DUREE_VAL_2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.DUREE_VAL_3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.DUREE_VAL_4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.DUREE_VAL_5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PLAFOND_1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PLAFOND_2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PLAFOND_3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PLAFOND_4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS>()
                .Property(e => e.PLAFOND_5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DECOPASS_ENTETE>()
                .Property(e => e.VERSION_DECOPASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.ID_DEVISE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.VERSION_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.LIBELLE_DEVISE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.TAUX_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.COUP1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.COUP2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.COUP3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.COUP4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DEVISE>()
                .Property(e => e.COUP5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DEVISE_ENTETE>()
                .Property(e => e.VERSION_DEVISE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DISCOUNT>()
                .Property(e => e.VERSION_DISCOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DISCOUNT>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_DISCOUNT>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_DISCOUNT>()
                .Property(e => e.ID_PRODUCT)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_DISCOUNT>()
                .Property(e => e.THRESHOLD_TYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DISCOUNT>()
                .Property(e => e.THRESHOLD_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DISCOUNT>()
                .Property(e => e.DISCOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DISCOUNT_ENTETE>()
                .Property(e => e.VERSION_DISCOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_DISCOUNT_ENTETE>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_DISCOUNT_ENTETE>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VERSION_FUFARE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.ID_NETWORK)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.ID_PLAZA)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_MODULATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.THRESHOLD_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.THRESHOLD_VALUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL01)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL02)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL03)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL04)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL05)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL06)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL07)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL08)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL09)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.FARE_INCLVAT_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL01)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL02)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL03)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL04)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL05)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL06)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL07)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL08)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL09)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_FUFARE>()
                .Property(e => e.VAT_AMOUNT_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_LSTPRINT>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_LSTPRINT>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_LSTPRINT>()
                .Property(e => e.VERSION_LSTPRINT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_LSTPRINT>()
                .Property(e => e.NUMERO_LIGNE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_LSTPRINT>()
                .Property(e => e.CADRAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_LSTPRINT>()
                .Property(e => e.LIGNE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_LSTPRINT_ENTETE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_LSTPRINT_ENTETE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_LSTPRINT_ENTETE>()
                .Property(e => e.VERSION_LSTPRINT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.VERSION_MAGNETIQUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.CODE_MIN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.CODE_MAX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.CODE_SERVICE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.LIBELLE_CARTE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.LIBELLE_RECU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.TYPE_CARTE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.ORGANISATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.ID_MONNAIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.BILLING_CODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MAGNETIQUE>()
                .Property(e => e.BANK_CODE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MAGNETIQUE_ENTETE>()
                .Property(e => e.VERSION_MAGNETIQUE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.TAB_ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.TAB_ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.VERSION_MODULATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C01_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C01_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C02_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C02_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C03_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C03_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C04_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C04_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C05_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C05_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C06_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C06_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C07_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C07_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C08_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C08_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C09_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C09_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C10_1)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION>()
                .Property(e => e.C10_2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION_ENTETE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION_ENTETE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_MODULATION_ENTETE>()
                .Property(e => e.VERSION_MODULATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.VERSION_PARAMETRE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.TOLERANCE_HEURE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.ECART_OK_MONNAIE1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.ECART_OK_MONNAIE2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.ECART_OK_MONNAIE3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.ECART_OK_MONNAIE4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.ECART_OK_CHQ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.ECART_OK_JETON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.ECART_OK_RDD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE>()
                .Property(e => e.ECART_OK_GRATUIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PARAMETRE_ENTETE>()
                .Property(e => e.VERSION_PARAMETRE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PERIODE_TARIF>()
                .Property(e => e.VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PERIODE_TARIF>()
                .Property(e => e.CODE_TARIF)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERIODE_TARIF>()
                .Property(e => e.COMMENTAIRE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERIODE_TARIF_ENTETE>()
                .Property(e => e.VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.ID_FONCTION)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.VERSION_PERSONNEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.NOM)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.CODE_ACCES)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.PRENOM)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.SITE_AUTORISES)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.NB_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.MATRICULE_SL)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL>()
                .Property(e => e.NUMERO_CAPUFE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_PERSONNEL_ENTETE>()
                .Property(e => e.VERSION_PERSONNEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.ID_MONNAIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.VERSION_TARIF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.ID_NATIONALITE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.ID_RESEAU_ENTREE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.ID_GARE_ENTREE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.ID_PERIODE_TARIFAIRE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TYPE_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.CODE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL01)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL02)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL03)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL04)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL05)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL06)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL07)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL08)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL09)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.PRIX_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL01)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL02)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL03)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL04)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL05)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL06)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL07)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL08)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL09)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TVA_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL01)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL02)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL03)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL04)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL05)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL06)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL07)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL08)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL09)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF>()
                .Property(e => e.TAX_FREE_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF_ENTETE>()
                .Property(e => e.VERSION_TARIF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TARIF_ENTETE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TARIF_ENTETE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.VERSION_TRAJET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.ID_RESEAU_SORTIE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.ID_GARE_SORTIE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.ID_RESEAU_ENTREE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.ID_GARE_ENTREE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.CODE_SENS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.DISTANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL1)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL3)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL4)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL5)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL6)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL7)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL8)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL9)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL10)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL11)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL12)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL13)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL14)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL15)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL16)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL17)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL18)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL19)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MINI_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET>()
                .Property(e => e.TEMPS_MAXI_CL20)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TABLE_TRAJET_ENTETE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TRAJET_ENTETE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TABLE_TRAJET_ENTETE>()
                .Property(e => e.VERSION_TRAJET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_ETAT_TELEPEAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_MODE_VOIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.NUMERO_POSTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_CLASSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_TYPE_ACQUISITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_OBS_TT)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_OBS_MP)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_OBS_PASSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_CATEGORIE_FISCALE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_TRANSIT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TAB_ID_CLASSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TAB_ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TAB_ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRA_ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRA_ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRA_ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRA_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.VERSION_TARIF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_PAIEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.NUMERO_TRANSACTION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.INDICE_SUITE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.NIVEAU_EMISSION_TT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.DATE_ENTREE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.NUMERO_TICKET)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.CODE_GRILLE_TARIF)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.PRIX_TOTAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.PRIX_PARTIEL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.CONTENU_ISO)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.CODE_OCTAL)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.MODE_REGLEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT0)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT1)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT2)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT3)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT4)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT5)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT6)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT7)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT8)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TRANSACTION_CPT9)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_FACTURATION)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.CODE1)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.NUMERO_CARTE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.NO_ABONNEMENT_CARTE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_NETWORK_ENTRY)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_STAFF_ENTRY)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.INCOME_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.VAT_AMOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.RECEIPT_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.VALIDATED_DATA_FLAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.VALIDATION_STAFF)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ID_TYPE_CORRECTION)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.CORRECTION_STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.SHIFT_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.VIOLATION_NUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.VEHICLE_LPN)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.EVENT_NUMBER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ACD_CLASS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.ISSUER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.TAG_TRX_NB)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.EFACTURA)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.OPERATION_CODE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSACTION>()
                .Property(e => e.FOLIO_ECT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TRANSFERT_BANQUE>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERT_BANQUE>()
                .Property(e => e.MATRICULE)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERT_BANQUE>()
                .Property(e => e.NB_SACS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_ACQUISITION>()
                .Property(e => e.ID_TYPE_ACQUISITION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_ACQUISITION>()
                .Property(e => e.LIBELLE_ACQUISITION)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CLASSE>()
                .Property(e => e.ID_CLASSE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_CLASSE>()
                .Property(e => e.ORDRE_AFFICHAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_CLASSE>()
                .Property(e => e.LIBELLE_CLASSE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CLASSE>()
                .Property(e => e.LIBELLE_CLASSE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CLASSE>()
                .Property(e => e.LIBELLE_COURT1)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CLASSE>()
                .Property(e => e.LIBELLE_COURT1_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CLASSE>()
                .Property(e => e.LIBELLE_COURT2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_CLASSE>()
                .Property(e => e.LIBELLE_COURT2_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_EQUIPEMENT>()
                .Property(e => e.ID_EQUIPEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_EQUIPEMENT>()
                .Property(e => e.LIBELLE_EQUIPEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_EQUIPEMENT>()
                .Property(e => e.LIBELLE_EQUIPEMENT_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_EQUIPEMENT>()
                .Property(e => e.LIBELLE_EQUIPEMENT_LONG)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_EQUIPEMENT>()
                .Property(e => e.LIBELLE_EQUIPEMENT_LONG_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_ETAT_TELEPEAGE>()
                .Property(e => e.ID_ETAT_TELEPEAGE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_ETAT_TELEPEAGE>()
                .Property(e => e.LIBELLE_ETAT_TELEPEAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FONCTION>()
                .Property(e => e.ID_FONCTION)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FONCTION>()
                .Property(e => e.LIBELLE_FONCTION)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_FONCTION>()
                .Property(e => e.LIBELLE_FONCTION_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_GARE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_GARE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_GARE>()
                .Property(e => e.NOM_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_GARE>()
                .Property(e => e.NOM_GARE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_LIBELLE_EVENEMENT>()
                .Property(e => e.ID_LIBELLE_EVENEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_LIBELLE_EVENEMENT>()
                .Property(e => e.LIBELLE_EVENEMENT_LONG)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_LIBELLE_EVENEMENT>()
                .Property(e => e.LIBELLE_EVENEMENT_COURT_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_LIBELLE_EVENEMENT>()
                .Property(e => e.LIBELLE_EVENEMENT_COURT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_LIBELLE_EVENEMENT>()
                .Property(e => e.LIBELLE_EVENEMENT_LONG_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_MODE_VOIE>()
                .Property(e => e.ID_MODE_VOIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_MODE_VOIE>()
                .Property(e => e.LIBELLE_MODE_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_MODE_VOIE>()
                .Property(e => e.LIBELLE_MODE_VOIE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_MONNAIE>()
                .Property(e => e.ID_MONNAIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_MONNAIE>()
                .Property(e => e.ORDRE_MONNAIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_MONNAIE>()
                .Property(e => e.MONNAIE_REF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_MONNAIE>()
                .Property(e => e.LIBELLE_MONNAIE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_MONNAIE>()
                .Property(e => e.LIBELLE_MONNAIE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_NATIONALITE>()
                .Property(e => e.ID_NATIONALITE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_NATIONALITE>()
                .Property(e => e.LIBELLE_NATIONALITE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_MP>()
                .Property(e => e.ID_OBS_MP)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_MP>()
                .Property(e => e.SEL_OBS_MP)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_MP>()
                .Property(e => e.LIBELLE_OBS_MP)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_MP>()
                .Property(e => e.LIBELLE_OBS_MP_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_PASSAGE>()
                .Property(e => e.ID_OBS_PASSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_PASSAGE>()
                .Property(e => e.LIBELLE_OBS_PASSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_PASSAGE>()
                .Property(e => e.LIBELLE_OBS_PASSAGE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_PASSAGE>()
                .Property(e => e.SEL_OBS_PASSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_PASSAGE_BE>()
                .Property(e => e.ID_OBS_PASSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_PASSAGE_BE>()
                .Property(e => e.LIBELLE_OBS_PASSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_PASSAGE_BE>()
                .Property(e => e.LIBELLE_OBS_PASSAGE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_PASSAGE_BE>()
                .Property(e => e.SEL_OBS_PASSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_SEQUENCE>()
                .Property(e => e.ID_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_SEQUENCE>()
                .Property(e => e.SEL_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_SEQUENCE>()
                .Property(e => e.LIBELLE_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_SEQUENCE>()
                .Property(e => e.LIBELLE_OBS_SEQUENCE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_SEQUENCE_BE>()
                .Property(e => e.ID_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_SEQUENCE_BE>()
                .Property(e => e.SEL_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_SEQUENCE_BE>()
                .Property(e => e.LIBELLE_OBS_SEQUENCE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_SEQUENCE_BE>()
                .Property(e => e.LIBELLE_OBS_SEQUENCE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_TT>()
                .Property(e => e.ID_OBS_TT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_TT>()
                .Property(e => e.SEL_OBS_TT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_TT>()
                .Property(e => e.LIBELLE_OBS_TT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_TT>()
                .Property(e => e.LIBELLE_OBS_TT_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_TT_BE>()
                .Property(e => e.ID_OBS_TT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_TT_BE>()
                .Property(e => e.SEL_OBS_TT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_TT_BE>()
                .Property(e => e.LIBELLE_OBS_TT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_OBS_TT_BE>()
                .Property(e => e.LIBELLE_OBS_TT_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PAIEMENT>()
                .Property(e => e.ID_PAIEMENT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_PAIEMENT>()
                .Property(e => e.LIBELLE_PAIEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PAIEMENT>()
                .Property(e => e.LIBELLE_PAIEMENT_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PAIEMENT>()
                .Property(e => e.SEL_OBS_TYPE_PAIEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PAIEMENT>()
                .Property(e => e.ID_TYPE_MODE_PAIEMENT)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PAIEMENT>()
                .Property(e => e.PRESENTATION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_PROBLEME>()
                .Property(e => e.ID_PROBLEME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_PROBLEME>()
                .Property(e => e.LIBELLE_PROBLEME)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_PROBLEME_BE>()
                .Property(e => e.ID_PROBLEME)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TYPE_PROBLEME_BE>()
                .Property(e => e.LIBELLE_PROBLEME)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_RESEAU>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_RESEAU>()
                .Property(e => e.NOM_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_RESEAU>()
                .Property(e => e.NOM_RESEAU_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_SITE>()
                .Property(e => e.ID_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_SITE>()
                .Property(e => e.NOM_SITE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_SITE>()
                .Property(e => e.NOM_SITE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_TRANSACTION>()
                .Property(e => e.ID_TRX)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_TRANSACTION>()
                .Property(e => e.TRX_LABEL)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_TRANSACTION>()
                .Property(e => e.TRX_LABEL_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_TRANSACTION>()
                .Property(e => e.DISPLAY_INDICATOR)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_VOIE>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_VOIE>()
                .Property(e => e.LIBELLE_COURT_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_VOIE>()
                .Property(e => e.LIBELLE_COURT_VOIE_L2)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_VOIE>()
                .Property(e => e.LIBELLE_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_VOIE>()
                .Property(e => e.ENTREE_SORTIE)
                .IsUnicode(false);

            modelBuilder.Entity<VOIE_PHYSIQUE>()
                .Property(e => e.ID_RESEAU)
                .IsUnicode(false);

            modelBuilder.Entity<VOIE_PHYSIQUE>()
                .Property(e => e.ID_GARE)
                .IsUnicode(false);

            modelBuilder.Entity<VOIE_PHYSIQUE>()
                .Property(e => e.ID_VOIE)
                .IsUnicode(false);

            modelBuilder.Entity<VOIE_PHYSIQUE>()
                .Property(e => e.VOIE)
                .IsUnicode(false);
        }
    }
}

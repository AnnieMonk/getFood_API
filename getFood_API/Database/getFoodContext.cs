using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace getFood_API.Database
{
    public partial class getFoodContext : DbContext
    {
        public getFoodContext()
        {
        }

        public getFoodContext(DbContextOptions<getFoodContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dostava> Dostava { get; set; }
        public virtual DbSet<Favoriti> Favoriti { get; set; }
        public virtual DbSet<Izlaz> Izlaz { get; set; }
        public virtual DbSet<IzlazStavke> IzlazStavke { get; set; }
        public virtual DbSet<Kartica> Kartica { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<KorisnikRestoran> KorisnikRestoran { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUloga { get; set; }
        public virtual DbSet<Kuhinja> Kuhinja { get; set; }
        public virtual DbSet<Kuponi> Kuponi { get; set; }
        public virtual DbSet<Meni> Meni { get; set; }
        public virtual DbSet<MeniProdukti> MeniProdukti { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public virtual DbSet<Produkti> Produkti { get; set; }
        public virtual DbSet<ProduktiSastojci> ProduktiSastojci { get; set; }
        public virtual DbSet<Restoran> Restoran { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Rezervacije> Rezervacije { get; set; }
        public virtual DbSet<Sastojci> Sastojci { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.; Database=getFood; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dostava>(entity =>
            {
                entity.Property(e => e.DostavaId).HasColumnName("DostavaID");

                entity.Property(e => e.DatumVrijemeEnd)
                    .HasColumnName("DatumVrijeme_End")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatumVrijemeStart)
                    .HasColumnName("DatumVrijeme_Start")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Favoriti>(entity =>
            {
                entity.HasKey(e => e.FavoritId);

                entity.Property(e => e.FavoritId).HasColumnName("FavoritID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Favoriti)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favoriti_Korisnik");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Favoriti)
                    .HasForeignKey(d => d.RestoranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favoriti_Restoran");
            });

            modelBuilder.Entity<Izlaz>(entity =>
            {
                entity.Property(e => e.IzlazId).HasColumnName("IzlazID");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.IznosBezPdv).HasColumnName("IznosBezPDV");

                entity.Property(e => e.IznosSaPdv).HasColumnName("IznosSaPDV");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Izlaz)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Izlaz_Korisnik");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.Izlaz)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Izlaz_Narudzba");
            });

            modelBuilder.Entity<IzlazStavke>(entity =>
            {
                entity.Property(e => e.IzlazStavkeId).HasColumnName("IzlazStavkeID");

                entity.Property(e => e.IzlazId).HasColumnName("IzlazID");

                entity.Property(e => e.Popust).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProduktiId).HasColumnName("ProduktiID");

                entity.HasOne(d => d.Izlaz)
                    .WithMany(p => p.IzlazStavke)
                    .HasForeignKey(d => d.IzlazId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IzlazStavke_Izlaz");

                entity.HasOne(d => d.Produkti)
                    .WithMany(p => p.IzlazStavke)
                    .HasForeignKey(d => d.ProduktiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IzlazStavke_Produkti");
            });

            modelBuilder.Entity<Kartica>(entity =>
            {
                entity.Property(e => e.KarticaId).HasColumnName("KarticaID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Kartica)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kartica_Korisnik");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Adresa).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime).IsRequired();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Telefon).IsRequired();
            });

            modelBuilder.Entity<KorisnikRestoran>(entity =>
            {
                entity.Property(e => e.KorisnikRestoranId).HasColumnName("KorisnikRestoranID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikRestoran)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikRestoran_Korisnik");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.KorisnikRestoran)
                    .HasForeignKey(d => d.RestoranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikRestoran_Restoran");
            });

            modelBuilder.Entity<KorisnikUloga>(entity =>
            {
                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.DatumPromjene).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUloga)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikUloga_Korisnik");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUloga)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikUloga_Uloga");
            });

            modelBuilder.Entity<Kuhinja>(entity =>
            {
                entity.Property(e => e.KuhinjaId).HasColumnName("KuhinjaID");
            });

            modelBuilder.Entity<Kuponi>(entity =>
            {
                entity.HasKey(e => e.KuponId);

                entity.Property(e => e.KuponId).HasColumnName("KuponID");

                entity.Property(e => e.Kod)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Popust).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Kuponi)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_Kuponi_Korisnik");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Kuponi)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kuponi_Status");
            });

            modelBuilder.Entity<Meni>(entity =>
            {
                entity.Property(e => e.MeniId).HasColumnName("MeniID");

                entity.Property(e => e.DatumIsteka)
                    .HasColumnName("Datum_Isteka")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatumNapravljen)
                    .HasColumnName("Datum_Napravljen")
                    .HasColumnType("datetime");

                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.Opis).HasColumnType("text");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Meni)
                    .HasForeignKey(d => d.RestoranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Meni_Restoran");
            });

            modelBuilder.Entity<MeniProdukti>(entity =>
            {
                entity.Property(e => e.MeniProduktiId).HasColumnName("MeniProduktiID");

                entity.Property(e => e.MeniId).HasColumnName("MeniID");

                entity.Property(e => e.ProduktiId).HasColumnName("ProduktiID");

                entity.HasOne(d => d.Meni)
                    .WithMany(p => p.MeniProdukti)
                    .HasForeignKey(d => d.MeniId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeniProdukti_Meni");

                entity.HasOne(d => d.Produkti)
                    .WithMany(p => p.MeniProdukti)
                    .HasForeignKey(d => d.ProduktiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeniProdukti_Produkti");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.BrojNarudzbe).IsRequired();

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.DostavaId).HasColumnName("DostavaID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Napomena).HasColumnType("text");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Dostava)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.DostavaId)
                    .HasConstraintName("FK_Narudzba_Dostava");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzba_Korisnik");

                entity.HasOne(d => d.Kupon)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.KuponId)
                    .HasConstraintName("FK_Narudzba_Kupon");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.RestoranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzba_Restoran");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzba_Status");
            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.Property(e => e.NarudzbaStavkeId).HasColumnName("NarudzbaStavkeID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.ProduktiId).HasColumnName("ProduktiID");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NarudzbaStavke_Narudzba");

                entity.HasOne(d => d.Produkti)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.ProduktiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NarudzbaStavke_Produkti");
            });

            modelBuilder.Entity<Produkti>(entity =>
            {
                entity.Property(e => e.ProduktiId).HasColumnName("ProduktiID");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.Opis).HasColumnType("text");

                entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Produkti)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produkti_Kategorija");
            });

            modelBuilder.Entity<ProduktiSastojci>(entity =>
            {
                entity.Property(e => e.ProduktiSastojciId).HasColumnName("ProduktiSastojciID");

                entity.Property(e => e.Kolicina).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProduktiId).HasColumnName("ProduktiID");

                entity.Property(e => e.SastojciId).HasColumnName("SastojciID");

                entity.HasOne(d => d.Produkti)
                    .WithMany(p => p.ProduktiSastojci)
                    .HasForeignKey(d => d.ProduktiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProduktiSastojci_Produkti");

                entity.HasOne(d => d.Sastojci)
                    .WithMany(p => p.ProduktiSastojci)
                    .HasForeignKey(d => d.SastojciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProduktiSastojci_Sastojci");
            });

            modelBuilder.Entity<Restoran>(entity =>
            {
                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.Property(e => e.Adresa).IsRequired();

                entity.Property(e => e.KuhinjaId).HasColumnName("KuhinjaID");

                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.Opis).HasColumnType("text");

                entity.Property(e => e.RadnoVrijeme).IsRequired();

                entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.Telefon).IsRequired();

                entity.Property(e => e.Web).IsRequired();

                entity.HasOne(d => d.Kuhinja)
                    .WithMany(p => p.Restoran)
                    .HasForeignKey(d => d.KuhinjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Restoran_Kuhinja");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Komentar).HasColumnType("text");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Ocjena).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProduktiId).HasColumnName("ProduktiID");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Review_Korisnik");

                entity.HasOne(d => d.Produkti)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.ProduktiId)
                    .HasConstraintName("FK_Review_Produkti");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.RestoranId)
                    .HasConstraintName("FK_Review_Restoran");
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId);

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.DatumVrijeme).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Napomena).HasMaxLength(100);

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Korisnik");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.RestoranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Restoran");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Rezervacije)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacije_Status");
            });

            modelBuilder.Entity<Sastojci>(entity =>
            {
                entity.Property(e => e.SastojciId).HasColumnName("SastojciID");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv).IsRequired();
            });
        }
    }
}

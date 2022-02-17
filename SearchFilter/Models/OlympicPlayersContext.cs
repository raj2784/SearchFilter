//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//#nullable disable

//namespace SearchFilter.Models
//{
//    public partial class OlympicPlayersContext : DbContext
//    {
//        public OlympicPlayersContext()
//        {
//        }

//        public OlympicPlayersContext(DbContextOptions<OlympicPlayersContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Player> Players { get; set; }

////        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////        {
////            if (!optionsBuilder.IsConfigured)
////            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
////                optionsBuilder.UseSqlServer("Server=DXC215181\\SQLEXPRESS;Database=OlympicPlayers;Trusted_Connection=True;");
////            }
////        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Player>(entity =>
//            {
//                entity.HasKey(e => e.PlayersId)
//                    .HasName("PK__Players__9BD582CEB8C919E7");

//                entity.Property(e => e.PlayersId).HasColumnName("PlayersID");

//                entity.Property(e => e.Country)
//                    .HasMaxLength(100)
//                    .IsUnicode(false)
//                    .HasColumnName("country");

//                entity.Property(e => e.Name)
//                    .HasMaxLength(255)
//                    .IsUnicode(false)
//                    .HasColumnName("name");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}

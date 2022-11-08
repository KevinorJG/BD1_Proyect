using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Financiera.Domain.Entities;
using Financiera.Domain.Interfaces;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

#nullable disable

namespace Financiera.Domain.ContextDB
{
    public partial class FinancieraContext : DbContext, IFinancieraContext
    {
        public FinancieraContext()
        {
        }

        public FinancieraContext(DbContextOptions<FinancieraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountDetail> AccountDetails { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<CardDetail> CardDetails { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Hideline> Hidelines { get; set; }

        public Task<bool> DeleteClient(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetClientByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertClient(Client entity)
        {
            SqlParameter[]? param = null;
            Task<int> result = null;

            try
            {
                param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@names",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size= 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Names
                        },
                        new SqlParameter() {
                            ParameterName = "@lastnames",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.LastNames
                        },
                        new SqlParameter() {
                            ParameterName = "@Direction",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Direction
                        },
                        new SqlParameter() {
                            ParameterName = "@phone",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 15,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Phone
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@Birth",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.BirthDate
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@Nation",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Nacionality
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@dni",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Identification
                        }


                     };
                var execute = Database.ExecuteSqlRawAsync("[dbo].[sp_InsertClient] @names,@lastnames,@Direction,@phone,@Birth,@Nation,@dni", param);
                await execute;
                result = execute;
            }
            catch (Exception ex)
            {

            }
            return result.Result;
        }
        public Task<bool> UpdateClient(Client entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Validate(string login)
        {
            throw new NotImplementedException();
        }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=KEVINOR\\SQLEXPRESS;Database=Financiera;user=sa;password=12345678;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAccount)
                    .HasName("PK__Accounts__0EB75CDB6C31A0B5");

                entity.Property(e => e.IdAccount).HasColumnName("Id_Account");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Description_");

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.IdHideline).HasColumnName("id_Hideline");

                entity.Property(e => e.MinAmount).HasColumnType("money");

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Status_");

                entity.Property(e => e.TypeAccount)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Type_Account");

                entity.Property(e => e.TypeCoin)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Type_Coin");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__Accounts__id_Cli__5EBF139D");

                entity.HasOne(d => d.IdHidelineNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdHideline)
                    .HasConstraintName("FK__Accounts__id_Hid__5FB337D6");
            });

            modelBuilder.Entity<AccountDetail>(entity =>
            {
                entity.HasKey(e => e.IdAccountDetails)
                    .HasName("PK__AccountD__DF9627CD3D4B0327");

                entity.Property(e => e.IdAccountDetails).HasColumnName("Id_AccountDetails");

                entity.Property(e => e.Deposito).HasColumnType("money");

                entity.Property(e => e.IdAccount).HasColumnName("id_Account");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");

                entity.Property(e => e.Retiro).HasColumnType("money");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.HasOne(d => d.IdAccountNavigation)
                    .WithMany(p => p.AccountDetails)
                    .HasForeignKey(d => d.IdAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccountDe__id_Ac__60A75C0F");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.AccountDetails)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccountDe__id_Em__619B8048");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(e => e.IdCard)
                    .HasName("PK__Cards__A7B8DC5692306856");

                entity.Property(e => e.IdCard).HasColumnName("Id_Card");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Description_");

                entity.Property(e => e.ExpiredDate).HasColumnType("date");

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.MaxAmount).HasColumnType("money");

                entity.Property(e => e.MinAmount).HasColumnType("money");

                entity.Property(e => e.NameCard)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.TypeCard)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TypeCoin)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cards__id_Client__5CD6CB2B");
            });

            modelBuilder.Entity<CardDetail>(entity =>
            {
                entity.HasKey(e => e.IdCardDetails)
                    .HasName("PK__CardDeta__8B8DDC0267169511");

                entity.Property(e => e.IdCardDetails).HasColumnName("Id_CardDetails");

                entity.Property(e => e.Deposito).HasColumnType("money");

                entity.Property(e => e.IdCard).HasColumnName("id_Card");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");

                entity.Property(e => e.Retiro).HasColumnType("money");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.HasOne(d => d.IdCardNavigation)
                    .WithMany(p => p.CardDetails)
                    .HasForeignKey(d => d.IdCard)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CardDetai__id_Ca__5DCAEF64");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.CardDetails)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CardDetai__id_Em__628FA481");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PK__Clients__668DFF3F1B66E1BA");

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastNames)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nacionality)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__Employee__938D4B1019BE6262");

                entity.Property(e => e.IdEmployee).HasColumnName("Id_Employee");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DNI");

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Roll)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Status_");

                entity.Property(e => e.Surnames)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Hideline>(entity =>
            {
                entity.HasKey(e => e.IdHideline)
                    .HasName("PK__Hideline__49C5CC97EE226FA4");

                entity.ToTable("Hideline");

                entity.Property(e => e.IdHideline).HasColumnName("Id_Hideline");

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Name_");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

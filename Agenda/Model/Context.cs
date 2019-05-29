using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Model
{
    public class Context :DbContext
    {
        private Context Conn;
        public bool CreateConnection()
        {
            try
            {
                this.Conn = new Context();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Context GetConn()
        {
            return Conn;
        }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Email> Emails { get; set; }
        //public DbSet<Fixo> Fixos { get; set; }
        //public DbSet<Movel> Movels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqliteConn = new Microsoft.Data.Sqlite.SqliteConnection(@"DataSource = Agenda.db");
            optionsBuilder.UseSqlite(sqliteConn);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Telefone>().HasIndex(u => u.Numero).IsUnique();
        //}
    }
}

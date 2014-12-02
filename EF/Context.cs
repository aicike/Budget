using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Entity;
using EF.Mapping;

namespace EF
{
    public class Context : DbContext
    {
        public DbSet<Menu> Menu { get; set; }
        public DbSet<BudgetClass> BudgetClass { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyAccount> CompanyAccount { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupAccount> GroupAccount { get; set; }
        public DbSet<ParticularYear> ParticularYear { get; set; }
        public DbSet<ProfitLoss_Coefficient> ProfitLoss_Coefficient { get; set; }
        public DbSet<ProfitLoss_Main> ProfitLoss_Main { get; set; }
        public DbSet<ProfitLoss_Detailed> ProfitLoss_Detailed { get; set; }

        //数据库生成的其他设置
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new ProfitLossReality_MainMap());
            modelBuilder.Configurations.Add(new ProfitLossReality_DetailMap());
            
        }
    }
}

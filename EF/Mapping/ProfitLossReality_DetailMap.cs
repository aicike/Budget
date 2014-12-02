using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace EF.Mapping
{
    public class ProfitLossReality_DetailMap : EntityTypeConfiguration<ProfitLossReality_Detail>
    {
        public ProfitLossReality_DetailMap()
        {
            this.HasRequired(a => a.ProfitLossReality_Main)
            .WithMany(a => a.ProfitLossReality_Details)
            .HasForeignKey(a => a.ProfitLossReality_MainID).WillCascadeOnDelete(true);
        }
    }
}

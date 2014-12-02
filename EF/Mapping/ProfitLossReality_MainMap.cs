using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace EF.Mapping
{
    public class ProfitLossReality_MainMap : EntityTypeConfiguration<ProfitLossReality_Main>
    {
        public ProfitLossReality_MainMap()
        {
            this.HasRequired(a => a.ProfitLoss_Detailed).WithRequiredDependent(a => a.ProfitLossReality_Main);
        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Recon; 

namespace IMS.DAL.Maps.Recon {
    
    
    public class ViewSamplesYyMmAllIDMap : ClassMap<ViewSamplesYyMmAllID> {
        
        public ViewSamplesYyMmAllIDMap() {
            Schema("recon");
			Table("view_samples_yy_mm_all_id");
            Id(x => x.row_id).GeneratedBy.Assigned().Column("row_id");
			Map(x => x.YY).Column("yy").Not.Nullable();
			Map(x => x.MM).Column("mm");
			Map(x => x.flag_code).Column("flag_code").Length(2);
			Map(x => x.company_country_code).Column("company_country_code").Length(2);
			Map(x => x.gear_code).Column("gear_code").Not.Nullable().Length(2);
			Map(x => x.samples_n).Column("samples_n");
            Map(x => x.vessels_n).Column("vessels_n");
            Map(x => x.alb_n).Column("alb_n");
            Map(x => x.bet_n).Column("bet_n");
            Map(x => x.skj_n).Column("skj_n");
            Map(x => x.yft_n).Column("yft_n");
            Map(x => x.oth_n).Column("oth_n");
            Map(x => x.tot_n).Column("tot_n");
            Map(x => x.alb_mt).Column("alb_mt");
            Map(x => x.bet_mt).Column("bet_mt");
            Map(x => x.skj_mt).Column("skj_mt");
            Map(x => x.yft_mt).Column("yft_mt");
			Map(x => x.oth_mt).Column("oth_mt");
			Map(x => x.tot_mt).Column("tot_mt");
        }
    }
}

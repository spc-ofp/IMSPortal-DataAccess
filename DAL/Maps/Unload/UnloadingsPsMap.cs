using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Unload; 

namespace IMS.DAL.Maps.Unload {
    
    
    public class UnloadingsPsMap : ClassMap<UnloadingsPs> {
        
        public UnloadingsPsMap() {
            Schema("unload");
			Table("unloadings_ps");
			Id(x => x.unload_id).GeneratedBy.Assigned().Column("unload_id");
			Map(x => x.recon_trip_id).Column("recon_trip_id");
			References(x => x.vessels).Column("vessel_id");
			References(x => x.ports).Column("port_id");
			Map(x => x.unload_carr_id).Column("unload_carr_id");
			Map(x => x.flag_code).Column("flag_code").Length(50);
			Map(x => x.unload_startdate).Column("unload_startdate");
			Map(x => x.unload_enddate).Column("unload_enddate");
            Map(x => x.log_trip_id).Column("log_trip_id");
			Map(x => x.log_dep_date).Column("log_dep_date");
			Map(x => x.log_ret_date).Column("log_ret_date");
			Map(x => x.logsheet).Column("logsheet").Not.Nullable();
            Map(x => x.obs_trip_id).Column("obs_trip_id");
            Map(x => x.vess_act_id).Column("vess_act_id");
            Map(x => x.license_id).Column("license_id");
            Map(x => x.unload_type_code).Column("unload_type_code").Nullable().Length(1);
			Map(x => x.sample_id).Column("sample_id");
            Map(x => x.batch_code).Column("batch_code").Nullable().Length(10);
            Map(x => x.nat_fleet_id).Column("nat_fleet_id");
            Map(x => x.skj_mt).Column("skj_mt");
            Map(x => x.yft_lt9_mt).Column("yft_lt9_mt");
            Map(x => x.yft_gt9_mt).Column("yft_gt9_mt");
            Map(x => x.yft_mt).Column("yft_mt");
            Map(x => x.bet_lt9_mt).Column("bet_lt9_mt");
			Map(x => x.bet_gt9_mt).Column("bet_gt9_mt");
			Map(x => x.bet_mt).Column("bet_mt");
			Map(x => x.yft_bet_mt).Column("yft_bet_mt");
			Map(x => x.skj_yft_bet_mt).Column("skj_yft_bet_mt");
            Map(x => x.oth_mt).Column("oth_mt");
            Map(x => x.tot_mt).Column("tot_mt");
			Map(x => x.unload_type_code2).Column("unload_type_code2").Nullable().Length(1);
            Map(x => x.entered_by).Column("entered_by").Nullable().Length(50);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

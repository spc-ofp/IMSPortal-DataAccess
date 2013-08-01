using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class NationalFleetsMap : ClassMap<NationalFleets> {
        
        public NationalFleetsMap() {
            Schema("lic");
			Table("national_fleets");
            Id(x => x.nat_fleet_id).GeneratedBy.Assigned().Column("nat_fleet_id");
			References(x => x.vessels).Column("vessel_id");
			Map(x => x.date_from).Column("date_from").Not.Nullable();
			Map(x => x.date_to).Column("date_to");
			Map(x => x.active).Column("active").Not.Nullable();
			Map(x => x.regist_no).Column("regist_no").Length(20);
			Map(x => x.auth_no).Column("auth_no").Length(50);
			Map(x => x.company_id).Column("company_id").Precision(10);
			Map(x => x.fishing_zones).Column("fishing_zones").Length(250);
			Map(x => x.auth_ports).Column("auth_ports").Length(250);
			Map(x => x.comments).Column("comments");
			Map(x => x.charter).Column("charter").Not.Nullable();
			Map(x => x.nat_subfleet_code).Column("nat_subfleet_code").Length(5);
			Map(x => x.active_wcpfc).Column("active_wcpfc");
			Map(x => x.authorized_vessel).Column("authorized_vessel");
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class NatFleetLicMap : ClassMap<NatFleetLic> {
        
        public NatFleetLicMap() {
            Schema("lic");
			Table("nat_fleet_lic");
            Id(x => x.nat_fleet_lic_id).GeneratedBy.Assigned().Column("nat_fleet_lic_id");
			References(x => x.national_fleets).Column("nat_fleet_id");
			References(x => x.countries).Column("country_code");
			Map(x => x.license_no).Column("license_no").Not.Nullable().Length(20);
			Map(x => x.lic_startdate).Column("lic_startdate").Not.Nullable();
			Map(x => x.lic_enddate).Column("lic_enddate").Not.Nullable();
			Map(x => x.license_id).Column("license_id").Precision(10);
			Map(x => x.comments).Column("comments");
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

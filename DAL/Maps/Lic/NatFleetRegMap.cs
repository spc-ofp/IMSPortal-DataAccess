using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class NatFleetRegMap : ClassMap<NatFleetReg> {
        
        public NatFleetRegMap() {
            Schema("lic");
			Table("nat_fleet_reg");
            Id(x => x.nat_fleet_reg_id).GeneratedBy.Assigned().Column("nat_fleet_reg_id");
			References(x => x.national_fleets).Column("nat_fleet_id");
			Map(x => x.certificate_no).Column("certificate_no").Not.Nullable().Length(20);
			Map(x => x.start_date).Column("start_date").Not.Nullable();
			Map(x => x.end_date).Column("end_date").Not.Nullable();
			Map(x => x.comments).Column("comments");
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

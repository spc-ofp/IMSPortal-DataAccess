using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class NatFleetIafMap : ClassMap<NatFleetIaf> {
        
        public NatFleetIafMap() {
            Schema("lic");
			Table("nat_fleet_iaf");
            Id(x => x.iaf_id).GeneratedBy.Assigned().Column("iaf_id");
            References(x => x.national_fleets).Column("nat_fleet_id");
            Map(x => x.iaf_no).Column("iaf_no").Not.Nullable().Length(50);
            References(x => x.iaf_zones).Column("iaf_zone_id");
            Map(x => x.iaf_zone_other).Column("iaf_zone_other").Not.Nullable().Length(50);
            Map(x => x.iaf_startdate).Column("iaf_startdate").Not.Nullable();
            Map(x => x.iaf_enddate).Column("iaf_enddate").Not.Nullable();
            Map(x => x.iaf_issuedate).Column("iaf_issuedate").Not.Nullable();
            Map(x => x.entered_by).Column("entered_by").Not.Nullable().Length(50);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.iaf_fee).Column("iaf_fee").Precision(10).Scale(2);
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}

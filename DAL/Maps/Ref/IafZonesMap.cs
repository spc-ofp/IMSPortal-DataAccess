using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace IMS.DAL.Maps.Ref {
    
    
    public class IafZonesMap : ClassMap<IafZones> {
        
        public IafZonesMap() {
            Schema("ref");
			Table("iaf_zones");
			Id(x => x.iaf_zone_id).GeneratedBy.Assigned().Column("iaf_zone_id");
			Map(x => x.iaf_zone_name).Column("iaf_zone_name").Length(50);
			Map(x => x.iaf_zone_desc).Column("iaf_zone_desc").Length(250);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

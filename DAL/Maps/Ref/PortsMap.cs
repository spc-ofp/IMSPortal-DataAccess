using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace IMS.DAL.Maps.Ref {
    
    
    public class PortsMap : ClassMap<Ports> {
        
        public PortsMap() {
            Schema("ref");
			Table("ports");
			Id(x => x.port_id).GeneratedBy.Assigned().Column("port_id");
			Map(x => x.port_name).Column("port_name").Length(30);
			Map(x => x.country_code).Column("country_code").Length(2);
			Map(x => x.location_code).Column("location_code").Length(5);
			Map(x => x.port_lat).Column("port_lat").Length(9);
			Map(x => x.port_lon).Column("port_lon").Length(10);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}

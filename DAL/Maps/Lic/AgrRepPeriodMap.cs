using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class AgrRepPeriodMap : ClassMap<AgrRepPeriod> {
        
        public AgrRepPeriodMap() {
            Schema("lic");
			Table("agr_rep_period");
            Id(x => x.arp_id).GeneratedBy.Assigned().Column("arp_id");
			References(x => x.agreements).Column("agr_code");
			Map(x => x.arp_type_code).Column("arp_type_code").Not.Nullable().Length(1);
			Map(x => x.arp_no).Column("arp_no").Precision(5);
			Map(x => x.arp_startdate).Column("arp_startdate");
			Map(x => x.arp_enddate).Column("arp_enddate");
			Map(x => x.comments).Column("comments");
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

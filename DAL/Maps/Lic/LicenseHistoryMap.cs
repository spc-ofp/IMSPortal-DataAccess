using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class LicenseHistoryMap : ClassMap<LicenseHistory> {
        
        public LicenseHistoryMap() {
            Schema("lic");
			Table("license_history");
            Id(x => x.status_id).GeneratedBy.Assigned().Column("status_id");
			Map(x => x.license_id).Column("license_id").Precision(10);
			Map(x => x.lic_status_id).Column("lic_status_id").Precision(10);
			Map(x => x.status_effect_date).Column("status_effect_date");
			Map(x => x.entered_by).Column("entered_by").Length(50);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.comments).Column("comments");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

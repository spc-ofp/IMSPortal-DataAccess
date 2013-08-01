using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref;

namespace IMS.DAL.Maps.Ref
{
    
    
    public class LicenseStatusMap : ClassMap<LicenseStatus> {
        
        public LicenseStatusMap() {
            Schema("ref");
			Table("license_status");
            Id(x => x.lic_status_id).GeneratedBy.Assigned().Column("lic_status_id");
			Map(x => x.lic_status_name).Column("lic_status_name").Length(50);
			Map(x => x.lic_status_desc).Column("lic_status_desc").Length(50);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}

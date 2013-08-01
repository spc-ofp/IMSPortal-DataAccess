using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref;

namespace IMS.DAL.Maps.Ref
{
    
    
    public class LicenseTypesMap : ClassMap<LicenseTypes> {
        
        public LicenseTypesMap() {
            Schema("ref");
			Table("license_types");
			Id(x => x.lic_type_id).GeneratedBy.Assigned().Column("lic_type_id");
			Map(x => x.lic_type_desc).Column("lic_type_desc").Length(50);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic; 

namespace IMS.DAL.Maps.Lic {
    
    
    public class ActivationsMap : ClassMap<Activations> {
        
        public ActivationsMap() {
            Schema("lic");
			Table("activations");
			Id(x => x.activation_id).GeneratedBy.Assigned().Column("activation_id");
			Map(x => x.license_id).Column("license_id").Not.Nullable().Precision(10);
			Map(x => x.activation_date).Column("activation_date").Not.Nullable();
			Map(x => x.activation_fee).Column("activation_fee").Precision(53);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref;

namespace IMS.DAL.Maps.Ref
{
    
    
    public class AgreementTypesMap : ClassMap<AgreementTypes> {
        
        public AgreementTypesMap() {
            Schema("ref");
			Table("agreement_types");
            Id(x => x.agr_type_id).GeneratedBy.Assigned().Column("agr_type_id");
			Map(x => x.agr_type_desc).Column("agr_type_desc").Length(50);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}

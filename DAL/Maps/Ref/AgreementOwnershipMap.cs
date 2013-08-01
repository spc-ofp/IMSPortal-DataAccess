using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ref; 

namespace IMS.DAL.Maps.Ref {
    
    
    public class AgreementOwnershipMap : ClassMap<AgreementOwnership> {
        
        public AgreementOwnershipMap() {
            Schema("ref");
			Table("agreement_ownership");
            Id(x => x.agr_own_id).GeneratedBy.Assigned().Column("agr_own_id");
			Map(x => x.agr_own_desc).Column("agr_own_desc").Length(50);
			Map(x => x.agr_own_longdesc).Column("agr_own_longdesc").Length(100);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman; 

namespace IMS.DAL.Maps.Tufman {
    
    
    public class CompaniesMap : ClassMap<Companies> {
        
        public CompaniesMap() {
            Schema("tufman");
			Table("companies");
            Id(x => x.company_id).GeneratedBy.Assigned().Column("company_id");
			Map(x => x.company_name).Column("company_name").Length(255);
			Map(x => x.country_code).Column("country_code").Length(2);
			Map(x => x.jv_country_code).Column("jv_country_code").Length(2);
			Map(x => x.company_code).Column("company_code").Length(50);
			Map(x => x.address1).Column("address1").Length(50);
			Map(x => x.address2).Column("address2").Length(50);
			Map(x => x.address3).Column("address3").Length(50);
			Map(x => x.city).Column("city").Length(50);
			Map(x => x.contact_name).Column("contact_name").Length(50);
			Map(x => x.phone).Column("phone").Length(20);
			Map(x => x.fax).Column("fax").Length(20);
			Map(x => x.email).Column("email").Length(50);
			Map(x => x.agreements_flag).Column("agreements_flag").Not.Nullable();
			Map(x => x.inactive).Column("inactive").Not.Nullable();
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class AgreementsMap : ClassMap<Agreements> {
        
        public AgreementsMap() {
            Schema("lic");
			Table("agreements");
			Id(x => x.agr_code).GeneratedBy.Assigned().Column("agr_code");
			References(x => x.companies).Column("company_id");
			References(x => x.agreement_types).Column("agr_type_id");
			Map(x => x.agr_signdate).Column("agr_signdate");
			Map(x => x.agr_place).Column("agr_place").Length(30);
			Map(x => x.agr_no).Column("agr_no").Not.Nullable().Precision(5);
			Map(x => x.agr_own_id).Column("agr_own_id").Not.Nullable().Precision(10);
			Map(x => x.agr_startdate).Column("agr_startdate").Not.Nullable();
			Map(x => x.agr_enddate).Column("agr_enddate").Not.Nullable();
			Map(x => x.reg_profile_id).Column("reg_profile_id").Precision(10);
			Map(x => x.agr_vessels_n).Column("agr_vessels_n").Precision(10);
			Map(x => x.agr_lumpsum_fee).Column("agr_lumpsum_fee").Precision(53);
			Map(x => x.agr_extra_fee).Column("agr_extra_fee").Precision(53);
			Map(x => x.agr_reg_fee).Column("agr_reg_fee").Precision(53);
			Map(x => x.cur_code).Column("cur_code").Length(3);
			Map(x => x.entered_by).Column("entered_by").Length(15);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.arp_code).Column("arp_code").Length(1);
			Map(x => x.comments).Column("comments");
			Map(x => x.auth_areas).Column("auth_areas").Length(250);
			Map(x => x.auth_species).Column("auth_species").Length(250);
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

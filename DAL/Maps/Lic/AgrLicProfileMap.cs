using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class AgrLicProfileMap : ClassMap<AgrLicProfile> {
        
        public AgrLicProfileMap() {
            Schema("lic");
			Table("agr_lic_profile");
            Id(x => x.agr_lic_id).GeneratedBy.Assigned().Column("agr_lic_id");
			Map(x => x.agr_code).Column("agr_code").Not.Nullable().Length(7);
			Map(x => x.lic_profile_id).Column("lic_profile_id").Precision(10);
			Map(x => x.lic_fee).Column("lic_fee").Not.Nullable().Precision(18).Scale(2);
			Map(x => x.obs_fee).Column("obs_fee").Precision(18).Scale(2);
			Map(x => x.reg_fee).Column("reg_fee").Precision(18).Scale(2);
			Map(x => x.voc_fee).Column("voc_fee").Precision(18).Scale(2);
			Map(x => x.acc_fee).Column("acc_fee").Precision(53);
			Map(x => x.cur_code).Column("cur_code").Length(3);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

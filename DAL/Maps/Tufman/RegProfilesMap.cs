using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman;

namespace IMS.DAL.Maps.Tufman
{
    
    public class RegProfilesMap : ClassMap<RegProfiles> {
        
        public RegProfilesMap() {
            Schema("tufman");
			Table("reg_profiles");
			Id(x => x.reg_profile_id).GeneratedBy.Assigned().Column("reg_profile_id");
			Map(x => x.reg_desc).Column("reg_desc").Length(100);
			Map(x => x.reg_mask).Column("reg_mask").Length(50);
			Map(x => x.country_code).Column("country_code").Length(2);
			Map(x => x.reg_period).Column("reg_period").Precision(5);
			Map(x => x.payment_required).Column("payment_required").Not.Nullable();
			Map(x => x.reg_fee).Column("reg_fee").Not.Nullable();
			Map(x => x.obs_fee).Column("obs_fee").Not.Nullable();
			Map(x => x.reg_certificate).Column("reg_certificate").Length(50);
			Map(x => x.sequence_group).Column("sequence_group").Length(20);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

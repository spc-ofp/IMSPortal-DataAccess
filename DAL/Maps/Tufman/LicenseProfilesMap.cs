using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman;

namespace IMS.DAL.Maps.Tufman
{
    
    
    public class LicenseProfilesMap : ClassMap<LicenseProfiles> {
        
        public LicenseProfilesMap() {
            Schema("tufman");
			Table("license_profiles");
            Id(x => x.lic_profile_id).GeneratedBy.Assigned().Column("lic_profile_id");
			References(x => x.countries).Column("country_code");
			References(x => x.gears).Column("gear_code");
			References(x => x.license_types).Column("lic_type_id");
			Map(x => x.lic_own_id).Column("lic_own_id").Precision(10);
			Map(x => x.lic_desc).Column("lic_desc").Length(100);
			Map(x => x.lic_short).Column("lic_short").Length(2);
			Map(x => x.license_mask).Column("license_mask").Length(80);
			Map(x => x.lic_period).Column("lic_period").Precision(5);
			Map(x => x.reg_required).Column("reg_required").Not.Nullable();
			Map(x => x.license_holder).Column("license_holder").Not.Nullable();
			Map(x => x.payment_required).Column("payment_required").Not.Nullable();
			Map(x => x.reg_fee).Column("reg_fee").Not.Nullable();
			Map(x => x.obs_fee).Column("obs_fee").Not.Nullable();
			Map(x => x.lic_fee).Column("lic_fee").Not.Nullable();
			Map(x => x.extra_ves_fee).Column("extra_ves_fee").Not.Nullable();
			Map(x => x.voc_fee).Column("voc_fee").Not.Nullable();
			Map(x => x.acc_fee).Column("acc_fee").Not.Nullable();
			Map(x => x.activation_fee).Column("activation_fee").Not.Nullable();
			Map(x => x.activation_required).Column("activation_required").Not.Nullable();
			Map(x => x.goods_services).Column("goods_services").Not.Nullable();
			Map(x => x.oth_fee).Column("oth_fee").Not.Nullable();
			Map(x => x.oth_fee_desc).Column("oth_fee_desc").Length(50);
			Map(x => x.sequence_group).Column("sequence_group").Length(20);
			Map(x => x.lic_certificate).Column("lic_certificate").Length(50);
			Map(x => x.period_units_code).Column("period_units_code").Length(4);
			Map(x => x.comments).Column("comments").Length(255);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

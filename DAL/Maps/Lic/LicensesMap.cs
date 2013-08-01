using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class LicensesMap : ClassMap<Licenses> {
        
        public LicensesMap() {
            Schema("lic");
			Table("licenses");
            Id(x => x.license_id).GeneratedBy.Assigned().Column("license_id");
			References(x => x.license_profiles).Column("lic_profile_id");
			References(x => x.license_status).Column("lic_status_id");
			References(x => x.vessels).Column("vessel_id");
			References(x => x.license_types).Column("lic_type_id");
			References(x => x.agr_rep_period).Column("arp_id");
			Map(x => x.license_no).Column("license_no").Length(25);
			Map(x => x.status_effect_date).Column("status_effect_date");
			Map(x => x.agr_code).Column("agr_code").Length(7);
			Map(x => x.lic_seq_no).Column("lic_seq_no").Precision(10);
			Map(x => x.lic_startdate).Column("lic_startdate");
			Map(x => x.lic_enddate).Column("lic_enddate");
			Map(x => x.lic_issue_date).Column("lic_issue_date");
			Map(x => x.license_holder).Column("license_holder").Precision(10);
			Map(x => x.lic_fee).Column("lic_fee").Precision(18).Scale(2);
			Map(x => x.obs_fee).Column("obs_fee").Precision(18).Scale(2);
			Map(x => x.reg_fee).Column("reg_fee").Precision(18).Scale(2);
			Map(x => x.voc_fee).Column("voc_fee").Precision(18).Scale(2);
			Map(x => x.acc_fee).Column("acc_fee").Precision(53);
			Map(x => x.oth_fee).Column("oth_fee").Precision(53);
			Map(x => x.gst_value).Column("gst_value").Precision(53);
			Map(x => x.activation_fees).Column("activation_fees").Precision(53);
			Map(x => x.cur_code).Column("cur_code").Length(3);
			Map(x => x.cert_issued).Column("cert_issued").Not.Nullable();
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.entered_by).Column("entered_by").Length(50);
			Map(x => x.changed_date).Column("changed_date");
			Map(x => x.changed_by).Column("changed_by").Length(50);
			Map(x => x.comments).Column("comments");
			Map(x => x.discharge_port1).Column("discharge_port1").Length(12);
			Map(x => x.discharge_port2).Column("discharge_port2").Length(12);
			Map(x => x.discharge_port3).Column("discharge_port3").Length(12);
			Map(x => x.discharge_port4).Column("discharge_port4").Length(12);
			Map(x => x.trip_no).Column("trip_no").Precision(5);
			Map(x => x.auth_areas).Column("auth_areas").Length(250);
			Map(x => x.auth_species).Column("auth_species").Length(250);
        }
    }
}

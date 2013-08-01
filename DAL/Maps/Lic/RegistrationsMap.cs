using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class RegistrationsMap : ClassMap<Registrations> {
        
        public RegistrationsMap() {
            Schema("lic");
			Table("registrations");
            Id(x => x.reg_id).GeneratedBy.Assigned().Column("reg_id");
			Map(x => x.agr_code).Column("agr_code").Not.Nullable().Length(6);
			Map(x => x.arp_id).Column("arp_id").Precision(10);
			Map(x => x.vessel_id).Column("vessel_id").Not.Nullable().Precision(10);
			Map(x => x.reg_profile_id).Column("reg_profile_id").Not.Nullable().Precision(10);
			Map(x => x.reg_no).Column("reg_no").Not.Nullable().Length(20);
			Map(x => x.reg_seq_no).Column("reg_seq_no").Not.Nullable().Precision(10);
			Map(x => x.reg_startdate).Column("reg_startdate").Not.Nullable();
			Map(x => x.reg_enddate).Column("reg_enddate").Not.Nullable();
			Map(x => x.reg_issuedate).Column("reg_issuedate");
			Map(x => x.reg_fee).Column("reg_fee").Precision(18).Scale(2);
			Map(x => x.obs_fee).Column("obs_fee").Precision(18).Scale(2);
			Map(x => x.cur_code).Column("cur_code").Length(3);
			Map(x => x.port_code).Column("port_code").Length(2);
			Map(x => x.entered_by).Column("entered_by").Length(50);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

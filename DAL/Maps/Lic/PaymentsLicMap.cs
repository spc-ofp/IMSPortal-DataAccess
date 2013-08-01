using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class PaymentsLicMap : ClassMap<PaymentsLic> {
        
        public PaymentsLicMap() {
            Schema("lic");
			Table("payments_lic");
            Id(x => x.pmt_id).GeneratedBy.Assigned().Column("pmt_id");
			Map(x => x.rec_id).Column("rec_id").Precision(10);
			Map(x => x.license_id).Column("license_id").Precision(10);
			Map(x => x.payment_type_id).Column("payment_type_id").Not.Nullable().Precision(10);
			Map(x => x.amount_foreign).Column("amount_foreign").Not.Nullable().Precision(53);
			Map(x => x.cur_code).Column("cur_code").Not.Nullable().Length(3);
			Map(x => x.amount_local).Column("amount_local").Precision(53);
			Map(x => x.comments).Column("comments").Length(50);
			Map(x => x.zprl_id).Column("zprl_id").Length(7);
			Map(x => x.zref_id).Column("zref_id").Precision(10);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

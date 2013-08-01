using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Lic;

namespace IMS.DAL.Maps.Lic
{
    
    
    public class ReceiptsMap : ClassMap<Receipts> {
        
        public ReceiptsMap() {
            Schema("lic");
			Table("receipts");
            Id(x => x.rec_id).GeneratedBy.Assigned().Column("rec_id");
			Map(x => x.rem_ref).Column("rem_ref").Not.Nullable().Length(20);
			Map(x => x.company_id).Column("company_id").Not.Nullable().Precision(10);
			Map(x => x.recvd_date).Column("recvd_date").Not.Nullable();
			Map(x => x.bank_ref).Column("bank_ref").Length(20);
			Map(x => x.amount_foreign).Column("amount_foreign").Not.Nullable().Precision(18).Scale(2);
			Map(x => x.incomplete).Column("incomplete").Not.Nullable();
			Map(x => x.cur_code).Column("cur_code").Not.Nullable().Length(3);
			Map(x => x.amount_local).Column("amount_local").Precision(18).Scale(2);
			Map(x => x.bank_fees).Column("bank_fees").Precision(18).Scale(2);
			Map(x => x.ex_rate).Column("ex_rate").Precision(53);
			Map(x => x.confirmed).Column("confirmed").Not.Nullable();
			Map(x => x.comments).Column("comments");
			Map(x => x.entered_by).Column("entered_by").Not.Nullable().Length(15);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.other_ref).Column("other_ref").Length(17);
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman;

namespace IMS.DAL.Maps.Tufman
{
    
    
    public class PaymentTypesMap : ClassMap<PaymentTypes> {
        
        public PaymentTypesMap() {
            Schema("tufman");
			Table("payment_types");
            Id(x => x.payment_type_id).GeneratedBy.Assigned().Column("payment_type_id");
			Map(x => x.payment_type_desc).Column("payment_type_desc").Length(50);
			Map(x => x.payment_group).Column("payment_group").Length(50);
			Map(x => x.table_key).Column("table_key").Length(50);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

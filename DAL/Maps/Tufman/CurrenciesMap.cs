using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman;

namespace IMS.DAL.Maps.Tufman
{
    
    
    public class CurrenciesMap : ClassMap<Currencies> {
        
        public CurrenciesMap() {
            Schema("tufman");
			Table("currencies");
			Id(x => x.cur_code).GeneratedBy.Assigned().Column("cur_code");
			Map(x => x.cur_desc).Column("cur_desc").Length(50);
			Map(x => x.min_rate).Column("min_rate").Precision(53);
			Map(x => x.max_rate).Column("max_rate").Precision(53);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Ves; 

namespace IMS.DAL.Maps.Ves {
    
    
    public class VesselCategoriesMap : ClassMap<VesselCategories> {
        
        public VesselCategoriesMap() {
            Schema("ves");
			Table("vessel_categories");
			Id(x => x.vessel_category_code).GeneratedBy.Assigned();
			Map(x => x.vessel_category_desc).Column("vessel_category_desc").Length(250);
            Map(x => x.entered_date).Column("entered_date");
            Map(x => x.changed_date).Column("changed_date");
        }
    }
}

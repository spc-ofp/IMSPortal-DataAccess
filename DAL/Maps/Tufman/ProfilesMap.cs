using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using TUFMAN.Domain.Tufman;

namespace IMS.DAL.Maps.Tufman
{
    
    
    public class ProfilesMap : ClassMap<Profiles> {
        
        public ProfilesMap() {
            Schema("tufman");
			Table("profiles");
			Id(x => x.country_code).GeneratedBy.Assigned().Column("country_code");
			References(x => x.countries).Column("country_code");
			//References(x => x.ports).Column("port_id");                   // port not mapped until ports are standardised to standard ref table
			Map(x => x.revision).Column("revision").Length(6);
			Map(x => x.mapinfo_path).Column("mapinfo_path").Length(100);
			Map(x => x.show_logsheet).Column("show_logsheet").Length(1);
			Map(x => x.show_vess_act).Column("show_vess_act").Not.Nullable();
			Map(x => x.show_sampling).Column("show_sampling").Length(1);
			Map(x => x.show_unloading).Column("show_unloading").Not.Nullable();
			Map(x => x.show_pack_list).Column("show_pack_list").Not.Nullable();
			Map(x => x.show_licensing).Column("show_licensing").Not.Nullable();
			Map(x => x.show_observer).Column("show_observer").Not.Nullable();
			Map(x => x.show_registrations).Column("show_registrations").Not.Nullable();
			Map(x => x.show_receipting).Column("show_receipting").Not.Nullable();
			Map(x => x.show_telex).Column("show_telex").Not.Nullable();
			Map(x => x.show_artisanal).Column("show_artisanal").Not.Nullable();
			Map(x => x.show_registry).Column("show_registry").Not.Nullable();
			Map(x => x.local_cur_code).Column("local_cur_code").Length(3);
			Map(x => x.agr_format).Column("agr_format").Not.Nullable().Length(7);
			Map(x => x.arp_type_code).Column("arp_type_code").Length(1);
			Map(x => x.show_nat_fleet).Column("show_nat_fleet").Not.Nullable();
			Map(x => x.eez_catch_only).Column("eez_catch_only").Not.Nullable();
			Map(x => x.vidmast).Column("vidmast").Precision(10);
			Map(x => x.link_lic_date).Column("link_lic_date");
			Map(x => x.link_nat_date).Column("link_nat_date");
			Map(x => x.link_ll_date).Column("link_ll_date");
			Map(x => x.link_ps_date).Column("link_ps_date");
			Map(x => x.link_pl_date).Column("link_pl_date");
			Map(x => x.links_oth_date).Column("links_oth_date");
			Map(x => x.est_catch_date).Column("est_catch_date");
			Map(x => x.est_hooks_date).Column("est_hooks_date");
			Map(x => x.raise_catch_date).Column("raise_catch_date");
			Map(x => x.trip_cov_date).Column("trip_cov_date");
			Map(x => x.odbc_driver).Column("odbc_driver").Length(100);
			Map(x => x.odbc_database).Column("odbc_database").Length(100);
			Map(x => x.odbc_server).Column("odbc_server").Length(100);
			Map(x => x.odbc_connect_string).Column("odbc_connect_string").Length(250);
			Map(x => x.license_upload_date).Column("license_upload_date");
			Map(x => x.install_no).Column("install_no").Precision(10);
			Map(x => x.copy_only).Column("copy_only");
			Map(x => x.iw_eez_entry).Column("iw_eez_entry");
			Map(x => x.use_ringnet).Column("use_ringnet").Not.Nullable();
			Map(x => x.use_gillnet).Column("use_gillnet").Not.Nullable();
			Map(x => x.use_alia).Column("use_alia").Not.Nullable();
			Map(x => x.require_ves_cat).Column("require_ves_cat").Not.Nullable();
			Map(x => x.ps_vessel_unloads).Column("ps_vessel_unloads").Not.Nullable();
			Map(x => x.all_vessels_licensed).Column("all_vessels_licensed").Not.Nullable().Length(1);
			Map(x => x.all_vessels_national).Column("all_vessels_national").Not.Nullable().Length(1);
			Map(x => x.recon_date_full).Column("recon_date_full");
			Map(x => x.recon_date_inc).Column("recon_date_inc");
			Map(x => x.smartpdfdata_path).Column("smartpdfdata_path").Length(250);
			Map(x => x.entered_date).Column("entered_date");
			Map(x => x.changed_date).Column("changed_date");
        }
    }
}

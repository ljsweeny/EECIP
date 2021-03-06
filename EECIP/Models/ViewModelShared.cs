﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EECIP.App_Logic.DataAccessLayer;
using System.Web.Mvc;

namespace EECIP.Models
{

    public static class ddlHelpers
    {
        public static IEnumerable<SelectListItem> get_ddl_states()
        {

            return db_Ref.GetT_OE_REF_STATE().Select(x => new SelectListItem
            {
                Value = x.STATE_CD,
                Text = x.STATE_NAME
            });
        }

        public static IEnumerable<SelectListItem> get_ddl_regions()
        {

            return db_Ref.GetT_OE_REF_REGION().Select(x => new SelectListItem
            {
                Value = x.EPA_REGION.ToString(),
                Text = x.EPA_REGION_NAME
            });
        }

        public static IEnumerable<SelectListItem> get_ddl_organizations_all_active()
        {

            return db_Ref.GetT_OE_ORGANIZATION(true).Select(x => new SelectListItem
            {
                Value = x.ORG_IDX.ToString(),
                Text = x.ORG_NAME
            });
        }

        public static IEnumerable<SelectListItem> get_ddl_tags_by_category(string cat_name)
        {

            return db_Ref.GetT_OE_REF_TAGS_ByCategory(cat_name).Select(x => new SelectListItem
            {
                Value = x.TAG_IDX.ToString(),
                Text = x.TAG_NAME
            });
        }

        public static IEnumerable<SelectListItem> get_ddl_tags_by_category_stringy(string cat_name)
        {

            return db_Ref.GetT_OE_REF_TAGS_ByCategory(cat_name).Select(x => new SelectListItem
            {
                Value = x.TAG_NAME,
                Text = x.TAG_NAME
            });

        }


        public static IEnumerable<SelectListItem> get_ddl_tag_cats()
        {

            return db_Ref.GetT_OE_REF_TAG_CATEGORIES().Select(x => new SelectListItem
            {
                Value = x.TAG_CAT_NAME,
                Text = x.TAG_CAT_NAME
            });
        }



    }

    public class vmSharedNotificationHeader
    {
        public int NotifyCount { get; set; }
        public List<T_OE_USER_NOTIFICATION> Notifications { get; set; }
    }
}
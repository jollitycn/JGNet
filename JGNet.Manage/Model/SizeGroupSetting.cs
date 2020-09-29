using JGNet.Common;
using JGNet.Core.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace JGNet.Manage.Model
{
    public class SizeGroupSetting
    {
        public List<String> Items { get; set; }
        public SizeGroup SizeGroup { get; set; }

        public List<String> DisplayItems { get { return SetupDisplayItems(); } }

        private List<string> SetupDisplayItems()
        {
            List<string> displayItems = new List<string>();

            if (Items != null) {
                foreach (var item in Items)
                {
                    displayItems.Add(CommonGlobalUtil.GetSizeDisplayNames(this.SizeGroup, item));
                }
            }

            return displayItems;
        }

        public String SelectedSizeNames
        {
            get
            {
                return SetupSizeName();
            }
            set {


                SetupSizeName(value);
            }
        }

        public String SelectedDisplaySizeNames
        {
            get
            {
                return SetupDisplaySizeName();
            } 
        }

        private void SetupSizeName(String sizeNames)
        {
            if (String.IsNullOrEmpty(sizeNames)) { return; }
            string[] sizeNameArrs = sizeNames.Split(',');
            Items = new List<string>();

            if (sizeNameArrs != null)
            {
                foreach (var item in sizeNameArrs)
                {
                    Items.Add(item);
                }
            }
        }

        private String SetupSizeName()
        {
            return CommonGlobalUtil.GetArrayString(Items?.ToArray(), SystemDefault.SPLIT_CHAR_COMMA);
        }

        private String SetupDisplaySizeName()
        {
          return  CommonGlobalUtil.GetArrayString(DisplayItems?.ToArray(), SystemDefault.SPLIT_CHAR_COMMA);
        }
    }
}

using JGNet.Common;
using JGNet.Common.cache.Wholesale;
using JGNet.Core.InteractEntity;
using JGNet.Manage;
using QCloud.CosApi.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class PaymentCashForm : 
        BaseForm
    {
        private DistributorWithdrawRecord result;
        private DistributorWithdrawRecord Result { get { return result; } } 

        public Action<DistributorWithdrawRecord> ConfirmClick;

        public CosLoginInfo CosLoginInfo { get; private set; }
        public CosCloud CosCloud { get; private set; }
        public PaymentCashForm(DistributorWithdrawRecord item)
        {
            InitializeComponent();
            SetUpCos();
            String savePath = GlobalUtil.EmallDir + Path.GetFileName(item.PaymentCdeUrl);
            //item.LinkAddress.Substring(item.LinkAddress.LastIndexOf());
            //引用前必须释放所有图片文件的使用权
            Image img = null;
            try
            {
                if (!File.Exists(savePath))
                {
                    CosCloud.DownloadFile(CosLoginInfo.BucketName, item.PaymentCdeUrl, savePath);
                }
                img = JGNet.Core.ImageHelper.FromFileStream(savePath);
            }
            catch (Exception ex)
            {
                //下载失败，可能文件被占用，直接使用该文件即可。
                //文件找不到使用默认图片，找不到
            }

            img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 160);

            this.pictureBox1.Image = img;
             
        }
        private void SetUpCos()
        {
            this.CosLoginInfo = GlobalCache.CosLoginInfo;
            //创建cos对象
            this.CosCloud = new CosCloud(CosLoginInfo.AppID, CosLoginInfo.SecretId, CosLoginInfo.SecretKey);
        }
        private void SkinTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BaseButton1_Click(null, null);
            }
        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            //ConfirmClick?.Invoke(result);
            this.DialogResult = DialogResult.OK;
        }   

       /* private String GetNewId()
        {
            String id = string.Empty;
            InteractResult result = null;// = GlobalCache.ServerProxy.GetPfCustomerId();
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    id = result.Msg;
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    break;
            }
            return id;
        }*/

        private void baseButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

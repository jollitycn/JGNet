/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-? cskin Corporation All rights reserved.
 * * 网站：CSkin界面库 http://www.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2016-01-18
 * * 说明：SkinChatRichTextBox.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CCWin.SkinControl
{
    [ToolboxBitmap(typeof(RichTextBox))]
    public class SkinChatRichTextBox : RichTextBox
    {
        public SkinChatRichTextBox() {
            base.SetStyle(
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.ResizeRedraw |
               ControlStyles.DoubleBuffer, true);
        }

        protected override void OnCreateControl() {
            ScrollBarHelper _ScrollBarHelper = new ScrollBarHelper(
               Handle,
               Properties.Resources.vista_ScrollHorzShaft,
               Properties.Resources.vista_ScrollHorzArrow,
               Properties.Resources.vista_ScrollHorzThumb,
               Properties.Resources.vista_ScrollVertShaft,
               Properties.Resources.vista_ScrollVertArrow,
               Properties.Resources.vista_ScrollVertThumb,
               Properties.Resources.vista_ScrollHorzArrow
               );
            base.OnCreateControl();
        }

        private IImagePathGetter imagePathGetter = new DefaultImagePathGetter();
        private RichEditOle richEditOle;

        public void AppendRichText(string textContent, SortedArray<int, uint> imagePosition_imageID, Font font, Color color) {
            int length = this.Text.Length;
            if (imagePosition_imageID != null) {
                int num2;
                string text = textContent;
                List<int> allKeyList = imagePosition_imageID.GetAllKeyList();
                for (num2 = allKeyList.Count - 1; num2 >= 0; num2--) {
                    text = text.Remove(allKeyList[num2], 1);
                }
                base.AppendText(text);
                for (num2 = 0; num2 < allKeyList.Count; num2++) {
                    int num3 = allKeyList[num2];
                    this.InsertImage(imagePosition_imageID[num3], length + num3);
                }
            } else {
                base.AppendText(textContent);
            }
            base.Select(length, textContent.Length);
            base.SelectionColor = color;
            if (font != null) {
                base.SelectionFont = font;
            }
        }

        public void AppendRichText(string textContent, SortedArray<int, uint> imagePosition_imageID, Dictionary<int, Bitmap> foreignObjectAry, Font font, Color color) {
            int length = this.Text.Length;
            if (imagePosition_imageID != null) {
                int index;
                string text = textContent;
                List<int> allKeyList = imagePosition_imageID.GetAllKeyList();
                List<int> list2 = new List<int>();
                list2.AddRange(allKeyList);
                foreach (int num2 in foreignObjectAry.Keys) {
                    list2.Add(num2);
                }
                list2.Sort();
                for (index = list2.Count - 1; index >= 0; index--) {
                    text = text.Remove(list2[index], 1);
                }
                base.AppendText(text);
                for (index = 0; index < list2.Count; index++) {
                    int item = list2[index];
                    if (allKeyList.Contains(item)) {
                        this.InsertImage(imagePosition_imageID[item], length + item);
                    } else {
                        this.InsertImage(foreignObjectAry[item], length + item);
                    }
                }
            } else {
                base.AppendText(textContent);
            }
            base.Select(length, textContent.Length);
            base.SelectionColor = color;
            if (font != null) {
                base.SelectionFont = font;
            }
        }

        public void AppendRtf(string _rtf) {
            base.Select(this.TextLength, 0);
            base.SelectedRtf = _rtf;
            base.Update();
            base.Select(base.Rtf.Length, 0);
        }

        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }

        public SortedArray<int, uint> GetAllImage(out bool containsForeignObject) {
            containsForeignObject = false;
            SortedArray<int, uint> array = new SortedArray<int, uint>();
            List<REOBJECT> allREOBJECT = this.RichEditOle.GetAllREOBJECT();
            for (int i = 0; i < allREOBJECT.Count; i++) {
                if (allREOBJECT[i].dwUser != 0) {
                    array.Add(allREOBJECT[i].posistion, allREOBJECT[i].dwUser);
                } else {
                    containsForeignObject = true;
                }
            }
            return array;
        }

        public void Initialize(IImagePathGetter getter) {
            this.imagePathGetter = getter;
        }

        /// <summary>
        /// ����ͼƬ
        /// </summary>
        /// <param name="image">gifͼƬ·��</param>
        /// <param name="position">λ��</param>
        /// <returns>GifBox����ؼ�</returns>
        public GifBox InsertImage(Image image, int? position = null) {
            if (position == null) {
                position = this.SelectionStart;
            }
            GifBox control = new GifBox {
                BackColor = base.BackColor,
                Image = image
            };
            this.RichEditOle.InsertControl(control, Convert.ToInt32(position), 0);
            return control;
        }

        /// <summary>
        /// ����ؼ�
        /// </summary>
        /// <param name="c"></param>
        /// <param name="position"></param>
        public void InsertControl(Control c, int? position = null) {
            if (position == null) {
                position = this.SelectionStart;
            }
            this.RichEditOle.InsertControl(c, Convert.ToInt32(position), 0);
        }

        /// <summary>
        /// ���ݱ�Ų���ͼƬ
        /// </summary>
        /// <param name="imageID">���</param>
        /// <param name="position">λ��</param>
        /// <returns>GifBox����ؼ�</returns>
        public GifBox InsertImage(uint imageID, int? position = null) {
            if (position == null) {
                position = this.SelectionStart;
            }
            if (imageID <= 0) {
                throw new Exception("imageID must greater than 0.");
            }
            GifBox control = new GifBox {
                BackColor = base.BackColor,
                Image = Image.FromFile(this.imagePathGetter.GetPath(imageID))
            };
            this.RichEditOle.InsertControl(control, Convert.ToInt32(position), imageID);
            return control;
        }

        private RichEditOle RichEditOle {
            get {
                if ((this.richEditOle == null) && base.IsHandleCreated) {
                    this.richEditOle = new RichEditOle(this);
                }
                return this.richEditOle;
            }
        }
    }
}
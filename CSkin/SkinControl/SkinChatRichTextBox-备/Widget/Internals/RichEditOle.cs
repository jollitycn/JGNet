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
 * * 说明：RichEditOle.cs
 * *
********************************************************************/

using CCWin.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CCWin.SkinControl
{
    internal class RichEditOle
    {
        private SkinChatRichTextBox agileRichTextBox;
        private IRichEditOle richEditOle;

        public RichEditOle(SkinChatRichTextBox _richEdit)
        {
            this.agileRichTextBox = _richEdit;
        }

        public List<REOBJECT> GetAllREOBJECT()
        {
            List<REOBJECT> list = new List<REOBJECT>();
            int objectCount = this.IRichEditOle.GetObjectCount();
            for (int i = 0; i < objectCount; i++)
            {
                REOBJECT lpreobject = new REOBJECT();
                this.IRichEditOle.GetObject(i, lpreobject, GETOBJECTOPTIONS.REO_GETOBJ_ALL_INTERFACES);
                list.Add(lpreobject);
            }
            return list;
        }

        private Size GetSizeFromMillimeter(REOBJECT lpreobject)
        {
            using (Graphics graphics = Graphics.FromHwnd(this.agileRichTextBox.Handle))
            {
                Point[] pts = new Point[1];
                graphics.PageUnit = GraphicsUnit.Millimeter;
                pts[0] = new Point(lpreobject.sizel.Width / 100, lpreobject.sizel.Height / 100);
                graphics.TransformPoints(CoordinateSpace.Device, CoordinateSpace.Page, pts);
                return new Size(pts[0]);
            }
        }

        public void InsertControl(Control control)
        {
            this.InsertControl(control, this.agileRichTextBox.TextLength, 1);
        }

        public void InsertControl(Control control, int position, uint dwUser)
        {
            if (control != null)
            {
                ILockBytes bytes;
                IStorage storage;
                IOleClientSite site;
                Guid guid = Marshal.GenerateGuidForType(control.GetType());
                NativeMethods.CreateILockBytesOnHGlobal(IntPtr.Zero, true, out bytes);
                NativeMethods.StgCreateDocfileOnILockBytes(bytes, 0x1012, 0, out storage);
                this.IRichEditOle.GetClientSite(out site);
                REOBJECT lpreobject = new REOBJECT {
                    posistion = position,
                    clsid = guid,
                    pstg = storage,
                    poleobj = Marshal.GetIUnknownForObject(control),
                    polesite = site,
                    dvAspect = 1,
                    dwFlags = 0x00000002,
                    dwUser = dwUser
                };
                this.IRichEditOle.InsertObject(lpreobject);
                Marshal.ReleaseComObject(bytes);
                Marshal.ReleaseComObject(site);
                Marshal.ReleaseComObject(storage);
            }
        }

        public bool InsertImageFromFile(string strFilename)
        {
            return this.InsertImageFromFile(strFilename, this.agileRichTextBox.TextLength);
        }

        public bool InsertImageFromFile(string strFilename, int position)
        {
            ILockBytes bytes;
            IStorage storage;
            IOleClientSite site;
            object obj2;
            NativeMethods.CreateILockBytesOnHGlobal(IntPtr.Zero, true, out bytes);
            NativeMethods.StgCreateDocfileOnILockBytes(bytes, 0x1012, 0, out storage);
            this.IRichEditOle.GetClientSite(out site);
            FORMATETC pFormatEtc = new FORMATETC {
                cfFormat = (CLIPFORMAT) 0,
                ptd = IntPtr.Zero,
                dwAspect = DVASPECT.DVASPECT_CONTENT,
                lindex = -1,
                tymed = TYMED.TYMED_NULL
            };
            Guid riid = new Guid("{00000112-0000-0000-C000-000000000046}");
            Guid rclsid = new Guid("{00000000-0000-0000-0000-000000000000}");
            NativeMethods.OleCreateFromFile(ref rclsid, strFilename, ref riid, 1, ref pFormatEtc, site, storage, out obj2);
            if (obj2 == null)
            {
                Marshal.ReleaseComObject(bytes);
                Marshal.ReleaseComObject(site);
                Marshal.ReleaseComObject(storage);
                return false;
            }
            IOleObject pUnk = (IOleObject) obj2;
            Guid pClsid = new Guid();
            pUnk.GetUserClassID(ref pClsid);
            NativeMethods.OleSetContainedObject(pUnk, true);
            REOBJECT lpreobject = new REOBJECT {
                posistion = position,
                clsid = pClsid,
                pstg = storage,
                poleobj = Marshal.GetIUnknownForObject(pUnk),
                polesite = site,
                dvAspect = 1,
                dwFlags = 2,
                dwUser = 0
            };
            this.IRichEditOle.InsertObject(lpreobject);
            Marshal.ReleaseComObject(bytes);
            Marshal.ReleaseComObject(site);
            Marshal.ReleaseComObject(storage);
            Marshal.ReleaseComObject(pUnk);
            return true;
        }

        public REOBJECT InsertOleObject(IOleObject oleObject, int index)
        {
            return this.InsertOleObject(oleObject, index, this.agileRichTextBox.TextLength);
        }

        public REOBJECT InsertOleObject(IOleObject oleObject, int index, int pos)
        {
            ILockBytes bytes;
            IStorage storage;
            IOleClientSite site;
            if (oleObject == null)
            {
                return null;
            }
            NativeMethods.CreateILockBytesOnHGlobal(IntPtr.Zero, true, out bytes);
            NativeMethods.StgCreateDocfileOnILockBytes(bytes, 0x1012, 0, out storage);
            this.IRichEditOle.GetClientSite(out site);
            Guid pClsid = new Guid();
            oleObject.GetUserClassID(ref pClsid);
            NativeMethods.OleSetContainedObject(oleObject, true);
            REOBJECT lpreobject = new REOBJECT {
                posistion = pos,
                clsid = pClsid,
                pstg = storage,
                poleobj = Marshal.GetIUnknownForObject(oleObject),
                polesite = site,
                dvAspect = 1,
                dwFlags = 2,
                dwUser = (uint) index
            };
            this.IRichEditOle.InsertObject(lpreobject);
            Marshal.ReleaseComObject(bytes);
            Marshal.ReleaseComObject(site);
            Marshal.ReleaseComObject(storage);
            return lpreobject;
        }

        public void UpdateObjects()
        {
            int objectCount = this.IRichEditOle.GetObjectCount();
            for (int i = 0; i < objectCount; i++)
            {
                REOBJECT lpreobject = new REOBJECT();
                this.IRichEditOle.GetObject(i, lpreobject, GETOBJECTOPTIONS.REO_GETOBJ_ALL_INTERFACES);
                Point positionFromCharIndex = this.agileRichTextBox.GetPositionFromCharIndex(lpreobject.posistion);
                Rectangle rc = new Rectangle(positionFromCharIndex.X, positionFromCharIndex.Y, 50, 50);
                this.agileRichTextBox.Invalidate(rc, false);
            }
        }

        public void UpdateObjects(REOBJECT reObj)
        {
            Point positionFromCharIndex = this.agileRichTextBox.GetPositionFromCharIndex(reObj.posistion);
            Size sizeFromMillimeter = this.GetSizeFromMillimeter(reObj);
            Rectangle rc = new Rectangle(positionFromCharIndex, sizeFromMillimeter);
            this.agileRichTextBox.Invalidate(rc, false);
        }

        public void UpdateObjects(int pos)
        {
            REOBJECT lpreobject = new REOBJECT();
            this.IRichEditOle.GetObject(pos, lpreobject, GETOBJECTOPTIONS.REO_GETOBJ_ALL_INTERFACES);
            this.UpdateObjects(lpreobject);
        }

        public IRichEditOle IRichEditOle
        {
            get
            {
                if (this.richEditOle == null)
                {
                    this.richEditOle = NativeMethods.SendMessage(this.agileRichTextBox.Handle, 0x43c, 0);
                }
                return this.richEditOle;
            }
        }
    }
}


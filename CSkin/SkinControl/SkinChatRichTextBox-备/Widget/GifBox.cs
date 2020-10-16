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
 * * 说明：GifBox.cs
 * *
********************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace CCWin.SkinControl
{
    public class GifBox : Control
    {
        private Color _borderColor = Color.Transparent;
        private bool _canAnimate = false;
        private EventHandler _eventAnimator;
        private System.Drawing.Image _image;
        private Rectangle _imageRectangle;

        public GifBox()
        {
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.CacheText | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.Opaque, false);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                this._eventAnimator = null;
                this._canAnimate = false;
                if (this._image != null)
                {
                    this._image = null;
                }
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            this.StopAnimate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this._image != null)
            {
                this.UpdateImage();
                e.Graphics.DrawImage(this._image, this.ImageRectangle, 0, 0, this._image.Width, this._image.Height, GraphicsUnit.Pixel);
            }
            ControlPaint.DrawBorder(e.Graphics, base.ClientRectangle, this._borderColor, ButtonBorderStyle.Solid);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            this._imageRectangle = Rectangle.Empty;
            base.OnSizeChanged(e);
        }

        private void StartAnimate()
        {
            if (this.CanAnimate)
            {
                ImageAnimator.Animate(this._image, this.EventAnimator);
            }
        }

        private void StopAnimate()
        {
            if (this.CanAnimate)
            {
                ImageAnimator.StopAnimate(this._image, this.EventAnimator);
            }
        }

        private void UpdateImage()
        {
            if (this.CanAnimate)
            {
                ImageAnimator.UpdateFrames(this._image);
            }
        }

        public Color BorderColor
        {
            get
            {
                return this._borderColor;
            }
            set
            {
                this._borderColor = value;
                base.Invalidate();
            }
        }

        private bool CanAnimate
        {
            get
            {
                return this._canAnimate;
            }
        }

        private EventHandler EventAnimator
        {
            get
            {
                if (this._eventAnimator == null)
                {
                    this._eventAnimator = delegate(object sender, EventArgs e)
                    {
                        base.Invalidate(this.ImageRectangle);
                    };
                }
                return this._eventAnimator;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return this._image;
            }
            set
            {
                this.StopAnimate();
                this._image = value;
                this._imageRectangle = Rectangle.Empty;
                if (value != null)
                {
                    this._canAnimate = ImageAnimator.CanAnimate(this._image);
                }
                else
                {
                    this._canAnimate = false;
                }
                base.Size = this.Image.Size;
                base.Invalidate(this.ImageRectangle);
                if (!base.DesignMode)
                {
                    this.StartAnimate();
                }
            }
        }

        private Rectangle ImageRectangle
        {
            get
            {
                if ((this._imageRectangle == Rectangle.Empty) && (this._image != null))
                {
                    this._imageRectangle.X = (base.Width - this._image.Width) / 2;
                    this._imageRectangle.Y = (base.Height - this._image.Height) / 2;
                    this._imageRectangle.Width = this._image.Width;
                    this._imageRectangle.Height = this._image.Height;
                }
                return this._imageRectangle;
            }
        }
    }
}


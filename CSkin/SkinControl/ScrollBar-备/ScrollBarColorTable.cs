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
 * * 说明：ScrollBarColorTable.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CCWin.SkinControl
{
    public class ScrollBarColorTable
    {
        private Color _base = Color.FromArgb(171, 230, 247);
        private Color _backNormal = Color.FromArgb(235, 249, 253);
        private Color _backHover = Color.FromArgb(121, 216, 243);
        private Color _backPressed = Color.FromArgb(70, 202, 239);
        private Color _border = Color.FromArgb(89, 210, 249);
        private Color _innerBorder = Color.FromArgb(200, 250, 250, 250);
        private Color _fore = Color.FromArgb(48, 135, 192);

        public ScrollBarColorTable() { }

        public Color Base {
            get {
                return _base;
            }
            set {
                _base = value;
            }
        }

        public Color BackNormal {
            get {
                return _backNormal;
            }
            set {
                _backNormal = value;
            }
        }

        public Color BackHover {
            get {
                return _backHover;
            }
            set {
                _backHover = value;
            }
        }

        public Color BackPressed {
            get {
                return _backPressed;
            }
            set {
                _backPressed = value;
            }
        }

        public Color Border {
            get {
                return _border;
            }
            set {
                _border = value;
            }
        }

        public Color InnerBorder {
            get {
                return _innerBorder;
            }
            set {
                _innerBorder = value;
            }
        }

        public Color Fore {
            get {
                return _fore;
            }
            set {
                _fore = value;
            }
        }
    }
}

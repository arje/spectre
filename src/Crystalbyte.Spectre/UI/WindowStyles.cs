﻿#region Licensing notice

// Copyright (C) 2012, Alexander Wieser-Kuciel <alexander.wieser@crystalbyte.de>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

#region Using directives

using System;

#endregion

namespace Crystalbyte.Spectre.UI {
    [Flags]
    internal enum WindowStyles : uint {
        /// <summary>
        ///   The window has a thin-line border.
        /// </summary>
        Border = 0x00800000,

        /// <summary>
        ///   The window has a title bar (includes the WS_BORDER style).
        /// </summary>
        Caption = 0x00C00000,

        /// <summary>
        ///   The window is a child window. A window with this style cannot have a menu bar. This style cannot be used with the WS_POPUP style.
        /// </summary>
        ChildWindow = 0x40000000,

        /// <summary>
        ///   Excludes the area occupied by child windows when drawing occurs within the parent window. This style is used when creating the parent window.
        /// </summary>
        ClipChildren = 0x02000000,

        /// <summary>
        ///   Clips child windows relative to each other; that is, when a particular child window receives a WM_PAINT message, 
        ///   the WS_CLIPSIBLINGS style clips all other overlapping child windows out of the region of the child window to be updated. 
        ///   If WS_CLIPSIBLINGS is not specified and child windows overlap, it is possible, when drawing within the client area of a child window, 
        ///   to draw within the client area of a neighboring child window.
        /// </summary>
        ClipSiblings = 0x04000000,

        /// <summary>
        ///   The window is initially disabled. A disabled window cannot receive input from the user. 
        ///   To change this after a window has been created, use the EnableWindow function.
        /// </summary>
        Disabled = 0x08000000,

        /// <summary>
        ///   The window has a border of a style typically used with dialog boxes. A window with this style cannot have a title bar.
        /// </summary>
        DialogFrame = 0x00400000,

        /// <summary>
        ///   The window is the first control of a group of controls. The group consists of this first control and all controls defined after it, up to the next control with the WS_GROUP style. 
        ///   The first control in each group usually has the WS_TABSTOP style so that the user can move from group to group. 
        ///   The user can subsequently change the keyboard focus from one control in the group to the next control in the group by using the direction keys.
        ///   You can turn this style on and off to change dialog box navigation. To change this style after a window has been created, use the SetWindowLong function.
        /// </summary>
        Group = 0x00020000,

        /// <summary>
        ///   The window has a horizontal scroll bar.
        /// </summary>
        HorizontalScroll = 0x00100000,

        /// <summary>
        ///   The window is initially minimized. Same as the WS_MINIMIZE style.
        /// </summary>
        Iconic = 0x20000000,

        /// <summary>
        ///   The window is initially maximized.
        /// </summary>
        Maximized = 0x01000000,

        /// <summary>
        ///   The window has a maximize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must also be specified.
        /// </summary>
        MaximizeBox = 0x00010000,

        /// <summary>
        ///   The window is initially minimized. Same as the WS_ICONIC style.
        /// </summary>
        Minimize = 0x20000000,

        /// <summary>
        ///   The window has a minimize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must also be specified.
        /// </summary>
        MinimizeBox = 0x00020000,

        /// <summary>
        ///   The window is an overlapped window. An overlapped window has a title bar and a border. Same as the WS_TILED style.
        /// </summary>
        Overlapped = 0x00000000,

        /// <summary>
        ///   The window is an overlapped window. Same as the WS_TILEDWINDOW style.
        /// </summary>
        OverlappedWindow = Overlapped
                           | Caption
                           | SystemMenu
                           | ThickFrame
                           | MinimizeBox
                           | MaximizeBox,

        /// <summary>
        ///   The windows is a pop-up window. This style cannot be used with the WS_CHILD style.
        /// </summary>
        Popup = 0x80000000,

        /// <summary>
        ///   The window is a pop-up window. The WS_CAPTION and WS_POPUPWINDOW styles must be combined to make the window menu visible.
        /// </summary>
        PopupWindow = Popup | Border | SystemMenu,

        /// <summary>
        ///   The window has a sizing border. Same as the WS_THICKFRAME style.
        /// </summary>
        SizeBox = 0x00040000,

        /// <summary>
        ///   The window has a window menu on its title bar. The WS_CAPTION style must also be specified.
        /// </summary>
        SystemMenu = 0x00080000,

        /// <summary>
        ///   The window is a control that can receive the keyboard focus when the user presses the TAB key. 
        ///   Pressing the TAB key changes the keyboard focus to the next control with the WS_TABSTOP style.
        ///   You can turn this style on and off to change dialog box navigation. 
        ///   To change this style after a window has been created, use the SetWindowLong function. 
        ///   For user-created windows and modeless dialogs to work with tab stops, alter the message loop to call the IsDialogMessage function.
        /// </summary>
        TabStop = 0x00010000,

        /// <summary>
        ///   The window has a sizing border. Same as the WS_SIZEBOX style.
        /// </summary>
        ThickFrame = 0x00040000,

        /// <summary>
        ///   The window is an overlapped window. An overlapped window has a title bar and a border. Same as the WS_OVERLAPPED style.
        /// </summary>
        Tiled = 0x00000000,

        /// <summary>
        ///   The window is an overlapped window. Same as the WS_OVERLAPPEDWINDOW style.
        /// </summary>
        TiledWindow = Overlapped
                      | Caption
                      | SystemMenu
                      | ThickFrame
                      | MinimizeBox
                      | MaximizeBox,

        /// <summary>
        ///   The window is initially visible.
        ///   This style can be turned on and off by using the ShowWindow or SetWindowPos function.
        /// </summary>
        Visible = 0x10000000,

        /// <summary>
        ///   The window has a vertical scroll bar.
        /// </summary>
        VerticalScroll = 0x00200000
    }
}

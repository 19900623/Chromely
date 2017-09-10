﻿#region Port Info
/**
 * This is a port from CefGlue.WindowsForms sample of . Mostly provided as-is. 
 * For more info: https://bitbucket.org/xilium/xilium.cefglue/wiki/Home
 **/
#endregion

namespace Chromely.Browser.EventParams
{
    using System;
    using Xilium.CefGlue;

    public sealed class StatusMessageEventArgs : EventArgs
    {
        private readonly string m_value;

        public StatusMessageEventArgs(string value)
        {
            m_value = value;
        }

        public string Value { get { return m_value; } }
    }
}

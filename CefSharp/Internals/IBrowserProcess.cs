﻿// Copyright © 2010-2014 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using System.Collections.Generic;
using System.ServiceModel;

namespace CefSharp.Internals
{
    [ServiceContract(CallbackContract = typeof (IRenderProcess), SessionMode = SessionMode.Required)]
    [ServiceKnownType(typeof (object[]))]
    [ServiceKnownType(typeof (Dictionary<string, object>))]
    [ServiceKnownType(typeof (JavascriptObject))]
    [ServiceKnownType(typeof (JavascriptMethod))]
    [ServiceKnownType(typeof (JavascriptProperty))]
    [ServiceKnownType(typeof (JavascriptCallbackDto))]
    public interface IBrowserProcess
    {
        [OperationContract]
        BrowserProcessResponse CallMethod(long objectId, string name, object[] parameters);

        [OperationContract]
        BrowserProcessResponse GetProperty(long objectId, string name);

        [OperationContract]
        BrowserProcessResponse SetProperty(long objectId, string name, object value);

        [OperationContract]
        JavascriptRootObject GetRegisteredJavascriptObjects();

        [OperationContract]
        void Connect();
    }
}

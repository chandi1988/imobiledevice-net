//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="FileRelayNativeMethods.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.FileRelay
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class FileRelayNativeMethods
    {
        
        public static FileRelayError file_relay_request_sources(FileRelayClientHandle client, out string sources, out iDeviceConnectionHandle connection)
        {
            System.Runtime.InteropServices.ICustomMarshaler sourcesMarshaler = NativeStringMarshaler.GetInstance(null);
            System.IntPtr sourcesNative = System.IntPtr.Zero;
            FileRelayError returnValue = FileRelayNativeMethods.file_relay_request_sources(client, out sourcesNative, out connection);
            sources = ((string)sourcesMarshaler.MarshalNativeToManaged(sourcesNative));
            sourcesMarshaler.CleanUpNativeData(sourcesNative);
            return returnValue;
        }
        
        public static FileRelayError file_relay_request_sources_timeout(FileRelayClientHandle client, out string sources, out iDeviceConnectionHandle connection, uint timeout)
        {
            System.Runtime.InteropServices.ICustomMarshaler sourcesMarshaler = NativeStringMarshaler.GetInstance(null);
            System.IntPtr sourcesNative = System.IntPtr.Zero;
            FileRelayError returnValue = FileRelayNativeMethods.file_relay_request_sources_timeout(client, out sourcesNative, out connection, timeout);
            sources = ((string)sourcesMarshaler.MarshalNativeToManaged(sourcesNative));
            sourcesMarshaler.CleanUpNativeData(sourcesNative);
            return returnValue;
        }
    }
}

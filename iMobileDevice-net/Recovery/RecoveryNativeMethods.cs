//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="RecoveryNativeMethods.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Recovery
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class RecoveryNativeMethods
    {
        
        public const string LibraryName = "irecovery";
        
        static RecoveryNativeMethods()
        {
            LibraryResolver.EnsureRegistered();
        }
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_set_debug_level", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void irecv_set_debug_level(int level);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_strerror", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern System.IntPtr irecv_strerror(RecoveryError error);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_init", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void irecv_init();
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_exit", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void irecv_exit();
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_open_with_ecid", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_open_with_ecid(out RecoveryClientHandle client, ulong ecid);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_open_with_ecid_and_attempts", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_open_with_ecid_and_attempts(out RecoveryClientHandle pclient, ulong ecid, int attempts);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_reset", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_reset(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_close", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_close(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_reconnect", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryClientHandle irecv_reconnect(RecoveryClientHandle client, int initialPause);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_receive", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_receive(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_execute_script", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_execute_script(RecoveryClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string script);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_reset_counters", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_reset_counters(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_finish_transfer", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_finish_transfer(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_trigger_limera1n_exploit", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_trigger_limera1n_exploit(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_usb_set_configuration", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_usb_set_configuration(RecoveryClientHandle client, int configuration);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_usb_set_interface", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_usb_set_interface(RecoveryClientHandle client, int usbInterface, int usbAltInterface);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_usb_control_transfer", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int irecv_usb_control_transfer(RecoveryClientHandle client, char bmRequestType, char bRequest, ushort wValue, ushort wIndex, ref char data, ushort wLength, uint timeout);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_usb_bulk_transfer", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern int irecv_usb_bulk_transfer(RecoveryClientHandle client, char endpoint, ref char data, int length, ref int transferred, uint timeout);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_device_event_subscribe", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_device_event_subscribe(out RecoveryDeviceEventContextHandle context, RecoveryDeviceEventCallBack callback, System.IntPtr userData);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_device_event_unsubscribe", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_device_event_unsubscribe(RecoveryDeviceEventContextHandle context);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_event_subscribe", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_event_subscribe(RecoveryClientHandle client, RecoveryEventType type, RecoveryEventCallBack callback, System.IntPtr userData);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_event_unsubscribe", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_event_unsubscribe(RecoveryClientHandle client, RecoveryEventType type);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_send_file", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_send_file(RecoveryClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string filename, int dfuNotifyFinished);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_send_command", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_send_command(RecoveryClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string command);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_send_buffer", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_send_buffer(RecoveryClientHandle client, ref char buffer, int length, int dfuNotifyFinished);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_recv_buffer", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_recv_buffer(RecoveryClientHandle client, System.IntPtr buffer, int length);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_saveenv", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_saveenv(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_getenv", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_getenv(RecoveryClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string variable, out System.IntPtr value);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_setenv", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_setenv(RecoveryClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string variable, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string value);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_reboot", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_reboot(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_getret", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_getret(RecoveryClientHandle client, ref uint value);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_get_mode", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_get_mode(RecoveryClientHandle client, ref int mode);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_get_device_info", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern System.IntPtr irecv_get_device_info(RecoveryClientHandle client);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_devices_get_all", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryDeviceHandle irecv_devices_get_all();
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_devices_get_device_by_client", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_devices_get_device_by_client(RecoveryClientHandle client, out RecoveryDeviceHandle device);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_devices_get_device_by_product_type", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_devices_get_device_by_product_type([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string productType, out RecoveryDeviceHandle device);
        
        [System.Runtime.InteropServices.DllImportAttribute(RecoveryNativeMethods.LibraryName, EntryPoint="irecv_devices_get_device_by_hardware_model", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern RecoveryError irecv_devices_get_device_by_hardware_model([System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string hardwareModel, out RecoveryDeviceHandle device);
    }
}

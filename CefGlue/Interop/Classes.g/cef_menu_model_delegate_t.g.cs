//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_menu_model_delegate_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _execute_command;
        internal IntPtr _mouse_outside_menu;
        internal IntPtr _unhandled_open_submenu;
        internal IntPtr _unhandled_close_submenu;
        internal IntPtr _menu_will_show;
        internal IntPtr _menu_closed;
        internal IntPtr _format_label;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_menu_model_delegate_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_menu_model_delegate_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_menu_model_delegate_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void execute_command_delegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int command_id, CefEventFlags event_flags);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void mouse_outside_menu_delegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, cef_point_t* screen_point);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void unhandled_open_submenu_delegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int is_rtl);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void unhandled_close_submenu_delegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, int is_rtl);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void menu_will_show_delegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void menu_closed_delegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int format_label_delegate(cef_menu_model_delegate_t* self, cef_menu_model_t* menu_model, cef_string_t* label);
        
        private static int _sizeof;
        
        static cef_menu_model_delegate_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_menu_model_delegate_t));
        }
        
        internal static cef_menu_model_delegate_t* Alloc()
        {
            var ptr = (cef_menu_model_delegate_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_menu_model_delegate_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_menu_model_delegate_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}

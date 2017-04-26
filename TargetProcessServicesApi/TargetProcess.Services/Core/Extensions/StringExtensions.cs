using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace TargetProcess.Services.Core.Extensions
{
    public static class StringExtensions
    {
        public static string ToBase64Encoded(this string value) => Convert.ToBase64String(Encoding.UTF8.GetBytes(value));

        [DebuggerHidden]
        public static SecureString ConvertToSecureString(this string password)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));

            unsafe
            {
                fixed (char* passwordChars = password)
                {
                    var securePassword = new SecureString(passwordChars, password.Length);
                    securePassword.MakeReadOnly();
                    return securePassword;
                }
            }
        }

        [DebuggerHidden]
        public static string ConvertToUnsecureString(this SecureString securePassword)
        {
            if (securePassword == null) throw new ArgumentNullException(nameof(securePassword));

            var unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
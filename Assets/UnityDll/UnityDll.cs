using System.Runtime.InteropServices;

public class UnityDll
{
    const string DLLNAME = "UnityDll";
    [DllImport(DLLNAME, CallingConvention = CallingConvention.Cdecl)]    
    public static extern void hello();
}

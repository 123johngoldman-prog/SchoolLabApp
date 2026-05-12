using System;
using System.IO;
using System.Linq;

namespace SchoolLabApp.Helpers
{
    public static class TechnicianPasswordManager
    {
        private static readonly string folderPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TechnicianPassword");

        private static readonly string passwordFile =
            Path.Combine(folderPath, "password.txt");

        private static readonly string logFile =
            Path.Combine(folderPath, "password_log.txt");

        public static void Initialize()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(passwordFile))
            {
                string password = GenerateRandomPassword();

                File.WriteAllText(passwordFile, password);

                LogPassword(password);
            }
        }

        public static string GetCurrentPassword()
        {
            Initialize();

            return File.ReadAllText(passwordFile);
        }

        public static bool ValidatePassword(string password)
        {
            string currentPassword = GetCurrentPassword();

            return password == currentPassword;
        }

        public static string GenerateNewPassword()
        {
            string newPassword = GenerateRandomPassword();

            File.WriteAllText(passwordFile, newPassword);

            LogPassword(newPassword);

            return newPassword;
        }

        private static string GenerateRandomPassword()
        {
            const string chars =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random random = new Random();

            return new string(
                Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
        }

        private static void LogPassword(string password)
        {
            string log =
                $"[{DateTime.Now}] New password: {password}{Environment.NewLine}";

            File.AppendAllText(logFile, log);
        }
    }
}
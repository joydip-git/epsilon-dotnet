using System;

namespace UtilityLibrary
{
    public static class Utility
    {
        private static string conStr;
        public static String GetConnection() => "db connection";
        public static string ConnectionString => conStr;
    }
}

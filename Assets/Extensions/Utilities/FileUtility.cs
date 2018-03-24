using UnityEngine;
using System;
using System.IO;
using System.Collections;

namespace Extensions
{
    public static partial class FileUtility
    {
        private static string PersistentDataPath = Application.persistentDataPath;

        public static void Save(string path, Action<BinaryWriter> onWriter)
        {
            using (FileStream fs = new FileStream(GetFullPath(path), FileMode.Create, FileAccess.Write))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                SystemUtility.SafeCall(onWriter, bw);
            }
        }

        public static void Load(string path, Action<BinaryReader> onReader)
        {
            using (FileStream fs = new FileStream(GetFullPath(path), FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(fs))
            {
                SystemUtility.SafeCall(onReader, br);
            }
        }

        public static bool Exists(string path)
        {
            return File.Exists(GetFullPath(path));
        }

        private static string GetFullPath(string path)
        {
            return Path.Combine(PersistentDataPath, path);
        }
    }
}

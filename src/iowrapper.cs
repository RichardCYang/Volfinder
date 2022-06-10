
using System;
using System.IO;
using System.Collections.Generic;

namespace Volfinder {
    public partial class IOWrapper {
        public static List<string> SearchRecursivePath( string rootpath ){
            List<string> paths = new List<string>();
            DirectoryInfo dirInfo = new DirectoryInfo( rootpath );
            if( dirInfo.Exists ){
                foreach ( DirectoryInfo dir in dirInfo.GetDirectories() )
                {
                    paths.AddRange( SearchRecursivePath( dir.FullName ) );
                }
                foreach ( FileInfo file in dirInfo.GetFiles() )
                {
                    paths.Add( file.FullName );
                }
            }
            return paths;
        }
    }
}
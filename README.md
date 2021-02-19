# Get Directory Size in MB using ASP.Net C#
# System.IO Namespace is requere 

It is helpful to calculate the size of directory or folder, so you can allow or restrict the user to upload new data 

#Working Example Code :

#public string ServerRootDirPath = System.Web.HttpContext.Current.Server.MapPath("~/");
 
#public float GetDirSizeInMB(string DirPath)
# {
#  DirectoryInfo di = new DirectoryInfo(ServerRootDirPath + DirPath);
# //Given size in bytes;
# float FolderSize = (di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length));
# //Covert Size into MB and Return
# return FolderSize = FolderSize / 1048576;
# }

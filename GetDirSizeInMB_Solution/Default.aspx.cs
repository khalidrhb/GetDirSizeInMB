using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Size: " + GetDirSizeInMB("Folder1") + " MB");
        Response.Write("<br/> Size: " + GetDirSizeInMB("Products/ProductList1") + " MB");
        Response.Write("<br/> Size: " + GetDirSizeInMB("Products") + " MB");
    }


    public string ServerRootDirPath = System.Web.HttpContext.Current.Server.MapPath("~/");
    public float GetDirSizeInMB(string DirPath)
    {
        DirectoryInfo di = new DirectoryInfo(ServerRootDirPath + DirPath);
        //Given size in bytes;
        float FolderSize = (di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length));
        //Covert Size into MB and Return
        return FolderSize = FolderSize / 1048576;  
    }
}
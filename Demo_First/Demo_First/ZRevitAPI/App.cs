#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

#endregion


namespace Demo_First
{
    public class App : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
        public Result OnStartup(UIControlledApplication application)
        {
            CurrentModule.InitialTemplate(application);
            CreateRibbon(application);
            return Result.Succeeded;
        }

        private void CreateRibbon(UIControlledApplication application)
        {
            string tabName = "NewTab";
            string panelName = "New panel";
            var ribbonMng = CurrentModule.RibbonManage;

            ribbonMng.AddRibbonTab(tabName);
            var newPanel = ribbonMng.RibbonPanel(tabName, panelName);
            var project1 = ribbonMng.GetPushButtonFromTemplate("Project1", "NewButton", "Project1_16x16.ico", "Project1_32x32.ico");
            newPanel.AddItem(project1);
        }
    }
}

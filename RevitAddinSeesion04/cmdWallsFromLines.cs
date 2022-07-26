#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace RevitAddinSeesion04
{
    [Transaction(TransactionMode.Manual)]
    public class cmdWallsFromLInes : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            List<string> wallTypes = GetAlllWallTypesNames(doc);
            List<string> lineStyles = GetAllLineStyleNames(doc);




            return Result.Succeeded;
        }

        private List<string> GetAllLineStyleNames(Document doc)
        {
            List<string> result = new List<string>() ;

            FilteredElementCollector collector =  new FilteredElementCollector(doc, doc.ActiveView.Id);
            collector.OfClass(typeof(CurveElement));

            foreach (CurveElement element in collector) 
            {
                GraphicsStyle curGS = element.LineStyle as GraphicsStyle;
                if (result.Contains(curGS.Name)  == false)
                {
                    result.Add(curGS.Name); 
                }
            }
            return result;
        }

        private List<string> GetAlllWallTypesNames(Document doc)
        {
            List<string> result = new List<string>();

            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfClass(typeof(WallType));
            foreach(WallType elemnt in collector)
            {
                result.Add(elemnt.Name);
            }
            return result;
        }
    }
}

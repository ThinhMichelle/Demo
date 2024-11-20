using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_First
{
    public static class DebugHelperUtils
    {
        public static void DrawPoint(View view, XYZ point, Color color)
        {
            double length = 1.0;
            var doc = view.Document;
            Line lineZ = Line.CreateBound(point + XYZ.BasisZ * length / 2.0, point - XYZ.BasisZ * length / 2.0);
            Line lineX = Line.CreateBound(point + XYZ.BasisX * length / 2.0, point - XYZ.BasisX * length / 2.0);
            Line lineY = Line.CreateBound(point + XYZ.BasisY * length / 2.0, point - XYZ.BasisY * length / 2.0);
            var m1 = doc.Create.NewModelCurve(lineZ, lineZ.GetSketchPlane(doc));
            var m2 = doc.Create.NewModelCurve(lineX, lineX.GetSketchPlane(doc));
            var m3 = doc.Create.NewModelCurve(lineY, lineY.GetSketchPlane(doc));
            SetModelCurvesColor(m1, view, color);
            SetModelCurvesColor(m2, view, color);
            SetModelCurvesColor(m3, view, color);
        }
        public static void SetModelCurvesColor(ModelCurve curve, Autodesk.Revit.DB.View view, Color color)
        {
            var overrides = view.GetElementOverrides(curve.Id);
            overrides.SetProjectionLineColor(color);
            view.SetElementOverrides(curve.Id, overrides);
        }
    }
}

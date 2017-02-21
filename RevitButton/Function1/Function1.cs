using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace Function1
{
    [Transaction(TransactionMode.Manual)]

    public class FunctionOne : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            //Application app = uiapp.Application;
            Document doc = uidoc.Document;
            Autodesk.Revit.DB.View view = doc.ActiveView;
            //String[] doorArray = new String[0];
            List<string> doorList = new List<string>();
            int i = 0;



            //var formTest = new RevitButton.WindowsForm.Form1();

            //formTest.Items.add();

            foreach (Element R in new FilteredElementCollector(doc, view.Id).OfClass(typeof(FamilyInstance)).OfCategory(BuiltInCategory.OST_Doors))
            {
                i++;
                //ACCESS THE DOOR ELEMENT AS A FAMILY INSTANCE
                FamilyInstance rInstance = R as FamilyInstance;

                //GET THE DOOR'S HOSTING WALL AS A STRING
                String rName = rInstance.Host.Name.ToString();

                //doorArray.SetValue(rName, i);
                //doorArray.
                doorList.Add(rName);

                //return Result.Succeeded;
            }

            using (Transaction transactionOne = new Transaction(doc))
            {
                //transactionOne.Start();

                Array doorArray = doorList.ToArray();

                TaskDialog.Show("Debug", "Debug Test");

                var formTest3 = new RevitButton.WindowsForm.Form3(doorList.ToArray());

                formTest3.Show();

                //System.Threading.Thread.Sleep(5000);

                //var formtest = new RevitButton.WindowsForm.Form1();

               // formtest.Show();

               // System.Threading.Thread.Sleep(5000);

                //transactionOne.Commit();

                //TaskDialog.Show("Debug", "Debug Test 2");
            }

            //TaskDialog.Show("Debug", "Debug Test 3");

            return Result.Succeeded;

        }
    }
}
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string sProdName = "Widget";
        int iUnitQty = 100;
        double dUnitCost = 1.03;

        Debug.WriteLine("Debug Information-Product Starting ");
        Debug.Indent();

        /* Debug.WriteLine("The product name is " + sProdName);
        Debug.WriteLine("The available units on hand are " + iUnitQty.ToString());
        Debug.WriteLine("The per unit cost is " + dUnitCost.ToString()); */

        Debug.WriteLine("The product name is " + sProdName, "Field");
        Debug.WriteLine("The units on hand are " + iUnitQty, "Field");
        Debug.WriteLine("The per unit cost is " + dUnitCost.ToString(), "Field");
        Debug.WriteLine("Total Cost is " + (iUnitQty * dUnitCost), "Calc");

        Debug.WriteLineIf(iUnitQty > 50, "This message WILL appear");
        Debug.WriteLineIf(iUnitQty < 50, "This message will NOT appear");

        Debug.Assert(dUnitCost > 1, "Message will NOT appear");
        Debug.Assert(dUnitCost < 1, "Message will appear since dUnitcost < 1 is false");

        /* System.Xml.XmlDocument oxml = new System.Xml.XmlDocument();
        Debug.WriteLine(oxml); */

        TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
        // Debug.Listeners.Add(tr1);
        Trace.Listeners.Add(tr1);

        TextWriterTraceListener tr2 = new TextWriterTraceListener(
            System.IO.File.CreateText("Output.txt")
        );
        // Debug.Listeners.Add(tr2);
        Trace.Listeners.Add(tr2);

        Debug.Unindent();
        Debug.WriteLine("Debug Information-Product Ending");
        Debug.Flush();
    }
}

using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string sProdName = "Widget";
        int iUnitQty = 100;
        double dUnitCost = 1.03;

        Trace.WriteLine("Trace Information-Product Starting ");
        Trace.Indent();

        Trace.WriteLine("The product name is " + sProdName);
        Trace.WriteLine("The product name is" + sProdName, "Field");
        Trace.WriteLineIf(iUnitQty > 50, "This message WILL appear");
        Trace.Assert(dUnitCost > 1, "Message will NOT appear");

        Trace.Unindent();
        Trace.WriteLine("Trace Information-Product Ending");

        Trace.Flush();

        Console.ReadLine();
    }
}

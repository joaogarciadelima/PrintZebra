using System;
using PrintZebra;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//[assembly: ComVisible(true)]
//[assembly: Guid("4b8dcb67-ade0-46e6-8554-5c0343d54a84")]

namespace ImpressaoVB
{

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("29415AAB-5030-4E06-8580-30310C52363F")]
    [ProgId("Impressão.VB")]
    public class PrintHandler
    {

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Int32 SendStringToPrinter(string text, string printerName)
        {
            
            return RawPrinterHelper.SendStringToPrinter(printerName, text);
        }

    }
}

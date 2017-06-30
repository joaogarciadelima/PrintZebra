using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintZebra;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//[assembly: ComVisible(true)]
//[assembly: Guid("4b8dcb67-ade0-46e6-8554-5c0343d54a84")]

namespace impressaoVB
{

    //[assembly: ComVisible(true)]
    //// [ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(impressaoVB)), Guid("0162cf2b-365d-4dde-86f5-f6343110d1a6")]
    ////Impressão via vb6
    //[assembly: Guid("4b8dcb67-ade0-46e6-8554-5c0343d54a84")]
    
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("29415AAB-5030-4E06-8580-30310C52363F")]
    [ProgId("Impressão.VB")]
    public class impressaoVB
    {
        public string VB;
        public string printername1;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public string ImpressaoVB(string VB, string printername1)
        {
            RawPrinterHelper.SendStringToPrinter(printername1, VB);
            return null;
        }

    }
}

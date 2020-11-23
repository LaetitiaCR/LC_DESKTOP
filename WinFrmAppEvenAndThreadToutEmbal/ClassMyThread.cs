using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmAppEvenAndThreadToutEmbal
{
    class ClassMyThread
    {
        
            private Form myForm;
            public ClassMyThread(Form myForm)
            {
                this.myForm = myForm;
            }

            public void Run()
            {


               // myForm.Invoke(myForm.myDelegate);
            }

        
    }
}

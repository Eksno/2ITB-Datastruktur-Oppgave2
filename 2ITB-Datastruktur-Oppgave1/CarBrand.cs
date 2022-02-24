using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITB_Datastruktur_Oppgave1
{
    public class CarBrand : Label
    {
        public void Setup(Form form, string initialText, Point initialLocation)
        {
            this.Text = initialText;
            this.Location = initialLocation;

            // Set the AutoSize property of the Label control
            form.Controls.Add(this);
        }
    }
}

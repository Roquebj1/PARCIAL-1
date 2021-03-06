using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenParcial1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
        }
        private void BOTON(object sender, EventArgs e)
        {

            var A = int.Parse(WWX.Text);
            int B, TOTAL;
            B = A / 10;
            TOTAL = B - 4;
            string text = "";
            text = "Acaso soy mago?, tu numero pensado es : " + TOTAL;
            DisplayAlert("Resultado", text, "listo");
        }
        private void Buton(object sender, EventArgs e)
        {

            int resultado, dia, fecha, A;
            var C = int.Parse(www.Text);
            string Total = "";
            A = (C - 365);
            resultado = A;
            dia = resultado / 100;
            fecha = resultado % 100;
            Total = "Acaso soy mago?, el dia en que naciste es : " + dia + " y  el  mes " + fecha ;

            DisplayAlert("Resultado",
                Total,
                "Listo");

        }

    }
}

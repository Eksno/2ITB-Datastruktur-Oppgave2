using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ITB_Datastruktur_Oppgave1
{
    internal class Globals
    {
        public static string[] basicCarBrandNames = { "Ford", "Toyota", "Tesla", "Saab" };
        public static List<string> carBrandNames = new List<string>();
        public static List<CarBrand> carBrands = new List<CarBrand>();

        public static void AddBasicCarBrands(Form form)
        {
            for (int i = 0; i < basicCarBrandNames.Length; i++)
            {
                AddCarBrand(form, basicCarBrandNames[i]);
            }
        }

        public static bool AddCarBrand(Form form, string brand)
        {
            if (!carBrandNames.Contains(brand))
            {
                carBrandNames.Add(brand);
                carBrands.Add(new CarBrand());
                carBrands[^1].Setup(form, brand, new Point(30, carBrands.Count * 30));

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RemoveCarBrand(Form form, Label lblDebug, string brand)
        {
            if (carBrandNames.Contains(brand))
            {
                int index = carBrandNames.IndexOf(brand);
                form.Controls.Remove(carBrands[index]);
                carBrands.RemoveAt(index);
                carBrandNames.RemoveAt(index);

                RefreshBrands(form, lblDebug);

                return true;
            }
            else
            {
                return false;
            }
        }

        private static void RefreshBrands(Form form, Label lblDebug)
        {
            if (carBrands.Count != 0)
            {
                // Create temp list for recreation
                List<string> _carBrandNames = new List<string>(carBrandNames);

                // Remove brands
                foreach (CarBrand carBrand in carBrands)
                {
                    form.Controls.Remove(carBrand);
                }
                carBrandNames.Clear();
                carBrands.Clear();

                // Recreate brands
                foreach (string brandName in _carBrandNames)
                {
                    AddCarBrand(form, brandName);
                }
            }
        }
    }
}

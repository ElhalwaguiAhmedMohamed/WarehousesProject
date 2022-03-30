using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesProject.Models;

namespace WarehousesProject.Services
{
    public class ImporterService
    {
        public static ObservableCollection<Importer> getAll()
        {
            ObservableCollection<Importer> importers = new ObservableCollection<Importer>();
            Model1 model = new Model1();
            foreach (Importer importer in model.Importers)
            {
                importers.Add(importer);
            }
            return importers;
        }

        public static void addWarehouse(Importer _importer)
        {
            Model1 model = new Model1();
            model.Importers.Add(_importer);
            model.SaveChanges();
        }

        //public static void updateWarehouse(Importer _importer)
        //{
        //    Model1 model = new Model1();
        //    Warhouse toBeUpdatedObj = model.Warhouses.Find(_importer.Id);
        //    if (toBeUpdatedObj != null)
        //    {
        //        toBeUpdatedObj.Address = _warhouse.Address;
        //        toBeUpdatedObj.Responsible = _warhouse.Responsible;
        //        model.SaveChanges();
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehousesProject.Services;
using WarehousesProject.Models;
using WarehousesProject.Commands;

namespace WarehousesProject.ViewModels
{
    public class importerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Importer> allImporters;

        public ObservableCollection<Importer> AllImporters
        {
            get { return allImporters; }
            set
            {
                allImporters = value;
                onPropertyChanged("AllWareHouses");
            }
        }

        private void onPropertyChanged(string _prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_prop));
        }

        public importerViewModel()
        {
            AllImporters = ImporterService.getAll();
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace WpfAppintentodevexpress
{
    public class MainWindowVM : DevExpress.Mvvm.ViewModelBase
    {
        public MainWindowVM()
        {
            cargarInfo();
        }

        public void cargarInfo()
        {
            using (Data.DataSet1TableAdapters.PaisesTableAdapter ta = new Data.DataSet1TableAdapters.PaisesTableAdapter())
            {
                Data.DataSet1.PaisesDataTable dt = new Data.DataSet1.PaisesDataTable();
                dt = ta.GetData();

                Datasource = dt.ToList();
            }
        }


        public List<Data.DataSet1.PaisesRow> Datasource
        {
            get { return GetProperty(() => Datasource); }
            set { SetProperty(() => Datasource, value); }
        }
    }

    public class Paises
    {
        public string CLAVE_PAIS { get; set; }
        public string NOMBRE_PAIS { get; set; }
    }
}

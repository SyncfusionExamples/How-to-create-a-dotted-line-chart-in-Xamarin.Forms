using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChartSample
{
    public class ChartModel
    {
        public string XValue { get; set; }
        public double YValue1 { get; set; }
        public double YValue2 { get; set; }
        public double YValue3 { get; set; }
    }
    public class ViewModel
    {
        public ObservableCollection<ChartModel> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<ChartModel>();

            Data.Add(new ChartModel() { XValue = "Jan", YValue1 = 37, YValue2 = 51, YValue3 = 72 });
            Data.Add(new ChartModel() { XValue = "Feb", YValue1 = 37, YValue2 = 55 , YValue3 = 76 });
            Data.Add(new ChartModel() { XValue = "Mar", YValue1 = 39, YValue2 = 58 , YValue3 = 78});
            Data.Add(new ChartModel() { XValue = "Apr", YValue1 = 43, YValue2 = 62,YValue3=82 });
            Data.Add(new ChartModel() { XValue = "May", YValue1 = 48, YValue2 = 67 ,YValue3=87});
            Data.Add(new ChartModel() { XValue = "Jun", YValue1 = 54, YValue2 = 71,YValue3=91});
            Data.Add(new ChartModel() { XValue = "Jul", YValue1 = 57, YValue2 = 76 ,YValue3 = 96});
            Data.Add(new ChartModel() { XValue = "Aug", YValue1 = 57, YValue2 = 76,YValue3=96 });
            Data.Add(new ChartModel() { XValue = "Sep", YValue1 = 54, YValue2 = 73,YValue3=93 });
            Data.Add(new ChartModel() { XValue = "Oct", YValue1 = 48, YValue2 = 65 ,YValue3=85});
            Data.Add(new ChartModel() { XValue = "Nov", YValue1 = 43, YValue2 = 60,YValue3=80 });
            Data.Add(new ChartModel() { XValue = "Dec", YValue1 = 37, YValue2 = 55 ,YValue3=76});

        }
    }
}

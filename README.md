# How to create a dotted line chart in Xamarin.Forms

A [line chart in Xamarin.Forms](https://www.syncfusion.com/xamarin-ui-controls/xamarin-charts/chart-types/line-chart) display information as a series of data points which is connected by the straight line segments. [Xamarin.Forms Chart](https://help.syncfusion.com/xamarin/charts/getting-started) provides support to create a dotted line chart using the inbuild APIs.  This section explains how to apply the dashed style in the following FastLine and Line Chart series.

**Dash-Styled FastLine Chart**

A [fast line chart](https://help.syncfusion.com/xamarin/charts/charttypes#fast-line-chart) is a special kind of line chart that can render a collection with a huge number of data points. A dotted FastLine chart can be created by using the [StrokeDashArray](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.FastLineSeries.html#Syncfusion_SfChart_XForms_FastLineSeries_StrokeDashArray) property. [StrokeDashArray](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.FastLineSeries.html#Syncfusion_SfChart_XForms_FastLineSeries_StrokeDashArray) is a double array property.

```
<syncfusion:FastLineSeries ItemsSource="{Binding Data}" Color="#719daa" StrokeWidth="4" XBindingPath="XValue" YBindingPath="YValue1">
    <syncfusion:FastLineSeries.StrokeDashArray>
        <x:Array Type="{x:Type x:Double}">
            <x:Double>3</x:Double>
            <x:Double>2</x:Double>
        </x:Array>
    </syncfusion:FastLineSeries.StrokeDashArray>
</syncfusion:FastLineSeries>
<syncfusion:FastLineSeries ItemsSource="{Binding Data}" Color="#f25959" StrokeWidth="4" XBindingPath="XValue" YBindingPath="YValue2">
    <syncfusion:FastLineSeries.StrokeDashArray>
        <x:Array Type="{x:Type x:Double}">
            <x:Double>1</x:Double>
            <x:Double>2</x:Double>
        </x:Array>
    </syncfusion:FastLineSeries.StrokeDashArray>
</syncfusion:FastLineSeries>
<syncfusion:FastLineSeries ItemsSource="{Binding Data}" Color="#d8d79b"  StrokeWidth="4" XBindingPath="XValue" YBindingPath="YValue3">
    <syncfusion:FastLineSeries.StrokeDashArray>
        <x:Array Type="{x:Type x:Double}">
            <x:Double>9</x:Double>
            <x:Double>1</x:Double>
        </x:Array>
    </syncfusion:FastLineSeries.StrokeDashArray>
</syncfusion:FastLineSeries>
```

**Dash-Styled Line Chart**

In the same way, mentioned for the Fast Line chart, you can create a dotted line chart with Line Series as shown in the following code sample using the [StrokeDashArray](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.FastLineSeries.html#Syncfusion_SfChart_XForms_FastLineSeries_StrokeDashArray) property.
```
<syncfusion:LineSeries ItemsSource="{Binding Data}" Color="#719daa" StrokeWidth="4" XBindingPath="XValue" YBindingPath="YValue1">
    <syncfusion:LineSeries.StrokeDashArray>
        <x:Array Type="{x:Type x:Double}">
            <x:Double>3</x:Double>
            <x:Double>2</x:Double>
        </x:Array>
    </syncfusion:LineSeries.StrokeDashArray>
</syncfusion:LineSeries>
<syncfusion:LineSeries ItemsSource="{Binding Data}" Color="#f25959" StrokeWidth="4" XBindingPath="XValue" YBindingPath="YValue2">
    <syncfusion:LineSeries.StrokeDashArray>
        <x:Array Type="{x:Type x:Double}">
            <x:Double>1</x:Double>
            <x:Double>2</x:Double>
        </x:Array>
    </syncfusion:LineSeries.StrokeDashArray>
</syncfusion:LineSeries>
<syncfusion:LineSeries ItemsSource="{Binding Data}" Color="#d8d79b"  StrokeWidth="4" XBindingPath="XValue" YBindingPath="YValue3">
    <syncfusion:LineSeries.StrokeDashArray>
        <x:Array Type="{x:Type x:Double}">
            <x:Double>9</x:Double>
            <x:Double>1</x:Double>
        </x:Array>
    </syncfusion:LineSeries.StrokeDashArray>
</syncfusion:LineSeries>
```

## Output

![Dotted line chart Xamarin.forms](https://github.com/SyncfusionExamples/How-to-create-a-dotted-line-chart-in-Xamarin.Forms/blob/main/Dotted-Line-Chart.png)

KB article - [How to create a dotted line chart in Xamarin.Forms](https://www.syncfusion.com/kb/5924/how-to-create-a-dotted-line-chart-in-xamarin-forms)

## See also

[What are the different types of axis in Charts](https://help.syncfusion.com/xamarin/charts/axis)

[How to add multiple series in SfChart](https://help.syncfusion.com/xamarin/charts/chartseries#multiple-series)

[How to show the provided information of the data points to the user](https://help.syncfusion.com/xamarin/charts/datamarker)

[How to add annotations in SfChart](https://help.syncfusion.com/xamarin/charts/chartannotation)

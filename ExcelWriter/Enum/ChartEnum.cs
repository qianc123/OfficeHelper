﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelWriterCSharp
{
    public enum ChartStyle
    {
        None,
        Area3D = Excel.XlChartType.xl3DArea,
        AreaStacked3D = Excel.XlChartType.xl3DAreaStacked,
        AreaStacked1003D = Excel.XlChartType.xl3DAreaStacked100,
        BarClustered3D = Excel.XlChartType.xl3DBarClustered,
        BarStacked3D = Excel.XlChartType.xl3DBarStacked,
        BarStacked1003D = Excel.XlChartType.xl3DBarStacked100,
        Column3D = Excel.XlChartType.xl3DColumn,
        ColumnClustered3D = Excel.XlChartType.xl3DColumnClustered,
        ColumnStacked3D = Excel.XlChartType.xl3DColumnStacked,
        ColumnStacked1003D = Excel.XlChartType.xl3DColumnStacked100,
        Line3D = Excel.XlChartType.xl3DLine,
        Pie3D = Excel.XlChartType.xl3DPie,
        PieExploded3D = Excel.XlChartType.xl3DPieExploded,
        Area = Excel.XlChartType.xlArea,
        AreaStacked = Excel.XlChartType.xlAreaStacked,
        AreaStacked100 = Excel.XlChartType.xlAreaStacked100,
        BarClustered = Excel.XlChartType.xlBarClustered,
        BarOfPie = Excel.XlChartType.xlBarOfPie,
        BarStacked = Excel.XlChartType.xlBarStacked,
        BarStacked100 = Excel.XlChartType.xlBarStacked100,
        Bubble = Excel.XlChartType.xlBubble,
        Bubble3DEffect = Excel.XlChartType.xlBubble3DEffect,
        ColumnClustered = Excel.XlChartType.xlColumnClustered,
        ColumnStacked = Excel.XlChartType.xlColumnStacked,
        ColumnStacked100 = Excel.XlChartType.xlColumnStacked100,
        ConeBarClustered = Excel.XlChartType.xlConeBarClustered,
        ConeBarStacked = Excel.XlChartType.xlConeBarStacked,
        ConeBarStacked100 = Excel.XlChartType.xlConeBarStacked100,
        ConeCol = Excel.XlChartType.xlConeCol,
        ConeColClustered = Excel.XlChartType.xlConeColClustered,
        ConeColStacked = Excel.XlChartType.xlConeColStacked,
        ConeColStacked100 = Excel.XlChartType.xlConeColStacked100,
        CylinderBarClustered = Excel.XlChartType.xlCylinderBarClustered,
        CylinderBarStacked = Excel.XlChartType.xlCylinderBarStacked,
        CylinderBarStacked100 = Excel.XlChartType.xlCylinderBarStacked100,
        CylinderCol = Excel.XlChartType.xlCylinderCol,
        CylinderColClustered = Excel.XlChartType.xlCylinderColClustered,
        CylinderColStacked = Excel.XlChartType.xlCylinderColStacked,
        CylinderColStacked100 = Excel.XlChartType.xlCylinderColStacked100,
        Doughnut = Excel.XlChartType.xlDoughnut,
        DoughnutExploded = Excel.XlChartType.xlDoughnutExploded,
        Line = Excel.XlChartType.xlLine,
        LineMarkers = Excel.XlChartType.xlLineMarkers,
        LineMarkersStacked = Excel.XlChartType.xlLineMarkersStacked,
        LineMarkersStacked100 = Excel.XlChartType.xlLineMarkersStacked100,
        LineStacked = Excel.XlChartType.xlLineStacked,
        LineStacked100 = Excel.XlChartType.xlLineStacked100,
        Pie = Excel.XlChartType.xlPie,
        PieExploded = Excel.XlChartType.xlPieExploded,
        PieOfPie = Excel.XlChartType.xlPieOfPie,
        PyramidBarClustered = Excel.XlChartType.xlPyramidBarClustered,
        PyramidBarStacked = Excel.XlChartType.xlPyramidBarStacked,
        PyramidBarStacked100 = Excel.XlChartType.xlPyramidBarStacked100,
        PyramidCol = Excel.XlChartType.xlPyramidCol,
        PyramidColClustered = Excel.XlChartType.xlPyramidColClustered,
        PyramidColStacked = Excel.XlChartType.xlPyramidColStacked,
        PyramidColStacked100 = Excel.XlChartType.xlPyramidColStacked100,
        Radar = Excel.XlChartType.xlRadar,
        RadarFilled = Excel.XlChartType.xlRadarFilled,
        RadarMarkers = Excel.XlChartType.xlRadarMarkers,
        StockHlc = Excel.XlChartType.xlStockHLC,
        StockOhlc = Excel.XlChartType.xlStockOHLC,
        StockVhlc = Excel.XlChartType.xlStockVHLC,
        StockVOhlc = Excel.XlChartType.xlStockVOHLC,
        Surface = Excel.XlChartType.xlSurface,
        SurfaceTopView = Excel.XlChartType.xlSurfaceTopView,
        SurfaceTopViewWireframe = Excel.XlChartType.xlSurfaceTopViewWireframe,
        SurfaceWireframe = Excel.XlChartType.xlSurfaceWireframe,
        XYScatter = Excel.XlChartType.xlXYScatter,
        XYScatterLines = Excel.XlChartType.xlXYScatterLines,
        XYScatterLinesNoMarkers = Excel.XlChartType.xlXYScatterLinesNoMarkers,
        XYScatterSmooth = Excel.XlChartType.xlXYScatterSmooth,
        XYScatterSmoothNoMarkers = Excel.XlChartType.xlXYScatterSmoothNoMarkers
    }
}

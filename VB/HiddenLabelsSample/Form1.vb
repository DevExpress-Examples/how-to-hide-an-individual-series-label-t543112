﻿Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace HiddenLabelsSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ' This line of code is generated by Data Source Configuration Wizard
            gspTableAdapter1.Fill(gspDataSet1.GSP)
        End Sub

        #Region "#LabelsHidding"
        Private Sub OnCustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles chartControl1.CustomDrawSeriesPoint
            If e.SeriesPoint.Values(0) < 1 Then
                e.LabelText = String.Empty
            End If
        End Sub
        #End Region ' #LabelsHidding
    End Class
End Namespace
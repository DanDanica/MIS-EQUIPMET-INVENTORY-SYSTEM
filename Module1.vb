Imports System.Data.OleDb

Module Module1
    Public connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MISInventoryDatabase.mdb")
    Public StoreData, StoreDate, StoreTime As String ' GLOBAL VARIABLE, CAN USE TO ALL FORM 
    Public StoreAdminStudNum, StoreAdminDate As String
End Module

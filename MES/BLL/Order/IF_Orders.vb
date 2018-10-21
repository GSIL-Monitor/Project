Imports Common
Imports Common.ConvertData

Namespace Order
    ''' <summary>
    ''' IF_ORDERS 业务逻辑层 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class IF_ORDERS

        Public Function getNewOrdersCollectionLimit(ByVal nCount As Integer) As DataTable

            Try

                Dim dt As New DataTable
                '5
                For i As Integer = 1 To 5
                    dt.Columns.Add("column" & i, System.Type.GetType("System.String"))
                Next

                For i As Integer = 1 To 8
                    Dim dr As DataRow = dt.NewRow
                    dr.Item(0) = ""
                    dr.Item(1) = ""
                    dr.Item(2) = ""
                    dr.Item(3) = ""
                    dr.Item(4) = ""
                    dt.Rows.Add(dr)
                Next

                Dim Filter As String = " AND IF_FLAG='N'"
                Dim mdls As Model.Order.IF_ORDERSCollection = DAL.Order.IF_ORDERS.Create.Querylimit(nCount, Filter)
                Try
                    For i As Integer = 0 To nCount - 1
                        dt.Rows(0).Item(i) = toStr(mdls(i * 8 + 0).A17_SALEORDER)
                        dt.Rows(1).Item(i) = toStr(mdls(i * 8 + 1).A17_SALEORDER)
                        dt.Rows(2).Item(i) = toStr(mdls(i * 8 + 2).A17_SALEORDER)
                        dt.Rows(3).Item(i) = toStr(mdls(i * 8 + 3).A17_SALEORDER)
                        dt.Rows(4).Item(i) = toStr(mdls(i * 8 + 4).A17_SALEORDER)
                        dt.Rows(5).Item(i) = toStr(mdls(i * 8 + 5).A17_SALEORDER)
                        dt.Rows(6).Item(i) = toStr(mdls(i * 8 + 6).A17_SALEORDER)
                        dt.Rows(7).Item(i) = toStr(mdls(i * 8 + 7).A17_SALEORDER)
                    Next
                Catch ex As Exception

                End Try
                Return dt


            Catch ex As Exception
                Common.Debug.myMsg(ex.Message)
            End Try


        End Function


        Public Function getIF_ORDERSCollection() As Model.Order.IF_ORDERSCollection

            Try
                Return DAL.Order.IF_ORDERS.Create.Query
            Catch ex As Exception
                Common.Debug.myMsg(ex.Message)
            End Try

        End Function

        Public Function getIF_ORDERSCollection_byFiliter(ByVal Filiter As String) As Model.Order.IF_ORDERSCollection

            Try
                Return DAL.Order.IF_ORDERS.Create.Query_byFiliter(Filiter)
            Catch ex As Exception
                Common.Debug.myMsg(ex.Message)
            End Try

        End Function

        Public Function getIF_ORDERSSingle_byIF_ID(ByVal IF_ID As String) As Model.Order.IF_ORDERS

            Try
                Return DAL.Order.IF_ORDERS.Create.Query_BySingle(IF_ID)
            Catch ex As Exception
                Common.Debug.myMsg(ex.Message)
            End Try

        End Function

        Public Function Insert(ByVal mdl As Model.Order.IF_ORDERS) As ExecResult

            Try
                DAL.Order.IF_ORDERS.Create.Insert(mdl)
            Catch ex As Exception
                Common.Debug.myMsg(ex.Message)
                Insert = ExecResult.Fail
            End Try

        End Function

        Public Function Update(ByVal mdl As Model.Order.IF_ORDERS) As ExecResult

            Try
                DAL.Order.IF_ORDERS.Create.Update(mdl)
            Catch ex As Exception
                Common.Debug.myMsg(ex.Message)
                Update = ExecResult.Fail
            End Try

        End Function

        Public Function Delete(ByVal IF_ID As String) As ExecResult

            Try
                DAL.Order.IF_ORDERS.Create.Delete(IF_ID)
            Catch ex As Exception
                Common.Debug.myMsg(ex.Message)
                Delete = ExecResult.Fail
            End Try

        End Function

    End Class
End Namespace


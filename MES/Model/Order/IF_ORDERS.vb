Namespace Order

    Public Class IF_ORDERS

        Private _A01_IF_ID As Integer
        Private _A02_IF_FROMSYSTEM As String
        Private _A03_IF_TOSYSTEM As String
        Private _A04_IF_FLAG As String
        Private _A05_IF_WRITEDATE As Date
        Private _A06_IF_READDATE As Date
        Private _A07_IF_ERRORLOG As String
        Private _A08_IF_INTERFACELOGID As String
        Private _A09_MOCODE As String
        Private _A10_MOTYPE As String
        Private _A11_ITEMCODE As String
        Private _A12_ITEMNAME As String
        Private _A13_PLANQTY As Integer
        Private _A14_UNIT As String
        Private _A15_SDATE As Date
        Private _A16_EDATE As Date
        Private _A17_SALEORDER As String
        Private _A18_THICK As String
        Private _A19_WIDTH As String
        Private _A20_LENGTH As String
        Private _A21_DIAMETER As String
        Private _A22_MTYPE As String
        Private _A23_SWEIGHT As Decimal
        Private _A24_SWEIGHT_UNIT As String
        Private _A25_STEPCODE As String
        Private _A26_THICK_U As String
        Private _A27_THICK_D As String
        Private _A28_WIDTH_U As String
        Private _A29_WIDTH_D As String
        Private _A30_LENGTH_U As String
        Private _A31_LENGTH_D As String
        Private _A32_DIAMETER_D As String
        Private _A33_DIAMETER_U As String
        Private _A34_MODELCODE As String
        Private _A35_LOSSTYPE As String
        Private _A36_IS_HT As Boolean
        Private _A37_IS_CT As Boolean
        Private _A38_HARDNESS As String
        Private _A39_ANGLE As String
        Private _A40_CUSNAME As String
        Private _A41_SALEPERSON As String
        Private _A42_MAKER As String
        Private _A43_DWEIGHT_TYPE As Integer
        Private _A44_HWEIGHT_TYPE As Integer
        Private _A45_SIP As String
        Private _A46_MEMO As String
        Private _A47_RECEIPTPERSON As String
        Private _A48_RECEIPTTIME As Date
        Private _A49_CITYNAME As String
        Private _A50_IROWS As Integer
        Private _A51_MI_ID As Integer
        Private _A52_cWORKCondition As String
        Private _A53_cWorkCode As String
        Private _A54_CINVCODE As String

        Private _Nuke As New PropertyNuke(Me)
        Private Shared _PN As New PropertyName(True)
        Private Shared _PM As New PropertyName(False)
        Public Function Nuke() As PropertyNuke
            Return _Nuke
        End Function
        ''' <summary>
        ''' 属性名称
        ''' </summary>
        Public Shared Function PN() As PropertyName
            Return _PN
        End Function
        ''' <summary>
        ''' 属性中文名
        ''' </summary>
        Public Shared Function PM() As PropertyName
            Return _PM
        End Function

        ''' <summary>
        ''' IF_ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A01_IF_ID() As Integer
            Get
                Return _A01_IF_ID
            End Get
            Set(ByVal value As Integer)
                _A01_IF_ID = Value
            End Set
        End Property

        ''' <summary>
        ''' IF_FROMSYSTEM
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A02_IF_FROMSYSTEM() As String
            Get
                Return _A02_IF_FROMSYSTEM
            End Get
            Set(ByVal value As String)
                _A02_IF_FROMSYSTEM = Value
            End Set
        End Property

        ''' <summary>
        ''' IF_TOSYSTEM
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A03_IF_TOSYSTEM() As String
            Get
                Return _A03_IF_TOSYSTEM
            End Get
            Set(ByVal value As String)
                _A03_IF_TOSYSTEM = Value
            End Set
        End Property

        ''' <summary>
        ''' IF_FLAG
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A04_IF_FLAG() As String
            Get
                Return _A04_IF_FLAG
            End Get
            Set(ByVal value As String)
                _A04_IF_FLAG = Value
            End Set
        End Property

        ''' <summary>
        ''' IF_WRITEDATE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A05_IF_WRITEDATE() As Date
            Get
                Return _A05_IF_WRITEDATE
            End Get
            Set(ByVal value As Date)
                _A05_IF_WRITEDATE = Value
            End Set
        End Property

        ''' <summary>
        ''' IF_READDATE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A06_IF_READDATE() As Date
            Get
                Return _A06_IF_READDATE
            End Get
            Set(ByVal value As Date)
                _A06_IF_READDATE = Value
            End Set
        End Property

        ''' <summary>
        ''' IF_ERRORLOG
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A07_IF_ERRORLOG() As String
            Get
                Return _A07_IF_ERRORLOG
            End Get
            Set(ByVal value As String)
                _A07_IF_ERRORLOG = Value
            End Set
        End Property

        ''' <summary>
        ''' IF_INTERFACELOGID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A08_IF_INTERFACELOGID() As String
            Get
                Return _A08_IF_INTERFACELOGID
            End Get
            Set(ByVal value As String)
                _A08_IF_INTERFACELOGID = Value
            End Set
        End Property

        ''' <summary>
        ''' MOCODE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A09_MOCODE() As String
            Get
                Return _A09_MOCODE
            End Get
            Set(ByVal value As String)
                _A09_MOCODE = Value
            End Set
        End Property

        ''' <summary>
        ''' MOTYPE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A10_MOTYPE() As String
            Get
                Return _A10_MOTYPE
            End Get
            Set(ByVal value As String)
                _A10_MOTYPE = Value
            End Set
        End Property

        ''' <summary>
        ''' ITEMCODE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A11_ITEMCODE() As String
            Get
                Return _A11_ITEMCODE
            End Get
            Set(ByVal value As String)
                _A11_ITEMCODE = Value
            End Set
        End Property

        ''' <summary>
        ''' ITEMNAME
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A12_ITEMNAME() As String
            Get
                Return _A12_ITEMNAME
            End Get
            Set(ByVal value As String)
                _A12_ITEMNAME = Value
            End Set
        End Property

        ''' <summary>
        ''' PLANQTY
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A13_PLANQTY() As Integer
            Get
                Return _A13_PLANQTY
            End Get
            Set(ByVal value As Integer)
                _A13_PLANQTY = Value
            End Set
        End Property

        ''' <summary>
        ''' UNIT
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A14_UNIT() As String
            Get
                Return _A14_UNIT
            End Get
            Set(ByVal value As String)
                _A14_UNIT = Value
            End Set
        End Property

        ''' <summary>
        ''' SDATE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A15_SDATE() As Date
            Get
                Return _A15_SDATE
            End Get
            Set(ByVal value As Date)
                _A15_SDATE = Value
            End Set
        End Property

        ''' <summary>
        ''' EDATE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A16_EDATE() As Date
            Get
                Return _A16_EDATE
            End Get
            Set(ByVal value As Date)
                _A16_EDATE = Value
            End Set
        End Property

        ''' <summary>
        ''' SALEORDER
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A17_SALEORDER() As String
            Get
                Return _A17_SALEORDER
            End Get
            Set(ByVal value As String)
                _A17_SALEORDER = Value
            End Set
        End Property

        ''' <summary>
        ''' THICK
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A18_THICK() As String
            Get
                Return _A18_THICK
            End Get
            Set(ByVal value As String)
                _A18_THICK = Value
            End Set
        End Property

        ''' <summary>
        ''' WIDTH
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A19_WIDTH() As String
            Get
                Return _A19_WIDTH
            End Get
            Set(ByVal value As String)
                _A19_WIDTH = Value
            End Set
        End Property

        ''' <summary>
        ''' LENGTH
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A20_LENGTH() As String
            Get
                Return _A20_LENGTH
            End Get
            Set(ByVal value As String)
                _A20_LENGTH = Value
            End Set
        End Property

        ''' <summary>
        ''' DIAMETER
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A21_DIAMETER() As String
            Get
                Return _A21_DIAMETER
            End Get
            Set(ByVal value As String)
                _A21_DIAMETER = Value
            End Set
        End Property

        ''' <summary>
        ''' MTYPE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A22_MTYPE() As String
            Get
                Return _A22_MTYPE
            End Get
            Set(ByVal value As String)
                _A22_MTYPE = Value
            End Set
        End Property

        ''' <summary>
        ''' SWEIGHT
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A23_SWEIGHT() As Decimal
            Get
                Return _A23_SWEIGHT
            End Get
            Set(ByVal value As Decimal)
                _A23_SWEIGHT = Value
            End Set
        End Property

        ''' <summary>
        ''' SWEIGHT_UNIT
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A24_SWEIGHT_UNIT() As String
            Get
                Return _A24_SWEIGHT_UNIT
            End Get
            Set(ByVal value As String)
                _A24_SWEIGHT_UNIT = Value
            End Set
        End Property

        ''' <summary>
        ''' STEPCODE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A25_STEPCODE() As String
            Get
                Return _A25_STEPCODE
            End Get
            Set(ByVal value As String)
                _A25_STEPCODE = Value
            End Set
        End Property

        ''' <summary>
        ''' THICK_U
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A26_THICK_U() As String
            Get
                Return _A26_THICK_U
            End Get
            Set(ByVal value As String)
                _A26_THICK_U = Value
            End Set
        End Property

        ''' <summary>
        ''' THICK_D
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A27_THICK_D() As String
            Get
                Return _A27_THICK_D
            End Get
            Set(ByVal value As String)
                _A27_THICK_D = Value
            End Set
        End Property

        ''' <summary>
        ''' WIDTH_U
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A28_WIDTH_U() As String
            Get
                Return _A28_WIDTH_U
            End Get
            Set(ByVal value As String)
                _A28_WIDTH_U = Value
            End Set
        End Property

        ''' <summary>
        ''' WIDTH_D
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A29_WIDTH_D() As String
            Get
                Return _A29_WIDTH_D
            End Get
            Set(ByVal value As String)
                _A29_WIDTH_D = Value
            End Set
        End Property

        ''' <summary>
        ''' LENGTH_U
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A30_LENGTH_U() As String
            Get
                Return _A30_LENGTH_U
            End Get
            Set(ByVal value As String)
                _A30_LENGTH_U = Value
            End Set
        End Property

        ''' <summary>
        ''' LENGTH_D
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A31_LENGTH_D() As String
            Get
                Return _A31_LENGTH_D
            End Get
            Set(ByVal value As String)
                _A31_LENGTH_D = Value
            End Set
        End Property

        ''' <summary>
        ''' DIAMETER_D
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A32_DIAMETER_D() As String
            Get
                Return _A32_DIAMETER_D
            End Get
            Set(ByVal value As String)
                _A32_DIAMETER_D = Value
            End Set
        End Property

        ''' <summary>
        ''' DIAMETER_U
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A33_DIAMETER_U() As String
            Get
                Return _A33_DIAMETER_U
            End Get
            Set(ByVal value As String)
                _A33_DIAMETER_U = Value
            End Set
        End Property

        ''' <summary>
        ''' MODELCODE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A34_MODELCODE() As String
            Get
                Return _A34_MODELCODE
            End Get
            Set(ByVal value As String)
                _A34_MODELCODE = Value
            End Set
        End Property

        ''' <summary>
        ''' LOSSTYPE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A35_LOSSTYPE() As String
            Get
                Return _A35_LOSSTYPE
            End Get
            Set(ByVal value As String)
                _A35_LOSSTYPE = Value
            End Set
        End Property

        ''' <summary>
        ''' IS_HT
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A36_IS_HT() As Boolean
            Get
                Return _A36_IS_HT
            End Get
            Set(ByVal value As Boolean)
                _A36_IS_HT = Value
            End Set
        End Property

        ''' <summary>
        ''' IS_CT
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A37_IS_CT() As Boolean
            Get
                Return _A37_IS_CT
            End Get
            Set(ByVal value As Boolean)
                _A37_IS_CT = Value
            End Set
        End Property

        ''' <summary>
        ''' HARDNESS
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A38_HARDNESS() As String
            Get
                Return _A38_HARDNESS
            End Get
            Set(ByVal value As String)
                _A38_HARDNESS = Value
            End Set
        End Property

        ''' <summary>
        ''' ANGLE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A39_ANGLE() As String
            Get
                Return _A39_ANGLE
            End Get
            Set(ByVal value As String)
                _A39_ANGLE = Value
            End Set
        End Property

        ''' <summary>
        ''' CUSNAME
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A40_CUSNAME() As String
            Get
                Return _A40_CUSNAME
            End Get
            Set(ByVal value As String)
                _A40_CUSNAME = Value
            End Set
        End Property

        ''' <summary>
        ''' SALEPERSON
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A41_SALEPERSON() As String
            Get
                Return _A41_SALEPERSON
            End Get
            Set(ByVal value As String)
                _A41_SALEPERSON = Value
            End Set
        End Property

        ''' <summary>
        ''' MAKER
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A42_MAKER() As String
            Get
                Return _A42_MAKER
            End Get
            Set(ByVal value As String)
                _A42_MAKER = Value
            End Set
        End Property

        ''' <summary>
        ''' DWEIGHT_TYPE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A43_DWEIGHT_TYPE() As Integer
            Get
                Return _A43_DWEIGHT_TYPE
            End Get
            Set(ByVal value As Integer)
                _A43_DWEIGHT_TYPE = Value
            End Set
        End Property

        ''' <summary>
        ''' HWEIGHT_TYPE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A44_HWEIGHT_TYPE() As Integer
            Get
                Return _A44_HWEIGHT_TYPE
            End Get
            Set(ByVal value As Integer)
                _A44_HWEIGHT_TYPE = Value
            End Set
        End Property

        ''' <summary>
        ''' SIP
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A45_SIP() As String
            Get
                Return _A45_SIP
            End Get
            Set(ByVal value As String)
                _A45_SIP = Value
            End Set
        End Property

        ''' <summary>
        ''' MEMO
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A46_MEMO() As String
            Get
                Return _A46_MEMO
            End Get
            Set(ByVal value As String)
                _A46_MEMO = Value
            End Set
        End Property

        ''' <summary>
        ''' RECEIPTPERSON
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A47_RECEIPTPERSON() As String
            Get
                Return _A47_RECEIPTPERSON
            End Get
            Set(ByVal value As String)
                _A47_RECEIPTPERSON = Value
            End Set
        End Property

        ''' <summary>
        ''' RECEIPTTIME
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A48_RECEIPTTIME() As Date
            Get
                Return _A48_RECEIPTTIME
            End Get
            Set(ByVal value As Date)
                _A48_RECEIPTTIME = Value
            End Set
        End Property

        ''' <summary>
        ''' CITYNAME
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A49_CITYNAME() As String
            Get
                Return _A49_CITYNAME
            End Get
            Set(ByVal value As String)
                _A49_CITYNAME = Value
            End Set
        End Property

        ''' <summary>
        ''' IROWS
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A50_IROWS() As Integer
            Get
                Return _A50_IROWS
            End Get
            Set(ByVal value As Integer)
                _A50_IROWS = Value
            End Set
        End Property

        ''' <summary>
        ''' MI_ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A51_MI_ID() As Integer
            Get
                Return _A51_MI_ID
            End Get
            Set(ByVal value As Integer)
                _A51_MI_ID = Value
            End Set
        End Property

        ''' <summary>
        ''' cWORKCondition
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A52_cWORKCondition() As String
            Get
                Return _A52_cWORKCondition
            End Get
            Set(ByVal value As String)
                _A52_cWORKCondition = Value
            End Set
        End Property

        ''' <summary>
        ''' cWorkCode
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A53_cWorkCode() As String
            Get
                Return _A53_cWorkCode
            End Get
            Set(ByVal value As String)
                _A53_cWorkCode = Value
            End Set
        End Property

        ''' <summary>
        ''' CINVCODE
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property A54_CINVCODE() As String
            Get
                Return _A54_CINVCODE
            End Get
            Set(ByVal value As String)
                _A54_CINVCODE = Value
            End Set
        End Property

        ''' <summary>
        ''' 核心属性
        ''' </summary>

        Public Class PropertyNuke
            Private mdl As IF_ORDERS
            Friend Sub New(ByVal mdl As IF_ORDERS)
                Me.mdl = mdl
            End Sub

            ''' <summary>
            ''' IF_ID
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A01_IF_ID() As Integer
                Get
                    Return mdl.A01_IF_ID
                End Get
                Set(ByVal value As Integer)
                    mdl.A01_IF_ID = Value
                End Set
            End Property

            ''' <summary>
            ''' IF_FROMSYSTEM
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A02_IF_FROMSYSTEM() As String
                Get
                    Return mdl.A02_IF_FROMSYSTEM
                End Get
                Set(ByVal value As String)
                    mdl.A02_IF_FROMSYSTEM = Value
                End Set
            End Property

            ''' <summary>
            ''' IF_TOSYSTEM
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A03_IF_TOSYSTEM() As String
                Get
                    Return mdl.A03_IF_TOSYSTEM
                End Get
                Set(ByVal value As String)
                    mdl.A03_IF_TOSYSTEM = Value
                End Set
            End Property

            ''' <summary>
            ''' IF_FLAG
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A04_IF_FLAG() As String
                Get
                    Return mdl.A04_IF_FLAG
                End Get
                Set(ByVal value As String)
                    mdl.A04_IF_FLAG = Value
                End Set
            End Property

            ''' <summary>
            ''' IF_WRITEDATE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A05_IF_WRITEDATE() As Date
                Get
                    Return mdl.A05_IF_WRITEDATE
                End Get
                Set(ByVal value As Date)
                    mdl.A05_IF_WRITEDATE = Value
                End Set
            End Property

            ''' <summary>
            ''' IF_READDATE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A06_IF_READDATE() As Date
                Get
                    Return mdl.A06_IF_READDATE
                End Get
                Set(ByVal value As Date)
                    mdl.A06_IF_READDATE = Value
                End Set
            End Property

            ''' <summary>
            ''' IF_ERRORLOG
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A07_IF_ERRORLOG() As String
                Get
                    Return mdl.A07_IF_ERRORLOG
                End Get
                Set(ByVal value As String)
                    mdl.A07_IF_ERRORLOG = Value
                End Set
            End Property

            ''' <summary>
            ''' IF_INTERFACELOGID
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A08_IF_INTERFACELOGID() As String
                Get
                    Return mdl.A08_IF_INTERFACELOGID
                End Get
                Set(ByVal value As String)
                    mdl.A08_IF_INTERFACELOGID = Value
                End Set
            End Property

            ''' <summary>
            ''' MOCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A09_MOCODE() As String
                Get
                    Return mdl.A09_MOCODE
                End Get
                Set(ByVal value As String)
                    mdl.A09_MOCODE = Value
                End Set
            End Property

            ''' <summary>
            ''' MOTYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A10_MOTYPE() As String
                Get
                    Return mdl.A10_MOTYPE
                End Get
                Set(ByVal value As String)
                    mdl.A10_MOTYPE = Value
                End Set
            End Property

            ''' <summary>
            ''' ITEMCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A11_ITEMCODE() As String
                Get
                    Return mdl.A11_ITEMCODE
                End Get
                Set(ByVal value As String)
                    mdl.A11_ITEMCODE = Value
                End Set
            End Property

            ''' <summary>
            ''' ITEMNAME
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A12_ITEMNAME() As String
                Get
                    Return mdl.A12_ITEMNAME
                End Get
                Set(ByVal value As String)
                    mdl.A12_ITEMNAME = Value
                End Set
            End Property

            ''' <summary>
            ''' PLANQTY
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A13_PLANQTY() As Integer
                Get
                    Return mdl.A13_PLANQTY
                End Get
                Set(ByVal value As Integer)
                    mdl.A13_PLANQTY = Value
                End Set
            End Property

            ''' <summary>
            ''' UNIT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A14_UNIT() As String
                Get
                    Return mdl.A14_UNIT
                End Get
                Set(ByVal value As String)
                    mdl.A14_UNIT = Value
                End Set
            End Property

            ''' <summary>
            ''' SDATE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A15_SDATE() As Date
                Get
                    Return mdl.A15_SDATE
                End Get
                Set(ByVal value As Date)
                    mdl.A15_SDATE = Value
                End Set
            End Property

            ''' <summary>
            ''' EDATE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A16_EDATE() As Date
                Get
                    Return mdl.A16_EDATE
                End Get
                Set(ByVal value As Date)
                    mdl.A16_EDATE = Value
                End Set
            End Property

            ''' <summary>
            ''' SALEORDER
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A17_SALEORDER() As String
                Get
                    Return mdl.A17_SALEORDER
                End Get
                Set(ByVal value As String)
                    mdl.A17_SALEORDER = Value
                End Set
            End Property

            ''' <summary>
            ''' THICK
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A18_THICK() As String
                Get
                    Return mdl.A18_THICK
                End Get
                Set(ByVal value As String)
                    mdl.A18_THICK = Value
                End Set
            End Property

            ''' <summary>
            ''' WIDTH
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A19_WIDTH() As String
                Get
                    Return mdl.A19_WIDTH
                End Get
                Set(ByVal value As String)
                    mdl.A19_WIDTH = Value
                End Set
            End Property

            ''' <summary>
            ''' LENGTH
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A20_LENGTH() As String
                Get
                    Return mdl.A20_LENGTH
                End Get
                Set(ByVal value As String)
                    mdl.A20_LENGTH = Value
                End Set
            End Property

            ''' <summary>
            ''' DIAMETER
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A21_DIAMETER() As String
                Get
                    Return mdl.A21_DIAMETER
                End Get
                Set(ByVal value As String)
                    mdl.A21_DIAMETER = Value
                End Set
            End Property

            ''' <summary>
            ''' MTYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A22_MTYPE() As String
                Get
                    Return mdl.A22_MTYPE
                End Get
                Set(ByVal value As String)
                    mdl.A22_MTYPE = Value
                End Set
            End Property

            ''' <summary>
            ''' SWEIGHT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A23_SWEIGHT() As Decimal
                Get
                    Return mdl.A23_SWEIGHT
                End Get
                Set(ByVal value As Decimal)
                    mdl.A23_SWEIGHT = Value
                End Set
            End Property

            ''' <summary>
            ''' SWEIGHT_UNIT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A24_SWEIGHT_UNIT() As String
                Get
                    Return mdl.A24_SWEIGHT_UNIT
                End Get
                Set(ByVal value As String)
                    mdl.A24_SWEIGHT_UNIT = Value
                End Set
            End Property

            ''' <summary>
            ''' STEPCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A25_STEPCODE() As String
                Get
                    Return mdl.A25_STEPCODE
                End Get
                Set(ByVal value As String)
                    mdl.A25_STEPCODE = Value
                End Set
            End Property

            ''' <summary>
            ''' THICK_U
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A26_THICK_U() As String
                Get
                    Return mdl.A26_THICK_U
                End Get
                Set(ByVal value As String)
                    mdl.A26_THICK_U = Value
                End Set
            End Property

            ''' <summary>
            ''' THICK_D
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A27_THICK_D() As String
                Get
                    Return mdl.A27_THICK_D
                End Get
                Set(ByVal value As String)
                    mdl.A27_THICK_D = Value
                End Set
            End Property

            ''' <summary>
            ''' WIDTH_U
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A28_WIDTH_U() As String
                Get
                    Return mdl.A28_WIDTH_U
                End Get
                Set(ByVal value As String)
                    mdl.A28_WIDTH_U = Value
                End Set
            End Property

            ''' <summary>
            ''' WIDTH_D
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A29_WIDTH_D() As String
                Get
                    Return mdl.A29_WIDTH_D
                End Get
                Set(ByVal value As String)
                    mdl.A29_WIDTH_D = Value
                End Set
            End Property

            ''' <summary>
            ''' LENGTH_U
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A30_LENGTH_U() As String
                Get
                    Return mdl.A30_LENGTH_U
                End Get
                Set(ByVal value As String)
                    mdl.A30_LENGTH_U = Value
                End Set
            End Property

            ''' <summary>
            ''' LENGTH_D
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A31_LENGTH_D() As String
                Get
                    Return mdl.A31_LENGTH_D
                End Get
                Set(ByVal value As String)
                    mdl.A31_LENGTH_D = Value
                End Set
            End Property

            ''' <summary>
            ''' DIAMETER_D
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A32_DIAMETER_D() As String
                Get
                    Return mdl.A32_DIAMETER_D
                End Get
                Set(ByVal value As String)
                    mdl.A32_DIAMETER_D = Value
                End Set
            End Property

            ''' <summary>
            ''' DIAMETER_U
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A33_DIAMETER_U() As String
                Get
                    Return mdl.A33_DIAMETER_U
                End Get
                Set(ByVal value As String)
                    mdl.A33_DIAMETER_U = Value
                End Set
            End Property

            ''' <summary>
            ''' MODELCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A34_MODELCODE() As String
                Get
                    Return mdl.A34_MODELCODE
                End Get
                Set(ByVal value As String)
                    mdl.A34_MODELCODE = Value
                End Set
            End Property

            ''' <summary>
            ''' LOSSTYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A35_LOSSTYPE() As String
                Get
                    Return mdl.A35_LOSSTYPE
                End Get
                Set(ByVal value As String)
                    mdl.A35_LOSSTYPE = Value
                End Set
            End Property

            ''' <summary>
            ''' IS_HT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A36_IS_HT() As Boolean
                Get
                    Return mdl.A36_IS_HT
                End Get
                Set(ByVal value As Boolean)
                    mdl.A36_IS_HT = Value
                End Set
            End Property

            ''' <summary>
            ''' IS_CT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A37_IS_CT() As Boolean
                Get
                    Return mdl.A37_IS_CT
                End Get
                Set(ByVal value As Boolean)
                    mdl.A37_IS_CT = Value
                End Set
            End Property

            ''' <summary>
            ''' HARDNESS
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A38_HARDNESS() As String
                Get
                    Return mdl.A38_HARDNESS
                End Get
                Set(ByVal value As String)
                    mdl.A38_HARDNESS = Value
                End Set
            End Property

            ''' <summary>
            ''' ANGLE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A39_ANGLE() As String
                Get
                    Return mdl.A39_ANGLE
                End Get
                Set(ByVal value As String)
                    mdl.A39_ANGLE = Value
                End Set
            End Property

            ''' <summary>
            ''' CUSNAME
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A40_CUSNAME() As String
                Get
                    Return mdl.A40_CUSNAME
                End Get
                Set(ByVal value As String)
                    mdl.A40_CUSNAME = Value
                End Set
            End Property

            ''' <summary>
            ''' SALEPERSON
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A41_SALEPERSON() As String
                Get
                    Return mdl.A41_SALEPERSON
                End Get
                Set(ByVal value As String)
                    mdl.A41_SALEPERSON = Value
                End Set
            End Property

            ''' <summary>
            ''' MAKER
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A42_MAKER() As String
                Get
                    Return mdl.A42_MAKER
                End Get
                Set(ByVal value As String)
                    mdl.A42_MAKER = Value
                End Set
            End Property

            ''' <summary>
            ''' DWEIGHT_TYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A43_DWEIGHT_TYPE() As Integer
                Get
                    Return mdl.A43_DWEIGHT_TYPE
                End Get
                Set(ByVal value As Integer)
                    mdl.A43_DWEIGHT_TYPE = Value
                End Set
            End Property

            ''' <summary>
            ''' HWEIGHT_TYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A44_HWEIGHT_TYPE() As Integer
                Get
                    Return mdl.A44_HWEIGHT_TYPE
                End Get
                Set(ByVal value As Integer)
                    mdl.A44_HWEIGHT_TYPE = Value
                End Set
            End Property

            ''' <summary>
            ''' SIP
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A45_SIP() As String
                Get
                    Return mdl.A45_SIP
                End Get
                Set(ByVal value As String)
                    mdl.A45_SIP = Value
                End Set
            End Property

            ''' <summary>
            ''' MEMO
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A46_MEMO() As String
                Get
                    Return mdl.A46_MEMO
                End Get
                Set(ByVal value As String)
                    mdl.A46_MEMO = Value
                End Set
            End Property

            ''' <summary>
            ''' RECEIPTPERSON
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A47_RECEIPTPERSON() As String
                Get
                    Return mdl.A47_RECEIPTPERSON
                End Get
                Set(ByVal value As String)
                    mdl.A47_RECEIPTPERSON = Value
                End Set
            End Property

            ''' <summary>
            ''' RECEIPTTIME
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A48_RECEIPTTIME() As Date
                Get
                    Return mdl.A48_RECEIPTTIME
                End Get
                Set(ByVal value As Date)
                    mdl.A48_RECEIPTTIME = Value
                End Set
            End Property

            ''' <summary>
            ''' CITYNAME
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A49_CITYNAME() As String
                Get
                    Return mdl.A49_CITYNAME
                End Get
                Set(ByVal value As String)
                    mdl.A49_CITYNAME = Value
                End Set
            End Property

            ''' <summary>
            ''' IROWS
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A50_IROWS() As Integer
                Get
                    Return mdl.A50_IROWS
                End Get
                Set(ByVal value As Integer)
                    mdl.A50_IROWS = Value
                End Set
            End Property

            ''' <summary>
            ''' MI_ID
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A51_MI_ID() As Integer
                Get
                    Return mdl.A51_MI_ID
                End Get
                Set(ByVal value As Integer)
                    mdl.A51_MI_ID = Value
                End Set
            End Property

            ''' <summary>
            ''' cWORKCondition
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A52_cWORKCondition() As String
                Get
                    Return mdl.A52_cWORKCondition
                End Get
                Set(ByVal value As String)
                    mdl.A52_cWORKCondition = Value
                End Set
            End Property

            ''' <summary>
            ''' cWorkCode
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A53_cWorkCode() As String
                Get
                    Return mdl.A53_cWorkCode
                End Get
                Set(ByVal value As String)
                    mdl.A53_cWorkCode = Value
                End Set
            End Property

            ''' <summary>
            ''' CINVCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public Property A54_CINVCODE() As String
                Get
                    Return mdl.A54_CINVCODE
                End Get
                Set(ByVal value As String)
                    mdl.A54_CINVCODE = Value
                End Set
            End Property
        End Class
        ''' <summary>
        ''' 属性名称
        ''' </summary>
        Public Class PropertyName
            Private bType As Boolean
            Friend Sub New(ByVal bType As Boolean)
                Me.bType = bType
            End Sub

            ''' <summary>
            ''' IF_ID
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A01_IF_ID() As String
                Get
                    Return IIf(bType, "A01_IF_ID", "IF_ID")
                End Get
            End Property

            ''' <summary>
            ''' IF_FROMSYSTEM
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A02_IF_FROMSYSTEM() As String
                Get
                    Return IIf(bType, "A02_IF_FROMSYSTEM", "IF_FROMSYSTEM")
                End Get
            End Property

            ''' <summary>
            ''' IF_TOSYSTEM
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A03_IF_TOSYSTEM() As String
                Get
                    Return IIf(bType, "A03_IF_TOSYSTEM", "IF_TOSYSTEM")
                End Get
            End Property

            ''' <summary>
            ''' IF_FLAG
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A04_IF_FLAG() As String
                Get
                    Return IIf(bType, "A04_IF_FLAG", "IF_FLAG")
                End Get
            End Property

            ''' <summary>
            ''' IF_WRITEDATE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A05_IF_WRITEDATE() As String
                Get
                    Return IIf(bType, "A05_IF_WRITEDATE", "IF_WRITEDATE")
                End Get
            End Property

            ''' <summary>
            ''' IF_READDATE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A06_IF_READDATE() As String
                Get
                    Return IIf(bType, "A06_IF_READDATE", "IF_READDATE")
                End Get
            End Property

            ''' <summary>
            ''' IF_ERRORLOG
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A07_IF_ERRORLOG() As String
                Get
                    Return IIf(bType, "A07_IF_ERRORLOG", "IF_ERRORLOG")
                End Get
            End Property

            ''' <summary>
            ''' IF_INTERFACELOGID
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A08_IF_INTERFACELOGID() As String
                Get
                    Return IIf(bType, "A08_IF_INTERFACELOGID", "IF_INTERFACELOGID")
                End Get
            End Property

            ''' <summary>
            ''' MOCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A09_MOCODE() As String
                Get
                    Return IIf(bType, "A09_MOCODE", "MOCODE")
                End Get
            End Property

            ''' <summary>
            ''' MOTYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A10_MOTYPE() As String
                Get
                    Return IIf(bType, "A10_MOTYPE", "MOTYPE")
                End Get
            End Property

            ''' <summary>
            ''' ITEMCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A11_ITEMCODE() As String
                Get
                    Return IIf(bType, "A11_ITEMCODE", "ITEMCODE")
                End Get
            End Property

            ''' <summary>
            ''' ITEMNAME
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A12_ITEMNAME() As String
                Get
                    Return IIf(bType, "A12_ITEMNAME", "ITEMNAME")
                End Get
            End Property

            ''' <summary>
            ''' PLANQTY
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A13_PLANQTY() As String
                Get
                    Return IIf(bType, "A13_PLANQTY", "PLANQTY")
                End Get
            End Property

            ''' <summary>
            ''' UNIT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A14_UNIT() As String
                Get
                    Return IIf(bType, "A14_UNIT", "UNIT")
                End Get
            End Property

            ''' <summary>
            ''' SDATE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A15_SDATE() As String
                Get
                    Return IIf(bType, "A15_SDATE", "SDATE")
                End Get
            End Property

            ''' <summary>
            ''' EDATE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A16_EDATE() As String
                Get
                    Return IIf(bType, "A16_EDATE", "EDATE")
                End Get
            End Property

            ''' <summary>
            ''' SALEORDER
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A17_SALEORDER() As String
                Get
                    Return IIf(bType, "A17_SALEORDER", "SALEORDER")
                End Get
            End Property

            ''' <summary>
            ''' THICK
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A18_THICK() As String
                Get
                    Return IIf(bType, "A18_THICK", "THICK")
                End Get
            End Property

            ''' <summary>
            ''' WIDTH
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A19_WIDTH() As String
                Get
                    Return IIf(bType, "A19_WIDTH", "WIDTH")
                End Get
            End Property

            ''' <summary>
            ''' LENGTH
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A20_LENGTH() As String
                Get
                    Return IIf(bType, "A20_LENGTH", "LENGTH")
                End Get
            End Property

            ''' <summary>
            ''' DIAMETER
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A21_DIAMETER() As String
                Get
                    Return IIf(bType, "A21_DIAMETER", "DIAMETER")
                End Get
            End Property

            ''' <summary>
            ''' MTYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A22_MTYPE() As String
                Get
                    Return IIf(bType, "A22_MTYPE", "MTYPE")
                End Get
            End Property

            ''' <summary>
            ''' SWEIGHT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A23_SWEIGHT() As String
                Get
                    Return IIf(bType, "A23_SWEIGHT", "SWEIGHT")
                End Get
            End Property

            ''' <summary>
            ''' SWEIGHT_UNIT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A24_SWEIGHT_UNIT() As String
                Get
                    Return IIf(bType, "A24_SWEIGHT_UNIT", "SWEIGHT_UNIT")
                End Get
            End Property

            ''' <summary>
            ''' STEPCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A25_STEPCODE() As String
                Get
                    Return IIf(bType, "A25_STEPCODE", "STEPCODE")
                End Get
            End Property

            ''' <summary>
            ''' THICK_U
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A26_THICK_U() As String
                Get
                    Return IIf(bType, "A26_THICK_U", "THICK_U")
                End Get
            End Property

            ''' <summary>
            ''' THICK_D
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A27_THICK_D() As String
                Get
                    Return IIf(bType, "A27_THICK_D", "THICK_D")
                End Get
            End Property

            ''' <summary>
            ''' WIDTH_U
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A28_WIDTH_U() As String
                Get
                    Return IIf(bType, "A28_WIDTH_U", "WIDTH_U")
                End Get
            End Property

            ''' <summary>
            ''' WIDTH_D
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A29_WIDTH_D() As String
                Get
                    Return IIf(bType, "A29_WIDTH_D", "WIDTH_D")
                End Get
            End Property

            ''' <summary>
            ''' LENGTH_U
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A30_LENGTH_U() As String
                Get
                    Return IIf(bType, "A30_LENGTH_U", "LENGTH_U")
                End Get
            End Property

            ''' <summary>
            ''' LENGTH_D
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A31_LENGTH_D() As String
                Get
                    Return IIf(bType, "A31_LENGTH_D", "LENGTH_D")
                End Get
            End Property

            ''' <summary>
            ''' DIAMETER_D
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A32_DIAMETER_D() As String
                Get
                    Return IIf(bType, "A32_DIAMETER_D", "DIAMETER_D")
                End Get
            End Property

            ''' <summary>
            ''' DIAMETER_U
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A33_DIAMETER_U() As String
                Get
                    Return IIf(bType, "A33_DIAMETER_U", "DIAMETER_U")
                End Get
            End Property

            ''' <summary>
            ''' MODELCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A34_MODELCODE() As String
                Get
                    Return IIf(bType, "A34_MODELCODE", "MODELCODE")
                End Get
            End Property

            ''' <summary>
            ''' LOSSTYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A35_LOSSTYPE() As String
                Get
                    Return IIf(bType, "A35_LOSSTYPE", "LOSSTYPE")
                End Get
            End Property

            ''' <summary>
            ''' IS_HT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A36_IS_HT() As String
                Get
                    Return IIf(bType, "A36_IS_HT", "IS_HT")
                End Get
            End Property

            ''' <summary>
            ''' IS_CT
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A37_IS_CT() As String
                Get
                    Return IIf(bType, "A37_IS_CT", "IS_CT")
                End Get
            End Property

            ''' <summary>
            ''' HARDNESS
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A38_HARDNESS() As String
                Get
                    Return IIf(bType, "A38_HARDNESS", "HARDNESS")
                End Get
            End Property

            ''' <summary>
            ''' ANGLE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A39_ANGLE() As String
                Get
                    Return IIf(bType, "A39_ANGLE", "ANGLE")
                End Get
            End Property

            ''' <summary>
            ''' CUSNAME
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A40_CUSNAME() As String
                Get
                    Return IIf(bType, "A40_CUSNAME", "CUSNAME")
                End Get
            End Property

            ''' <summary>
            ''' SALEPERSON
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A41_SALEPERSON() As String
                Get
                    Return IIf(bType, "A41_SALEPERSON", "SALEPERSON")
                End Get
            End Property

            ''' <summary>
            ''' MAKER
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A42_MAKER() As String
                Get
                    Return IIf(bType, "A42_MAKER", "MAKER")
                End Get
            End Property

            ''' <summary>
            ''' DWEIGHT_TYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A43_DWEIGHT_TYPE() As String
                Get
                    Return IIf(bType, "A43_DWEIGHT_TYPE", "DWEIGHT_TYPE")
                End Get
            End Property

            ''' <summary>
            ''' HWEIGHT_TYPE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A44_HWEIGHT_TYPE() As String
                Get
                    Return IIf(bType, "A44_HWEIGHT_TYPE", "HWEIGHT_TYPE")
                End Get
            End Property

            ''' <summary>
            ''' SIP
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A45_SIP() As String
                Get
                    Return IIf(bType, "A45_SIP", "SIP")
                End Get
            End Property

            ''' <summary>
            ''' MEMO
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A46_MEMO() As String
                Get
                    Return IIf(bType, "A46_MEMO", "MEMO")
                End Get
            End Property

            ''' <summary>
            ''' RECEIPTPERSON
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A47_RECEIPTPERSON() As String
                Get
                    Return IIf(bType, "A47_RECEIPTPERSON", "RECEIPTPERSON")
                End Get
            End Property

            ''' <summary>
            ''' RECEIPTTIME
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A48_RECEIPTTIME() As String
                Get
                    Return IIf(bType, "A48_RECEIPTTIME", "RECEIPTTIME")
                End Get
            End Property

            ''' <summary>
            ''' CITYNAME
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A49_CITYNAME() As String
                Get
                    Return IIf(bType, "A49_CITYNAME", "CITYNAME")
                End Get
            End Property

            ''' <summary>
            ''' IROWS
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A50_IROWS() As String
                Get
                    Return IIf(bType, "A50_IROWS", "IROWS")
                End Get
            End Property

            ''' <summary>
            ''' MI_ID
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A51_MI_ID() As String
                Get
                    Return IIf(bType, "A51_MI_ID", "MI_ID")
                End Get
            End Property

            ''' <summary>
            ''' cWORKCondition
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A52_cWORKCondition() As String
                Get
                    Return IIf(bType, "A52_cWORKCondition", "cWORKCondition")
                End Get
            End Property

            ''' <summary>
            ''' cWorkCode
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A53_cWorkCode() As String
                Get
                    Return IIf(bType, "A53_cWorkCode", "cWorkCode")
                End Get
            End Property

            ''' <summary>
            ''' CINVCODE
            ''' </summary>
            ''' <value></value>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Public ReadOnly Property A54_CINVCODE() As String
                Get
                    Return IIf(bType, "A54_CINVCODE", "CINVCODE")
                End Get
            End Property
        End Class
    End Class

    Public Class IF_ORDERSCollection
        Inherits Collections.ObjectModel.Collection(Of IF_ORDERS)
        Public Function get_byIF_ID(ByVal IF_ID As String) As IF_ORDERS
            For Each mdl As IF_ORDERS In Me
                If Trim(mdl.A01_IF_ID).ToLower() = Trim(IF_ID).ToLower() Then
                    Return mdl
                End If
            Next
        End Function

    End Class

End Namespace

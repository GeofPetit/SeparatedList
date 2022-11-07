'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Description:                                                                                                                          *
'*                                                                                                                                        *
'*  This class allows a list of entries to be stored in a string value with a user specified separator character stored in the first      *
'*  position of the string                                                                                                                *
'*                                                                                                                                        *
'******************************************************************************************************************************************
'*  Usage:                                                                                                                                *
'*                                                                                                                                        *
'*  This class can be instantiated in 3 ways                                                                                              *
'*                                                                                                                                        *
'*  1)  From an existing list held within a string                                                                                        *
'*      The first character of the string value supplied is used as the separator character and the entries are split accordingly         *
'*                                                                                                                                        *
'*  2)  From a separator character with an array of initial string value entries                                                          *
'*                                                                                                                                        *
'*  3)  From a list of possible separator characters with an array of initial string value entries                                        *
'*      The entries are scanned to find the first of the separator characters that are not used in the supplied list of entries           *
'*                                                                                                                                        *
'*  Once instantiated, entries can be added, replaced or removed.                                                                         *
'*                                                                                                                                        *
'*  The list can then be converted back to a single string value (with the first character as the separator used)                         *
'*                                                                                                                                        *
'*  NOTE:                                                                                                                                 *
'*  The Null, Carriage return and line feed characters cannot be used as separators                                                       *
'*                                                                                                                                        *
'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Amendment Log:                                                                                                                        *
'*                                                                                                                                        *
'*  Date        By          Reference    Details                                                                                          *
'*  ----------  ----------  ---------    -----------------------------------------------------------------------------------------------  *
'*  ccyy-mm-dd  xxxxxxxxxx  xxxxxxxxx    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  *
'*                                                                                                                                        *
'******************************************************************************************************************************************

Public Class vbSeparatedList

#Region "Private Variables"
    '*******************************************************************************************************************************
    '* Private variables                                                                                                           *
    '*******************************************************************************************************************************
    Private _Separator As Char
    Private _Entries As List(Of String)
    Private _UnusedSeparators As List(Of Char)

    Public Shared InvalidSeparatorCharacters As New List(Of Char)(Convert.ToChar(0) & Environment.NewLine)
    Public Shared ValidSeparatorCharacters As List(Of Char)
#End Region

#Region "Public Properties"
    Public ReadOnly Property Entries() As List(Of String)
        Get
            Return _Entries
        End Get
    End Property

    Public Property Separator() As Char
        Get
            Return _Separator
        End Get

        Set(value As Char)
            _Separator = value
        End Set
    End Property

    Public ReadOnly Property UnusedSeparators() As List(Of Char)
        Get
            Return _UnusedSeparators
        End Get
    End Property
#End Region

#Region "Public Methods"
    '*******************************************************************************************************************************
    '* Public methods                                                                                                              *
    '*******************************************************************************************************************************

    Shared Sub New()

        ' Initialise a list of all available separator characters
        ValidSeparatorCharacters = New List(Of Char)

        For CharCode As Int16 = 0 To 255
            Dim CurrentCharacter As Char = Convert.ToChar(CharCode)

            If Not InvalidSeparatorCharacters.Contains(CurrentCharacter) Then
                ValidSeparatorCharacters.Add(CurrentCharacter)
            End If
        Next
    End Sub

    Public Sub New(FromString As String)

        ' Initialise the separator value
        If FromString.Length > 0 Then
            _Separator = Convert.ToChar(FromString.Substring(0, 1))
        Else
            _Separator = Convert.ToChar(String.Empty)
        End If

        ' Split the string into a list using the extracted separator
        If FromString.Length > 1 Then
            _Entries = New List(Of String)(FromString.Substring(1).Split(_Separator))
        Else
            _Entries = New List(Of String)
        End If

        _UnusedSeparators = New List(Of Char)
    End Sub

    Public Sub New(Separator As Char, ParamArray Entries As String())

        ' Initialise the separator value and list using the values specified
        _Separator = Separator
        _Entries = New List(Of String)(Entries)
        _UnusedSeparators = New List(Of Char)
    End Sub

    Public Sub New(Separators() As Char, ParamArray Entries As String())

        ' Add any initial entries to the list
        _Entries = New List(Of String)(Entries)

        Select Case Separators.Length
            Case 1
                ' Choose the single separator character specified
                _Separator = Separators(0)

            Case Is > 1
                ' Choose the next unused separator from the values specified
                m_FindNextNotUsedSeparator(Separators)

            Case Else
                ' Choose the next unused separator from the list of all available valid separators
                Separators = ValidSeparatorCharacters.ToArray()
                m_FindNextNotUsedSeparator(Separators)
        End Select
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Separator & String.Join(Me.Separator, Me.Entries)
    End Function
#End Region

#Region "Private Methods"
    '*******************************************************************************************************************************
    '* Private methods                                                                                                             *
    '*******************************************************************************************************************************

    Private Sub m_FindNextNotUsedSeparator(Separators() As Char)

        Dim SearchString As String = String.Join(String.Empty, _Entries)
        _UnusedSeparators = New List(Of Char)
        Dim Found As Boolean = False

        For Each Separator As Char In Separators
            If Not Found Then
                If Not SearchString.Contains(Separator) Then
                    _Separator = Separator
                    Found = True
                End If
            Else
                _UnusedSeparators.Add(Separator)
            End If
        Next
    End Sub
#End Region
End Class

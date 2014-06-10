Imports System.IO
Imports System.Xml

Public Class AppSetting


    Public Class AppSettings
        Private settings As XmlDocument
        Private settingsFile As String

        Public Sub New()
            settingsFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SampleApp\\Settings.xml"
        End Sub

        Public Function GetProperty(ByVal name As String) As String
            Dim val As XmlNode = settings.SelectSingleNode("/Settings/" + name)

            If val Is Nothing Then Return Nothing

            Return val.InnerText
        End Function

        Public Sub SetProperty(ByVal name As String, ByVal value As String)
            Dim val As XmlNode = settings.SelectSingleNode("/Settings/" + name)

            If Not IsNothing(val) Then
                val.InnerText = value
            Else
                val = settings.CreateNode(XmlNodeType.Element, name, Nothing)
                val.InnerText = value

                settings.DocumentElement.SelectSingleNode("/Settings").AppendChild(val)
            End If
        End Sub

        Public Sub Load()
            Try
                settings = New XmlDocument()
                settings.Load(settingsFile)
            Catch ex As Exception

            End Try

            If settings.SelectSingleNode("/Settings") Is Nothing Then
                settings.AppendChild(settings.CreateElement("Settings", Nothing))
            End If

        End Sub

        Public Sub Save()
            Try
                Dim settingsPath As String = Path.GetDirectoryName(settingsFile)

                If Not Directory.Exists(settingsPath) Then
                    Directory.CreateDirectory(settingsPath)
                End If

                settings.Save(settingsFile)

            Catch ex As Exception

            End Try
        End Sub

    End Class

End Class

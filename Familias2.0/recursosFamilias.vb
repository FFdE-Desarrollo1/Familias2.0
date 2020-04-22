' Copyright:  Copyright (c) 2014 
' Company:    Familias de Esperanza 
' @author Paty De León
' @version 1.0

Public Class recursosFamilias
    Dim ingles As String(,)
    Dim español As String(,)
    Dim a As Integer
    Dim t As String = ""
    Public Function traduce(ByVal palabra As String) As String
        If L = "en" Then
            traduce = traduceIngles(palabra)
        Else
            traduce = traduceEspañol(palabra)
        End If
    End Function

    Private Function traduceEspañol(ByVal palabra As String) As String
        traduceEspañol = "s/t"
        llenarEspañol()
        For index0 = 0 To español.GetUpperBound(0)
            For index1 = 0 To español.GetUpperBound(1)
                If palabra = español(index0, index1) Then
                    traduceEspañol = español(index0, 1)
                End If
            Next
        Next
    End Function

    Private Function traduceIngles(ByVal palabra As String) As String
        traduceIngles = "s/t"
        llenarIngles()
        For index0 = 0 To ingles.GetUpperBound(0)
            For index1 = 0 To ingles.GetUpperBound(1)
                If palabra = ingles(index0, index1) Then
                    traduceIngles = ingles(index0, 1)
                End If
            Next
        Next
    End Function

    Private Sub llenarEspañol()
        español = {
            {"Actives", "Ver Activos"},
            {"Address", "Dirección"},
            {"Affiliate", "Apadrinado"},
            {"Affiliation", "Afiliación"},
            {"AffiliationStatus", "Estado de Afiliación"},
            {"AffiliationStatusDate", "Fecha de Estado de Afiliación"},
            {"AffiliationType", "Tipo de Afiliación"},
            {"Age", "Edad"},
            {"BirthDate", "Fecha Nacimiento"},
            {"BirthdayGift", "Regalo de Cumpleaños"},
            {"Career", "Carrera"},
            {"CarnetPrinted", "Carné Impreso"},
            {"Category", "Categoria"},
            {"CellularNumber", "No. Celular"},
            {"ChangeLanguage", "Cambiar lenguaje a Inglés"},
            {"ChangePreferences", "Cambiar Preferencias"},
            {"Classification", "Clasificación"},
            {"ClassificationDate", "Fecha de Clasificación"},
            {"Clinic", "Clinica"},
            {"Construction", "Vivienda"},
            {"Disaffiliate", "Desafiliado"},
            {"Disaffiliates", "Desafiliados"},
            {"Disaffiliation", "Desafiliación"},
            {"Education", "Educación"},
            {"EducationLevel", "Nivel Educativo"},
            {"EducationStatus", "Estado Educativo"},
            {"EndDate", "Fecha de Fin"},
            {"Ethnicity", "Etnia"},
            {"Familiar", "Afiliado"},
            {"FamilyRelation", "Relación Familiar"},
            {"FamilyId", "Número de Familia"},
            {"FamilyProfile", "Perfil de Familia"},
            {"FamilyWarnings", "Avisos Familiares"},
            {"Gender", "Género"},
            {"Grade", "Grado"},
            {"Graduate", "Graduado"},
            {"Graduates", "Graduados"},
            {"HasBirthdayGiftToPickUp", "tiene regalo de cumpleaños para recoger"},
            {"HasSponsorLetterToPickUp", "tiene carta de padrinos para recoger"},
            {"Health", "Salud"},
            {"Inactive", "Inactivo"},
            {"InactiveDate", "Fecha Inactivo"},
            {"IncludeEducationInformation", "Incluir Información Año Escolar"},
            {"LastGiftDate", "Ultimo Regalo"},
            {"LastNames", "Apellidos"},
            {"LetterWritten", "Carta Escrita"},
            {"LiveDead", "Vivo / Muerto"},
            {"MemberId", "Número de Miembro"},
            {"MembersOfFamily", "Miembros de la Familia"},
            {"MembersOfFamilyWithActiveRelationships", "Miembros de la Familia con Relaciones Activas"},
            {"MembersOfFamilyWithInactiveRelationships", "Miembros de la Familia con Relaciones Inactivas"},
            {"MemberProfile", "Perfil de Miembro"},
            {"MemberSearchByOtherInfo", "Búsqueda de Miembro por Otra Información"},
            {"MemberType", "Tipo de Miembro"},
            {"Name", "Nombre"},
            {"Names", "Nombres"},
            {"NeedsDeliveryCertificate", " pendiente de entregar certificado en educación"},
            {"NeedLetter", " NECESITA ESCRIBIR CARTA"},
            {"NeedPhoto", " NECESITA FOTO"},
            {"NeedsToUpdateEducationInformation", "Necesita actualizar información de educación"},
            {"Observations", "Observaciones"},
            {"Others", "Otros"},
            {"OtherAffiliation", "Otra Afiliación"},
            {"OtherSearchs", "Otras Búsquedas"},
            {"PhotoDate", "Fecha de Foto"},
            {"PreferredName", "Nombre Usual"},
            {"ProjectRight", "Derechos"},
            {"RelativesOfDisaffiliatedFamilies", "Parientes - Familias Desafiliadas"},
            {"RelativesOfGraduatedFamilies", "Parientes - Familias Graduadas"},
            {"Region", "Región"},
            {"SchoolName", "Escuela"},
            {"SchoolType", "Tipo de Escuela"},
            {"SearchById", "Búsqueda por Número"},
            {"SearchByYearOfEducationInformation", "Búsqueda por Información de Educación"},
            {"Semaphore", "Semáforo"},
            {"Site", "Sitio"},
            {"SocialWorker", "TS"},
            {"ShowInactives", "Ver Inactivos"},
            {"SpeaksSpanish", "Habla español"},
            {"Sponsor", "Padrino"},
            {"SponsorId", "No. Padrino"},
            {"SponsorNames", "Nombre del Padrino"},
            {"Sponsors", "Padrinos"},
            {"StartDate", "Fecha de Inicio"},
            {"Teacher", "Maestro"},
            {"TelephoneNumber", "Número de Teléfono"},
            {"Town", "Pueblo"},
            {"Type", "Tipo"},
            {"Year", "Año"},
            {"Yes", "Si"}
        }
    End Sub

    Private Sub llenarIngles()
        ingles = {
            {"Actives", "Show Actives"},
            {"Address", "Address"},
            {"Affiliate", "Affiliate"},
            {"Affiliation", "Affiliation"},
            {"AffiliationStatus", "Affiliation Status"},
            {"AffiliationStatusDate", "Affiliation Status Date"},
            {"AffiliationType", "Affiliation Type"},
            {"Age", "Age"},
            {"BirthDate", "Birth Date"},
            {"BirthdayGift", "Birthday Gift"},
            {"Career", "Career"},
            {"CarnetPrinted", "Carnet Printed"},
            {"Category", "Category"},
            {"CellularNumber", "Cellular Number"},
            {"ChangeLanguage", "Change language to Spanish"},
            {"ChangePreferences", "Change Preferences"},
            {"Classification", "Classification"},
            {"Clinic", "Clinic"},
            {"ClassificationDate", "Classification Date"},
            {"Construction", "Construction"},
            {"Disaffiliate", "Disaffiliate"},
            {"Disaffiliates", "Disaffiliates"},
            {"Disaffiliation", "Disaffiliation"},
            {"Education", "Education"},
            {"EducationLevel", "Education Level"},
            {"EducationStatus", "Education Status"},
            {"EndDate", "End Date"},
            {"Ethnicity", "Ethnicity"},
            {"Familiar", "Relatives of Affiliate Family"},
            {"FamilyRelation", "Family Relation"},
            {"FamilyId", "Family Id"},
            {"FamilyProfile", "Family Profile"},
            {"FamilyWarnings", "Family Warnings"},
            {"Gender", "Gender"},
            {"Grade", "Grade"},
            {"Graduate", "Graduate"},
            {"Graduates", "Graduates"},
            {"HasBirthdayGiftToPickUp", " has birthday gift to pick up"},
            {"HasSponsorLetterToPickUp", " has sponsor letter to pick up"},
            {"Health", "Health"},
            {"Inactive", "Inactive"},
            {"InactiveDate", "Inactive Date"},
            {"IncludeEducationInformation", "Include Education Information - Year:"},
            {"LastGiftDate", "Last Gift Date"},
            {"LastNames", "Last Names"},
            {"LetterWritten", "Letter Written"},
            {"LiveDead", "Living / Deceased"},
            {"MemberId", "Member Id"},
            {"MembersOfFamily", "Members of the Family"},
            {"MembersOfFamilyWithActiveRelationships", "Members of the Family with Active Relationships"},
            {"MembersOfFamilyWithInactiveRelationships", "Members of Family with Inactive Relationships"},
            {"MemberProfile", "Member Profile"},
            {"MemberSearchByOtherInfo", "Member Search By Other Info"},
            {"MemberType", "Member Type"},
            {"Name", "Name"},
            {"Names", "Names"},
            {"NeedsDeliveryCertificate", " is pending to delivery education certification"},
            {"NeedLetter", " needs write letter"},
            {"NeedPhoto", " needs photo"},
            {"NeedsToUpdateEducationInformation", " needs to update education information"},
            {"Observations", "Observations"},
            {"Others", "Others"},
            {"OtherAffiliation", "Other Affiliation"},
            {"OtherSearchs", "Other Searchs"},
            {"PhotoDate", "Photo Date"},
            {"PreferredName", "Preferred Name"},
            {"ProjectRight", "Rights"},
            {"RelativesOfDisaffiliatedFamilies", "Relatives of Disaffiliated Family"},
            {"RelativesOfGraduatedFamilies", "Relatives of Graduated Family"},
            {"Region", "Region"},
            {"SchoolName", "School"},
            {"SchoolType", "School Type"},
            {"SearchById", "Search by Id"},
            {"SearchByYearOfEducationInformation", "Search by Year of Education Information"},
            {"Semaphore", "Semaphore"},
            {"Site", "Site"},
            {"SocialWorker", "Social Worker"},
            {"ShowInactives", "Show Inactives"},
            {"SpeaksSpanish", "Speaks Spanish"},
            {"Sponsor", "Sponsor"},
            {"SponsorId", "Sponsor Id"},
            {"SponsorNames", "Sponsor Names"},
            {"Sponsors", "Sponsors"},
            {"StartDate", "Start Date"},
            {"Teacher", "Teacher"},
            {"TelephoneNumber", "Telephone Number"},
            {"Town", "Town"},
            {"Type", "Type"},
            {"Year", "Year"},
            {"Yes", "Yes"}
        }
    End Sub
End Class


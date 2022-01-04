
Partial Class Buyer
    Inherits System.Web.UI.MasterPage

    Protected Sub lnkcompose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkcompose.Click
        Response.Redirect("buyerCompose.aspx")
    End Sub

    Protected Sub Linkmodify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Linkmodify.Click
        Response.Redirect("responses.aspx")
    End Sub

    Protected Sub LinkButton8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton8.Click
        Response.Redirect("buyerinbox.aspx")
    End Sub

    Protected Sub LinkButton9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton9.Click
        Response.Redirect("compose1b.aspx")
    End Sub

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        Response.Redirect("modifybuyer.aspx")
    End Sub

    Protected Sub LinkButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton2.Click
        Response.Redirect("searchproduct11.aspx")
    End Sub
End Class

